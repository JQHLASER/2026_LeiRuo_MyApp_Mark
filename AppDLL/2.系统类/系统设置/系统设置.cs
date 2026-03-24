using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDLL
{
    internal class 系统设置
    {
        public class _cfg_
        {
          
        }
        internal static _cfg_ _参数 = new _cfg_();
        internal static (bool s, string msgErr) 读写参数(ushort model)
        {
            string path = Path.Combine(QF_MainClass_26.软件类.Files_Cfg.Files_sysConfig, "sysCfg.txt");
            _cfg_ cfg = _参数;
            bool rt = new QF_MainClass_26.文件_文件夹().WriteReadJson(path, model, ref cfg, out string msgErr);
            _参数 = cfg;
            return (rt, msgErr);
        }


        internal static void Win_设置()
        {
            using (Form_系统设置 forms=new Form_系统设置())
            {
                forms.ShowDialog();
            }
        }


    }
}
