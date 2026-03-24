namespace DLLMain
{
    partial class Form_扫码
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_扫码));
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiButton_复位序列号 = new Sunny.UI.UIButton();
            this.uiButton_设置序列号 = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.FillColor = System.Drawing.Color.White;
            this.uiTextBox1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTextBox1.Location = new System.Drawing.Point(22, 64);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.uiTextBox1.Maximum = 2147483647D;
            this.uiTextBox1.Minimum = -2147483648D;
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.uiTextBox1.Size = new System.Drawing.Size(400, 26);
            this.uiTextBox1.Style = Sunny.UI.UIStyle.深色;
            this.uiTextBox1.TabIndex = 1;
            this.uiTextBox1.textAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uiTextBox1.填充颜色 = System.Drawing.Color.White;
            // 
            // uiButton_复位序列号
            // 
            this.uiButton_复位序列号.Cursor = System.Windows.Forms.Cursors.Default;
            this.uiButton_复位序列号.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.uiButton_复位序列号.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiButton_复位序列号.Location = new System.Drawing.Point(48, 111);
            this.uiButton_复位序列号.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_复位序列号.Name = "uiButton_复位序列号";
            this.uiButton_复位序列号.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.uiButton_复位序列号.Size = new System.Drawing.Size(150, 35);
            this.uiButton_复位序列号.Style = Sunny.UI.UIStyle.深色;
            this.uiButton_复位序列号.TabIndex = 2;
            this.uiButton_复位序列号.Text = "复位序列号";
            // 
            // uiButton_设置序列号
            // 
            this.uiButton_设置序列号.Cursor = System.Windows.Forms.Cursors.Default;
            this.uiButton_设置序列号.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.uiButton_设置序列号.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiButton_设置序列号.Location = new System.Drawing.Point(246, 111);
            this.uiButton_设置序列号.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_设置序列号.Name = "uiButton_设置序列号";
            this.uiButton_设置序列号.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.uiButton_设置序列号.Size = new System.Drawing.Size(150, 35);
            this.uiButton_设置序列号.Style = Sunny.UI.UIStyle.深色;
            this.uiButton_设置序列号.TabIndex = 3;
            this.uiButton_设置序列号.Text = "编辑序列号";
            // 
            // Form_扫码
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 166);
            this.Controls.Add(this.uiButton_设置序列号);
            this.Controls.Add(this.uiButton_复位序列号);
            this.Controls.Add(this.uiTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_扫码";
            this.ShowInTaskbar = false;
            this.Text = "扫码";
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UIButton uiButton_复位序列号;
        private Sunny.UI.UIButton uiButton_设置序列号;
    }
}