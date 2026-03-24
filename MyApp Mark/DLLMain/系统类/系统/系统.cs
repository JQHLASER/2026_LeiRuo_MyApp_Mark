using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DLLMain
{
    internal class 系统
    {
      
        #region 系统线程 


        internal static 系统线程 _线程 = new 系统线程();
        internal static void 系统线程_()
        {
            _线程.Event_线程_100ms += 事件_系统线程.On_100ms;
            _线程.Event_线程_1s += 事件_系统线程.On_1s;
            new Thread(() => { _线程.初始化(); }) { IsBackground = true }.Start();

        }

        internal static void 释放()
        {
            _线程.Event_线程_100ms -= 事件_系统线程.On_100ms;
            _线程.Event_线程_1s -= 事件_系统线程.On_1s;
            _线程.释放();
        }


        #endregion
    }
}
