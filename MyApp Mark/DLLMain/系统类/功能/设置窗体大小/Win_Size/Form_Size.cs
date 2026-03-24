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
    public partial class Form_Size : Sunny.UI.UIForm
    {

        readonly viewModel_SizeFormMain _DataContext = new viewModel_SizeFormMain();

        public Form_Size()
        {
            InitializeComponent();
            this.DataContext = this._DataContext;
            this.uiTextBox_Main_Left.DataBindings.Add("IntValue", this._DataContext, nameof(this._DataContext.MainLeft), false, DataSourceUpdateMode.OnPropertyChanged);
            this.uiTextBox_Main_Right.DataBindings.Add("IntValue", this._DataContext, nameof(this._DataContext.MainRight), false, DataSourceUpdateMode.OnPropertyChanged);
            this.uiTextBox_Main_Log.DataBindings.Add("IntValue", this._DataContext, nameof(this._DataContext.MainLogHeight), false, DataSourceUpdateMode.OnPropertyChanged);
            this.uiTextBox_Laser_Height.DataBindings.Add("IntValue", this._DataContext, nameof(this._DataContext.LaserHeight), false, DataSourceUpdateMode.OnPropertyChanged);
            this.uiTextBox_logo1_width.DataBindings.Add("IntValue", this._DataContext, nameof(this._DataContext.logo1_Width), false, DataSourceUpdateMode.OnPropertyChanged);

            this.uiTextBox_logo2_width.DataBindings.Add("IntValue", this._DataContext, nameof(this._DataContext.logo2_Width), false, DataSourceUpdateMode.OnPropertyChanged);

            this.uiTextBox_加工条显示高度.DataBindings.Add("IntValue", this._DataContext, nameof(this._DataContext.加工显示条高度), false, DataSourceUpdateMode.OnPropertyChanged);


            this.uiButton_No.Click += (s, e) => No();
            this.uiButton_Yes.Click += (s, e) => Yes();
        }

        private void Form_Size_Load(object sender, EventArgs e)
        {

        }

        #region 方法

        void Yes()
        {
            Size_FormMain._参数.工作区_左 = this._DataContext.MainLeft;
            Size_FormMain._参数.工作区_右 = this._DataContext.MainRight;
            Size_FormMain._参数.日志高度 = this._DataContext.MainLogHeight;
            Size_FormMain._参数.激光图像高度 = this._DataContext.LaserHeight;
            Size_FormMain._参数.商标1_width = this._DataContext.logo1_Width;
            Size_FormMain._参数.商标2_width = this._DataContext.logo2_Width;
            Size_FormMain._参数.加工显示条高度 = this._DataContext.加工显示条高度;


            Size_FormMain.读写参数(0);
            MessageBox.Show("OK");

        }


        void No()
        {
            this.Close();
        }


        #endregion





    }
}
