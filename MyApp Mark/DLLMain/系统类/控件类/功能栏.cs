using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLMain
{
    internal class 功能栏
    {
        public 功能栏()
        {
            string 功能栏_标题 = Language_.Get语言("功能栏标题");
            FormMain.forms.ui_功能栏1?.功能标题(功能栏_标题);
            new qfmain.Image_().读取图片文件(qfmain.软件类.Files_Cfg.Files_res + "\\logo1.png", out Image r1, out string msgErr);
            new qfmain.Image_().读取图片文件(qfmain.软件类.Files_Cfg.Files_res + "\\logo2.png", out Image r2, out msgErr);
            FormMain.forms.ui_功能栏1.商标1(r1);
            FormMain.forms.ui_功能栏1.商标2(r2);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name">名称</param>
        /// <param name="Value">内容</param>
        internal static void Add(string Name, string Value)
        {
            FormMain.forms.ui_功能栏1?.Add(new Sunny._状态栏_功能栏_(Name, Value));
             
        }

        internal static void 时间(DateTime nows)
        {
            FormMain.forms.BeginInvoke((Action)(() =>
            {
                FormMain.forms.ui_功能栏1?.时间(nows.ToString("HH:mm"));
            }));
        }


        static DateTime now = DateTime.Now;
        internal static void 运行时间(DateTime nows)
        {
            string xt = nows.ToString("yyyy.MM.dd");
            new qfmain.日期时间_().计算_时间间隔(now, nows, out TimeSpan span, out string msgErr);
            string run = $"{span.Days.ToString()}.{span.Hours.ToString("00")}.{span.Minutes.ToString("00")}.{span.Seconds.ToString("00")}";

            FormMain.forms.BeginInvoke((Action)(() =>
            {
                FormMain.forms.ui_功能栏1?.运行时间($"{xt}\r\n{run}");
            }));
        }




    }
}
