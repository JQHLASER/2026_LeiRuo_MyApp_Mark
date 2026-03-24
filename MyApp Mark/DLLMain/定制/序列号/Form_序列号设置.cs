using Newtonsoft.Json;
using qfmain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLLMain
{
    public partial class Form_序列号设置 : Sunny.UI.UIForm
    {

        public Form_序列号设置()
        {
            InitializeComponent();
    
            this.Text = 系统参数._参数.工单号;
            var rtSn =db_序列号 . Get_查询(系统参数._参数.工单号);
            this.uiTextBox1.Text = rtSn.Sn ;
            this.Shown += (s, e) =>
            {
                置焦点();
            };

            this.uiButton_确定.Click += (s, e) =>
            {
                string strSn = this.uiTextBox1.Text.Trim();
                if (MessageBox.Show($"是否确认保存序列号?\r\n{strSn}", "", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                var rt = 序列号.设置序列号(strSn);
                if (!rt.s)
                {
                    MessageBox.Show(rt.m, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(rt.m); 

            };

        }

        private void UiButton_确定_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void 置焦点()
        {
            this.uiTextBox1.ImeMode = ImeMode.Disable;
            this.uiTextBox1.Focus();
        }




    }
}
