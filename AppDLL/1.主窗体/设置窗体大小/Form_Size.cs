using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDLL
{
    public partial class Form_Size : Sunny.UI.UIForm
    {


        public Form_Size()
        {
            InitializeComponent();
 
            this.uiButton_No.Click += (s, e) => No();
            this.uiButton_Yes.Click += (s, e) => Yes();

            shoCfg();
        }

        private void Form_Size_Load(object sender, EventArgs e)
        {

        }

        #region 方法

        void shoCfg()
        {
            this.uiTextBox_Main_Left.IntValue = Size_FormMain._参数.工作区_左;
            this.uiTextBox_Main_Right.IntValue = Size_FormMain._参数.工作区_右;
            this.uiTextBox_Main_Log.IntValue = Size_FormMain._参数.日志高度;
            this.uiTextBox_logo1_width.IntValue = Size_FormMain._参数.商标1_width;
            this.uiTextBox_logo2_width.IntValue = Size_FormMain._参数.商标2_width;
            this.uiTextBox_加工条显示高度.IntValue = Size_FormMain._参数.加工显示条高度;
            this.uiCheckBox_启动时显示宣传页.Checked = Size_FormMain._参数.Form宣传_使能;
            this.uiTextBox_Laser_Height.IntValue = Size_FormMain._参数.激光图像高度;
        }


        void Yes()
        {
            Size_FormMain._参数.工作区_左 = this.uiTextBox_Main_Left.IntValue;
            Size_FormMain._参数.工作区_右 = this.uiTextBox_Main_Right.IntValue;
            Size_FormMain._参数.日志高度 = this.uiTextBox_Main_Log.IntValue;
            Size_FormMain._参数.商标1_width = this.uiTextBox_logo1_width.IntValue;
            Size_FormMain._参数.商标2_width = this.uiTextBox_logo2_width.IntValue;
            Size_FormMain._参数.加工显示条高度 = this.uiTextBox_加工条显示高度.IntValue;
            Size_FormMain._参数.Form宣传_使能 = this.uiCheckBox_启动时显示宣传页.Checked;

            Size_FormMain._参数.激光图像高度 = this.uiTextBox_Laser_Height.IntValue;


            Size_FormMain.读写参数(0);
            shoCfg();
            MessageBox.Show("OK");

        }


        void No()
        {
            this.Close();
        }


        #endregion





    }
}
