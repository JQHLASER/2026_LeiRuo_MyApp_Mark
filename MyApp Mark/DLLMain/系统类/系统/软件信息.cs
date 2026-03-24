using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLMain
{
    internal class 软件信息
    {


        static string[] 信息 = new string[]
        {

        };

        internal static void Show()
        {
            new qfNet.软件类().Win_软件信息及help(信息);
        }





    }
}
