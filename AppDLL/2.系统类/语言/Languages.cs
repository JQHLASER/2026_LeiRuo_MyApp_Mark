using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDLL
{
    internal class Languages
    {

        static Languages()
        {
            // new QF_MainClass_26.Languages();
            QF_MainClass_26.Languages.Set语言包(LanguageList.lst_Language);
            //new QF_WinForm_26.Languages();
            //new QF_MyApp26_.Languages();
            //new QF_Iwork_26.Languages();
            //new QF_CodeBm_26.langeuages();
            //new QF_LaserMark_26.Languages();
            //new QF_PLC_26.Languages(); 
        }

        internal static string Get语言(string keyValue)
        {
            var rt = QF_MainClass_26.Languages.Get语言(keyValue, LanguageList.lst_Language);
            return rt.languageValue;
        }

        internal static void Win_设置()
        {
            QF_MainClass_26.Languages.Win_设置();
        }
         

    }
}
