using qfNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLMain
{
    internal class Size_FormMain
    {

        public class _cfg_
        {
            public int 日志高度 { set; get; } = 100;
            public int 工作区_左 { set; get; } = 100;
            public int 工作区_右 { set; get; } = 300;
            public int 激光图像高度 { set; get; } = 150;
            public int 加工显示条高度 { set; get; } = 100;


            public int 商标1_width { set; get; } = 0;
            public int 商标2_width { set; get; } = 0;


        }

        internal static _cfg_ _参数 = new _cfg_();
        internal static void 读写参数(ushort model)
        {
            string path = qfmain.软件类.Files_Cfg.Files_sysConfig + "\\syssize.dll";
            _cfg_ cfg = _参数;
            new qfmain.文件_文件夹().WriteReadIni(path, model, ref cfg, out string msgErr);
            _参数 = cfg;

            FormMain.forms.Invoke((Action)(() =>
            {
                FormMain.forms._DataContext.LogHeight = _参数.日志高度;
                new qfNet.tableLayoutPanel_(FormMain.forms.tableLayoutPanel_工作区).设置列宽度(0, _参数.工作区_左)
                    .设置列宽度(2, _参数.工作区_右);
                FormMain.forms.uiPanel_激光图像.Height = _参数.激光图像高度;
                FormMain.forms.ui_功能栏1._DataContext.商标1_width = _参数.商标1_width;
                FormMain.forms.ui_功能栏1._DataContext.商标2_width = _参数.商标2_width;
                FormMain.forms.uiPanel_加工显示条.Height = _参数.加工显示条高度;


            }));

        }

        internal static void Win_设置()
        {
            using (Form_Size forms = new Form_Size())
            {
                forms.ShowDialog();
            }
        }

    }
}
