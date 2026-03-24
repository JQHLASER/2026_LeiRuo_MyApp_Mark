using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLLMain
{
    internal class 注册
    {

        internal static qfNet.软件注册 软件注册_sys;
        /// <summary>
        /// 加密狗通知机制
        /// </summary>
        internal static qfNet.DogTW基础_window通知机制 dogEvent = new qfNet.DogTW基础_window通知机制();


        public 注册()
        {
            软件注册_sys = new qfNet.软件注册(功能.软件注册_注册方式);
            qfmain.DogTW.Config.功能类型 = 功能.Dog功能;

            软件注册_sys.Event_Log += On_Log;
            软件注册_sys.Event_注册结果 += 事件_注册.On_软件注册结果;
            系统._线程.Event_线程_1s += 判断注册是否到期;
            软件注册_sys.Event_注册结果 += On_注册结果;
            dogEvent.Event_DogTw += On_dogEvent;


            isInistiall = true;
        }
        static bool isInistiall = false;

        internal static void 释放()
        {
            if (!isInistiall)
            {
                return;
            }
            软件注册_sys.Event_Log -= On_Log;
            软件注册_sys.Event_注册结果 -= 事件_注册.On_软件注册结果;
            系统._线程.Event_线程_1s -= 判断注册是否到期;
            软件注册_sys.Event_注册结果 -= On_注册结果;
            dogEvent.Event_DogTw -= On_dogEvent;
        }



        internal static void 窗体()
        {
            if (!isInistiall)
            {
                return;
            }
            软件注册_sys.窗体_软件授权();
        }


        /// <summary>
        /// 进入系统时
        /// </summary>
        internal static void 注册_进入系统时()
        {
            if (!isInistiall)
            {
                return;
            }

            Task.Run(() => { 软件注册_sys.Inistiall(); });

        }

        static int keyInt = 0;
        /// <summary>
        /// 为日期注册时判断是否到注册日期
        /// </summary>
        internal static void 判断注册是否到期()
        {
            if (!isInistiall)
            {
                return;
            }
            else if (软件注册_sys._err != qfmain._软件授权_Err_.已日期注册)
            {
                return;
            }
            keyInt++;
            //10分钟检测一次,线程周期为1s一次
            if (keyInt >= 60 * 10)
            {
                Task.Run(() =>
                {
                    软件注册_sys.注册检测();
                    keyInt = 0;
                });
            }
        }



        static void On_Log(bool state, string log)
        {
            Log.Add(state, log);
        }

        static void On_注册结果(qfmain._软件授权_Err_ Err)
        {
            软件注册_sys.标题栏状态(窗体标题栏状态._标题栏状态);
        }


        /// <summary>
        /// 加密狗通知机制
        /// </summary>
        /// <param name="state"></param>
        static void On_dogEvent(bool state)
        {

            if (软件注册_sys._注册类型 != qfmain._软件授权_注册类型_.加密狗)
            {
                return;
            }
            else if (!state)
            {
                #region 加密狗拔出

                if ((软件注册_sys._err != qfmain._软件授权_Err_.已完全注册 &&
                    软件注册_sys._err != qfmain._软件授权_Err_.已日期注册) ||
                    isDog)
                {
                    return;
                }

                Task.Run(() =>
                {
                    状态栏.Add("加密狗", "DOG");
                    //在拔出5分钟后没有重新插入的话,就报警
                    isDog = true;
                    if (delay_.延时(1000 * 60 * 5).Result)
                    {
                        Log.Add(false, Language_.Get语言("系统检测到加密狗拔出"));
                        isDog = false;
                        软件注册_sys._err = qfmain._软件授权_Err_.未检测到加密狗;
                        软件注册_sys.On_注册结果(qfmain._软件授权_Err_.未检测到加密狗);
                        isDog = false;
                    }
                    状态栏.Add("加密狗", "");
                });

                #endregion
            }
            else
            {
                #region 加密狗插入

                if (isDog)
                {
                    delay_.中断延时();
                }

                if (!isDog)
                {
                    Log.Add(false, Language_.Get语言("系统检测到加密狗插入,请重启软件"));
                }
                else
                {
                    //Log日志_.Add(Language_.Get语言("系统检测到加密狗插入,无需重启软件"));
                    isDog = false;
                }

                #endregion

            }

        }

        static bool isDog = false;
        static qfmain.延时_Task delay_ = new qfmain.延时_Task();


    }
}
