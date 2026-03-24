using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLMain
{
    internal class 窗体标题栏状态
    {

        internal static qfNet.窗体_标题栏状态 _标题栏状态 = new qfNet.窗体_标题栏状态();
        static Color _color_标题栏默认颜色 = Color.WhiteSmoke;
        static Color _color_标题栏默认文本颜色 = Color.Black;

        static qfNet._cfg_标题栏状态_[] _标题栏信息 = new qfNet._cfg_标题栏状态_[]
                 {
                     new qfNet._cfg_标题栏状态_("系统",Language_ .Get语言 ("系统初始化中"),-1),
                     new qfNet._cfg_标题栏状态_("系统","",0)
                 };



        internal static void 初始化()
        {
            _color_标题栏默认文本颜色 = FormMain.forms._DataContext.标题栏文本颜色;
            _color_标题栏默认颜色 = FormMain.forms._DataContext.标题栏颜色;
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
            _标题栏状态.Event_标题栏状态 -= On_标题栏状态;
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


        static void On_标题栏状态(qfNet.窗体_标题栏状态._状态_ state, string value)
        {

            Color Bloack = Color.White;
            Color ForeColor = Color.Black;
            switch (state)
            {
                case qfNet.窗体_标题栏状态._状态_.None:
                    Bloack = _color_标题栏默认颜色;
                    ForeColor = _color_标题栏默认文本颜色;
                    break;
                case qfNet.窗体_标题栏状态._状态_.黄色:

                    Bloack = Color.Yellow;
                    break;
                case qfNet.窗体_标题栏状态._状态_.红色:
                    Bloack = Color.Red;
                    break;
            }

            FormMain.forms.BeginInvoke((Action)(() =>
            {
                FormMain.forms._DataContext.标题栏颜色 = Bloack;
                FormMain.forms._DataContext.标题栏文本颜色 = ForeColor;
                FormMain.forms._DataContext.标题栏内容 = value;
            }));
        }





        public static void Add(qfNet._cfg_标题栏状态_[] cfg, int state)
        {
            if (!IsInistiall)
            {
                return;
            }
            _标题栏状态.Add(cfg, state);
        }


    }
}
