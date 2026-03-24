using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLMain
{
    internal class 状态栏
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name">名称</param>
        /// <param name="Value">内容</param>
        internal static void Add(string Name, string Value)
        {
            FormMain.forms.ui_状态栏1?.Add(new Sunny._状态栏_功能栏_(Name, Value));
        }

    }
}
