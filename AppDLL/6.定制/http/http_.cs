using Newtonsoft.Json;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace AppDLL
{
    internal class http_
    {

        static QF_WebServices_26.http_Client http_sys = new QF_WebServices_26.http_Client();

        static async Task<(bool s, string m, Http_数据._反馈_ cfg)> 请求(Http_数据._请求_ info)
        {
            bool rt = true;
            string msg = string.Empty;
            Http_数据._反馈_ rtCfg = new Http_数据._反馈_();
            string getStr = 系统设置._参数.Url + info.MachiningId;


            Log.Add(true, $"mes请求....{getStr}");
            var rtHttp = await http_sys.请求(QF_WebServices_26.http_Client.enum请求方式.Get, getStr, null, "", 10 * 1000);
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
                系统设置._参数.工单号 = barcode;
                系统设置.读写参数(0);
            }

            return (rt, msg, rtMes.cfg);
        }


        #region Err

        internal static bool Err_请查询工单(out string msgErr, bool IsLog = true)
        {
            msgErr = "";
            if (string.IsNullOrEmpty(系统设置._参数.工单号))
            {
                msgErr = "请查询工单";
                if (IsLog)
                    Log.Add(false, msgErr);
                return false;
            }
            return true;
        }

        internal static bool Err_未获取到工单数据(out string msgErr, bool IsLog = true)
        {
            msgErr = "";
            if (string.IsNullOrEmpty(系统设置._参数.MesValue.MachiningId)
                && string.IsNullOrEmpty(系统设置._参数.MesValue.ProductName)
                && string.IsNullOrEmpty(系统设置._参数.MesValue.BomVersion)
                )
            {
                msgErr = "未获取到工单数据";
                if (IsLog)
                    Log.Add(false, msgErr);
                return false;
            }
            return true;
        }

        #endregion
    }
}
