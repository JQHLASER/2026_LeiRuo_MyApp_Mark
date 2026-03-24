using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AppDLL
{
    internal class 菜单_按钮
    {

      //  static ToolStripMenuItem 轴回零_ = new 菜单().新建主菜单(Languages.Get语言("轴回零"));

        internal static void 初始化()
        {
             
            //Form_Main.forms.menuStrip_菜单.Items.Add(轴回零_);

            //轴回零_.Click += async (s, e) =>
            //{
            // 
            //     
            //};




            Event_软件注册结果.Event_注册结果 += (s) => On_注册结果(s);
            Event_Longin用户登陆.Event_用户登陆结果 += (s) => On_用户登陆结果(s);
        }



        #region 本地方法




        static void On_注册结果(Event_软件注册结果._em_注册状态_ err)
        {
            switch (err)
            {
                case Event_软件注册结果._em_注册状态_.未注册:
                  //Form_Main.forms.BeginInvoke((Action)(() => { 轴回零_.Visible = false; }));
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
