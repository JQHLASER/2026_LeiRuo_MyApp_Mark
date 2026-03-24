using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLMain
{
    internal class 启动时自检_
    {
        static string[] Work = new string[]
      {
            "Zaxis.dll",
            "Miks.dll",
      };



        internal static bool 检测(out string msgErr)
        {
            bool rt = true;
            msgErr = string.Empty;

            foreach (string s in Work)
            {
                if (!rt)
                {
                    break;
                }
                else if (s == "Zaxis.dll")
                {
                    #region 正运动

                    if (功能._参数.Zaxis_使能)
                    {
                        rt = new qfWork.Zaxis().Err_Dll是否存在(out msgErr);
                    }

                    #endregion

                }
                else if (s == "Miks.dll")
                {
                    #region Miks

                    rt = LaserMark ._Iwork  .Err_dll是否存在(out msgErr, false);

                    #endregion

                }
                 



            }
            return rt;
        }




    }
}
