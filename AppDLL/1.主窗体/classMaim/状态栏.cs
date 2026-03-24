using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDLL
{
    internal class 状态栏
    {
        internal static void Add(string Name, string Value)
        {
            Form_Main.forms.ui_状态栏1?.Add(new Sunny._状态栏_
            {
                Name = Name,
                内容 = Value,
                colors = Color.White,
            });
        }

        internal static void Add(string Name, string Value, Color colors)
        {
            Form_Main.forms.ui_状态栏1?.Add(new Sunny._状态栏_
            {
                Name = Name,
                内容 = Value,
                colors = colors,
            });
        }

    }
}
