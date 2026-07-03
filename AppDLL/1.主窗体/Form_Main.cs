
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AppDLL.表;

namespace AppDLL
{
    public partial class Form_Main : Sunny.UI.UIForm
    {
        protected override void WndProc(ref Message m)
        {
            //调用基类的同名方法
            base.WndProc(ref m);
            Form_Main_class._MainClass_sys.软件注册授权_监测狗是否被拔出来_WndProc(ref m);//监测加密狗是否被拔出来 
        }

        internal static Form_Main forms;

        public Form_Main()
        {
            InitializeComponent();

            #region 配置

            // 1. 给窗体本身开启双缓冲
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
            //2.给所有控件开双缓冲
            QF_WinForm_26.winForm双缓冲设置.EnableFormDoubleBuffer(this);
            this.MaximizedBounds = Screen.PrimaryScreen.WorkingArea; //显示任务栏(在进入窗体前使用)
            forms = this;

            #endregion

            功能栏.初始化();
            菜单.初始化();
            Log.初始化(this.uiPanel_Log日志);
            窗体标题栏.初始化();
            Form_Main_class.初始化();
            new 生产计数();

            语言();

            this.Load += async (s, e) => await On_Load(s, e);
            this.FormClosing += async (s, e) => await On_Closeing(s, e);
            this.KeyDown += (s, e) => On_keyDown(s, e);

            this.ui_Button2_激光模板._Button.Click += (s, e) => 打开激光模板();
            this.ui_Button2_扫码._Button.Click += (s, e) => 扫码();


            显示.加工状态(Color.White, "");
            Size_FormMain.读写参数(1);

        }

        #region 本地方法

        async Task On_Load(object s, EventArgs e)
        {
            Form_Main_class._MainClass_sys.软件注册授权_加密狗通知事件();
            this.WindowState = FormWindowState.Maximized;
            this.ShowDragStretch = true;
            Form_Main_class._MainClass_sys.软件注册授权_监测狗是否被拔出来(this.Handle);//监测加密狗是否被拔出来

            窗体标题栏.标题栏状态_初始化中();
            this.ShowWaitForm("Please Wait ...");//请稍候...提示窗体         
            Log.Add(Languages.Get语言("进入系统"));

            Event_FormMain.On_Load();
            await Task.Run(() =>
            {

                Login用户.On_用户登陆();//使用用户时,触发登陆后事件
                Form_Main_class._MainClass_sys.软件注册授权_初始化();
            });
        }

        async Task On_Closeing(object s, FormClosingEventArgs e)
        {
            if (!Err_.系统忙(out string msgErr, false))
            {
                MessageBox.Show(msgErr, "", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }
            else if (!LaserMark._Iwork.Err_初始化中(out msgErr, false))
            {
                MessageBox.Show(msgErr, "", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }
            else if (MessageBox.Show(Languages.Get语言("是否关闭?"), "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }


            生产计数.释放();
            窗体标题栏.释放();
            this.ui_功能栏1.释放();
            this.ui_状态栏1.释放();
            Event_FormMain.On_Closeing();
            Event_软件注册结果.释放();

            Log.Add(Languages.Get语言("关闭系统"));
            Form_Main_class._MainClass_sys.释放();

            // 第一次进来，先取消关闭
            e.Cancel = true;
            await Task.Delay(200);
            new QF_MainClass_26.进程().结束自身进程2();
        }

        void On_keyDown(object s, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11
                && new QF_WinForm_26.软件类().Win_密码输入框(功能._密码.设置工作区尺寸) == DialogResult.Yes)
            {
                Size_FormMain.Win_设置();
            }
            else if (e.KeyCode == Keys.F12)
            {
                Help_软件信息.Show();
            }
            else if (e.KeyCode == Keys.F10
                      && new QF_WinForm_26.软件类().Win_密码输入框(功能._密码.系统设置) == DialogResult.Yes)
            {
                using (Form_系统设置 forms = new Form_系统设置())
                {
                    forms.ShowDialog();
                }
            }



        }

        void 语言()
        {
            this.uiPanel_激光图像.Text = LaserMark._打标卡_名称 + Languages.Get语言("未初始化");
        }


        #endregion


        #region 本地方法...定制

        void 打开激光模板()
        {
            菜单_激光.On_打开激光模板();
        }

        void 扫码()
        {
            if (!Err_.系统报警(out string msgErr, false) || !Err_.系统忙(out msgErr, false))
            {
                MessageBox.Show(msgErr, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (Form_扫码 forms = new Form_扫码())
            {
                forms.uiTextBox1.KeyDown += async (s, e) =>
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        var barcode = forms.uiTextBox1.Text.Trim();
                        forms.uiTextBox1.Clear();
                        if (string.IsNullOrEmpty(barcode))
                        {
                            MessageBox.Show("请扫码", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        Log.Add($"扫码: {barcode}");
                        var work = new string[]
                         {
                               "http",
                               "getDb",
                         };

                        bool rt = true;
                        string msg = "";
                        string sn = "";
                        foreach (var item in work)
                        {
                            if (!rt)
                                break;
                            else if (item == "http")
                            {
                                var rthttp = await http_.请求(barcode);
                                rt = rthttp.s;
                                msg = rthttp.m;
                                系统设置._参数.MesValue = rthttp.cfg.result;
                            }
                            else if (item == "getDb")
                            {
                                this.Text = 系统设置._参数.工单号;
                                var m = 序列号.查询序列号(系统设置._参数.工单号);
                                rt = m.s;
                                msg = m.m;
                                sn = m.sn;
                            }

                        }

                        if (rt)
                        {
                            显示加工信息.显示Mes信息(sn);
                            系统设置.读写参数(0);
                            加工类_._加工.修改变量信息(sn, 系统设置._参数.MesValue);
                            MessageBox.Show("成功");
                            return;
                        }
                        else
                        {
                            MessageBox.Show($"失败,\r\n{msg}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }


                    }
                };

                forms.uiButton_确定.Click += (s, e) =>
                {  
                    序列号.窗体_设置序列号(系统设置._参数.工单号);  
                };
                Log.Add($"...进入扫码窗体");
                forms.ShowDialog();
                Log.Add($"...退出扫码窗体");
            }

        }


        #endregion

    }
}
