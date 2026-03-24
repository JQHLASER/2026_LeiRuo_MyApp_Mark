using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AppDLL
{
    internal class Zaxis_运动轴
    {
        internal static List<QF_Iwork_26.Zaxis_数据结构._inf_轴状态_> _轴状态 = new List<QF_Iwork_26.Zaxis_数据结构._inf_轴状态_>();



        internal static List<string> _lst轴名称 = new List<string>()
        {
            "Z",

        };

        static bool _Inistiall = false;
        static bool _is初始 = true;
        internal static void 初始化()
        {
            if (!功能._Zaxis运动轴_使能 || _lst轴名称.Count == 0)
                return;

            if (!_Inistiall)
            {
                Zaxis_.Zaxis_sys.Event_其它 += () =>
                {
                    if (!_Inistiall)
                    {
                        return;
                    }
                    Task.Run(() =>
                    {
                        获取轴状态();

                    });
                };

                Zaxis_.Zaxis_sys._Zaxis运动轴.Event_读写参数 += () =>
                {
                    设置_全部轴参数();
                };

            }
            Zaxis_.Zaxis_sys.运动轴_初始化(_lst轴名称);
            _轴状态 = Zaxis_.Zaxis_sys._Zaxis运动轴._轴状态; 
            设置轴IO_Z轴();


            _Inistiall = true;
        }

        internal static void Win_设置()
        {
            Zaxis_.Zaxis_sys.运动轴_Win_设置("");
        }



        #region 本地方法


        static void 设置_全部轴参数()
        {
            for (int i = 0; i < _lst轴名称.Count; i++)
            {
                int 轴号 = i;
                设置_轴参数(轴号);
            }
        }
        static void 设置_轴参数(int 轴号)
        {
            if (轴号 < 0 || Zaxis_.Zaxis_sys._Zaxis运动轴._轴参数.Count == 0)
            {
                return;
            }

            Zaxis_.Zaxis_sys.axis_设置_轴使能(轴号, (int)Zaxis_.Zaxis_sys._Zaxis运动轴._轴参数[轴号].轴使能);
            Zaxis_.Zaxis_sys.axis_设置_轴类型(轴号, (int)Zaxis_.Zaxis_sys._Zaxis运动轴._轴参数[轴号].轴类型);
            Zaxis_.Zaxis_sys.axis_设置_轴脉冲当量(轴号, (int)Zaxis_.Zaxis_sys._Zaxis运动轴._轴参数[轴号].轴参数.脉冲当量);

            Zaxis_.Zaxis_sys.axis_设置_轴起始速度(轴号, Zaxis_.Zaxis_sys._Zaxis运动轴._轴参数[轴号].轴参数.起始速度);
            Zaxis_.Zaxis_sys.axis_设置_加速度(轴号, Zaxis_.Zaxis_sys._Zaxis运动轴._轴参数[轴号].轴参数.加速度);
            Zaxis_.Zaxis_sys.axis_设置_减速度(轴号, Zaxis_.Zaxis_sys._Zaxis运动轴._轴参数[轴号].轴参数.减速度);

            Zaxis_.Zaxis_sys.axis_设置_轴异常快速减速度(轴号, Zaxis_.Zaxis_sys._Zaxis运动轴._轴参数[轴号].轴参数.轴异常快减速度);
            Zaxis_.Zaxis_sys.axis_设置_轴脉冲输出模式_即轴方向(轴号, (int)Zaxis_.Zaxis_sys._Zaxis运动轴._轴参数[轴号].轴方向);

            Zaxis_.Zaxis_sys.axis_设置_回零反找等待时间(轴号, Zaxis_.Zaxis_sys._Zaxis运动轴._轴参数[轴号].轴回零参数.精确回零延时);
            Zaxis_.Zaxis_sys.axis_设置_回零爬行速度(轴号, Zaxis_.Zaxis_sys._Zaxis运动轴._轴参数[轴号].轴回零参数.精确回零速度);

        }

        #region 轴IO限位

        internal static void 设置_IO_急停(int 轴号, int port)
        {
            Zaxis_.Zaxis_sys.axis_设置_轴急停报警信号输入口(轴号, port);
        }
        /// <summary>
        /// 原点
        /// </summary> 
        internal static void 设置_IO_零点(int 轴号, int port)
        {
            Zaxis_.Zaxis_sys.axis_设置_轴原点硬限位输入口(轴号, port);
        }

        /// <summary>
        /// 原点
        /// </summary> 
        internal static void 设置_IO_正限位(int 轴号, int port)
        {
            Zaxis_.Zaxis_sys.axis_设置_轴正向硬限位输入口(轴号, port);
        }

        /// <summary>
        /// 原点
        /// </summary> 
        internal static void 设置_IO_负限位(int 轴号, int port)
        {
            Zaxis_.Zaxis_sys.axis_设置_轴负向硬限位输入口(轴号, port);
        }

        #endregion


        static void 设置_轴速度(int 轴号, float 速度)
        {
            Zaxis_.Zaxis_sys._Zaxis运动轴.设置轴速度(轴号, 速度);
        }

        internal static QF_Iwork_26.Zaxis_数据结构._em_轴运动状态_ 读取_轴运行状态(int 轴号)
        {
            return Zaxis_.Zaxis_sys._Zaxis运动轴.读取_轴运行状态(轴号);
        }

        internal static QF_Iwork_26.Zaxis_数据结构._em_轴回零状态_ 读取_轴回零状态(int 轴号)
        {
            return Zaxis_.Zaxis_sys._Zaxis运动轴.读取_轴回零状态(轴号);
        }

        internal static float 读取_轴坐标(int 轴号)
        {
            float a = 0f;
            Zaxis_.Zaxis_sys.axis_读取_轴命令位置坐标(轴号, ref a);
            return a;
        }

        internal static int 读取_轴状态(int 轴号)
        {
            return Zaxis_.Zaxis_sys._Zaxis运动轴.读取_轴状态(轴号);
        }


        #endregion

        #region 本地方法....轴/轴IO及限位

        static void 设置轴IO_Z轴()
        {
            int 轴号 = 0;

            //下面是IO输入口
            int 急停_0 = 0;
            int 零点_0 = 1;
            int 正限位_0 = 2;
            int 负限位_0 = 3;

            Zaxis_.Zaxis_sys.IO_设置输入状态反转(急停_0, 0);
            Zaxis_.Zaxis_sys.IO_设置输入状态反转(零点_0, 0);
            Zaxis_.Zaxis_sys.IO_设置输入状态反转(正限位_0, 0);
            Zaxis_.Zaxis_sys.IO_设置输入状态反转(负限位_0, 0);


            设置_IO_急停(轴号, 急停_0);
            设置_IO_零点(轴号, 零点_0);
            设置_IO_正限位(轴号, 正限位_0);
            设置_IO_负限位(轴号, 负限位_0);
        }

        static void 获取轴状态()
        {


            for (int i = 0; i < Zaxis_.Zaxis_sys._Zaxis运动轴._轴状态.Count; i++)
            {
                int 轴号 = i;
                Zaxis_.Zaxis_sys._Zaxis运动轴._轴状态[轴号].轴回零状态 = 读取_轴回零状态(轴号);
                Zaxis_.Zaxis_sys._Zaxis运动轴._轴状态[轴号].轴运动状态 = 读取_轴运行状态(轴号);
                Zaxis_.Zaxis_sys._Zaxis运动轴._轴状态[轴号].轴坐标 = 读取_轴坐标(轴号);
                Zaxis_.Zaxis_sys._Zaxis运动轴._轴状态[轴号].轴状态 = 读取_轴状态(轴号);



                显示_轴状态(轴号);

            }
            _轴状态 = Zaxis_.Zaxis_sys._Zaxis运动轴._轴状态;
            _is初始 = false;
        }

        static void 显示_轴状态(int 轴号)
        {
            窗体标题栏_轴回零状态(轴号, Zaxis_.Zaxis_sys._Zaxis运动轴._轴状态[轴号].轴回零状态);
            窗体标题栏_轴运动状态(轴号, Zaxis_.Zaxis_sys._Zaxis运动轴._轴状态[轴号].轴运动状态);



            状态栏.Add("Z轴坐标", $"{_lst轴名称[0]}:{_轴状态[0].轴坐标.ToString("0.00")}");
        }


        #endregion

        #region Err


        internal static bool Err_轴运动中(int 轴号, out string msgErr)
        {
            bool rt = true;
            msgErr = "";
            var rtGet = 读取_轴运行状态(轴号);
            if (rtGet != QF_Iwork_26.Zaxis_数据结构._em_轴运动状态_.停止)
            {
                msgErr = $"{_lst轴名称[轴号]}{Languages.Get语言("运动中")}";
                return false;
            }
            return true;
        }

        internal static bool Err_轴未回零(int 轴号, out string msgErr)
        {
            bool rt = true;
            msgErr = "";
            var rtGet = 读取_轴回零状态(轴号);
            if (rtGet != QF_Iwork_26.Zaxis_数据结构._em_轴回零状态_.正常)
            {
                msgErr = $"{_lst轴名称[轴号]}{Languages.Get语言("未回零")}";
                return false;
            }
            return true;
        }

        internal static bool Err_轴号不能小于0(int 轴号, out string msgErr)
        {
            return Zaxis_.Zaxis_sys._Zaxis运动轴.Err_轴号不能小于0(轴号, out msgErr);
        }


        #endregion

        #region 窗体标题栏


        static void 窗体标题栏_轴运动状态(int 轴号, QF_Iwork_26.Zaxis_数据结构._em_轴运动状态_ state)
        {
            int a = state == QF_Iwork_26.Zaxis_数据结构._em_轴运动状态_.运动中
                    ? 1
                    : 0;
            QF_WinForm_26._cfg_标题栏状态_[] cfg = new QF_WinForm_26._cfg_标题栏状态_[]
            {
                new QF_WinForm_26._cfg_标题栏状态_ ("轴运动状态",$"{_lst轴名称[轴号]}{Languages .Get语言("运动中")}",1 ),
                new QF_WinForm_26._cfg_标题栏状态_ ("轴运动状态",$"",0  ),
            };
            窗体标题栏.Add(cfg, a);
        }

        static void 窗体标题栏_轴回零状态(int 轴号, QF_Iwork_26.Zaxis_数据结构._em_轴回零状态_ state)
        {
            int a = state == QF_Iwork_26.Zaxis_数据结构._em_轴回零状态_.正常
                    ? 0
                    : -1;
            QF_WinForm_26._cfg_标题栏状态_[] cfg = new QF_WinForm_26._cfg_标题栏状态_[]
            {
                new QF_WinForm_26._cfg_标题栏状态_ ("轴回零状态",$"{_lst轴名称[轴号]}{Languages .Get语言("未回零")}",-1 ),
                new QF_WinForm_26._cfg_标题栏状态_ ("轴回零状态",$"",0  ),
            };
            窗体标题栏.Add(cfg, a);
        }



        #endregion


        #region 轴操作


        internal static async Task<(bool s, string m)> 轴全部回零(bool 弹窗确认)
        {
            bool rt = true;
            string msgErr = "";
            if (!Zaxis_.Zaxis_sys.Err_运动轴未初始化(out msgErr) || !Err_.系统忙(out msgErr, false))
            {
                return (false, msgErr);
            }
            int count = _lst轴名称.Count; 
            List<Task> lstTask = new List<Task>();
            for (int i = 0; i < count; i++)
            {
                int 轴号 = i;
                if (Zaxis_.Zaxis_sys._Zaxis运动轴._轴参数[轴号].轴回零参数.使能回零)
                {
                    var ts = Task.Run(() => { Zaxis_.Zaxis_sys._Zaxis运动轴.回零(轴号); });
                    lstTask.Add(ts);
                }
            }
            await Task.WhenAll(lstTask);
            return (rt, msgErr);
        }










        #endregion






    }
}
