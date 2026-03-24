using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DLLMain
{
    internal class 事件_注册
    {
        internal static bool _注册状态 = false;



        internal static void On_软件注册结果(qfmain._软件授权_Err_ Err)
        {

            //开始注册
            if (Err == qfmain._软件授权_Err_.开始注册)
            {
                //窗体标题栏状态.标题栏状态_初始化中();


                return;
            }
            //已注册
            else if (Err == qfmain._软件授权_Err_.已完全注册 || Err == qfmain._软件授权_Err_.已日期注册)
            {
                _注册状态 = true;
                注册.软件注册_sys.标题栏状态(窗体标题栏状态._标题栏状态);
                //窗体标题栏状态.标题栏状态_初始化结束();
                new LaserMark();
                new Zaxis_();



                //Task.Run(() =>
                //{




                //});
                 

              

            }
            //未注册
            else
            {
                _注册状态 = false;
                //窗体标题栏状态.标题栏状态_初始化结束();
                FormMain.forms.Invoke((Action)(() =>
                {
                    FormMain.forms.激光ToolStripMenuItem.Enabled = false;
                    FormMain.forms.控制器toolStripMenuItem1.Enabled = false;



                }));


            }


        }


        internal static void 释放()
        {
            LaserMark.释放();
            Zaxis_.释放();

        }





    }
}
