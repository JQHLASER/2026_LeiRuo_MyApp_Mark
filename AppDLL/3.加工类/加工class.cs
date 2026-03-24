using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


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

        internal (bool s, string m) 加工流程()
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
                "Err",
                "Err激光",
                "出激光加工",
            };

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



    }
}
