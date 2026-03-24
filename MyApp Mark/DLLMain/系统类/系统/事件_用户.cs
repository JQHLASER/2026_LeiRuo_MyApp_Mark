using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DLLMain
{
    internal class 事件_用户
    {

        internal static void On_用户登陆()
        {
            if (!功能._参数.用户_使能)
            {
                return;
            }

            qfNet._loginInfo_ loginInfo = Login_._Login_sys._Config.loginInfo;

            Login_.状态栏显示(loginInfo);
           Log.Add($"{Language_.Get语言("用户登陆")}: {loginInfo.UserName}<{Language_.Get语言($"{loginInfo.UserType}")}>");

            FormMain.forms.Invoke((Action)(() =>
            {
                FormMain.forms.用户管理ToolStripMenuItem.Visible = true;
                FormMain.forms.激光ToolStripMenuItem.Enabled = true ;


                switch (loginInfo.UserType)
                {
                    case qfNet._LoginUserType_.开发者:


                        break;
                    case qfNet._LoginUserType_.超级管理员:


                        break;
                    case qfNet._LoginUserType_.管理员:



                        break;
                    case qfNet._LoginUserType_.技术员:
                        FormMain.forms.用户管理ToolStripMenuItem.Visible = false;

                        break;
                    case qfNet._LoginUserType_.操作员:
                        FormMain.forms.用户管理ToolStripMenuItem.Visible = false;
                        FormMain.forms.激光ToolStripMenuItem.Enabled = false;

                        break;
                }

            }));

        }





    }
}
