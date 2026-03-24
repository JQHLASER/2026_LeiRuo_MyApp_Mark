using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace DLLMain
{
    internal class 功能
    {

        public class _cfg_
        {

            //宣传窗体
            public bool Form宣传_使能 { set; get; } = false;
            //用户登陆...Login
            public bool 用户_使能 { set; get; } = false;
            //使能语言
            public bool 语言_使能 { set; get; } = false;

            //生产计数
            public bool 生产计数_良品_使能 { set; get; } = false;
            //生产计数
            public bool 生产计数_不良品_使能 { set; get; } = false;
            //生产计数
            public bool 生产计数_零件_使能 { set; get; } = false;

            //正运动
            public bool Zaxis_使能 { set; get; } = false;

            public bool 使能_报警持续输出IO { set; get; } = false;
        }

        public class _cfg密码_
        {
            public string 设置工作区尺寸 { set; get; } = "QF8888";


        }





        public 功能()
        {

            FormMain.forms.注册ToolStripMenuItem.Visible = 软件注册_注册方式 == qfmain._软件授权_注册类型_.不注册 ? false : true;

            FormMain.forms.ui_log._BackColor = 日志栏_背景颜色;//日志背景色
            FormMain.forms.ui_log._ItemHeight = 日志栏_行高;//日志行高度

            FormMain.forms.用户ToolStripMenuItem.Visible = _参数.用户_使能;
            FormMain.forms.语言ToolStripMenuItem.Visible = _参数.语言_使能;
            FormMain.forms.控制器toolStripMenuItem1.Visible = _参数.Zaxis_使能;
            if (打标卡 == qf_Laser._em_打标卡类型_.None)
            {
                FormMain.forms.uiPanel_激光图像.Visible = false;

            }

            FormMain.forms.激光_复位ToolStripMenuItem.Visible = _参数.使能_报警持续输出IO;

        }


        /// <summary>
        /// 主窗体日志区
        /// </summary>
        internal static int 日志_显示行数 = 200;

        internal static Color 工作区_边框颜色 = Color.WhiteSmoke;// Color.Gainsboro;// Color.FromArgb(74, 74, 74);
        internal static Color 日志栏_背景颜色 = Color.White;
        internal static int 日志栏_行高 = 25;


        //软件注册 / 加密狗

        internal static qfmain._软件授权_注册类型_ 软件注册_注册方式 = qfmain._软件授权_注册类型_.本地;
        internal static string Dog功能 = $"{qfmain._Dog_Type.代理}|";

        internal static qf_Laser._em_打标卡类型_ 打标卡 = qf_Laser._em_打标卡类型_.Ezd2;

        internal static _cfg_ _参数 = new _cfg_();
        internal static _cfg密码_ _密码 = new _cfg密码_();




    }
}
