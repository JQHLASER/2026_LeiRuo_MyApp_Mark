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
    internal class 菜单_激光 : Languages
    {
        static ToolStripMenuItem 激光_ = new 菜单().新建主菜单(Languages.Get语言("激光"));
        internal static ToolStripMenuItem _编辑软件名称 = new 菜单().新建子菜单("");
        static ToolStripMenuItem _打开 = new 菜单().新建子菜单(Languages.Get语言("打开"));
        static ToolStripMenuItem _复位 = new 菜单().新建子菜单(Languages.Get语言("复位"));
        static ToolStripMenuItem _调试 = new 菜单().新建子菜单(Languages.Get语言("调试"));
        static ToolStripMenuItem _加工 = new 菜单().新建子菜单(Languages.Get语言("加工"));
        static ToolStripMenuItem _红光 = new 菜单().新建子菜单(Languages.Get语言("红光"));
        static ToolStripMenuItem _停止 = new 菜单().新建子菜单(Languages.Get语言("停止"));




        internal static void 初始化()
        {
            switch (功能._打标卡类型)
            {
                case QF_LaserMark_26._em_打标卡类型_.None:
                    return;
                case QF_LaserMark_26._em_打标卡类型_.Ezd2:
                    _编辑软件名称.Text = LaserMark._Iwork._激光编辑软件名称; ;
                    break;
            }

            激光_.DropDownItems.Add(_编辑软件名称);
            激光_.DropDownItems.Add(_打开);
            激光_.DropDownItems.Add(_调试);
            激光_.DropDownItems.Add(_复位);
            激光_.DropDownItems.Add(_加工);
            激光_.DropDownItems.Add(_红光);
            激光_.DropDownItems.Add(_停止);

            Form_Main.forms.menuStrip_菜单.Items.Add(激光_);

            _编辑软件名称.Click += (s, e) =>
            {
                if (!Err_.系统忙(out string msgErr, false))
                {
                    MessageBox.Show(msgErr, "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                Log.Add(true, Get语言("打开激光编辑软件"));
                LaserMark.打开激光软件();
            };

            _打开.Click += (s, e) =>
            {
                if (!Err_.系统报警(out string msgErr, false) || !Err_.系统忙(out msgErr, false))
                {
                    MessageBox.Show(msgErr, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                LaserMark.打开激光模板();
            };

            _复位.Click += (s, e) =>
            {
                On_复位();
            };

            _调试.Click += (s, e) =>
            {
                Log.Add($"{Get语言("进入激光调试窗体")}...");
                LaserMark.窗体_调试();
                Log.Add($"...{Get语言("关闭激光调试窗体")}");
            };

            _红光.Click += (s, e) =>
            {
                var rt = LaserMark.红光指示(false, true);
            };

            _加工.Click += async (s, e) =>
            {
                await Task.Run(() => { 加工类_._加工.加工流程(); });
            };

            _停止.Click += async (s, e) =>
            {
                LaserMark.停止标刻();
            };



            Event_软件注册结果.Event_注册结果 += (s) => On_注册结果(s);
            Event_Longin用户登陆.Event_用户登陆结果 += (s) => On_用户登陆结果(s);
        }



        #region 本地方法

        internal static void On_复位()
        {
            Log.Add(true, $"{Get语言("手动,复位")}");
            IO.Out_报警(false);
        }


        static void On_注册结果(Event_软件注册结果._em_注册状态_ err)
        {
            switch (err)
            {
                case Event_软件注册结果._em_注册状态_.未注册:
                    Form_Main.forms.BeginInvoke((Action)(() => { 激光_.Visible = false; }));
                    break;
            }
        }

        static void On_用户登陆结果(QF_WinForm_26._LoginUserType_ 权限)
        {
            Form_Main.forms.Invoke((Action)(() =>
            {
                激光_.Visible  = true;

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

                        激光_.Visible  = false;

                        break;
                }

            }));
        }


        #endregion





    }
}
