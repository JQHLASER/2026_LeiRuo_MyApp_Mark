using DLLMain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static AppDLL.表;


namespace AppDLL
{
    public enum _加工状态_
    {
        None,
        加工中,
    }
    public enum _加工急停状态_
    {
        None,
        急停,
    }

    internal class 加工class : Languages
    {
        void 标题栏状态(_加工状态_ state)
        {
            _加工状态 = state;
            QF_WinForm_26._cfg_标题栏状态_[] beff = new QF_WinForm_26._cfg_标题栏状态_[]
            {
                new QF_WinForm_26 ._cfg_标题栏状态_ ("加工状态",Languages .Get语言 ( "加工中"),(int)_加工状态_ .加工中 ),
                new QF_WinForm_26 ._cfg_标题栏状态_ ("加工状态","",(int)_加工状态_ .None  ),
            };
            窗体标题栏.Add(beff, (int)state);
        }


        internal _加工状态_ _加工状态 = _加工状态_.None;
        internal _加工急停状态_ _加工急停状态 = _加工急停状态_.None;

        internal async Task<(bool s, string m)> 加工流程()
        {
            bool rt = true;
            string msgErr = string.Empty;
            DateTime now = DateTime.Now;


            #region Err

            if (!Err_.系统报警(out msgErr)
                || !LaserMark.Laser_sys._IWork_LaserMark.Err_未初始化(out msgErr)
                || !LaserMark.Laser_sys._IWork_LaserMark.Err_加载激光模板中(out msgErr)
                )
            {
                return (false, msgErr);
            }
            else if (LaserMark._Iwork._激光加工状态 == QF_LaserMark_26._激光加工状态_.红光指示光中)
            {
                LaserMark.停止标刻();
                if (LaserMark._参数.连续加工周期 > 0)
                {
                    Thread.Sleep(LaserMark._参数.连续加工周期);
                }
                Thread.Sleep(100);
            }

            if (!Err_.系统忙(out msgErr))
            {
                return (false, msgErr);
            }

            #endregion


            #region 加工开始

            标题栏状态(_加工状态_.加工中);

            显示.加工状态(Color.Transparent, "");
            Log.Add(true, $"--------------------Start");
            On_IO输出_加工中(true);
            On_加工开始();

            #endregion

            List<string> lswork = new List<string>()
            {
              //  "Err",
                "Err激光",

                "获取Sn",
              //  "判断Sn是否达到最大值",
                "递增Sn",
                "修改加工信息",


                "出激光加工",
            };

            string sn = "";
            foreach (string s in lswork)
            {
                if (!rt || _加工急停状态 == _加工急停状态_.急停)
                {
                    rt = false;
                    break;
                }
                else if (s == "Err")
                {
                    #region Err

                    if (!http_.Err_未获取到工单数据(out msgErr)
                   || !http_.Err_请查询工单(out msgErr))
                    {
                        rt = false;
                    }


                    #endregion

                }
                else if (s == "Err激光")
                {
                    #region Err激光

                    if (!LaserMark.Laser_sys._IWork_LaserMark.Err_未初始化(out msgErr)
                        || !LaserMark.Laser_sys._IWork_LaserMark.Err_未加载激光模板(out msgErr)
                        || !LaserMark.Laser_sys._IWork_LaserMark.Err_无可加工数据(out msgErr)
                        )
                    {
                        rt = false;
                    }


                    #endregion

                }
                else if (s == "出激光加工")
                {
                    #region 出激光加工

                    显示.加工状态(Color.Yellow, Get语言("出激光标刻中"));
                    (bool s, string m) rtMark = LaserMark.出激光标刻();
                    msgErr = rtMark.m;
                    rt = rtMark.s;
                    LaserMark.刷新图形();

                    #endregion
                }
                else if (s == "获取Sn")
                {
                    #region 获取Sn

                    var rtSn = db_序列号.Get_查询(系统设置._参数.工单号);
                    rt = rtSn.s;
                    msgErr = rtSn.m;
                    sn = rtSn.Sn;

                    显示加工信息.显示Mes信息(sn);

                    #endregion
                }
                else if (s == "判断Sn是否达到最大值")
                {
                    #region 判断Sn是否达到最大值
                    if (系统设置._参数.MesValue.Qty <= 0)
                    {
                        rt = false;
                        msgErr = $"工单数量为0,<工单:{系统设置._参数.工单号}><{系统设置._参数.MesValue.Qty}>";
                        Log.Add(rt, msgErr);
                        continue;
                    }
                    rt = int.TryParse(sn, out int snE);
                    if (rt && snE > 系统设置._参数.MesValue.Qty)
                    {
                        rt = false;
                        msgErr = $"序列号已达到工单数量,<工单:{系统设置._参数.工单号}><Sn:{sn}><{系统设置._参数.MesValue.Qty}>";
                        Log.Add(rt, msgErr);
                    }

                    #endregion
                }
                else if (s == "递增Sn")
                {
                    #region 递增Sn 

                    var rtSn = 序列号.递增(系统设置._参数.工单号);
                    rt = rtSn.s;
                    msgErr = rtSn.m;

                    #endregion
                }
                else if (s == "修改加工信息")
                {
                    #region 修改加工信息

                    修改变量信息(sn, 系统设置._参数.MesValue);
                    var rtcsv = CSV.Save(系统设置._参数.MesValue, 系统设置._参数.工单号, sn, "加工");

                    #endregion
                }


            }



            #region 加工结束

            On_加工即将结束(rt);
            On_IO输出_加工结束(rt);
            On_IO输出_加工中(false);
            string show = $"{Languages.Get语言("加工结束")},{Languages.Get语言("耗时")}: {new QF_MainClass_26.软件类().耗时(now, DateTime.Now)}";
            Log.Add(true, show);
            Log.Add(true, $"--------------------End");

            Color cr = rt ? Color.Lime : Color.Red;
            显示.加工状态(cr, Languages.Get语言("加工结束"));

            _加工急停状态 = _加工急停状态_.None;
            标题栏状态(_加工状态_.None);

            On_加工结束_最后(rt);

            #endregion

            #region 是否红光

            if (LaserMark._参数.加工时使能红光)
            {
                LaserMark.红光指示(true);
            }

            #endregion


            return (rt, msgErr);
        }



