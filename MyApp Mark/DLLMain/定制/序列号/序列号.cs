using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace DLLMain
{
    internal class 序列号
    {
        internal static string _序列号 = "001";
  
        internal static (bool s, string m, string sn) 递增()
        {
            bool rt = true;
            string msg = "";
            string v = "";
            int lenght = _序列号.Length;
            rt = int.TryParse(_序列号, out int sn);
            if (!rt)
            {
                msg = "序列号格式错误,不为十进制整型";
                Log.Add(rt, msg);
                return (rt, msg, v);
            }
            sn += 1;
            v = sn.ToString().PadLeft(lenght, '0');
            var rtDb = db_序列号.Add(new 表.Sn
            {
                工单 = 系统参数._参数.工单号,
                序列号 = v,
            });
             
            rt = rtDb.s;
            msg = rtDb.m;
            Log.Add(rt, msg);
            return (rt, msg, v);

        }

        internal static (bool s, string m) 设置序列号(string strSn)
        {
            bool rt = true;
            string msg = "";
            if (string.IsNullOrEmpty(strSn))
            {
                rt = false;
                msg = "请输入序列号";
                return (rt, msg);
            }
            if (!int.TryParse(strSn, out int i))
            {
                rt = false;
                msg = "序列号应为整型";
                return (rt, msg);
            }

            表.Sn tabel = new 表.Sn
            {
                工单 = 系统参数._参数.工单号,
                序列号 = strSn,
            };
            var rtDb = db_序列号.Add(tabel);
            if (rtDb.s)
            {
                var rtSn = db_序列号.Get_查询(系统参数._参数.工单号);
                _序列号 = rtSn.Sn;
             
                显示Mes.显示Mes信息();

                msg = $"手动,设置序列号,成功";
                Log.Add($"{msg},{JsonConvert.SerializeObject(tabel)}");

            }
            else
            {
                msg = $"手动,设置序列号,失败,{rtDb.m}";
                Log.Add(false, $"{msg},{JsonConvert.SerializeObject(tabel)}");
                rt = false;
            }

            return (rt, msg);
        }

        internal static (bool s, string m) 复位序列号()
        {
            bool rt = true;
            string msg = "";
            int lenght = _序列号.Length;
            rt = int.TryParse(_序列号, out int sn);
            if (!rt)
            {
                msg = "序列号格式错误,不为十进制整型";
                return (rt, msg);
            }

            sn = 1;
            string v = sn.ToString().PadLeft(lenght, '0');

            表.Sn tabel = new 表.Sn
            {
                工单 = 系统参数._参数.工单号,
                序列号 = v,
            };
            var rtDb = db_序列号.Add(tabel);
            if (rtDb.s)
            {
                var rtSn = db_序列号.Get_查询(系统参数._参数.工单号);
                _序列号 = rtSn.Sn;
            
                显示Mes.显示Mes信息();

                msg = $"手动,复位序列号,成功";
                Log.Add($"{msg},{JsonConvert.SerializeObject(tabel)}");

            }
            else
            {
                msg = $"手动,复位序列号,失败,{rtDb.m}";
                rt = false;
            }

            return (rt, msg);
        }


    }
}
