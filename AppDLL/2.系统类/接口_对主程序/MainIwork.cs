using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDLL
{
    public class MainIwork
    {
        /// <summary>
        /// 对外接口
        /// </summary>
        public MainIwork()
        {
            try
            {
                new QF_MainClass_26.GC_();
                new QF_MainClass_26.程序_捕获异常_Win().捕获异常();
                new QF_MainClass_26.软件类();

                new Languages(); 


                string[] Work = new string[]
               {
                  "程序是否已启动",
                  "自检",
                  "宣传页",
                  "用户登陆",
                  "进入主窗体",
               };




                foreach (var s in Work)
                {
                    if (s == "程序是否已启动")
                    {
                        #region 程序是否已启动

                        var rtMain = Form_Main_class._MainClass_sys.Err_程序已启动();
                        if (!rtMain.s)
                        {
                            MessageBox.Show(rtMain.msgErr, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        #endregion
                    }
                    else if (s == "自检")
                    {
                        #region 自检

                        var rt自检 = 开机自检.自检();
                        if (!rt自检.s)
                        {
                            MessageBox.Show(rt自检.msgErr, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        #endregion
                    }
                    else if (s == "宣传页")
                    {
                        #region 宣传页

                        Size_FormMain.读写参数(1, false);
                        Form_Main_class._MainClass_sys.启动宣传页(Size_FormMain._参数.Form宣传_使能);

                        #endregion
                    }
                    else if (s == "用户登陆")
                    {
                        #region 用户登陆
                        if (功能._功能Main.用户_使能)
                        {
                            new Login用户();
                            if (!Login用户.win_用户登陆())
                            {
                                //强制结束,
                                new QF_MainClass_26.进程().结束自身进程2();
                                return;
                            }

                        }

                        #endregion
                    }
                    else if (s == "进入主窗体")
                    {
                        #region 进入主窗体
                         
                        using (var forms = new Form_Main())
                        {
                            forms.ShowDialog();
                        }

                        #endregion
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }












        }



    }
}