        #region  方法...IO输出

        void On_IO输出_加工中(bool state)
        {
            if ((LaserMark.端口是否有效(LaserMark._Iwork._参数.OUT.报警) || LaserMark.端口是否有效(LaserMark._Iwork._参数.OUT.标刻完成))
              && !state)
                Thread.Sleep(100);
            IO.Out_加工中(state);
        }


        void On_IO输出_加工结束(bool rt)
        {
            if (rt)
            {
                IO.Out_加工结束();
            }
            else
            {
                IO.Out_报警();
            }


        }

        #endregion


        #region 事件



        public event Action Event_加工开始;
        void On_加工开始()
        {

            Event_加工开始?.Invoke();
        }

        /// <summary>
        /// 在耗时之前
        /// </summary>
        public event Action<bool> Event_加工即将结束;
        void On_加工即将结束(bool state)
        {
            Event_加工即将结束?.Invoke(state);
        }

        /// <summary>
        /// 在耗时之后
        /// </summary>
        public event Action<bool> Event_加工结束_最后;
        void On_加工结束_最后(bool state)
        {
            Event_加工结束_最后?.Invoke(state);
        }



        #endregion



        internal void 修改变量信息(string 序列号, Http_数据._values_ cfg)
        {
            LaserMark._Iwork.修改对象内容("流转卡号", cfg.MachiningId);
            LaserMark._Iwork.修改对象内容("产品型号", cfg.ProductName);
            LaserMark._Iwork.修改对象内容("Bom版本号", cfg.BomVersion);
            LaserMark._Iwork.修改对象内容("工单数量", cfg.Qty.ToString());


            LaserMark._Iwork.修改对象内容("MachiningId", cfg.MachiningId);
            LaserMark._Iwork.修改对象内容("ProductName", cfg.ProductName);
            LaserMark._Iwork.修改对象内容("BomVersion", cfg.BomVersion);
            LaserMark._Iwork.修改对象内容("Qty", cfg.Qty.ToString());

            //if (!string.IsNullOrEmpty(cfg.MachiningId ))
            //{
            //    LaserMark._Iwork.修改对象内容("流转卡号", cfg.MachiningId );
            //}
            //if (!string.IsNullOrEmpty(cfg.ProductName ))
            //{
            //    LaserMark._Iwork.修改对象内容("产品型号", cfg.ProductName );
            //}
            //if (!string.IsNullOrEmpty(cfg.Line3))
            //{
            //    LaserMark._Iwork.修改对象内容("Line3", cfg.Line3);
            //}
            //if (!string.IsNullOrEmpty(cfg.Line4))
            //{
            //    LaserMark._Iwork.修改对象内容("Line4", cfg.Line4);
            //}
            LaserMark._Iwork.修改对象内容("Sn", 序列号);


            Log.Add($"修改变量内容,<序列号: {序列号}>...{JsonConvert.SerializeObject(cfg, Formatting.None)}");

            LaserMark.刷新图形();
        }


    }
}
