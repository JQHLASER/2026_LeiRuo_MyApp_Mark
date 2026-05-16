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
    public partial class Form_扫码 : Sunny.UI.UIForm
    {

        public Form_扫码()
        {
            InitializeComponent();
            this.Text = 系统参数._参数.工单号;


            this.Shown += (s, e) =>
            {
                置焦点();
            };

            this.uiTextBox1.KeyDown += async (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    string barcode = this.uiTextBox1.Text.Trim();
                    this.uiTextBox1.Clear();
                    if (string.IsNullOrEmpty(barcode))
                    {
                        MessageBox.Show("请扫码", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Log.Add($"扫码: {barcode}");
                    var rt = await http_.请求(barcode);
                    if (rt.s)
                    {
                        this.Text = 系统参数._参数.工单号;
                        系统参数._参数.MesValue = rt.cfg.result;
                        系统参数.读写(0); 
                        加工._加工.修改变量信息(序列号._序列号);
                        MessageBox.Show("成功");
                        return;
                    }
                    else
                    {
                        MessageBox.Show($"失败,\r\n{rt.m}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            };

            this.uiButton_设置序列号.Click += (s, e) =>
            {
                if (MessageBox.Show($"是否设置序列号?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                else if (new qfNet.软件类().Win_密码输入框("8888", "请输入密码", true) != DialogResult.Yes)
                {
                    return;
                }

                using (Form_序列号设置 forms = new Form_序列号设置())
                {
                    Log.Add("进入序列号设置窗体....");
                    forms.ShowDialog();
                    Log.Add("....关闭序列号设置窗体");
                }


            };

            this.uiButton_复位序列号.Click += (s, e) =>
            {
                if (MessageBox.Show($"是否复位序列号?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                else if (new qfNet.软件类().Win_密码输入框("8888", "请输入密码", true) != DialogResult.Yes)
                {
                    return;
                }
                var rt = 序列号.复位序列号();
                if (rt.s)
                {
                    var rtcsv = CSV.Save(序列号._序列号, "设置<非加工>,复位");
                    MessageBox.Show(rt.m);
                }
                else
                {
                    MessageBox.Show(rt.m, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
        }

        void 置焦点()
        {
            this.uiTextBox1.ImeMode = ImeMode.Disable;
            this.uiTextBox1.Focus();
        }


    }
}
