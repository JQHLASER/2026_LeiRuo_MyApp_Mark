using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDLL
{
    internal class Help_软件信息
    {

        static string 版本 = "(QF)App26.4-V0.1";
        static string[] 信息 = new string[]
        {

        };

        internal static void Show()
        {
            new QF_WinForm_26.help信息_().Win_显示_Help文件夹(信息, 版本);
        }





    }
}
