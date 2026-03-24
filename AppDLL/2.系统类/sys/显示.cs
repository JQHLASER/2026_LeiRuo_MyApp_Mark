using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDLL
{
    internal class 显示
    {
        internal static void 加工状态(Color cor, string msg)
        {
            Form_Main .forms.Invoke((Action)(() => { new QF_WinForm_26.显示().加工状态(Form_Main.forms.uiPanel_加工显示条, cor, msg); }));
        }

    }
}
