using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLMain
{
    internal class 显示
    {
        internal static void 加工状态(Color cor, string msg)
        {
            FormMain.forms.Invoke((Action)(() => { new qfNet.显示().加工状态(FormMain.forms.uiPanel_加工显示条, cor, msg); }));
        }

    }
}
