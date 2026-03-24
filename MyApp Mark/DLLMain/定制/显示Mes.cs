using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLMain
{
    internal class 显示Mes
    {

        private static readonly object _lock = new object();

        internal static void 显示Mes信息()
        {
            lock (_lock)
            {
                系统参数._Cfg_ cfg = 系统参数._参数;

                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"<扫码>");
                sb.AppendLine($"  {cfg.工单号}");

                if (!string.IsNullOrEmpty(cfg.工单号))
                {
                    sb.AppendLine($"<序列号 Sn>");
                    sb.AppendLine($"  {序列号._序列号 }");

                    sb.AppendLine($"<流转卡号>(MachiningId)");
                    sb.AppendLine($"  {cfg.MesValue.MachiningId}");

                    sb.AppendLine($"<产品型号>(ProductName)");
                    sb.AppendLine($"  {cfg.MesValue.ProductName}");

                    sb.AppendLine($"<Bom版本号>(BomVersion)");
                    sb.AppendLine($"  {cfg.MesValue.BomVersion}");

                    sb.AppendLine($"<工单数量>(Qty)");
                    sb.AppendLine($"  {cfg.MesValue.Qty }");

                }
                //if (!string.IsNullOrEmpty(cfg.MesValue .Line1))
                //{
                //    sb.AppendLine($"<Line1>");
                //    sb.AppendLine($"  {cfg.MesValue.Line1}");
                //}

                //if (!string.IsNullOrEmpty(cfg.MesValue.Line2))
                //{
                //    sb.AppendLine($"<Line2>");
                //    sb.AppendLine($"  {cfg.MesValue.Line2}");
                //}

                //if (!string.IsNullOrEmpty(cfg.MesValue.Line3))
                //{
                //    sb.AppendLine($"<Line3>");
                //    sb.AppendLine($"  {cfg.MesValue.Line3}");
                //}

                //if (!string.IsNullOrEmpty(cfg.MesValue.Line4))
                //{
                //    sb.AppendLine($"<Line4>");
                //    sb.AppendLine($"  {cfg.MesValue.Line4}");
                //}
                FormMain.forms.Invoke((Action)(() =>
                {
                    FormMain.forms.uiLabel_加工信息.Text = sb.ToString();
                }));


            }
        }




    }
}
