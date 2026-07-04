
using QF_WinForm_26;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDLL
{
    internal class Event_软件注册结果
    {
        public enum _em_注册状态_
        {
            已注册 = 0,
            注册中 = 1,
            未注册 = -1,
        }




        internal static _em_注册状态_ _注册结果 = _em_注册状态_.未注册;

        internal static async void On_软件注册结果(QF_MainClass_26._软件授权_Err_ Err, string msgErr)
        {
            //开始注册
            if (Err == QF_MainClass_26._软件授权_Err_.开始注册)
            {
                _注册结果 = _em_注册状态_.注册中;
                窗体标题栏.标题栏状态_初始化结束();
                Event_注册结果?.Invoke(_注册结果);

                Form_Main.forms.Invoke((Action)(() =>
                {
                    //请稍候...关闭提示窗体
                    Form_Main.forms.HideWaitForm();
                }));

                return;
            }
            //已注册
            else if (Err == QF_MainClass_26._软件授权_Err_.已完全注册 || Err == QF_MainClass_26._软件授权_Err_.已日期注册)
            {
                _注册结果 = _em_注册状态_.已注册;
                Event_注册结果?.Invoke(_注册结果);

                LaserMark.初始化();
                Zaxis_.初始化();


                //Task.Run(() =>
                //{




                //});

                db_序列号.初始化();
                QF_SqlSugar_26.SqlSugar_DB_封装.初始化(1000 * 10);

            }
            //未注册
            else
            {
                _注册结果 = _em_注册状态_.未注册;
                Event_注册结果?.Invoke(_注册结果);

                Form_Main.forms.Invoke((Action)(() =>
                 {

                     Form_Main.forms.panel_操作按钮.Enabled = false;


                 }));


            }


        }


        internal static void 释放()
        {
            LaserMark.释放();
            Zaxis_.释放();
        }

        internal static event Action<_em_注册状态_> Event_注册结果;
    }

}
