
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDLL
{
    internal class Size_FormMain
    {

        public class _cfg_
        {
            //宣传窗体
            public bool Form宣传_使能 { set; get; } = false;

            public int 日志高度 { set; get; } = 150;
            public int 工作区_左 { set; get; } = 0;
            public int 工作区_右 { set; get; } = 400;
            public int 激光图像高度 { set; get; } = 150;
            public int 加工显示条高度 { set; get; } = 150;


            public int 商标1_width { set; get; } = 100;
            public int 商标2_width { set; get; } = 0;


        }

        internal static _cfg_ _参数 = new _cfg_();
        internal static void 读写参数(ushort model, bool 处理控件 = true)
        {
            string path = Path.Combine(QF_MainClass_26.软件类.Files_Cfg.Files_sysConfig, "syssize.dll");
            _cfg_ cfg = _参数;
            new QF_MainClass_26.文件_文件夹().WriteReadIni(path, model, ref cfg, out string msgErr);
            _参数 = cfg;

            if (处理控件)
                Form_Main.forms.BeginInvoke((Action)(() =>
                {

                    Form_Main.forms.uiPanel_Log日志.Height = _参数.日志高度;
                    new QF_WinForm_26.tableLayoutPanel_(Form_Main.forms.tableLayoutPanel_工作区).设置列宽度(1, _参数.工作区_左)
                        .设置列宽度(3, _参数.工作区_右);
                    Form_Main.forms.ui_功能栏1._DataContext.商标1_width = _参数.商标1_width;
                    Form_Main.forms.ui_功能栏1._DataContext.商标2_width = _参数.商标2_width;
                    Form_Main.forms.uiPanel_加工显示条.Height = _参数.加工显示条高度;
                    Form_Main.forms.uiPanel_激光图像.Height = _参数.激光图像高度;

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
