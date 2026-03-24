using QF_WinForm_26;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDLL
{
    internal class Err_
    {

        internal static bool 系统报警(out string msgErr, bool 显示日志 = true)
        {
            return Form_Main_class._MainClass_sys.Err_系统报警(out msgErr, 显示日志);
        }

        internal static bool 系统忙(out string msgErr, bool 显示日志 = true)
        {
            return Form_Main_class._MainClass_sys.Err_系统忙(out msgErr, 显示日志);
        }



    }
}
