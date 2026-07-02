namespace AppDLL
{
    partial class Form_系统设置
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_系统设置));
            this.uiButton_Yes = new Sunny.UI.UIButton();
            this.uiButton_No = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // uiButton_Yes
            // 
            this.uiButton_Yes.Cursor = System.Windows.Forms.Cursors.Default;
            this.uiButton_Yes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.uiButton_Yes.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiButton_Yes.Location = new System.Drawing.Point(161, 526);
            this.uiButton_Yes.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_Yes.Name = "uiButton_Yes";
            this.uiButton_Yes.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(124)))));
            this.uiButton_Yes.Size = new System.Drawing.Size(167, 47);
            this.uiButton_Yes.Style = Sunny.UI.UIStyle.深色;
            this.uiButton_Yes.TabIndex = 0;
            this.uiButton_Yes.Text = "Yes";
            // 
            // uiButton_No
            // 
            this.uiButton_No.Cursor = System.Windows.Forms.Cursors.Default;
            this.uiButton_No.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiButton_No.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.uiButton_No.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.uiButton_No.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.uiButton_No.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiButton_No.Location = new System.Drawing.Point(480, 526);
            this.uiButton_No.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton_No.Name = "uiButton_No";
            this.uiButton_No.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiButton_No.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.uiButton_No.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.uiButton_No.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.uiButton_No.Size = new System.Drawing.Size(167, 47);
            this.uiButton_No.Style = Sunny.UI.UIStyle.Red;
            this.uiButton_No.StyleCustomMode = true;
            this.uiButton_No.TabIndex = 1;
            this.uiButton_No.Text = "No";
            // 
            // Form_系统设置
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.uiButton_No);
            this.Controls.Add(this.uiButton_Yes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_系统设置";
            this.ShowInTaskbar = false;
            this.Text = "系统设置";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton uiButton_Yes;
        private Sunny.UI.UIButton uiButton_No;
    }
}