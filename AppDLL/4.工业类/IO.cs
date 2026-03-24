using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AppDLL
{
    internal class IO:Languages 
    {
        internal IO()
        {

            isInistiall = true;
        }
        static bool isInistiall = false;
        internal static void 释放()
        {
            if (!isInistiall)
            {
                return;
            }

        }


        internal static void Out_加工中(bool state)
        {
            LaserMark._Iwork.输出_标刻中(state);
        }

        internal static void Out_加工结束()
        {

            if (LaserMark.端口是否有效(LaserMark._参数.OUT.标刻完成))
            {
                Log.Add(true, $"{Get语言("IO输出")}...<{LaserMark._参数.OUT.标刻完成}>...<{LaserMark._参数.OUT.输出脉宽}>");
                LaserMark._Iwork.输出_标刻完成();
            }

        }

        /// <summary>
        /// 脉冲式
        /// </summary>
        internal static void Out_报警()
        {
            if (功能._功能Main .使能_报警持续输出IO)
            {
                if (LaserMark.端口是否有效(LaserMark._参数.OUT.报警))
                {
                    Log.Add(true, $"{Get语言("IO输出")}...<{LaserMark._参数.OUT.报警}>");
                    LaserMark._Iwork.输出_报警(true);
                }
            }
            else
            {
                if (LaserMark.端口是否有效(LaserMark._参数.OUT.报警))
                {
                    Log.Add(true, $"{Get语言("IO报警输出")}...<{LaserMark._参数.OUT.报警}>...<{LaserMark._参数.OUT.输出脉宽}>");
                    LaserMark._Iwork.输出_报警();
                }
            }
        }

        internal static void Out_报警(bool state)
        {
            LaserMark._Iwork.输出_报警(state);
        }

        internal static void Out_Ready(bool state)
        {
            LaserMark._Iwork.输出_Ready(state);
        }


        static QF_WinForm_26._cfg_标题栏状态_[] info_IO报警输出 = new QF_WinForm_26._cfg_标题栏状态_[]
        {
               new QF_WinForm_26._cfg_标题栏状态_("IO报警输出","",0),
               new QF_WinForm_26._cfg_标题栏状态_ ("IO报警输出",Languages  .Get语言 ("IO报警输出"),-1),
        };
        internal static void 标题栏状态_报警(bool state)
        {
            int a = state ? -1 : 0;
            窗体标题栏.Add(info_IO报警输出, a);
        }



    }
}
