using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDLL
{
    internal class Form_Main_class
    {
        internal static QF_MyApp26_.MyApp26_class _MainClass_sys  ;
        static Form_Main_class()
        {
            _MainClass_sys = new QF_MyApp26_.MyApp26_class();
        }

        internal static void 初始化()
        {
            QF_MyApp26_.MyApp26_class._cfg_软件注册_ _cfg_软件注册 = new QF_MyApp26_.MyApp26_class._cfg_软件注册_
            {
                Dog功能 = 功能.Dog功能,
                注册类型 = 功能._软件注册类型,
                加密狗类型 = 功能._加密狗类型,
            };

            /// <summary>
            /// 主窗体的控件
            /// </summary>
            QF_MyApp26_.MyApp26_class._cfg_控件类_ _cfg_控件类 = new QF_MyApp26_.MyApp26_class._cfg_控件类_
            {
                Form_Main = Form_Main.forms,
                ui_Log = Log.ui_log,
                ui_功能栏 = Form_Main.forms.ui_功能栏1,
                ui_状态栏 = Form_Main.forms.ui_状态栏1,
                窗体_标题栏状态 = 窗体标题栏._标题栏状态,


            };



            _MainClass_sys.Evernt_软件授权结果 += (s, e) => Event_软件注册结果.On_软件注册结果(s, e);
            _MainClass_sys.初始化(_cfg_控件类, _cfg_软件注册);

        }


    }
}
