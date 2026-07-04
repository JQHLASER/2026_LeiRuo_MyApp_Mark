using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDLL
{
    internal class 系统设置
    {

        public class _cfg_
        {
            public string Url { set; get; } = "http://58.216.251.76:5010/Httphandler/Z/Sunyo/PenMa/GetPenMaContent.ashx?MachiningId=";


            /// <summary>
            /// 最后一次扫码的订单号
            /// </summary>
            public string 工单号 { set; get; } = "";

            public Http_数据._values_ MesValue { set; get; } = new Http_数据._values_();
        }

        internal static _cfg_ _参数 = new _cfg_();
        private static readonly object _lockRead = new object();
        internal static (bool s, string msgErr) 读写参数(ushort model)
        {
            lock (_lockRead)
            {
                string path = Path.Combine(QF_MainClass_26.软件类.Files_Cfg.Files_Config, "sysCfg.txt");
                _cfg_ cfg = _参数;
                bool rt = new QF_MainClass_26.文件_文件夹().WriteReadJson(path, model, ref cfg, out string msgErr);
                _参数 = cfg;
               // Log.Add(rt, $"系统设置, {JsonConvert.SerializeObject(_参数.MesValue, Formatting.None)},,{msgErr}");
                return (rt, msgErr);
            }
        }


        internal static void Win_设置()
        {
            using (Form_系统设置 forms = new Form_系统设置())
            {
                forms.ShowDialog();
            }
        }


    }
}
