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
    internal class 菜单_系统
    {
        static ToolStripMenuItem 系统_ = new 菜单().新建主菜单(Languages.Get语言("系统"));

        static ToolStripMenuItem _生产计数清零 = new 菜单().新建子菜单(Languages.Get语言("生产计数清零"));
        static ToolStripMenuItem _关闭 = new 菜单().新建子菜单(Languages.Get语言("关闭"));
        static ToolStripMenuItem _注册 = new 菜单().新建子菜单(Languages.Get语言("注册"));
        static ToolStripMenuItem _语言 = new 菜单().新建子菜单(Languages.Get语言("语言"));
        static ToolStripMenuItem _设置 = new 菜单().新建子菜单(Languages.Get语言("设置"));
        static ToolStripMenuItem _关于 = new 菜单().新建子菜单(Languages.Get语言("关于"));


        internal static void 初始化()
        {
             
            //系统_.DropDownItems.Add(_设置);

            if (功能._功能Main.生产计数_良品_使能 || 功能._功能Main.生产计数_良品_使能)
                系统_.DropDownItems.Add(_生产计数清零);

            if (功能._软件注册类型 != _软件授权_注册类型_.不注册)
                系统_.DropDownItems.Add(_注册);
            if (功能._功能Main.语言_使能)
                系统_.DropDownItems.Add(_语言);


            系统_.DropDownItems.Add(_关于);
            系统_.DropDownItems.Add(_关闭);          
            Form_Main.forms.menuStrip_菜单.Items.Add(系统_);


            _关闭.Click += (s, e) =>
            {
                Form_Main.forms.Close();
            };


            _注册.Click += (s, e) =>
            {




                Form_Main_class._MainClass_sys.软件注册授权_注册窗体();
            };

            _语言.Click += (s, e) =>
            {
                QF_MainClass_26.Languages.Win_设置();
            };

            _设置.Click += (s, e) =>
            {
                系统设置.Win_设置();
            };

            _关于.Click += (s, e) =>
            {
                Help_软件信息.Show();
            };

            _生产计数清零.Click += (s, e) =>
            {
                if (MessageBox.Show($"{Languages.Get语言("生产计数清零")}?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                生产计数.设置((int)生产计数.JS_sys._当前计数信息.零件, 0, 0);
                Log.Add($"{Languages.Get语言("生产计数清零")}");
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

                    break;
            }
        }


        static void On_用户登陆结果(QF_WinForm_26._LoginUserType_ 权限)
        {
            Form_Main.forms.Invoke((Action)(() =>
            {



                switch (权限)
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

        #endregion




    }
}
