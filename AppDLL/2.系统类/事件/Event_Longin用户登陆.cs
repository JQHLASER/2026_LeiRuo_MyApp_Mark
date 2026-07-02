using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AppDLL
{
    internal class Event_Longin用户登陆
    {

        internal static void On_用户登陆()
        {
            if (!功能._功能Main.用户_使能)
            {
                return;
            }

            QF_WinForm_26._loginInfo_ loginInfo = Login用户._Login_sys._Config.loginInfo;

            Login用户.状态栏显示(loginInfo);
            Log.Add($"{Languages.Get语言("用户登陆")}: {loginInfo.UserName}<{Login用户._Login_sys.语言_用户权限(loginInfo.UserType)}>");

            Event_用户登陆结果?.Invoke(loginInfo.UserType);


            Form_Main.forms.Invoke((Action)(() =>
            {


                switch (loginInfo.UserType)
                {
                    case QF_WinForm_26._LoginUserType_.开发者:


                        break;
                    case QF_WinForm_26._LoginUserType_.超级管理员:


                        break;
                    case QF_WinForm_26._LoginUserType_.管理员:



                        break;
                    case QF_WinForm_26._LoginUserType_.技术员:


                        break;
                    case QF_WinForm_26._LoginUserType_.操作员:



                        break;
                }

            }));

        }


        internal static event Action<QF_WinForm_26._LoginUserType_> Event_用户登陆结果;


    }
}
