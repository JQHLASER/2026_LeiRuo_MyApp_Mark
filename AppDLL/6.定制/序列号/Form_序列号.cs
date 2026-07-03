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
    public partial class Form_序列号 : Sunny.UI.UIForm
    {
        public Form_序列号()
        {
            InitializeComponent();
            this.uiTextBox1.ImeMode = ImeMode.Disable;
            this.uiTextBox1.Focus();
        }
    }
}
