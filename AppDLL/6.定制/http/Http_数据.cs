using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDLL  
{
    internal class Http_数据
    {
        public class _请求_
        {
            /// <summary>
            /// 流转卡号,工单号
            /// </summary>
            public string MachiningId { set; get; } = "";
        }


        public class _反馈_
        {
            /// <summary>
            /// 请求接口成功标记
            /// </summary>
            public bool success { set; get; } = false;

            /// <summary>
            /// 接口请求成功编码,0代码成功
            /// </summary>
            public int code { set; get; } = -1;

            /// <summary>
            /// 描述,消息
            /// </summary>
            public string msg { set; get; } = "";

            public _values_ result { set; get; } = new _values_();


        }

        public class _values_
        {

            /// <summary>
            /// 流转卡号
            /// </summary>
            public string MachiningId { set; get; } = "";

            /// <summary>
            /// 产品型号
            /// </summary>
            public string ProductName { set; get; } = "";

            /// <summary>
            /// Bom版本号
            /// </summary>
            public string BomVersion { set; get; } = "";

            /// <summary>
            /// 工单数量,也就是最大序列号
            /// </summary>
            public int Qty { set; get; } = 0;



            ///// <summary>
            ///// 第一行内容
            ///// </summary>
            //public string Line1 { set; get; } = "";
            ///// <summary>
            ///// 第二行内容
            ///// </summary>
            //public string Line2 { set; get; } = "";
            ///// <summary>
            ///// 第三行内容,没有数据不返回
            ///// </summary>
            //public string Line3 { set; get; } = "";
            ///// <summary>
            ///// 第四行内容,没有数据不返回
            ///// </summary>
            //public string Line4 { set; get; } = "";



        }

    }
}
