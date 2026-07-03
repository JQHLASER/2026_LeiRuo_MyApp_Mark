using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AppDLL
{
    public class 表
    {
        public class Sn
        {
            [SugarColumn(IsPrimaryKey = true )]//主键
            public string 工单 { set; get; }
            public string 序列号 { set; get; }

        }
    }
}
