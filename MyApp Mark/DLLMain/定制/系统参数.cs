using qfNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLMain
{
    internal class 系统参数
    {
        public class _Cfg_
        {
            /// <summary>
            /// 最后一次扫码的订单号
            /// </summary>
            public string 工单号 { set; get; } = "";
            public string Url { set; get; } = "http://58.216.251.76:5010/Httphandler/Z/Sunyo/PenMa/GetPenMaContent.ashx?MachiningId=";
            public Http_数据._values_ MesValue { set; get; } = new Http_数据._values_();
            public _Cfg_ Clone()
            {
                return new _Cfg_
                {
                    工单号 = this.工单号,
                    Url = this.Url,
                    MesValue = this.MesValue
                };
            }
        }


        private static readonly object _lock = new object();

        internal static _Cfg_ _参数 = new _Cfg_();


        internal static void 初始化()
        {
            读写(1);
            Log.Add($"url: {_参数.Url}");
            db_序列号.Event_初始化成功 += () =>
            {
                lock (_lock)
                {
                    var rt = db_序列号.Get_查询(_参数.工单号);
                    序列号._序列号 = rt.Sn;
                    显示Mes.显示Mes信息();
                    加工._加工.修改变量信息(rt.Sn);
                }
            };

            LaserMark.Event_加载模板成功 += () =>
            {
                lock (_lock)
                {
                    var rt = db_序列号.Get_查询(_参数.工单号);
                    序列号._序列号 = rt.Sn;
                    加工._加工.修改变量信息(序列号._序列号);
                }
            };


        }
        internal static void 读写(ushort model)
        {
            lock (_lock)
            {
                string path = qfmain.软件类.Files_Cfg.Files_Config + "\\sysCfg.txt";
                _Cfg_ cfg = _参数.Clone();
                new qfmain.文件_文件夹().WriteReadJson<_Cfg_>(path, model, ref cfg, out string msgErr);
                _参数 = cfg.Clone ();               
                显示Mes.显示Mes信息();
            }
        }







    }
}
