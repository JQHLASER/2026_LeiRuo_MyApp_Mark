namespace DLLMain
{
    partial class Form_序列号设置
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_序列号设置));
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiButton_确定 = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.FillColor = System.Drawing.Color.White;
            this.uiTextBox1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiTextBox1.Location = new System.Drawing.Point(79, 93);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.uiTextBox1.Maximum = 2147483647D;
            this.uiTextBox1.Minimum = -2147483648D;
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.uiTextBox1.Size = new System.Drawing.Size(185, 26);
            this.uiTextBox1.Style = Sunny.UI.UIStyle.深色;
            this.uiTextBox1.TabIndex = 1;
            this.uiTextBox1.textAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uiTextBox1.填充颜色 = System.Drawing.Color.White;
            // 
            // uiButton_确定
            // 
            this.uiButton_确定.Cursor = System.Windows.Forms.Cursors.Default;
            this.uiButton_确定.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.uiButton_确定.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiButton_确定.Location = new System.Drawing.Point(90, 164);
            this.uiButton_确定.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_确定.Name = "uiButton_确定";
            this.uiButton_确定.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.uiButton_确定.Size = new System.Drawing.Size(167, 38);
            this.uiButton_确定.Style = Sunny.UI.UIStyle.深色;
            this.uiButton_确定.TabIndex = 2;
            this.uiButton_确定.Text = "确定";
            // 
            // Form_序列号设置
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 238);
            this.Controls.Add(this.uiButton_确定);
            this.Controls.Add(this.uiTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_序列号设置";
            this.ShowInTaskbar = false;
            this.Text = "序列号";
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UIButton uiButton_确定;
    }
}