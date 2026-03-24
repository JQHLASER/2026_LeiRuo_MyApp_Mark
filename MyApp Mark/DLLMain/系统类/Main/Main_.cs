using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace DLLMain
{
    public class Main_
    {
        /// <summary>
        /// 主窗体接口
        /// </summary>
        public Main_()
        {
            qfmain.程序_捕获异常_Win Errs_ = new qfmain.程序_捕获异常_Win();
            Errs_.捕获异常();
            new qfmain.软件类();

            new Language_();

            #region 检测


            bool rt = new qfmain.进程().程序是否已运行();
            if (rt)
            {
                MessageBox.Show(Language_.Get语言("程序已运行"), "", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else if (!启动时自检_.检测(out string msgErr))
            {
                MessageBox.Show(msgErr, Language_.Get语言("启动自检"), MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            #endregion


            new qfmain.GC_();
            FormMain forms = new FormMain();

            #region 宣传窗体

            if (功能._参数.Form宣传_使能)
            {
                using (Form_宣传 form = new Form_宣传())
                {
                    form.ShowDialog();
                }
            }

            #endregion



            #region 进入主窗体

            if (功能._参数.用户_使能)
            {
                #region 用户登陆

                if (Login_.用户登陆())
                {
                    forms.ShowDialog();
                }
                else
                {
                    //强制结束,
                    new qfmain.进程().结束自身进程2();
                }

                #endregion
            }
            else
            {
                forms.ShowDialog();
            }

            #endregion

        }



    }
}
