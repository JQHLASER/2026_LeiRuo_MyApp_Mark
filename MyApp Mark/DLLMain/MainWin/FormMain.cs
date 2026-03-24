
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Xml.Linq;



namespace DLLMain
{
    public partial class FormMain : Sunny.UI.UIForm
    {
        //双缓冲显示窗体所有子控件
        // protected override CreateParams CreateParams { get { CreateParams cp = base.CreateParams; cp.ExStyle |= 0x02000000; return cp; } }
        internal static FormMain forms;

        // 视图模型实例
        internal readonly ViewMovel_FormMain _DataContext;

        /// <summary>
        /// 日志
        /// </summary>
        internal qfNet.ui_Log ui_log = new qfNet.ui_Log()
        {
            Dock = DockStyle.Fill,
        };



        protected override void WndProc(ref Message m)
        {
            //调用基类的同名方法
            base.WndProc(ref m);
            注册.dogEvent.WndProc(ref m);//监测加密狗是否被拔出来


        }


        public FormMain()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.PrimaryScreen.WorkingArea; //显示任务栏(在进入窗体前使用)
            forms = this;

            // 初始化 ViewModel
            this._DataContext = new ViewMovel_FormMain();
            // 设置数据上下文（绑定源）
            this.DataContext = this._DataContext;


            #region 绑定数据源 

            //this.uiTextBox1.DataBindings.Add("Text", this._DataContext, nameof(this._DataContext.UserName), false, DataSourceUpdateMode.OnPropertyChanged);

            //日志栏高度
            this.uiPanel_Log.DataBindings.Add("Height", this._DataContext, nameof(this._DataContext.LogHeight), false);
            this.uiPanel_工作区左.DataBindings.Add("RectColor", this._DataContext, nameof(this._DataContext.工作区边框颜色), false);
            this.uiPanel_工作区右.DataBindings.Add("RectColor", this._DataContext, nameof(this._DataContext.工作区边框颜色), false);
            this.uiPanel_工作区中.DataBindings.Add("RectColor", this._DataContext, nameof(this._DataContext.工作区边框颜色), false);

            this.DataBindings.Add("RectColor", this._DataContext, nameof(this._DataContext.标题栏颜色), false);
            this.DataBindings.Add("Text", this._DataContext, nameof(this._DataContext.标题栏内容), false);
            this.DataBindings.Add("TitleForeColor", this._DataContext, nameof(this._DataContext.标题栏文本颜色), false);

            //  this.DataBindings.Add("WindowState", this._DataContext, nameof(this._DataContext.FormMainState), false,DataSourceUpdateMode.OnPropertyChanged);



            #endregion


            this.uiPanel_Log.Controls.Add(ui_log);


            #region 事件


            事件_主窗体.进入窗体前();
            this.Load += (s, e) => 事件_主窗体.进入窗体();
            this.FormClosing += (s, e) => 事件_主窗体.退出窗体(e);
            this.Shown += (s, e) => 事件_主窗体.Shown();
            this.KeyDown += (s, e) => 事件_主窗体.快捷键(s, e);


            #endregion


            #region 事件....菜单...系统

            this.注册ToolStripMenuItem.Click += (s, e) => 软件注册();
            this.语言ToolStripMenuItem.Click += (s, e) => 语言();
            this.退出ToolStripMenuItem.Click += (s, e) => 退出();

            #endregion

            #region 事件....菜单...用户

            this.用户登陆ToolStripMenuItem.Click += (s, e) => 用户切换();
            this.用户管理ToolStripMenuItem.Click += (s, e) => 用户管理();

            #endregion

            #region 事件....菜单...控制器

            this.iO查看ToolStripMenuItem.Click += (s, e) => IO查看();


            #endregion

            #region 事件....菜单...激光

            this.ezCad2ToolStripMenuItem.Click += (s, e) => 激光_打开EzCad();
            this.激光_打开ToolStripMenuItem.Click += (s, e) => 激光_打开模板();
            this.激光_调试ToolStripMenuItem.Click += (s, e) => 激光_调试();
            this.激光_复位ToolStripMenuItem.Click += (s, e) => 激光_复位();
            this.激光_红光ToolStripMenuItem.Click += (s, e) => 激光_红光();
            this.激光_加工ToolStripMenuItem.Click += (s, e) => 激光_加工();
            this.激光_停止ToolStripMenuItem.Click += (s, e) => 激光_停止();

            #endregion


            this.uiButton_扫码.Click += (s, e) =>
            {
                if (!Err.系统报警(out string msg, false)
                || !Err.系统忙(out msg, false))
                {
                    MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (Form_扫码 forms = new Form_扫码())
                {
                    Log.Add("进入扫码窗体....");
                    forms.ShowDialog();
                    var rtSn = db_序列号.Get_查询(系统参数._参数.工单号);
                    if (rtSn.s)
                    { 
                        加工._加工.修改变量信息(rtSn.Sn);
                    }
                    Log.Add("....关闭扫码窗体");
                }
            };

            this.uiButton_激光模板.Click += (s, e) =>
            {
                激光_打开模板();
            };



            #region 语言

            窗体语言();

            #endregion

        }

        #region 方法...菜单...系统

        void 软件注册()
        {
            注册.窗体();
        }

        void 语言()
        {
            Language_.Win_设置();
        }

        void 退出()
        {
            this.Close();
        }



        #endregion

        #region 方法...菜单...用户

        void 用户切换()
        {
            Login_.用户切换();
        }

        void 用户管理()
        {
            Login_.用户管理();
        }


        #endregion

        #region 方法...菜单...控制器

        void IO查看()
        {
            Zaxis_.窗体_IO查看();
        }




        #endregion

        #region 方法...菜单...激光

        void 激光_打开EzCad()
        {
            if (!Err.系统忙(out string msgErr, false))
            {
                MessageBox.Show(msgErr, "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            Log.Add(true, Language_.Get语言("打开激光编辑软件"));
            LaserMark.打开激光软件();
        }

        void 激光_打开模板()
        {
            if (!Err.系统报警(out string msgErr, false) || !Err.系统忙(out msgErr, false))
            {
                MessageBox.Show(msgErr, "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            LaserMark.打开激光模板();
        }

        void 激光_调试()
        {
            Log.Add($"{Language_.Get语言("进入激光调试窗体")}...");
            LaserMark.窗体_调试();
            Log.Add($"...{Language_.Get语言("关闭激光调试窗体")}");
        }
        void 激光_复位()
        {
            Log.Add(true, $"{Language_.Get语言("手动,复位")}");
            IO.Out_报警(false);

        }
        void 激光_红光()
        {
            var rt = LaserMark.红光指示(false, true);

        }
        void 激光_加工()
        {
            var t0 = 加工.启动加工();
        }
        void 激光_停止()
        {
            LaserMark.停止标刻();
        }

        #endregion

        void 窗体语言()
        {
            this.uiPanel_激光图像.Text = Language_.Get语言("打标卡") + Language_.Get语言("未初始化");
        }
    }
}
