using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDLL
{
    internal class 功能栏
    {
        internal static void 初始化()
        {
            string 功能栏_标题 = Languages.Get语言("功能栏标题");
            if (string.IsNullOrEmpty(功能栏_标题))
                功能栏_标题 = Form_Main.forms.ui_功能栏1._DataContext .Title;
            Form_Main.forms.ui_功能栏1?.功能标题(功能栏_标题);

            string path_logo1 = Path.Combine(QF_MainClass_26.软件类.Files_Cfg.Files_res, "logo1.png");
            string path_logo2 = Path.Combine(QF_MainClass_26.软件类.Files_Cfg.Files_res, "logo2.png");
            new QF_MainClass_26.Image_().读取图片文件(path_logo1, out Image r1, out string msgErr);
            new QF_MainClass_26.Image_().读取图片文件(path_logo2, out Image r2, out msgErr);
            Form_Main.forms.ui_功能栏1?.商标1(r1);
            Form_Main.forms.ui_功能栏1?.商标2(r2);
        }

        /// <summary>
        /// 
        /// </summary> 
        internal static void Add(string Name, string Value)
        {
            Form_Main  .forms.ui_功能栏1?.Add(new Sunny._状态栏_功能栏_(Name, Value));

        }
    }
}
