
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Navigation;

namespace DLLMain
{
    internal class 事件_主窗体
    {


        /// <summary>
        /// FormMain()
        /// </summary>
        internal static void 进入窗体前()
        {

            窗体标题栏状态.初始化();
            //new qfmain.软件类();
            //new Language_();
            new 功能();
            new Log();
            new 注册();
            new 生产计数();
            new 功能栏();
        }

        internal static void 进入窗体()
        {
            FormMain.forms.WindowState = FormWindowState.Maximized;
            FormMain.forms.ShowDragStretch = true;

            注册.dogEvent.监测狗是否被拔出来(FormMain.forms.Handle);//监测加密狗是否被拔出来

            窗体标题栏状态.标题栏状态_初始化中();//初始化时,标题栏红色显示
            系统.系统线程_();
            Size_FormMain.读写参数(1);//设置Main窗体的控件大小
            FormMain.forms.ShowWaitForm("Please Wait ...");//请稍候...提示窗体         
            Log.Add(Language_.Get语言("进入系统"));

            显示.加工状态(Color.Transparent, "");

            事件_用户.On_用户登陆();//用户登陆

          

            注册.注册_进入系统时();//系统注册

        }

        internal static void 退出窗体(FormClosingEventArgs e)
        {
            if (窗体标题栏状态._标题栏状态._当前系统状态 == qfNet.窗体_标题栏状态._状态_.黄色)
            {
                MessageBox.Show(Language_.Get语言("系统忙"), "", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }
            else if (MessageBox.Show(Language_.Get语言("是否关闭?"), "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            事件_注册.释放();
            生产计数.释放();
            注册.释放();
            系统.释放();
            窗体标题栏状态.释放();
            FormMain.forms.ui_功能栏1.释放();
            FormMain.forms.ui_状态栏1.释放();


            Log.Add(Language_.Get语言("关闭系统"));
            Thread.Sleep(200);
            new qfmain.进程().结束自身进程2();
        }

        /// <summary>
        /// 第一次显示窗体时
        /// </summary>
        internal static void Shown()
        {
            FormMain.forms.HideWaitForm();//请稍候...关闭提示窗体
            窗体标题栏状态.标题栏状态_初始化结束();







        }

        internal static void 快捷键(object s, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                软件信息.Show();
            }
            else if (e.KeyCode == Keys.F11 && new qfNet.软件类().Win_密码输入框(功能._密码.设置工作区尺寸) == DialogResult.Yes)
            {
                Size_FormMain.Win_设置();
            }
        }


    }
}
