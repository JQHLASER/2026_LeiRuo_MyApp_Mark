
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDLL
{
    internal class 窗体标题栏
    {
        internal static QF_WinForm_26.窗体_标题栏状态 _标题栏状态 = new QF_WinForm_26.窗体_标题栏状态();
    


        static QF_WinForm_26._cfg_标题栏状态_[] _标题栏信息 = new QF_WinForm_26._cfg_标题栏状态_[]
                 {
                     new QF_WinForm_26 ._cfg_标题栏状态_("系统",Languages  .Get语言 ("系统初始化中"),-1),
                     new QF_WinForm_26 ._cfg_标题栏状态_("系统","",0)
                 };

        public static void 初始化()
        {
            Form_Main .forms .TitleForeColor = 功能 ._FormMain .标题栏默认文本颜色;
            Form_Main.forms .RectColor  = 功能._FormMain.标题栏默认背景颜色 ;



            _标题栏状态.Event_标题栏状态 += On_标题栏状态;
            _标题栏状态.初始化();


            _标题栏状态.Event_标题栏状态 += On_标题栏状态;
            _标题栏状态.初始化();

            IsInistiall = true;
        }
        static bool IsInistiall = false;
         
       internal static void 释放()
        {
            if (!IsInistiall)
            {
                return;
            }
            _标题栏状态.释放();
        }

        internal static void 标题栏状态_初始化中()
        {
            Add(_标题栏信息, -1);
        }

        internal static void 标题栏状态_初始化结束()
        {
            Add(_标题栏信息, 0);
        }



        public static void Add(QF_WinForm_26 ._cfg_标题栏状态_[] cfg, int state)
        {
            if (!IsInistiall)
            {
                return;
            }
            _标题栏状态.Add(cfg, state);
        }
        static void On_标题栏状态(QF_WinForm_26.窗体_标题栏状态._状态_ state, string value)
        {

            Color Bloack = Color.White;
            Color ForeColor = Color.Black;
            switch (state)
            {
                case QF_WinForm_26.窗体_标题栏状态._状态_.None:
                    Bloack = 功能 ._FormMain .标题栏默认背景颜色;
                    ForeColor = 功能._FormMain.标题栏默认文本颜色;
                    break;
                case QF_WinForm_26.窗体_标题栏状态._状态_.黄色:

                    Bloack = Color.Yellow;
                    break;
                case QF_WinForm_26.窗体_标题栏状态._状态_.红色:
                    Bloack = Color.Red;
                    break;
            }

            Form_Main.forms.BeginInvoke((Action)(() =>
            {
                Form_Main.forms.RectColor = Bloack;
                Form_Main.forms.TitleForeColor = ForeColor;
                Form_Main.forms.Text = value;
            }));
        }
    }
}
