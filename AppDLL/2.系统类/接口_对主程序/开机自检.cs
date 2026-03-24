using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDLL
{
    internal class 开机自检
    {

        internal static (bool s, string msgErr) 自检()
        {
            bool rt = true;
            string msgErr = "";

            string[] Work = new string[]
            {
                "Zaxis.dll",
                "Miks.dll",
            };

            foreach (string s in Work)
            {
                if (!rt)
                {
                    break;
                }
                else if (s == "Zaxis.dll")
                {
                    continue;//暂不使用

                    #region 正运动

                    rt = new QF_Iwork_26.Zaxis().Err_Dll是否存在(out msgErr);

                    #endregion

                }
                else if (s == "Miks.dll")
                {
                    #region Miks

                    rt = LaserMark._Iwork.Err_dll是否存在(out msgErr, false);

                    #endregion

                }




            }



            return (rt, msgErr);
        }
         
    }
}
