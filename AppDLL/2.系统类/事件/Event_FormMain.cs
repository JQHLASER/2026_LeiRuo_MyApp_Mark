using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDLL
{
    internal class Event_FormMain
    {

        internal static void On_Load()
        {    
            系统设置.读写参数(1);

            db_序列号.Event_初始化成功 += () =>
            {
                系统设置.读写参数(1);
                var rt = 序列号.查询序列号(系统设置._参数.工单号);
                显示加工信息.显示Mes信息(rt.sn);
            };
        }

        internal static void On_Closeing()
        {






        }






    }
}
