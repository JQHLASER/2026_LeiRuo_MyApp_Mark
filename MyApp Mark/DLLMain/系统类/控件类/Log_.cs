using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLMain
{
    internal class Log
    {
        static qfmain.log日志 log_sys;
        public Log()
        {
            qfmain.log日志._cfg_ cfg = new qfmain.log日志._cfg_();
            cfg.保存天数 = 31;
            cfg.使能_清除线程 = true;
            cfg.使能_保存 = true;
            cfg.文件标识 = "";         
            log_sys = new qfmain.log日志(cfg);
            log_sys.Event_添加日志 += On_Log_Add;
            isInistiall = true;
        }

        static bool isInistiall = false;
        internal static void Add(bool state, string LogValue, bool 显示到日志栏 = true)
        {
            if (!isInistiall)
            {
                return;
            }
            LogValue = 显示到日志栏 ? LogValue : $"{qfmain.log日志._不显示到日志栏}  {LogValue}";
            log_sys.Add(state, LogValue);
        }
        internal static void Add(string LogValue, bool 显示到日志栏 = true, bool state = true)
        {
            if (!isInistiall)
            {
                return;
            }
            LogValue = 显示到日志栏 ? LogValue : $"{qfmain.log日志._不显示到日志栏}  {LogValue}";
            log_sys.Add(state, LogValue);
        }






        /// <summary>
        /// 清除日志显示框
        /// </summary>
        /// <param name="state"></param>
        /// <param name="LogValue"></param>
        public static void Clear(bool state, string LogValue)
        {
            if (!isInistiall)
            {
                return;
            }
 FormMain.forms.ui_log.Clear();
        }

        internal static void 释放()
        {
            if (!isInistiall)
            {
                return;
            }
            log_sys.释放();
        }


        #region 事件响应

        void On_Log_Add(qfmain.log日志._logValue_ info)
        {
           
          FormMain.forms.ui_log.Add(info);  
        }

        #endregion


    }
}

