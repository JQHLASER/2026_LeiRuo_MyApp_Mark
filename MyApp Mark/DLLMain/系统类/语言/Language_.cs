using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLMain
{
    internal class Language_
    {

        internal Language_()
        {
            new qfmain.Language_();
            qfmain.Language_.Set语言包(new LanguageList().lst_Language);
            qfmain.Language_.Get语言包();
        }

        internal static string Get语言(string keyValue)
        {
            return qfmain.Language_.Get语言(keyValue);
        }

        internal static void Win_设置()
        {
            qfNet.Language_.Win_设置();
        }

    }
}
