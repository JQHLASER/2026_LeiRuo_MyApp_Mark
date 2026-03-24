using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace DLLMain
{
    internal class ViewMovel_FormMain : qfNet.ViewModelBase
    {


        private int _logHeight = Size_FormMain._参数.日志高度;
        /// <summary>
        /// 日志栏高度
        /// </summary>
        public int LogHeight
        {
            get => this._logHeight;
            set
            {
                SetProperty(ref this._logHeight, value);
                OnPropertyChanged(); // 通知视图属性已更新
            }
        }

              

        private Color _工作区边框颜色 = 功能.工作区_边框颜色;
        public Color 工作区边框颜色
        {
            get => _工作区边框颜色;
            set
            {
                _工作区边框颜色 = value;
                OnPropertyChanged();
            }
        }

        private Color _标题栏颜色 = Color.WhiteSmoke;// Color.FromArgb(2, 56, 110);
        public Color 标题栏颜色
        {
            get => _标题栏颜色;
            set
            {
                _标题栏颜色 = value;
                OnPropertyChanged();
            }
        }

        private string _标题栏内容 = "";
        public string 标题栏内容
        {
            get => _标题栏内容;
            set
            {
                _标题栏内容 = value;
                OnPropertyChanged();
            }
        }

        private Color _标题栏文本颜色 = Color.Black;
        public Color 标题栏文本颜色
        {
            get => _标题栏文本颜色;
            set
            {
                _标题栏文本颜色 = value;
                OnPropertyChanged();
            }
        }

        private FormWindowState _FormMainState = FormWindowState.Maximized;//最大化
        public FormWindowState FormMainState
        {
            get => this._FormMainState;
            set
            {
                _FormMainState = value;
                OnPropertyChanged();
            }
        }




        // 命令：按钮点击事件（简化版，实际可使用 ICommand 接口）
        internal void SaveUser()
        {
            MessageBox.Show("滚");



        }








    }
}
