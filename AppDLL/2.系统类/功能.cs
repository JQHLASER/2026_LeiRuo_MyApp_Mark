using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDLL
{
    internal class 功能
    {
        #region 数据结构

        public class _cfg_功能Main_
        {
            //用户登陆...Login
            public bool 用户_使能 { set; get; } = false;
            //使能语言
            public bool 语言_使能 { set; get; } = false;

            //生产计数
            public bool 生产计数_良品_使能 { set; get; } = false;
            //生产计数
            public bool 生产计数_不良品_使能 { set; get; } = false;
            //生产计数
            public bool 生产计数_零件_使能 { set; get; } = false;


            public bool 使能_报警持续输出IO { set; get; } = false;



        }

        public class _cfg_FormMain_
        {
            public Color 工作区_边框颜色 { set; get; } = Color.WhiteSmoke;

            /// <summary>
            /// 主窗体日志区
            /// </summary>
            public int 日志栏_显示行数 { set; get; } = 200;
            public Color 日志栏_背景颜色 { set; get; } = Color.White;
            public int 日志栏_行高 { set; get; } = 25;
            public int 日志栏_UI刷新周期 { set; get; } = 100;


            public Color 标题栏默认背景颜色 { set; get; } = Color.FromArgb(4, 83, 100);
            public Color 标题栏默认文本颜色 { set; get; } = Color.White;

        }



        public class _cfg_密码_
        {
            public string 设置工作区尺寸 { set; get; } = "QF8888";
            public string 系统设置 { set; get; } = "8888";

        }





        #endregion



        internal static _cfg_功能Main_ _功能Main = new _cfg_功能Main_();
        internal static _cfg_密码_ _密码 = new _cfg_密码_();
        internal static _cfg_FormMain_ _FormMain = new _cfg_FormMain_();

        internal static bool _Zaxis使能  = false ;
        internal static bool _Zaxis运动轴_使能= false  ;
     


        internal static QF_MainClass_26._软件授权_注册类型_ _软件注册类型 = QF_MainClass_26._软件授权_注册类型_.加密狗;
        internal static QF_MainClass_26._em_DogKeyType_ _加密狗类型 = QF_MainClass_26._em_DogKeyType_.TW_普通;
        /// <summary>
        /// 已经包含了 代理
        /// </summary>
        internal static string Dog功能 = $"";
        internal static QF_LaserMark_26._em_打标卡类型_ _打标卡类型 = QF_LaserMark_26._em_打标卡类型_.Ezd2;



    }
}
