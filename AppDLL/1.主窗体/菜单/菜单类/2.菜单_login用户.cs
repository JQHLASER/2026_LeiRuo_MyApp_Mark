using QF_MainClass_26;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDLL
{
    internal class 菜单_login用户
    {
        static ToolStripMenuItem 用户_ = new 菜单().新建主菜单(Languages.Get语言("用户"));
        internal static ToolStripMenuItem _管理 = new 菜单().新建子菜单(Languages.Get语言("管理"));
        static ToolStripMenuItem _切换 = new 菜单().新建子菜单(Languages.Get语言("切换"));



        internal static void 初始化()
        {
            if (!功能._功能Main.用户_使能)
                return;

            用户_.DropDownItems.Add(_管理);
            用户_.DropDownItems.Add(_切换);
            Form_Main.forms.menuStrip_菜单.Items.Add(用户_);

            _管理.Click += (s, e) =>
            {
                Login用户.win_用户管理();
            };

            _切换.Click += (s, e) =>
            {
                Login用户.win_用户切换();
            };


            Event_软件注册结果.Event_注册结果 += (s) => On_注册结果(s);
            Event_Longin用户登陆.Event_用户登陆结果 += (s) => On_用户登陆结果(s);
        }





        #region 本地方法


        static void On_注册结果(Event_软件注册结果._em_注册状态_ err)
        {
            switch (err)
            {
                case Event_软件注册结果._em_注册状态_.未注册:
                    Form_Main.forms.BeginInvoke((Action)(() => { 用户_.Visible = false; }));
                    break;
            }
        }

        static void On_用户登陆结果(QF_WinForm_26._LoginUserType_ 权限)
        {
            Form_Main.forms.Invoke((Action)(() =>
            {
                _管理.Visible = true;

                switch (权限)
                {
                    case QF_WinForm_26._LoginUserType_.开发者:


                        break;
                    case QF_WinForm_26._LoginUserType_.超级管理员:


                        break;
                    case QF_WinForm_26._LoginUserType_.管理员:



                        break;
                    case QF_WinForm_26._LoginUserType_.技术员:
                        _管理.Visible = false;

                        break;
                    case QF_WinForm_26._LoginUserType_.操作员:

                        _管理.Visible  = false;

                        break;
                }

            }));
        }


        #endregion



    }
}
