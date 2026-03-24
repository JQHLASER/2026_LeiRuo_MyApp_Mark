using Newtonsoft.Json;
using qfmain;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static DLLMain.Http_数据;

namespace DLLMain
{
    internal class http_
    {

        static async Task<(bool s, string m, Http_数据._反馈_ cfg)> 请求(Http_数据._请求_ info)
        {
            bool rt = true;
            string msg = string.Empty;
            Http_数据._反馈_ rtCfg = new Http_数据._反馈_();
            string getStr = 系统参数._参数.Url + info.MachiningId;
            Log.Add(true, $"mes请求....{getStr}");
            var rtHttp = await new qfmain.http_Client().请求(qfmain.http_Client.enum请求方式.Get, getStr, null, "", 10 * 1000);
            msg = rtHttp.msg;
            try
            {
                rtCfg = JsonConvert.DeserializeObject<Http_数据._反馈_>(rtHttp.msg);
                if (!rtCfg.success || rtCfg.code != 0)
                {
                    rt = false;
                    msg = rtCfg.msg;
                }
                else
                { 
                    Log.Add($"{JsonConvert.SerializeObject(rtCfg, Formatting.Indented)}");
                }
            }
            catch (Exception ex)
            {
                rt = false;
                msg = ex.Message;
            }
            Log.Add(rt, $"mes反馈....{msg}");
            return (rt, msg, rtCfg);

        }


        internal static async Task<(bool s, string m, Http_数据._反馈_ cfg)> 请求(string barcode)
        {
            bool rt = true;
            string msg = "";
            var rtMes = await http_.请求(new Http_数据._请求_ { MachiningId = barcode });
            rt = rtMes.s;
            msg = rtMes.m;

            if (rt)
            {
                系统参数._参数.工单号 = barcode;
                系统参数.读写(0);
            }

            return (rt, msg, rtMes.cfg);
        }



    }
}
