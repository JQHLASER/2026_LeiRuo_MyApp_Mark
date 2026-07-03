
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AppDLL.表;

namespace AppDLL
{
    internal class 序列号
    {

        internal static (bool s, string m, string sn) 递增(string 工单)
        {
            var work = new string[]
            {
                "查询",
                "递增",
                "保存",
            };

            bool rt = true;
            string msg = "";
            string sn = "001";
            foreach (var s in work)
            {
                if (!rt)
                    break;
                else if (s == "查询")
                {
                    var rtGet = 查询序列号(工单);
                    rt = rtGet.s;
                    msg = rtGet.m;
                    sn = rtGet.sn;
                }
                else if (s == "递增")
                {
                    var lth = sn.Length;
                    var num = int.Parse(sn);
                    num++;
                    sn = num.ToString().PadLeft(lth, '0');
                }
                else if (s == "保存")
                {
                    var rtAdd = db_序列号.Add(new 表.Sn
                    {
                        工单 = 工单,
                        序列号 = sn,
                    });
                    rt = rtAdd.s;
                    msg = rtAdd.m;
                }
            }


            return (rt, msg, sn);
        }

        static (bool s, string m, string sn) 设置序列号(string 工单, string strSn)
        {
            bool rt = true;
            string msg = "";
            string sn = strSn;
            if (string.IsNullOrEmpty(strSn))
            {
                rt = false;
                msg = "请输入序列号";
                return (rt, msg, sn);
            }
            else if (!int.TryParse(strSn, out int i))
            {
                rt = false;
                msg = "序列号应为整型";
                return (rt, msg, sn);
            }
            else if (string.IsNullOrEmpty(工单))
            {
                rt = false;
                msg = "请输入工单";
                return (rt, msg, sn);
            }

            表.Sn tabel = new 表.Sn
            {
                工单 = 工单,
                序列号 = strSn,
            };
            var rtDb = db_序列号.Add(tabel);
            if (rtDb.s)
            {
                msg = $"手动,设置序列号,成功";
                Log.Add($"{msg},{JsonConvert.SerializeObject(tabel)}");

            }
            else
            {
                msg = $"手动,设置序列号,失败,{rtDb.m}";
                Log.Add(false, $"{msg},{JsonConvert.SerializeObject(tabel)}");
                rt = false;
            }

            return (rt, msg, sn);
        }

        internal static (bool s, string m, string sn) 查询序列号(string 工单)
        {

            var rtDb = db_序列号.Get_查询(工单);
            string sn = rtDb.Sn;
            bool rt = rtDb.s;
            string msg = rtDb.m;

            return (rt, msg, sn);
        }

        internal static void 窗体_设置序列号(string 工单)
        {

            if (string.IsNullOrWhiteSpace(工单))
            {
                MessageBox.Show("工单不能为空", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (new QF_WinForm_26.软件类().Win_密码输入框("8888", "请输入密码") != DialogResult.Yes)
            {
                return;
            }
            Log.Add($"...进入序列号设置窗体,<工单:{工单}>");
            using (Form_序列号 forms = new Form_序列号())
            {

                forms.uiButton_确定.Click += async (s, e) =>
                {
                    string text = forms.uiTextBox1.Text.Trim();
                    if (string.IsNullOrWhiteSpace(text))
                    {
                        MessageBox.Show("序列号不能为空", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (!int.TryParse(text, out int a))
                    {
                        MessageBox.Show("序列号必须为整型", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var rtSet = 设置序列号(工单, text);
                    if (!rtSet.s)
                    {
                        MessageBox.Show($"设置失败\r\n{rtSet.m}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("设置成功");
                        显示加工信息.显示Mes信息(text);
                        Log.Add($"设置序列号成功,<{工单}><序列号:{text}>");

                        await CSV.Save(new Http_数据._values_(), 系统设置._参数.工单号, text, $"人工修改序列号,{text},<工单:{工单}>");

                        return;
                    }

                };

                forms.Text = $"工单: {工单}";
                var rt = 查询序列号(工单);
                if (!rt.s)
                {
                    MessageBox.Show($"查询工单失败\r\n{rt.m}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                forms.uiTextBox1.Text = rt.sn;
                forms.ShowDialog();

            }
            Log.Add($"...退出序列号设置窗体,<工单:{工单}>");
        }

    }
}
