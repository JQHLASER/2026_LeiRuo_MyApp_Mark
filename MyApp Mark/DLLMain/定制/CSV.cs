using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLMain
{
    internal class CSV
    {


        internal static async Task<(bool s, string m)> Save(string 序列号)
        {
            List<string> lst = new List<string>();
            List<string[]> lstStr = new List<string[]>();

            string fileCsv = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CSV");
            new qfmain.文件_文件夹().文件夹_新建(fileCsv, out string msgErr);
            string pathCsv = Path.Combine(fileCsv, $"{DateTime.Now.ToString("yyyy-MM-dd")}.csv");

            if (!new qfmain.文件_文件夹().文件_是否存在(pathCsv))
            {
                lst = new List<string>
                {
                    "时间",
                    "流转卡号",
                    "产品型号",
                    "Bom版本号",
                    "MachiningId",
                    "ProductName",
                    "BomVersion",
                    "Qty",
                    "Sn",
                };

                lstStr.Add(lst.ToArray());
            }
            Http_数据._values_ cfg = 系统参数._参数.Clone().MesValue;
            lst = new List<string>
                {
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    cfg.MachiningId,
                    cfg.ProductName,
                    cfg.BomVersion,
                    cfg.MachiningId,
                     cfg.ProductName,
                     cfg.BomVersion,
                    cfg.Qty.ToString(),
                    序列号,
                };
            lstStr.Add(lst.ToArray());

            var rt = await new qfmain.CSV().Write(pathCsv, lstStr, true, Encoding.UTF8);
            string show = rt.state ? $"保存csv成功" : $"保存csv失败,{rt.msgErr}";
            Log.Add(rt.state, show);
            return rt;
        }




    }
}
