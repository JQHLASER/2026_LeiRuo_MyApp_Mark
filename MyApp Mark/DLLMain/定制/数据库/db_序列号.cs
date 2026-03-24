using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace DLLMain
{
    internal class db_序列号
    {
        static string path = qfmain.软件类.Files_Cfg.Files_Config + "\\Sn.db";
        static string _id = "Sn";
        internal static qfmain._连接状态_ _连接状态 = qfmain._连接状态_.未连接;
        static qfSqlSugar.SqlSugar_DB _Db;

        internal static void 初始化()
        {
            _连接状态 = qfmain._连接状态_.连接中;
            窗体标题栏();
            qfSqlSugar.SqlSugar_DB_封装.Event_ConnectionConfig += (s, e) =>
            {
                _Db = e;
                string sql = e.生成连接字符串(new qfSqlSugar._cfg_SQLite_(path), qfSqlSugar._SQLite_连接类型_.V2);
                var connent = e.生成连接信息(sql, _id, SqlSugar.DbType.Sqlite);
                s.Add(connent);
            };

            qfSqlSugar.SqlSugar_DB_封装.Event_初始化结束 += (s, m, e) =>
            {
                if (!s)
                {
                    _连接状态 = qfmain._连接状态_.未连接;
                    窗体标题栏();
                    Log.Add(s, $"序列号模块,Err,{m}");
                    return;
                }
                var rt = Get_查询("^%%^%^%^");
                string show = rt.s ? $"序列号模块,已初始化" : $"序列号模块,未初始化,{rt.m}";
                Log.Add(rt.s, show);
                if (rt.s)
                {
                    Event_初始化成功?.Invoke();
                }
                _连接状态 = rt.s ? qfmain._连接状态_.已连接 : qfmain._连接状态_.未连接; 
                窗体标题栏();
            };

        }

        internal static (bool s, string m, string Sn, List<表.Sn> lst) Get_查询(string 工单号)
        {
            using (var db = new qfSqlSugar.SqlSugar_GetDB(_Db, _id))
            {
                using (var table = new qfSqlSugar.SqlSugar_Table<表.Sn>(db.Db))
                {
                    bool rt = table.GetList(user => user.工单 == 工单号, out List<表.Sn> lst, out string msgErr);
                    string Sn = "001";
                    if (rt && lst.Count > 0)
                    {
                        Sn = lst[0].序列号;
                    }
                    return (rt, msgErr, Sn, lst);
                }
            }
        }

        /// <summary>
        /// 添加/修改
        /// </summary> 
        internal static (bool s, string m) Add(表.Sn value)
        {
            using (var db = new qfSqlSugar.SqlSugar_GetDB(_Db, _id))
            {
                using (var table = new qfSqlSugar.SqlSugar_Table<表.Sn>(db.Db))
                {
                    bool rt = table.Storageable(value, out int count, out string msgErr);
                    if (rt && count == 0)
                    {
                        msgErr = $"序列号模块,存储失败,受影响0行";
                        rt = false;
                    }
                    else if (rt && count > 0)
                    {
                        msgErr = $"序列号模块,存储成功";
                    }

                    return (rt, msgErr);
                }
            }
        }


        internal static event Action Event_初始化成功;

        static void 窗体标题栏()
        {
            new qfNet.窗体_标题栏状态_方法().标题栏状态(窗体标题栏状态._标题栏状态, "序列号模块", "序列号模块", _连接状态);
        }
    }
}
