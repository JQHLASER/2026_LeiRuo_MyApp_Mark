using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLMain
{
    internal class viewModel_SizeFormMain : qfNet.ViewModelBase
    {
        private int _MainLeft = Size_FormMain._参数.工作区_左;
        public int MainLeft
        {
            get => _MainLeft;
            set
            {
                _MainLeft = value;
                OnPropertyChanged();
            }
        }

        private int _MainRight = Size_FormMain._参数.工作区_右;
        public int MainRight
        {
            get => _MainRight;
            set
            {
                _MainRight = value;
                OnPropertyChanged();
            }
        }

        private int _MainLogHeight = Size_FormMain._参数.日志高度;
        public int MainLogHeight
        {
            get => _MainLogHeight;
            set
            {
                _MainLogHeight = value;
                OnPropertyChanged();
            }
        }

        private int _LaserHeight = Size_FormMain._参数.激光图像高度;
        public int LaserHeight
        {
            get => _LaserHeight;
            set
            {
                _LaserHeight = value;
                OnPropertyChanged();
            }
        }


        private int _logo1Width = Size_FormMain._参数.商标1_width ;
        public int logo1_Width
        {
            get => _logo1Width;
            set
            {
                _logo1Width = value;
                OnPropertyChanged();
            }
        }

        private int _logo2Width = Size_FormMain._参数.商标2_width;
        public int logo2_Width
        {
            get => _logo2Width;
            set
            {
                _logo2Width = value;
                OnPropertyChanged();
            }
        }

        private int _加工显示条高度 = Size_FormMain._参数.加工显示条高度 ;
        public int 加工显示条高度
        {
            get => _加工显示条高度;
            set
            {
                _加工显示条高度 = value;
                OnPropertyChanged();
            }
        }



    }
}
