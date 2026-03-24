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
    public partial class Form_系统设置 : Sunny.UI.UIForm
    {
        public Form_系统设置()
        {
            InitializeComponent();


         

            this.uiButton_No.Click += (s, e) =>
            {
                this.Close();
            };
            this.uiButton_Yes.Click += (s, e) =>
            {
                
            };


 

        }
    }
}
