using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLMain
{
    internal class Db
    {
        public Db()
        {
            db_序列号.初始化(); 
            qfSqlSugar.SqlSugar_DB_封装.初始化( 10 * 1000);
             
        }
         
    }
}
