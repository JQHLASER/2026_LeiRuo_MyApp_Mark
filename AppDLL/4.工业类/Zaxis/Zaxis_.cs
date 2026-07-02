using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace AppDLL
{
    /// <summary>
    /// 正运动
    /// </summary>
    internal class Zaxis_
    {
        static string 控制器名称 = Languages.Get语言("控制器");
        static int IO_IN_组数 = 2;
        static int IO_OUT_组数 = 2;
        internal static QF_Iwork_26.Zaxis Zaxis_sys;






        internal Zaxis_()
        {



        }

        internal static void 初始化()
        {
            if (!功能._Zaxis使能)
            {
                return;
            }

            Zaxis_sys = new QF_Iwork_26.Zaxis(控制器名称, IO_IN_组数, IO_OUT_组数);

            Zaxis_sys.Event_连接状态 += (s) => On_连接状态(s);
            Zaxis_sys.Event_连接控制器 += () => On_连接控制器();
            Zaxis_sys.Event_关闭控制器 += () => On_关闭控制器();
            Zaxis_sys.Event_IO输入 += (s) => On_IO_输入(s);
            Zaxis_sys.Event_IO输出 += (s) => On_IO_输出(s);
            Zaxis_sys.Event_IO输入B += (s) => On_IO_输入(s);
            Zaxis_sys.Event_IO输出B += (s) => On_IO_输出(s);
            Zaxis_sys.Event_Log += (s, e) => On_Log(s, e);
            Zaxis_sys.Event_其它 += () => On_其它();

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

            Zaxis_sys.释放();
        }

        internal static void Win_IO查看()
        {
            if (!isInistiall)
            {
                return;
            }
            else if (!Zaxis_sys.Err_未连接(out string msgErr, false) || !Err_.系统报警(out msgErr, false) || !Zaxis_sys.Err_未连接(out msgErr))
            {
                MessageBox.Show(msgErr, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Zaxis_sys.窗体_查看IO();
        }

        internal static void 设置_IO输出(int Port, bool status)
        {
            Zaxis_sys.IO_设置输出口状态(Port, status);
        }

        internal static void 设置_IO输出_脉冲(int Port, uint 输出宽度)
        {
            Zaxis_sys.IO_设置输出口状态_脉冲(Port, 输出宽度);
        }




        #region 事件响应...控制器

        static void On_连接状态(QF_MainClass_26._连接状态_ state)
        {
            new QF_WinForm_26.窗体_标题栏状态_方法().设置标题栏状态(窗体标题栏._标题栏状态, 控制器名称, 控制器名称, state);
            switch (state)
            {
                case QF_MainClass_26._连接状态_.已连接:
                    Log.Add($"{控制器名称}{Languages.Get语言("已连接")}");
                    Zaxis_运动轴.初始化();
                    break;
                case QF_MainClass_26._连接状态_.功能码不匹配:
                    Log.Add(false, $"{控制器名称}{Languages.Get语言("硬件不匹配")}");
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

        #region 响应事件...IO

        static void On_IO_输入(byte[] state)
        {
            Event_输入Bytes?.Invoke(state);
        }
        static void On_IO_输出(byte[] state)
        {
            Event_输出bytes?.Invoke(state);
        }

        static void On_IO_输入(bool[] state)
        {
            Event_输入bools?.Invoke(state);
        }
        static void On_IO_输出(bool[] state)
        {
            Event_输出bools?.Invoke(state);
        }

        #endregion

        #region 响应事件...

        static void On_Log(bool state, string logvalue)
        {
            Log.Add(state, logvalue);
        }

        static void On_其它()
        {

        }

        #endregion


        #region 事件

        internal static event Action<bool[]> Event_输入bools;
        internal static event Action<bool[]> Event_输出bools;
        internal static event Action<byte[]> Event_输入Bytes;
        internal static event Action<byte[]> Event_输出bytes;



        #endregion


    }
}
