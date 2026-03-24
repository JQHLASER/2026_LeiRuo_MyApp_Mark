using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDLL
{
    internal class Log
    {
        /// <summary>
        /// 日志框
        /// </summary>
        internal static QF_WinForm_26.ui_Log ui_log = new QF_WinForm_26.ui_Log()
        {
            Dock = DockStyle.Fill,
            _显示时间 = false,
            _最大显示行数 = 功能._FormMain.日志栏_显示行数,
            _BackColor = 功能._FormMain.日志栏_背景颜色,
            _ItemHeight = 功能._FormMain.日志栏_行高,
            _UI刷新时间 = 功能._FormMain.日志栏_UI刷新周期,
        };


        internal static void 初始化(Control 显示日志框的控件)
        {
            显示日志框的控件.Controls.Clear();
            显示日志框的控件.Controls.Add(ui_log);
        }

        internal static void Add(bool status, string value, bool Is显示到日志栏 = true)
        {
            Form_Main_class._MainClass_sys.Log日志_Add(status, value, Is显示到日志栏);
        }
        internal static void Add(string value, bool status = true, bool Is显示到日志栏 = true)
        {
            Form_Main_class._MainClass_sys.Log日志_Add(status, value, Is显示到日志栏);
        }



    }
}
