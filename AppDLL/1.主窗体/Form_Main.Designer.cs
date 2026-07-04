namespace AppDLL
{
    partial class Form_Main
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
            Sunny.viewModel_功能栏 viewModel_功能栏1 = new Sunny.viewModel_功能栏();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.ui_功能栏1 = new Sunny.ui_功能栏();
            this.menuStrip_菜单 = new System.Windows.Forms.MenuStrip();
            this.ui_状态栏1 = new Sunny.ui_状态栏();
            this.tableLayoutPanel_工作区 = new System.Windows.Forms.TableLayoutPanel();
            this.uiPanel_工作区左 = new Sunny.UI.UIPanel();
            this.uiPanel_工作区中 = new Sunny.UI.UIPanel();
            this.uiPanel_激光图像 = new Sunny.UI.UIPanel();
            this.uiPanel_Log日志 = new Sunny.UI.UIPanel();
            this.uiPanel_工作区右 = new Sunny.UI.UIPanel();
            this.uiLabel_加工信息 = new Sunny.UI.UILabel();
            this.panel_操作按钮 = new System.Windows.Forms.Panel();
            this.ui_Button2_激光模板 = new Sunny.ui_Button2();
            this.ui_Button2_扫码 = new Sunny.ui_Button2();
            this.uiPanel_加工显示条 = new Sunny.UI.UIPanel();
            this.tableLayoutPanel_工作区.SuspendLayout();
            this.uiPanel_工作区中.SuspendLayout();
            this.uiPanel_工作区右.SuspendLayout();
            this.panel_操作按钮.SuspendLayout();
            this.SuspendLayout();
            // 
            // ui_功能栏1
            // 
            this.ui_功能栏1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(100)))));
            viewModel_功能栏1.ShowTitle = "AutoControl";
            viewModel_功能栏1.Title = "AutoControl";
            viewModel_功能栏1.商标1_width = 0;
            viewModel_功能栏1.商标2_width = 0;
            viewModel_功能栏1.时间 = "00:00";
            viewModel_功能栏1.运行时间 = "0000.00.00\r\n00.00.00.00";
            this.ui_功能栏1.DataContext = viewModel_功能栏1;
            this.ui_功能栏1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ui_功能栏1.Font = new System.Drawing.Font("微软雅黑", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ui_功能栏1.Location = new System.Drawing.Point(0, 35);
            this.ui_功能栏1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ui_功能栏1.Name = "ui_功能栏1";
            this.ui_功能栏1.Size = new System.Drawing.Size(1000, 50);
            this.ui_功能栏1.TabIndex = 8;
            this.ui_功能栏1.Title = "AutoControl";
            // 
            // menuStrip_菜单
            // 
            this.menuStrip_菜单.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip_菜单.Font = new System.Drawing.Font("微软雅黑", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip_菜单.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip_菜单.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_菜单.Location = new System.Drawing.Point(0, 85);
            this.menuStrip_菜单.Name = "menuStrip_菜单";
            this.menuStrip_菜单.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip_菜单.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip_菜单.TabIndex = 9;
            this.menuStrip_菜单.Text = "menuStrip1";
            // 
            // ui_状态栏1
            // 
            this.ui_状态栏1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(100)))));
            this.ui_状态栏1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ui_状态栏1.Font = new System.Drawing.Font("微软雅黑", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ui_状态栏1.ForeColor = System.Drawing.Color.Gray;
            this.ui_状态栏1.Location = new System.Drawing.Point(0, 670);
            this.ui_状态栏1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ui_状态栏1.MinimumSize = new System.Drawing.Size(1, 1);
            this.ui_状态栏1.Name = "ui_状态栏1";
            this.ui_状态栏1.Size = new System.Drawing.Size(1000, 30);
            this.ui_状态栏1.TabIndex = 10;
            // 
            // tableLayoutPanel_工作区
            // 
            this.tableLayoutPanel_工作区.ColumnCount = 5;
            this.tableLayoutPanel_工作区.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel_工作区.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel_工作区.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_工作区.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel_工作区.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel_工作区.Controls.Add(this.uiPanel_工作区左, 1, 1);
            this.tableLayoutPanel_工作区.Controls.Add(this.uiPanel_工作区中, 2, 1);
            this.tableLayoutPanel_工作区.Controls.Add(this.uiPanel_工作区右, 3, 1);
            this.tableLayoutPanel_工作区.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_工作区.Location = new System.Drawing.Point(0, 109);
            this.tableLayoutPanel_工作区.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel_工作区.Name = "tableLayoutPanel_工作区";
            this.tableLayoutPanel_工作区.RowCount = 3;
            this.tableLayoutPanel_工作区.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel_工作区.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_工作区.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel_工作区.Size = new System.Drawing.Size(1000, 561);
            this.tableLayoutPanel_工作区.TabIndex = 11;
            // 
            // uiPanel_工作区左
            // 
            this.uiPanel_工作区左.BackColor = System.Drawing.Color.Transparent;
            this.uiPanel_工作区左.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel_工作区左.FillColor = System.Drawing.Color.WhiteSmoke;
            this.uiPanel_工作区左.FillDisableColor = System.Drawing.Color.Transparent;
            this.uiPanel_工作区左.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiPanel_工作区左.Location = new System.Drawing.Point(4, 4);
            this.uiPanel_工作区左.Margin = new System.Windows.Forms.Padding(2);
            this.uiPanel_工作区左.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel_工作区左.Name = "uiPanel_工作区左";
            this.uiPanel_工作区左.RectColor = System.Drawing.Color.Gainsboro;
            this.uiPanel_工作区左.Size = new System.Drawing.Size(96, 553);
            this.uiPanel_工作区左.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel_工作区左.StyleCustomMode = true;
            this.uiPanel_工作区左.TabIndex = 3;
            this.uiPanel_工作区左.Text = null;
            // 
            // uiPanel_工作区中
            // 
            this.uiPanel_工作区中.BackColor = System.Drawing.Color.Transparent;
            this.uiPanel_工作区中.Controls.Add(this.uiPanel_激光图像);
            this.uiPanel_工作区中.Controls.Add(this.uiPanel_Log日志);
            this.uiPanel_工作区中.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel_工作区中.FillColor = System.Drawing.Color.WhiteSmoke;
            this.uiPanel_工作区中.FillDisableColor = System.Drawing.Color.Transparent;
            this.uiPanel_工作区中.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiPanel_工作区中.Location = new System.Drawing.Point(104, 4);
            this.uiPanel_工作区中.Margin = new System.Windows.Forms.Padding(2);
            this.uiPanel_工作区中.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel_工作区中.Name = "uiPanel_工作区中";
            this.uiPanel_工作区中.RectColor = System.Drawing.Color.Gainsboro;
            this.uiPanel_工作区中.Size = new System.Drawing.Size(592, 553);
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
            this.uiPanel_激光图像.Padding = new System.Windows.Forms.Padding(2, 1, 1, 1);
            this.uiPanel_激光图像.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel_激光图像.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel_激光图像.Size = new System.Drawing.Size(592, 368);
            this.uiPanel_激光图像.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel_激光图像.StyleCustomMode = true;
            this.uiPanel_激光图像.TabIndex = 1;
            this.uiPanel_激光图像.Text = "打标卡未初始化";
            // 
            // uiPanel_Log日志
            // 
            this.uiPanel_Log日志.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPanel_Log日志.FillColor = System.Drawing.Color.White;
            this.uiPanel_Log日志.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiPanel_Log日志.Location = new System.Drawing.Point(0, 368);
            this.uiPanel_Log日志.Margin = new System.Windows.Forms.Padding(0);
            this.uiPanel_Log日志.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel_Log日志.Name = "uiPanel_Log日志";
            this.uiPanel_Log日志.Padding = new System.Windows.Forms.Padding(2);
            this.uiPanel_Log日志.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel_Log日志.RectColor = System.Drawing.Color.Gainsboro;
            this.uiPanel_Log日志.RectDisableColor = System.Drawing.Color.Gainsboro;
            this.uiPanel_Log日志.Size = new System.Drawing.Size(592, 185);
            this.uiPanel_Log日志.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel_Log日志.StyleCustomMode = true;
            this.uiPanel_Log日志.TabIndex = 3;
            this.uiPanel_Log日志.Text = "Log";
            // 
            // uiPanel_工作区右
            // 
            this.uiPanel_工作区右.BackColor = System.Drawing.Color.Transparent;
            this.uiPanel_工作区右.Controls.Add(this.uiLabel_加工信息);
            this.uiPanel_工作区右.Controls.Add(this.panel_操作按钮);
            this.uiPanel_工作区右.Controls.Add(this.uiPanel_加工显示条);
            this.uiPanel_工作区右.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel_工作区右.FillColor = System.Drawing.Color.WhiteSmoke;
            this.uiPanel_工作区右.FillDisableColor = System.Drawing.Color.Transparent;
            this.uiPanel_工作区右.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiPanel_工作区右.Location = new System.Drawing.Point(700, 4);
            this.uiPanel_工作区右.Margin = new System.Windows.Forms.Padding(2);
            this.uiPanel_工作区右.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel_工作区右.Name = "uiPanel_工作区右";
            this.uiPanel_工作区右.RectColor = System.Drawing.Color.Gainsboro;
            this.uiPanel_工作区右.Size = new System.Drawing.Size(296, 553);
            this.uiPanel_工作区右.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel_工作区右.StyleCustomMode = true;
            this.uiPanel_工作区右.TabIndex = 2;
            this.uiPanel_工作区右.Text = null;
            // 
            // uiLabel_加工信息
            // 
            this.uiLabel_加工信息.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel_加工信息.Font = new System.Drawing.Font("Cascadia Code", 11.26957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel_加工信息.Location = new System.Drawing.Point(0, 76);
            this.uiLabel_加工信息.Name = "uiLabel_加工信息";
            this.uiLabel_加工信息.Size = new System.Drawing.Size(296, 437);
            this.uiLabel_加工信息.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel_加工信息.TabIndex = 3;
            this.uiLabel_加工信息.Text = "uiLabel1";
            // 
            // panel_操作按钮
            // 
            this.panel_操作按钮.Controls.Add(this.ui_Button2_激光模板);
            this.panel_操作按钮.Controls.Add(this.ui_Button2_扫码);
            this.panel_操作按钮.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_操作按钮.Location = new System.Drawing.Point(0, 0);
            this.panel_操作按钮.Name = "panel_操作按钮";
            this.panel_操作按钮.Padding = new System.Windows.Forms.Padding(5);
            this.panel_操作按钮.Size = new System.Drawing.Size(296, 76);
            this.panel_操作按钮.TabIndex = 2;
            // 
            // ui_Button2_激光模板
            // 
            this.ui_Button2_激光模板.BackColor = System.Drawing.Color.Transparent;
            this.ui_Button2_激光模板.Dock = System.Windows.Forms.DockStyle.Left;
            this.ui_Button2_激光模板.Location = new System.Drawing.Point(113, 5);
            this.ui_Button2_激光模板.Name = "ui_Button2_激光模板";
            this.ui_Button2_激光模板.Padding = new System.Windows.Forms.Padding(5);
            this.ui_Button2_激光模板.Radius_圆角 = 5;
            this.ui_Button2_激光模板.Size = new System.Drawing.Size(108, 66);
            this.ui_Button2_激光模板.TabIndex = 1;
            this.ui_Button2_激光模板.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.ui_Button2_激光模板.Text文本 = "激光模板";
            this.ui_Button2_激光模板.文本颜色 = System.Drawing.Color.White;
            this.ui_Button2_激光模板.背景颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.ui_Button2_激光模板.背景颜色_鼠标按下 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.ui_Button2_激光模板.背景颜色_鼠标移上 = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.ui_Button2_激光模板.背景颜色_鼠标选中 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.ui_Button2_激光模板.边框颜色 = System.Drawing.Color.Silver;
            this.ui_Button2_激光模板.边框颜色_鼠标按下 = System.Drawing.Color.Silver;
            this.ui_Button2_激光模板.边框颜色_鼠标移上 = System.Drawing.Color.Silver;
            this.ui_Button2_激光模板.边框颜色_鼠标选中 = System.Drawing.Color.Silver;
            // 
            // ui_Button2_扫码
            // 
            this.ui_Button2_扫码.BackColor = System.Drawing.Color.Transparent;
            this.ui_Button2_扫码.Dock = System.Windows.Forms.DockStyle.Left;
            this.ui_Button2_扫码.Location = new System.Drawing.Point(5, 5);
            this.ui_Button2_扫码.Name = "ui_Button2_扫码";
            this.ui_Button2_扫码.Padding = new System.Windows.Forms.Padding(5);
            this.ui_Button2_扫码.Radius_圆角 = 5;
            this.ui_Button2_扫码.Size = new System.Drawing.Size(108, 66);
            this.ui_Button2_扫码.TabIndex = 0;
            this.ui_Button2_扫码.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.ui_Button2_扫码.Text文本 = "扫码";
            this.ui_Button2_扫码.文本颜色 = System.Drawing.Color.White;
            this.ui_Button2_扫码.背景颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.ui_Button2_扫码.背景颜色_鼠标按下 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.ui_Button2_扫码.背景颜色_鼠标移上 = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.ui_Button2_扫码.背景颜色_鼠标选中 = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.ui_Button2_扫码.边框颜色 = System.Drawing.Color.Silver;
            this.ui_Button2_扫码.边框颜色_鼠标按下 = System.Drawing.Color.Silver;
            this.ui_Button2_扫码.边框颜色_鼠标移上 = System.Drawing.Color.Silver;
            this.ui_Button2_扫码.边框颜色_鼠标选中 = System.Drawing.Color.Silver;
            // 
            // uiPanel_加工显示条
            // 
            this.uiPanel_加工显示条.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPanel_加工显示条.Font = new System.Drawing.Font("微软雅黑", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel_加工显示条.Location = new System.Drawing.Point(0, 513);
            this.uiPanel_加工显示条.Margin = new System.Windows.Forms.Padding(0);
            this.uiPanel_加工显示条.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel_加工显示条.Name = "uiPanel_加工显示条";
            this.uiPanel_加工显示条.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel_加工显示条.Size = new System.Drawing.Size(296, 40);
            this.uiPanel_加工显示条.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel_加工显示条.TabIndex = 1;
            this.uiPanel_加工显示条.Text = "加工状态";
            // 
            // Form_Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.tableLayoutPanel_工作区);
            this.Controls.Add(this.ui_状态栏1);
            this.Controls.Add(this.menuStrip_菜单);
            this.Controls.Add(this.ui_功能栏1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(999999, 999999);
            this.Name = "Form_Main";
            this.RectColor = System.Drawing.Color.Red;
            this.ShowDragStretch = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.StyleCustomMode = true;
            this.Text = "Loading";
            this.TitleColor = System.Drawing.Color.WhiteSmoke;
            this.TitleForeColor = System.Drawing.Color.Black;
            this.标题栏字体Font = new System.Drawing.Font("微软雅黑", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel_工作区.ResumeLayout(false);
            this.uiPanel_工作区中.ResumeLayout(false);
            this.uiPanel_工作区右.ResumeLayout(false);
            this.panel_操作按钮.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Sunny.ui_功能栏 ui_功能栏1;
        public Sunny.ui_状态栏 ui_状态栏1;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel_工作区;
        private Sunny.UI.UIPanel uiPanel_工作区左;
        private Sunny.UI.UIPanel uiPanel_工作区中;
        private Sunny.UI.UIPanel uiPanel_工作区右;
        public Sunny.UI.UIPanel uiPanel_加工显示条;
        internal System.Windows.Forms.MenuStrip menuStrip_菜单;
        internal Sunny.UI.UIPanel uiPanel_Log日志;
        public Sunny.UI.UIPanel uiPanel_激光图像;
        private Sunny.ui_Button2 ui_Button2_激光模板;
        private Sunny.ui_Button2 ui_Button2_扫码;
        internal Sunny.UI.UILabel uiLabel_加工信息;
        internal System.Windows.Forms.Panel panel_操作按钮;
    }
}