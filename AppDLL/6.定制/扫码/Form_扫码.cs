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
    public partial class Form_扫码 : Sunny.UI.UIForm
    {
        public Form_扫码()
        {
            InitializeComponent();
            this.Shown += (s, e) =>
            {
                this.uiTextBox1.ImeMode = ImeMode.Disable;
                this.uiTextBox1.Focus();
            };
        }
    }
}
