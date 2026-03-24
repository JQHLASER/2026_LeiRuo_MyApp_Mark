namespace DLLMain
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Sunny.viewModel_状态栏 viewModel_状态栏1 = new Sunny.viewModel_状态栏();
            Sunny.viewModel_状态栏 viewModel_状态栏2 = new Sunny.viewModel_状态栏();
            Sunny.viewModel_功能栏 viewModel_功能栏1 = new Sunny.viewModel_功能栏();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tableLayoutPanel_工作区 = new System.Windows.Forms.TableLayoutPanel();
            this.uiPanel_工作区左 = new Sunny.UI.UIPanel();
            this.uiPanel_工作区中 = new Sunny.UI.UIPanel();
            this.uiPanel_激光图像 = new Sunny.UI.UIPanel();
            this.uiPanel_Log = new Sunny.UI.UIPanel();
            this.uiPanel_工作区右 = new Sunny.UI.UIPanel();
            this.uiPanel_加工显示条 = new Sunny.UI.UIPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注册ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.语言ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户登陆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.控制器toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iO查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.激光ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ezCad2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.激光_打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.激光_复位ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.激光_调试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.激光_加工ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.激光_红光ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.激光_停止ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ui_状态栏1 = new Sunny.ui_状态栏();
            this.ui_功能栏1 = new Sunny.ui_功能栏();
            this.tableLayoutPanel_工作区.SuspendLayout();
            this.uiPanel_工作区中.SuspendLayout();
            this.uiPanel_工作区右.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_工作区
            // 
            this.tableLayoutPanel_工作区.ColumnCount = 3;
            this.tableLayoutPanel_工作区.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel_工作区.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_工作区.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel_工作区.Controls.Add(this.uiPanel_工作区左, 0, 1);
            this.tableLayoutPanel_工作区.Controls.Add(this.uiPanel_工作区中, 1, 1);
            this.tableLayoutPanel_工作区.Controls.Add(this.uiPanel_工作区右, 2, 1);
            this.tableLayoutPanel_工作区.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_工作区.Location = new System.Drawing.Point(0, 105);
            this.tableLayoutPanel_工作区.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel_工作区.Name = "tableLayoutPanel_工作区";
            this.tableLayoutPanel_工作区.RowCount = 2;
            this.tableLayoutPanel_工作区.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel_工作区.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_工作区.Size = new System.Drawing.Size(900, 465);
            this.tableLayoutPanel_工作区.TabIndex = 3;
            // 
            // uiPanel_工作区左
            // 
            this.uiPanel_工作区左.BackColor = System.Drawing.Color.Transparent;
            this.uiPanel_工作区左.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel_工作区左.FillColor = System.Drawing.Color.WhiteSmoke;
            this.uiPanel_工作区左.FillDisableColor = System.Drawing.Color.Transparent;
            this.uiPanel_工作区左.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiPanel_工作区左.Location = new System.Drawing.Point(2, 7);
            this.uiPanel_工作区左.Margin = new System.Windows.Forms.Padding(2);
            this.uiPanel_工作区左.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel_工作区左.Name = "uiPanel_工作区左";
            this.uiPanel_工作区左.RectColor = System.Drawing.Color.Gainsboro;
            this.uiPanel_工作区左.Size = new System.Drawing.Size(96, 456);
            this.uiPanel_工作区左.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel_工作区左.StyleCustomMode = true;
            this.uiPanel_工作区左.TabIndex = 3;
            this.uiPanel_工作区左.Text = null;
            // 
            // uiPanel_工作区中
            // 
            this.uiPanel_工作区中.BackColor = System.Drawing.Color.Transparent;
            this.uiPanel_工作区中.Controls.Add(this.uiPanel_激光图像);
            this.uiPanel_工作区中.Controls.Add(this.uiPanel_Log);
            this.uiPanel_工作区中.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel_工作区中.FillColor = System.Drawing.Color.WhiteSmoke;
            this.uiPanel_工作区中.FillDisableColor = System.Drawing.Color.Transparent;
            this.uiPanel_工作区中.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiPanel_工作区中.Location = new System.Drawing.Point(102, 7);
            this.uiPanel_工作区中.Margin = new System.Windows.Forms.Padding(2);
            this.uiPanel_工作区中.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel_工作区中.Name = "uiPanel_工作区中";
            this.uiPanel_工作区中.RectColor = System.Drawing.Color.Gainsboro;
            this.uiPanel_工作区中.Size = new System.Drawing.Size(496, 456);
            this.uiPanel_工作区中.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel_工作区中.StyleCustomMode = true;
            this.uiPanel_工作区中.TabIndex = 4;
            this.uiPanel_工作区中.Text = null;
            // 
            // uiPanel_激光图像
            // 
            this.uiPanel_激光图像.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel_激光图像.FillColor = System.Drawing.Color.Black;
            this.uiPanel_激光图像.Font = new System.Drawing.Font("微软雅黑", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel_激光图像.ForeColor = System.Drawing.Color.White;
            this.uiPanel_激光图像.Location = new System.Drawing.Point(0, 0);
            this.uiPanel_激光图像.Margin = new System.Windows.Forms.Padding(0);
            this.uiPanel_激光图像.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel_激光图像.Name = "uiPanel_激光图像";
            this.uiPanel_激光图像.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel_激光图像.Size = new System.Drawing.Size(496, 356);
            this.uiPanel_激光图像.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel_激光图像.StyleCustomMode = true;
            this.uiPanel_激光图像.TabIndex = 0;
            this.uiPanel_激光图像.Text = "打标卡未初始化";
            // 
            // uiPanel_Log
            // 
            this.uiPanel_Log.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPanel_Log.FillColor = System.Drawing.Color.White;
            this.uiPanel_Log.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiPanel_Log.Location = new System.Drawing.Point(0, 356);
            this.uiPanel_Log.Margin = new System.Windows.Forms.Padding(0);
            this.uiPanel_Log.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel_Log.Name = "uiPanel_Log";
            this.uiPanel_Log.Padding = new System.Windows.Forms.Padding(2);
            this.uiPanel_Log.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel_Log.RectColor = System.Drawing.Color.Gainsboro;
            this.uiPanel_Log.RectDisableColor = System.Drawing.Color.Gainsboro;
            this.uiPanel_Log.Size = new System.Drawing.Size(496, 100);
            this.uiPanel_Log.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel_Log.StyleCustomMode = true;
            this.uiPanel_Log.TabIndex = 0;
            this.uiPanel_Log.Text = null;
            // 
            // uiPanel_工作区右
            // 
            this.uiPanel_工作区右.BackColor = System.Drawing.Color.Transparent;
            this.uiPanel_工作区右.Controls.Add(this.uiPanel_加工显示条);
            this.uiPanel_工作区右.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel_工作区右.FillColor = System.Drawing.Color.WhiteSmoke;
            this.uiPanel_工作区右.FillDisableColor = System.Drawing.Color.Transparent;
            this.uiPanel_工作区右.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiPanel_工作区右.Location = new System.Drawing.Point(602, 7);
            this.uiPanel_工作区右.Margin = new System.Windows.Forms.Padding(2);
            this.uiPanel_工作区右.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel_工作区右.Name = "uiPanel_工作区右";
            this.uiPanel_工作区右.RectColor = System.Drawing.Color.Gainsboro;
            this.uiPanel_工作区右.Size = new System.Drawing.Size(296, 456);
            this.uiPanel_工作区右.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel_工作区右.StyleCustomMode = true;
            this.uiPanel_工作区右.TabIndex = 2;
            this.uiPanel_工作区右.Text = null;
            // 
            // uiPanel_加工显示条
            // 
            this.uiPanel_加工显示条.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPanel_加工显示条.Font = new System.Drawing.Font("微软雅黑", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel_加工显示条.Location = new System.Drawing.Point(0, 416);
            this.uiPanel_加工显示条.Margin = new System.Windows.Forms.Padding(0);
            this.uiPanel_加工显示条.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel_加工显示条.Name = "uiPanel_加工显示条";
            this.uiPanel_加工显示条.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel_加工显示条.Size = new System.Drawing.Size(296, 40);
            this.uiPanel_加工显示条.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel_加工显示条.TabIndex = 1;
            this.uiPanel_加工显示条.Text = "加工状态";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("微软雅黑", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem,
            this.用户ToolStripMenuItem,
            this.控制器toolStripMenuItem1,
            this.激光ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 80);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(900, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.注册ToolStripMenuItem,
            this.语言ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.系统ToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(56, 25);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // 注册ToolStripMenuItem
            // 
            this.注册ToolStripMenuItem.Name = "注册ToolStripMenuItem";
            this.注册ToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.注册ToolStripMenuItem.Text = "注册";
            // 
            // 语言ToolStripMenuItem
            // 
            this.语言ToolStripMenuItem.Name = "语言ToolStripMenuItem";
            this.语言ToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.语言ToolStripMenuItem.Text = "语言";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 用户ToolStripMenuItem
            // 
            this.用户ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户管理ToolStripMenuItem,
            this.用户登陆ToolStripMenuItem});
            this.用户ToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.用户ToolStripMenuItem.Name = "用户ToolStripMenuItem";
            this.用户ToolStripMenuItem.Size = new System.Drawing.Size(56, 25);
            this.用户ToolStripMenuItem.Text = "用户";
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.用户管理ToolStripMenuItem.Text = "管理";
            // 
            // 用户登陆ToolStripMenuItem
            // 
            this.用户登陆ToolStripMenuItem.Name = "用户登陆ToolStripMenuItem";
            this.用户登陆ToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.用户登陆ToolStripMenuItem.Text = "登陆";
            // 
            // 控制器toolStripMenuItem1
            // 
            this.控制器toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iO查看ToolStripMenuItem});
            this.控制器toolStripMenuItem1.ForeColor = System.Drawing.Color.DimGray;
            this.控制器toolStripMenuItem1.Name = "控制器toolStripMenuItem1";
            this.控制器toolStripMenuItem1.Size = new System.Drawing.Size(72, 25);
            this.控制器toolStripMenuItem1.Text = "控制器";
            // 
            // iO查看ToolStripMenuItem
            // 
            this.iO查看ToolStripMenuItem.Name = "iO查看ToolStripMenuItem";
            this.iO查看ToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.iO查看ToolStripMenuItem.Text = "IO查看";
            // 
            // 激光ToolStripMenuItem
            // 
            this.激光ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ezCad2ToolStripMenuItem,
            this.激光_打开ToolStripMenuItem,
            this.激光_复位ToolStripMenuItem,
            this.激光_调试ToolStripMenuItem,
            this.激光_加工ToolStripMenuItem,
            this.激光_红光ToolStripMenuItem,
            this.激光_停止ToolStripMenuItem});
            this.激光ToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.激光ToolStripMenuItem.Name = "激光ToolStripMenuItem";
            this.激光ToolStripMenuItem.Size = new System.Drawing.Size(56, 25);
            this.激光ToolStripMenuItem.Text = "激光";
            // 
            // ezCad2ToolStripMenuItem
            // 
            this.ezCad2ToolStripMenuItem.Name = "ezCad2ToolStripMenuItem";
            this.ezCad2ToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.ezCad2ToolStripMenuItem.Text = "EzCad2";
            // 
            // 激光_打开ToolStripMenuItem
            // 
            this.激光_打开ToolStripMenuItem.Name = "激光_打开ToolStripMenuItem";
            this.激光_打开ToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.激光_打开ToolStripMenuItem.Text = "打开";
            // 
            // 激光_复位ToolStripMenuItem
            // 
            this.激光_复位ToolStripMenuItem.Name = "激光_复位ToolStripMenuItem";
            this.激光_复位ToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.激光_复位ToolStripMenuItem.Text = "复位";
            // 
            // 激光_调试ToolStripMenuItem
            // 
            this.激光_调试ToolStripMenuItem.Name = "激光_调试ToolStripMenuItem";
            this.激光_调试ToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.激光_调试ToolStripMenuItem.Text = "调试";
            // 
            // 激光_加工ToolStripMenuItem
            // 
            this.激光_加工ToolStripMenuItem.Name = "激光_加工ToolStripMenuItem";
            this.激光_加工ToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.激光_加工ToolStripMenuItem.Text = "加工";
            // 
            // 激光_红光ToolStripMenuItem
            // 
            this.激光_红光ToolStripMenuItem.Name = "激光_红光ToolStripMenuItem";
            this.激光_红光ToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.激光_红光ToolStripMenuItem.Text = "红光";
            // 
            // 激光_停止ToolStripMenuItem
            // 
            this.激光_停止ToolStripMenuItem.Name = "激光_停止ToolStripMenuItem";
            this.激光_停止ToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.激光_停止ToolStripMenuItem.Text = "停止";
            // 
            // ui_状态栏1
            // 
            this.ui_状态栏1.BackColor = System.Drawing.Color.White;
            viewModel_状态栏1.InfoStr = "";
            this.ui_状态栏1.DataBindings.Add(new System.Windows.Forms.Binding("Text", viewModel_状态栏1, "InfoStr", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            viewModel_状态栏2.InfoStr = "";
            this.ui_状态栏1.DataContext = viewModel_状态栏2;
            this.ui_状态栏1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ui_状态栏1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.ui_状态栏1.FillDisableColor = System.Drawing.Color.WhiteSmoke;
            this.ui_状态栏1.Font = new System.Drawing.Font("微软雅黑", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ui_状态栏1.ForeColor = System.Drawing.Color.Gray;
            this.ui_状态栏1.ForeDisableColor = System.Drawing.Color.Gray;
            this.ui_状态栏1.Location = new System.Drawing.Point(0, 570);
            this.ui_状态栏1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ui_状态栏1.MinimumSize = new System.Drawing.Size(1, 1);
            this.ui_状态栏1.Name = "ui_状态栏1";
            this.ui_状态栏1.RectColor = System.Drawing.Color.Gainsboro;
            this.ui_状态栏1.RectDisableColor = System.Drawing.Color.Gainsboro;
            this.ui_状态栏1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.ui_状态栏1.Size = new System.Drawing.Size(900, 30);
            this.ui_状态栏1.Style = Sunny.UI.UIStyle.Custom;
            this.ui_状态栏1.StyleCustomMode = true;
            this.ui_状态栏1.TabIndex = 6;
            this.ui_状态栏1.Text = "状态栏";
            // 
            // ui_功能栏1
            // 
            this.ui_功能栏1.BackColor = System.Drawing.Color.WhiteSmoke;
            viewModel_功能栏1.ShowTitle = "AutoControl";
            viewModel_功能栏1.Title = "AutoControl";
            viewModel_功能栏1.商标1_width = 0;
            viewModel_功能栏1.商标2_width = 0;
            viewModel_功能栏1.时间 = "00:00";
            viewModel_功能栏1.运行时间 = "0000.00.00\r\n00.00.00.00";
            this.ui_功能栏1.DataContext = viewModel_功能栏1;
            this.ui_功能栏1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ui_功能栏1.Font = new System.Drawing.Font("微软雅黑", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ui_功能栏1.Location = new System.Drawing.Point(0, 40);
            this.ui_功能栏1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ui_功能栏1.Name = "ui_功能栏1";
            this.ui_功能栏1.Size = new System.Drawing.Size(900, 40);
            this.ui_功能栏1.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.tableLayoutPanel_工作区);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ui_功能栏1);
            this.Controls.Add(this.ui_状态栏1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MaximumSize = new System.Drawing.Size(2400, 1073);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.RectColor = System.Drawing.Color.Red;
            this.ShowDragStretch = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.StyleCustomMode = true;
            this.Text = "Loading";
            this.TitleColor = System.Drawing.Color.White;
            this.TitleForeColor = System.Drawing.Color.Black;
            this.TitleHeight = 40;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.操作按钮颜色 = System.Drawing.Color.Black;
            this.标题栏字体Font = new System.Drawing.Font("微软雅黑", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel_工作区.ResumeLayout(false);
            this.uiPanel_工作区中.ResumeLayout(false);
            this.uiPanel_工作区右.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private Sunny.UI.UIPanel uiPanel_工作区左;
        private Sunny.UI.UIPanel uiPanel_工作区中;
        public Sunny.ui_状态栏 ui_状态栏1;
        public Sunny.ui_功能栏 ui_功能栏1;
        public System.Windows.Forms.ToolStripMenuItem 注册ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户登陆ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 用户ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private Sunny.UI.UIPanel uiPanel_Log;
        internal System.Windows.Forms.ToolStripMenuItem 语言ToolStripMenuItem;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel_工作区;
        private System.Windows.Forms.ToolStripMenuItem iO查看ToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem 控制器toolStripMenuItem1;
        private Sunny.UI.UIPanel uiPanel_工作区右;
        public Sunny.UI.UIPanel uiPanel_激光图像;
        public System.Windows.Forms.ToolStripMenuItem 激光ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ezCad2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 激光_打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 激光_调试ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 激光_加工ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 激光_红光ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 激光_停止ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 激光_复位ToolStripMenuItem;
        public Sunny.UI.UIPanel uiPanel_加工显示条;
    }
}