using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLLMain
{
    public partial class Form_宣传 : Sunny.UI.UIForm
    {

        //双缓冲显示窗体所有子控件
        protected override CreateParams CreateParams { get { CreateParams cp = base.CreateParams; cp.ExStyle |= 0x02000000; return cp; } }
        public Form_宣传()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.PrimaryScreen.WorkingArea; //显示任务栏(在进入窗体前使用)
             
            this.Load += (s, e) => Load_(); 
            new qfmain.Image_().读取图片文件(qfmain.软件类.Files_Cfg.Files_res + "\\logo11.png", out Image r1, out string msgErr);
            this.panel_公司介绍图片.BackgroundImage = r1;
        }


        async void Load_()
        {
            new qfNet.winForm窗体().居中(this, this.uiPanel1, FormWindowState.Maximized);

            await Task.Run(() =>
            {
                for (global::System.Int32 i = 3; i > 0; i--)
                {
                    this.Invoke((Action)(() => { this.uiPanel1.Text = $"Loading...{i}"; }));
                    Thread.Sleep(1000);
                }
              
            });
            this.Close();
        }


    }
}
