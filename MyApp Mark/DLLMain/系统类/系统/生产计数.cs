using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLMain
{
    internal class 生产计数
    {
        /// <summary>
        /// 生产计数
        /// </summary>
        static qfNet.生产计数 JS_sys = new qfNet.生产计数("js");
        public 生产计数()
        {

            if (!功能._参数.生产计数_零件_使能
                && !功能._参数.生产计数_良品_使能
                && !功能._参数.生产计数_不良品_使能)
            {
                return;
            }


            JS_sys._使能_零件 = 功能._参数.生产计数_零件_使能;
            JS_sys._使能_良品计数 = 功能._参数.生产计数_良品_使能;
            JS_sys._使能_不良品计数 = 功能._参数.生产计数_不良品_使能;

            JS_sys.Event_状态栏信息 += On_状态栏;
            JS_sys.读写信息(1);

            IsInistiall = true;
        }

        static bool IsInistiall = false;
        internal static void 释放()
        {
            if (!IsInistiall)
            {
                return;
            }

            JS_sys.Event_状态栏信息 -= On_状态栏;
        }


        internal static void 计数递增_良品(int 递增量 = 1)
        {
            if (功能._参数.生产计数_良品_使能)
            {
                JS_sys.计数递增_良品(递增量);
            }

        }

        internal static void 计数递增_不良品(int 递增量 = 1)
        {
            if (功能._参数.生产计数_不良品_使能)
            {
                JS_sys.计数递增_不良品(递增量);
            }
        }

        internal static void 设置(int 零件, int 良品, int 不良品)
        {


            JS_sys.设置(零件, 良品, 不良品);
        }

        #region 事件响应

        static void On_状态栏(string 状态名称, string 状态信息)
        {
            状态栏.Add(状态名称, 状态信息);
        }

        #endregion

    }
}
