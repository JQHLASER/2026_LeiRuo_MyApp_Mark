using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace DLLMain
{
    internal class Login_
    {
        public static qfNet.Login登陆 _Login_sys = new qfNet.Login登陆()
        {
            _登陆方式 = qfNet._LoginModelType_.本地数据,
        };

        public Login_() : base()
        {

        }


        /// <summary>
        /// 软件启动前登陆,这里还没有进入主窗体
        /// </summary>
        /// <returns></returns>
        internal static bool 用户登陆()
        {
            if (!功能._参数.用户_使能)
            {
                return true;
            }

            DialogResult rt = _Login_sys.登陆(qfNet._LoginShowType_.用户登陆);
            return rt == DialogResult.OK ? true : false;
        }

        internal static bool 用户切换()
        {
            if (!功能._参数.用户_使能)
            {
                return true;
            }
            DialogResult rt = _Login_sys.登陆(qfNet._LoginShowType_.用户切换);
            if (rt == DialogResult.OK)
            {
                事件_用户.On_用户登陆( );
            }
            return rt == DialogResult.OK ? true : false;
        }

        internal static void 用户管理()
        {
            if (!功能._参数.用户_使能)
            {
                return;
            }
            _Login_sys.Win_用户管理();
        }


        internal static void 状态栏显示(qfNet._loginInfo_ 用户信息)
        {
            string Show = $"{Language_.Get语言($"{用户信息.UserType}")} / {用户信息.UserName}";
            状态栏.Add("用户登陆", Show);

        }
    }
}
