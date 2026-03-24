using Model26;
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
    internal class 菜单_Zaxis
    {
        static ToolStripMenuItem 控制器_ = new 菜单().新建主菜单(Languages.Get语言("控制器"));
        internal static ToolStripMenuItem _IO查看 = new 菜单().新建子菜单(Languages.Get语言("IO查看"));
        static ToolStripMenuItem _轴参数 = new 菜单().新建子菜单(Languages.Get语言("轴参数"));
        static ToolStripMenuItem _轴回零 = new 菜单().新建主菜单(Languages.Get语言("轴回零"));
         

        internal static void 初始化()
        {
            if (!功能._Zaxis使能)
            {
                return;
            }
            控制器_.DropDownItems.Add(_IO查看);
            if (功能._Zaxis运动轴_使能)
            {
                控制器_.DropDownItems.Add(_轴参数);
                控制器_.DropDownItems.Add(_轴回零);
              


            }
            
            Form_Main.forms.menuStrip_菜单.Items.Add(控制器_);


            _IO查看.Click += (s, e) =>
            {
                Zaxis_.Win_IO查看();
            };

            _轴参数.Click += (s, e) =>
            {
                Zaxis_运动轴.Win_设置();
            };

            _轴回零.Click += async (s, e) =>
            {
                if (MessageBox .Show ($"{Languages.Get语言("轴回零")}?","",MessageBoxButtons.YesNo )==DialogResult.No )
                {
                    return;
                }
             await    Zaxis_运动轴.轴全部回零(true);

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
                    Form_Main.forms.BeginInvoke((Action)(() => { 控制器_.Visible = false; }));
                    break;
            }
        }

        static void On_用户登陆结果(QF_WinForm_26._LoginUserType_ 权限)
        {
            Form_Main.forms.Invoke((Action)(() =>
            {
                _轴参数 .Visible = true;
                _IO查看 .Visible = true;
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

                        _轴参数.Visible = false;
                        _IO查看.Visible = false ;

                        break;
                }

            }));
        }


        #endregion



    }
}
