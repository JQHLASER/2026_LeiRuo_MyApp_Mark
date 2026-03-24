using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DLLMain
{
    internal class Err
    {

        internal static bool 系统报警(out string msgErr,bool 显示日志=true)
        {
            msgErr = "";
            if (窗体标题栏状态._标题栏状态._当前系统状态 == qfNet.窗体_标题栏状态._状态_.红色)
            {
                msgErr = Language_.Get语言("系统报警");
                if (显示日志)
                {
                   Log.Add(false, msgErr);
                }
                return false;
            }
            return true;
        }

        internal static bool 系统忙(out string msgErr, bool 显示日志 = true)
        {
            msgErr = "";
            if (窗体标题栏状态._标题栏状态._当前系统状态 == qfNet.窗体_标题栏状态._状态_.黄色)
            {
                msgErr = Language_.Get语言("系统忙");
                if (显示日志)
                {
                   Log.Add(false, msgErr);
                }
                return false;
            }
            return true;
        }

        internal static bool 请查询工单(out string msgErr)
        {
            msgErr = "";
            if (string .IsNullOrEmpty (系统参数 ._参数 .工单号 ))
            {
                msgErr = "请查询工单";
                Log.Add(false, msgErr);
                return false;
            }
            return true;
        }

        internal static bool 未获取到工单数据(out string msgErr)
        {
            msgErr = "";
            if (string.IsNullOrEmpty(系统参数._参数 .MesValue .MachiningId  )
                && string.IsNullOrEmpty(系统参数._参数.MesValue.ProductName )
                && string.IsNullOrEmpty(系统参数._参数.MesValue.BomVersion ) 
                )
            {
                msgErr = "未获取到工单数据";
                Log.Add(false, msgErr);
                return false;
            }
            return true;
        }

    }
}
