using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDLL
{
    internal class CSV
    {


        internal static async Task<(bool s, string m)> Save(Http_数据._values_ cfg, string 工单号, string 序列号, string 说明)
        {
            List<string> lst = new List<string>();
            List<string[]> lstStr = new List<string[]>();

            string fileCsv = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CSV");
            string file工单 = Path.Combine(fileCsv, 工单号);


            new QF_MainClass_26.文件_文件夹().文件夹_新建(fileCsv, out string msgErr);
            new QF_MainClass_26.文件_文件夹().文件夹_新建(file工单, out msgErr);


            string pathCsv = Path.Combine(file工单, $"{DateTime.Now.ToString("yyyy-MM-dd")}.csv");

            if (!new QF_MainClass_26.文件_文件夹().文件_是否存在(pathCsv))
            {
                lst = new List<string>
                {
                    "时间",
                    "工单",
                    "流转卡号",
                    "产品型号",
                    "Bom版本号",
                    "MachiningId",
                    "ProductName",
                    "BomVersion",
                    "Qty",
                    "Sn",
                    "说明",
                };

                lstStr.Add(lst.ToArray());
            }
            //Http_数据._values_ cfg = 系统设置 ._参数.MesValue;
            lst = new List<string>
                {
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    工单号,
                    cfg.MachiningId,
                    cfg.ProductName,
                    cfg.BomVersion,
                    cfg.MachiningId,
                    cfg.ProductName,
                    cfg.BomVersion,
                    cfg.Qty.ToString(),
                    序列号,
                    说明 ,
                };
            lstStr.Add(lst.ToArray());

            var rt = await csv_sys.Write(pathCsv, lstStr, true, Encoding.UTF8);
            string show = rt.state ? $"保存csv成功" : $"保存csv失败,{rt.msgErr}";
            Log.Add(rt.state, show);
            return rt;
        }

        static QF_MainClass_26.CSV csv_sys = new QF_MainClass_26.CSV();


    }
}
