using qfLanguage;
using qfmain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLMain
{
    internal class LanguageList
    {
        static string keys = "语言";
        static string 标题 = "标题";
        /// <summary>
        /// 语言包
        /// </summary>
        public   List<_language_Value_> lst_Language = new List<_language_Value_>()
        {
            new _language_Value_ ( 标题, "功能栏标题","AutoControl"),//主窗体功能栏标题内容       
            new _language_Value_ ( keys, "系统初始化中","系统初始化中"),

            new _language_Value_ ( keys, "系统报警","系统报警"),
            new _language_Value_ ( keys, "系统忙","系统忙"),
            new _language_Value_ ( keys, "是否关闭?","是否关闭?"),
            new _language_Value_ ( keys, "进入系统","进入系统"),
            new _language_Value_ ( keys, "关闭系统","关闭系统"),
            new _language_Value_ ( keys, "系统检测到加密狗拔出","系统检测到加密狗拔出"),
            new _language_Value_ ( keys, "系统检测到加密狗插入,请重启软件","系统检测到加密狗插入,请重启软件"),
            new _language_Value_ ( keys, "系统检测到加密狗插入,无需重启软件","系统检测到加密狗插入,无需重启软件"),
            new _language_Value_ ( keys, "启动自检","启动自检"),
           
            new _language_Value_ ( keys, "用户登陆","用户登陆"),
            new _language_Value_ ( keys, "开发者","开发者"),
            new _language_Value_ ( keys, "超级管理员","超级管理员"),
            new _language_Value_ ( keys, "管理员","管理员"),
            new _language_Value_ ( keys, "技术员","技术员"),
            new _language_Value_ ( keys, "操作员","操作员"),
            new _language_Value_ ( keys, "良品","良品"),
            new _language_Value_ ( keys, "不良品","不良品"),
            new _language_Value_ ( keys, "零件","零件"),

            new _language_Value_ ( keys, "控制器","控制器"),
            new _language_Value_ ( keys, "已连接","已连接"),
            new _language_Value_ ( keys, "未连接","未连接"),
            new _language_Value_ ( keys, "连接中","连接中"),
            new _language_Value_ ( keys, "硬件不匹配","硬件不匹配"),
            new _language_Value_ ( keys, "Z控制器相关的文件丢失","Z控制器相关的文件丢失"),
            new _language_Value_ ( keys, "加工中","加工中"),

            new _language_Value_ ( keys, "系统","系统"),
            new _language_Value_ ( keys, "语言","语言"),
            new _language_Value_ ( keys, "注册","注册"),
            new _language_Value_ ( keys, "退出","退出"),

            new _language_Value_ ( keys, "用户","用户"),
            new _language_Value_ ( keys, "管理","管理"),
            new _language_Value_ ( keys, "切换","切换"),
            new _language_Value_ ( keys, "打标卡","打标卡"),
            new _language_Value_ ( keys, "激光","激光"),
            new _language_Value_ ( keys, "打开","打开"),
            new _language_Value_ ( keys, "调试","调试"),
            new _language_Value_ ( keys, "红光","红光"),
            new _language_Value_ ( keys, "加工","加工"),
            new _language_Value_ ( keys, "停止","停止"),
            new _language_Value_ ( keys, "左边","左边"),
            new _language_Value_ ( keys, "右边","右边"),
            new _language_Value_ ( keys, "日志栏","日志栏"),
            new _language_Value_ ( keys, "开始出激光标刻","开始出激光标刻"),
            new _language_Value_ ( keys, "出激光标刻结束","出激光标刻结束"),
            new _language_Value_ ( keys, "停止加工","停止加工"),
            new _language_Value_ ( keys, "出激光标刻","出激光标刻"),
            new _language_Value_ ( keys, "加工结束","加工结束"),
            new _language_Value_ ( keys, "耗时","耗时"),
            new _language_Value_ ( keys, "IO输出","IO输出"),
            new _language_Value_ ( keys, "IO报警输出","IO报警输出"),
            new _language_Value_ ( keys, "激光模板","激光模板"),
            new _language_Value_ ( keys, "手动,启动加工","手动,启动加工"),
            new _language_Value_ ( keys, "IO触发,启动加工","IO触发,启动加工"),
            new _language_Value_ ( keys, "手动,复位","手动,复位"),
            new _language_Value_ ( keys, "IO触发,复位","IO触发,复位"),
            new _language_Value_ ( keys, "手动,停止","手动,停止"),
            new _language_Value_ ( keys, "IO触发,停止","IO触发,停止"),
            new _language_Value_ ( keys, "进入激光调试窗体","进入激光调试窗体"),
            new _language_Value_ ( keys, "关闭激光调试窗体","关闭激光调试窗体"),
            new _language_Value_ ( keys, "打开激光编辑软件","打开激光编辑软件"),

        };

    }
}
