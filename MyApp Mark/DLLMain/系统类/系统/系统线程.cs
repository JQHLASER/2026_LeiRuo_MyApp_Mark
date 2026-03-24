using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DLLMain
{
    internal class 系统线程
    {


        internal void 初始化()
        {
            int a = 0;
          
            while (isRun)
            {
                Thread.Sleep(100);
                if (!isRun)
                {
                    break;
                }
                Event_线程_100ms?.Invoke();
                if (a == 0 || a >= 10)
                {
                    a = 0;
                    Event_线程_1s?.Invoke();
                }                 
                a++;
               
            }

        }

        static bool isRun = true;
        internal void 释放()
        {
            isRun = false;
        }

        internal event Action Event_线程_1s;
        internal event Action Event_线程_100ms;

       


    }
}
