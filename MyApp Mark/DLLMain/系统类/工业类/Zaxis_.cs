using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace DLLMain
{
    /// <summary>
    /// 正运动
    /// </summary>
    internal class Zaxis_
    {
        static string 控制器名称 = Language_.Get语言("控制器");
        static int IO_IN_组数 = 2;
        static int IO_OUT_组数 = 2;
        internal static qfNet.Zaxis Zaxis_sys;
        static qfNet._cfg_标题栏状态_[] _标题栏状态信息 = new qfNet._cfg_标题栏状态_[0];



        public Zaxis_()
        {
            if (!功能._参数.Zaxis_使能)
            {
                return;
            }
            Zaxis_sys = new qfNet.Zaxis(控制器名称, IO_IN_组数, IO_OUT_组数);

            Zaxis_sys.Event_连接状态 += On_连接状态;
            Zaxis_sys.Event_连接控制器 += On_连接控制器;
            Zaxis_sys.Event_关闭控制器 += On_关闭控制器;
            Zaxis_sys.Event_IO输入 += On_IO_输入;
            Zaxis_sys.Event_IO输出 += On_IO_输出;
            Zaxis_sys.Event_IO输入B += On_IO_输入;
            Zaxis_sys.Event_IO输出B += On_IO_输出;
            Zaxis_sys.Event_Log += On_Log;
            Zaxis_sys.Event_其它 += On_其它;

            Zaxis_sys.标题栏状态_生成状态参数(out _标题栏状态信息, 控制器名称);

            Zaxis_sys.初始化();
            isInistiall = true;
        }



        /// <summary>
        /// 是否初始化
        /// </summary>
        static bool isInistiall = false;
        internal static void 释放()
        {
            if (!isInistiall)
            {
                return;
            }

            Zaxis_sys.Event_连接状态 -= On_连接状态;
            Zaxis_sys.Event_连接控制器 -= On_连接控制器;
            Zaxis_sys.Event_关闭控制器 -= On_关闭控制器;
            Zaxis_sys.Event_IO输入 -= On_IO_输入;
            Zaxis_sys.Event_IO输出 -= On_IO_输出;
            Zaxis_sys.Event_IO输入B -= On_IO_输入;
            Zaxis_sys.Event_IO输出B -= On_IO_输出;
            Zaxis_sys.Event_Log -= On_Log;
            Zaxis_sys.Event_其它 -= On_其它;

            Zaxis_sys.释放();
        }

        internal static void 窗体_IO查看()
        {
            if (!Zaxis_sys.Err_未连接(out string msgErr, false) || !Err.系统报警(out msgErr, false) || !Zaxis_sys.Err_未连接(out msgErr))
            {
                MessageBox.Show(msgErr, "", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Zaxis_sys.窗体_查看IO();
        }

        #region 事件响应


        #region 控制器

        static void On_连接状态(qfmain._连接状态_ state)
        {
            窗体标题栏状态.Add(_标题栏状态信息, (int)state);
            switch (state)
            {
                case qfmain ._连接状态_.已连接 :
                   Log.Add( $"{控制器名称}{Language_.Get语言("已连接")}");
                    break;
                case qfmain ._连接状态_.功能码不匹配:
                   Log.Add(false, $"{控制器名称}{Language_.Get语言("硬件不匹配")}");
                    break;
            }
        }


        static void On_连接控制器()
        {

        }
        static void On_关闭控制器()
        {

        }

        #endregion


        #region IO

        static void On_IO_输入(byte[] state)
        {

        }
        static void On_IO_输出(byte[] state)
        {

        }

        static void On_IO_输入(bool[] state)
        {

        }
        static void On_IO_输出(bool[] state)
        {

        }

        #endregion


        static void On_Log(bool state, string logvalue)
        {
           Log.Add(state, logvalue);
        }


        static void On_其它()
        {

        }




        #endregion


        #region 方法

        #endregion


    }
}
