
using QF_MainClass_26;
using QF_WinForm_26;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDLL
{
    internal class LanguageList
    {
        static string keys = "Main";
        static string 标题 = "Title";
        /// <summary>
        /// 语言包
        /// </summary>
        public static List<_language_Value_> lst_Language = new List<_language_Value_>()
        {
            new _language_Value_ ( 标题, "功能栏标题",""),//主窗体功能栏标题内容   
            new _language_Value_ ( keys, "进入系统","进入系统"),
            new _language_Value_ ( keys, "关闭系统","关闭系统"),
            new _language_Value_ ( keys, "系统初始化中","系统初始化中"),
            new _language_Value_ ( keys, "是否关闭","是否关闭"),
            new _language_Value_ ( keys, "用户登陆","用户登陆"),

            new _language_Value_ ( keys, "系统","系统"),
            new _language_Value_ ( keys, "关闭","关闭"),
            new _language_Value_ ( keys, "注册","注册"),
            new _language_Value_ ( keys, "语言","语言"),

            new _language_Value_ ( keys, "用户","用户"),
            new _language_Value_ ( keys, "管理","管理"),
            new _language_Value_ ( keys, "切换","切换"),

            new _language_Value_ ( keys, "加工中","加工中"),
            new _language_Value_ ( keys, "加工结束","加工结束"),
            new _language_Value_ ( keys, "耗时","耗时"),
            new _language_Value_ ( keys, "控制器","控制器"),
            new _language_Value_ ( keys, "已连接","已连接"),
            new _language_Value_ ( keys, "硬件不匹配","硬件不匹配"),
            new _language_Value_ ( keys, "IO报警输出","IO报警输出"),
            
            new _language_Value_ ( keys, "激光","激光"),
            new _language_Value_ ( keys, "打标卡","打标卡"),
            new _language_Value_ ( keys, "停止加工","停止加工"),
            new _language_Value_ ( keys, "出激光标刻开始","出激光标刻开始"),
            new _language_Value_ ( keys, "出激光标刻结束","出激光标刻结束"),
            new _language_Value_ ( keys, "IO触发,启动加工","IO触发,启动加工"),
            new _language_Value_ ( keys, "IO触发,复位","IO触发,复位"),
            new _language_Value_ ( keys, "IO触发,停止","IO触发,停止"),
            new _language_Value_ ( keys, "激光模板","激光模板"),

            new _language_Value_ ( keys, "出激光标刻中","出激光标刻中"),
            new _language_Value_ ( keys, "加工中","加工中"),
            new _language_Value_ ( keys, "加载激光模板中","加载激光模板中"),
            new _language_Value_ ( keys, "红光指示光中","红光指示光中"),

            new _language_Value_ ( keys, "打开","打开"),
            new _language_Value_ ( keys, "复位","复位"),
            new _language_Value_ ( keys, "调试","调试"),
            new _language_Value_ ( keys, "加工","加工"),
            new _language_Value_ ( keys, "红光","红光"),
            new _language_Value_ ( keys, "停止","停止"),

            new _language_Value_ ( keys, "打开激光编辑软件","打开激光编辑软件"),
            new _language_Value_ ( keys, "手动,复位","手动,复位"),
            new _language_Value_ ( keys, "进入激光调试窗体","进入激光调试窗体"),
            new _language_Value_ ( keys, "关闭激光调试窗体","关闭激光调试窗体"),

            new _language_Value_ ( keys, "未初始化","未初始化"),
            new _language_Value_ ( keys, "IO输出","IO输出"),
            new _language_Value_ ( keys, "IO报警输出","IO报警输出"),
            new _language_Value_ ( keys, "设置","设置"),
            new _language_Value_ ( keys, "生产计数清零","生产计数清零"),
            new _language_Value_ ( keys, "关于","关于"),

            new _language_Value_ ( keys, "控制器","控制器"),
            new _language_Value_ ( keys, "IO查看","IO查看"),
            new _language_Value_ ( keys, "轴参数","轴参数"),
            new _language_Value_ ( keys, "运动中","运动中"),
            new _language_Value_ ( keys, "未回零","未回零"),
            new _language_Value_ ( keys, "轴回零","轴回零"),
            new _language_Value_ ( keys, "轴回零结束","轴回零结束"),
      
            






        };

    }
}
