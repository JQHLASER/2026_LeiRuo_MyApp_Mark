
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDLL
{
    internal class LaserMark : Languages
    {
        internal static QF_LaserMark_26.LaserMark_All单头 Laser_sys = new QF_LaserMark_26.LaserMark_All单头(功能._打标卡类型);
        internal static QF_LaserMark_26._激光参数_ _参数 = new QF_LaserMark_26._激光参数_();
        internal static QF_LaserMark_26.IWork_LaserMark _Iwork = Laser_sys._IWork_LaserMark;
        static string _Name = "EzCad2打标卡";

        /// <summary>
        /// 显示使用的名称,已语言处理
        /// </summary>
        internal static string _打标卡_名称 = Get语言 ("打标卡");


        internal static  void 初始化()
        {
            if (功能._打标卡类型 == QF_LaserMark_26._em_打标卡类型_.None)
            {
                return;
            }
            _Iwork = LaserMark.Laser_sys._IWork_LaserMark;
            _参数 = _Iwork.读参数();
            _Iwork.Event_IO_IN += (s) => On_IO_IN(s);
            _Iwork.Event_IO_OUT += (s) => On_IO_OUT(s);
            _Iwork.Event_初始化状态 += (s) => On_初始化状态(s);
            _Iwork.Event_Log += (s, e) => On_Log(s, e);
            _Iwork.Event_加工状态 += (s) => On_加工状态(s);
            _Iwork.Event_加载激光模板成功 += (s) => On_加载激光模板成功(s);
            _Iwork.Event_获取图像 += (s) => On_获取图像(s);

            _Iwork.初始化(true);
            Form_Main_class._MainClass_sys.Event_线程_100ms += () => On_判断系统是否报警();
            isInistiall = true;
        }

        static bool isInistiall = false;
        internal static void 释放()
        {
            if (!isInistiall)
            {
                return;
            }

            _Iwork.释放();
        }

        internal static void 打开激光软件()
        {
            _Iwork.打开激光编辑软件();
        }

        internal static void 打开激光模板()
        {
            (bool s, string m) rt = _Iwork.打开模板_openFileDialog(true, true);
            if (!rt.s)
            {
                MessageBox.Show(rt.m, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        internal static void 窗体_调试()
        {
            _Iwork.win_调试();
            _参数 = _Iwork.读参数();
        }

        internal static async Task<bool> 红光指示(bool Is日志, bool Is失败弹窗 = false)
        {
            (bool s, string m) rt = (true, "");
            Task t0 = Task.Run(() =>
            {
                rt = _Iwork.红光指示(Is日志);
            });
            await t0;
            if (!rt.s)
            {
                MessageBox.Show(rt.m, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }

        internal static void 停止标刻()
        {
            Log.Add($"{_打标卡_名称},{Get语言("停止加工")}");
            _Iwork.停止();
        }
        internal static (bool s, string m) 出激光标刻()
        {
            Log.Add($"{_打标卡_名称},{Get语言("出激光标刻开始")}...");
            (bool s, string m) rt = _Iwork.标刻(false, true);
            Log.Add(rt.s, $"...{_打标卡_名称},{Get语言("出激光标刻结束")}");
            return rt;
        }

        internal static void 刷新图形(QF_LaserMark_26._激光_获取图像_ state = QF_LaserMark_26._激光_获取图像_.获取)
        {
            _Iwork.刷新图形(state);
        }

        internal static bool 端口是否有效(ushort Port)
        {
            return _Iwork.端口是否有效(Port);
        }


        #region 本地

        static void Ui_图像显示控件()
        {
            if (功能._打标卡类型 == QF_LaserMark_26._em_打标卡类型_.None)
            {
                return;
            }
            Form_Main.forms.Invoke((Action)(() =>
            {
                _Iwork.ui_图像控件(Form_Main.forms.uiPanel_激光图像);
            }));
        }

        static bool IO获取状态(ushort Port, bool[] state)
        {
            if (IO端口是否有效(Port) && state.Length == 16)
            {
                return state[Port];
            }
            return false;
        }

        static bool IO端口是否有效(ushort Port)
        {

            bool rt = new QF_Iwork_26.IO类_().端口是否有效(Port, _Iwork._minPort, _Iwork._maxPort);

            return rt;
        }



        #endregion



        #region 事件响应

        static bool In_启动 = false;
        static bool In_复位 = false;
        static bool In_停止 = false;



        static void On_IO_IN(bool[] state)
        {
            #region 启动

            bool 启动 = IO获取状态(_参数.IN.启动标刻, state);
            if (启动 && !In_启动)
            {
                Log.Add(true, $"{Get语言("IO触发,启动加工")}");
                Task.Run(() =>
              {
                  加工类_._加工.加工流程();
              });
            }

            #endregion

            #region 复位

            bool 复位 = IO获取状态(_参数.IN.复位, state);
            if (复位 && !In_复位)
            {
                Log.Add(true, $"{Get语言("IO触发,复位")}");
                Task.Run(() => { IO.Out_报警(false); });
            }

            #endregion

            #region 停止

            bool 停止 = IO获取状态(_参数.IN.停止, state);
            if (停止 && !In_停止)
            {
                Log.Add(true, $"{Get语言("IO触发,停止")}");
                Task.Run(() => { 停止标刻(); });
            }

            #endregion



            In_停止 = 停止;
            In_复位 = 复位;
            In_启动 = 启动;
        }


        static bool Out_Ready = false;
        static bool Out_报警 = false;
        static bool Out_红光 = false;
        static bool Out_标刻中 = false;
        static bool Out_标刻完成 = false;

        static void On_IO_OUT(bool[] state)
        {
            Out_Ready = IO获取状态(_参数.OUT.软件准备好, state);
            bool 报警 = IO获取状态(_参数.OUT.报警, state);
            Out_红光 = IO获取状态(_参数.OUT.红光, state);
            Out_标刻中 = IO获取状态(_参数.OUT.标刻中, state);
            Out_标刻完成 = IO获取状态(_参数.OUT.标刻完成, state);


            if (报警 != Out_报警)
            {
                IO.标题栏状态_报警(报警);
            }

            Out_报警 = 报警;
        }

        static void On_Log(bool state, string msg)
        {
            Log.Add(state, $"{_打标卡_名称},{msg}");
        }


        static bool _Is第一次 = true;
        static void On_初始化状态(QF_MainClass_26._初始化状态_ state)
        {
            new QF_WinForm_26.窗体_标题栏状态_方法().设置标题栏状态(窗体标题栏._标题栏状态,_Name ,_打标卡_名称 , state);


            switch (state)
            {
                case QF_MainClass_26._初始化状态_.已初始化:
                    LaserMark.Ui_图像显示控件();
                    break;
                case QF_MainClass_26._初始化状态_.未初始化:
                    Form_Main.forms.Invoke((Action)(() => { Form_Main.forms.uiPanel_激光图像.Controls.Clear(); }));
                    break;
                case QF_MainClass_26._初始化状态_.初始化中:

                    break;
            }


        }

        static void On_加工状态(QF_LaserMark_26._激光加工状态_ state)
        {
            QF_WinForm_26._cfg_标题栏状态_[] beff = new QF_WinForm_26._cfg_标题栏状态_[]
            {
              new  QF_WinForm_26._cfg_标题栏状态_(_Name ,$"{_打标卡_名称}{Get语言 ("出激光标刻中")}",(int)QF_LaserMark_26._激光加工状态_.出激光标刻中),
              new  QF_WinForm_26._cfg_标题栏状态_(_Name ,$"{_打标卡_名称}{Get语言 ("加工中")}",(int)QF_LaserMark_26._激光加工状态_.加工中),
              new  QF_WinForm_26._cfg_标题栏状态_(_Name ,$"{_打标卡_名称}{Get语言 ("加载激光模板中")}",(int)QF_LaserMark_26._激光加工状态_.加载激光模板中 ),
              new  QF_WinForm_26._cfg_标题栏状态_(_Name ,$"{_打标卡_名称}{Get语言 ("红光指示光中")}",(int)QF_LaserMark_26._激光加工状态_.红光指示光中 ),
              new  QF_WinForm_26._cfg_标题栏状态_(_Name ,$"",(int)QF_LaserMark_26._激光加工状态_.闲置 ),
            };

            new QF_WinForm_26.窗体_标题栏状态_方法().设置标题栏状态(窗体标题栏._标题栏状态, beff, (int)state);
        }

        static void On_获取图像(QF_LaserMark_26._激光_获取图像_ state)
        {

        }

        static void On_加载激光模板成功(string TemplatePath)
        {
            new QF_MainClass_26.文件_文件夹().文件_获取文件名_含后缀(TemplatePath, out string name, out string msgErr);
            状态栏.Add("EzCad2激光模板", $"{Get语言("激光模板")} : {name}");
        }


        /// <summary>
        /// 判断系统是否报警
        /// </summary>
        static void On_判断系统是否报警()
        {
            bool is端口有效 = IO端口是否有效(LaserMark._参数.OUT.软件准备好);
            if (!is端口有效)
            {
                return;
            }
            bool isAlarm = Err_.系统报警(out string msgerr, false);
            if (isAlarm && !Out_Ready)
            {
                IO.Out_Ready(true);
            }
            else if (!isAlarm && Out_Ready)
            {
                IO.Out_Ready(false);
            }

        }





        #endregion



    }
}
