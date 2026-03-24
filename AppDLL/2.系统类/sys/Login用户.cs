using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace AppDLL
{
    internal class Login用户
    {
        public static QF_WinForm_26.Login登陆 _Login_sys = new QF_WinForm_26.Login登陆()
        {
            _登陆方式 = QF_WinForm_26._LoginModelType_.本地数据,
        };

        public Login用户() : base()
        {

        }


        /// <summary>
        /// 软件启动前登陆,这里还没有进入主窗体
        /// </summary>
        /// <returns></returns>
        internal static bool win_用户登陆()
        {
            if (!功能._功能Main.用户_使能)
            {
                return true;
            }

            DialogResult rt = _Login_sys.登陆(QF_WinForm_26._LoginShowType_.用户登陆);
            return rt == DialogResult.OK ? true : false;
        }

        internal static bool win_用户切换()
        {
            if (!功能._功能Main.用户_使能)
            {
                return true;
            }
            DialogResult rt = _Login_sys.登陆(QF_WinForm_26._LoginShowType_.用户切换);
            if (rt == DialogResult.OK)
            {
                Event_Longin用户登陆.On_用户登陆();
            }
            return rt == DialogResult.OK ? true : false;
        }

        internal static void win_用户管理()
        {
            if (!功能._功能Main.用户_使能)
            {
                return;
            }
            _Login_sys.Win_用户管理();
        }

        internal static void On_用户登陆()
        {
            if (!功能._功能Main.用户_使能)
            {
                return  ;
            }
            Event_Longin用户登陆.On_用户登陆();
        }

        internal static void 状态栏显示(QF_WinForm_26._loginInfo_ 用户信息)
        {
            string Show = $"{_Login_sys.语言_用户权限(用户信息.UserType)} / {用户信息.UserName}";
            功能栏.Add("用户登陆", Show);

        }
    }
}
