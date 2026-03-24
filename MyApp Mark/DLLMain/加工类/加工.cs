using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLMain
{
    internal class 加工
    {
        internal static 加工类 _加工 = new 加工类();

        internal static async Task<bool> 启动加工()
        {
            bool rt = true;
            Task t0 = Task.Run(() => { rt = _加工.加工流程(); });
            await t0;
            return rt;
        }




    }
}
