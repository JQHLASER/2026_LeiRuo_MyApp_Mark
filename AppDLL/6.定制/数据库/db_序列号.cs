using AppDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace DLLMain
{
    internal class db_序列号
    {
        static string path = QF_MainClass_26.软件类.Files_Cfg.Files_Config + "\\Sn.db";
        static string _id = "Sn";
        internal static QF_MainClass_26._连接状态_ _连接状态 = QF_MainClass_26._连接状态_.未连接;
        static QF_SqlSugar_26.SqlSugar_DB _Db;
        static QF_SqlSugar_26.SqlSugar_DB_Table<表.Sn> db_sys = new QF_SqlSugar_26.SqlSugar_DB_Table<表.Sn>();
        internal static void 初始化()
        {

            标题栏(QF_MainClass_26._连接状态_.连接中);
            QF_SqlSugar_26.SqlSugar_DB_封装.Event_ConnectionConfig += (s, e) =>
            {
                _Db = e;
                string sql = e.生成连接字符串(new QF_SqlSugar_26._cfg_SQLite_(path), QF_SqlSugar_26._SQLite_连接类型_.V2);
                var connent = e.生成连接信息(sql, _id, SqlSugar.DbType.Sqlite);
                s.Add(connent);
            };

            QF_SqlSugar_26.SqlSugar_DB_封装.Event_初始化结束 += async (s, m, e) =>
            {
                if (!s)
                {
                    标题栏(QF_MainClass_26._连接状态_.未连接);
                    Log.Add(s, $"序列号模块,Err,{m}");
                    return;
                }
                await Task.Run(() =>
                 {
                     e.优化数据库(_id);
                     var rt = Get_查询("^%%^%^%^");
                     string show = rt.s ? $"序列号模块,已初始化" : $"序列号模块,未初始化,{rt.m}";
                     Log.Add(rt.s, show);


                     var status = rt.s ? QF_MainClass_26._连接状态_.已连接 : QF_MainClass_26._连接状态_.未连接;
                     标题栏(status);

                     if (rt.s)
                     {
                         Event_初始化成功?.Invoke();
                     }


                 });
            };

        }

        internal static (bool s, string m, string Sn, 表.Sn cfg) Get_查询(string 工单号)
        {
            List<表.Sn> lst = new List<表.Sn>();
            表.Sn cfg = new 表.Sn();
            var rtGet = db_sys.Get_DB_Table(_id, (db, table) =>
                 {
                     bool rt = table.GetList(user => user.工单 == 工单号, out lst, out string msgErr);
                     string Sn = "001";
                     if (rt && lst.Count > 0)
                     {
                         Sn = lst[0].序列号;
                     }
                     return (rt, msgErr, Sn, lst);
                 });

            if (lst.Count > 0)
                cfg = lst[0];

            return (rtGet.rt, rtGet.msgErr, rtGet.Sn, cfg);
        }


        static private readonly object _lockAdd = new object();

        /// <summary>
        /// 添加/修改
        /// </summary> 
        internal static (bool s, string m) Add(表.Sn value)
        {
            lock (_lockAdd)
            {
                var rtDB = db_sys.Get_DB_Table(_id, (db, table) =>
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
                });

                return rtDB;
            }
        }


        internal static event Action Event_初始化成功;
        static QF_WinForm_26.窗体_标题栏状态_方法 title_sys = new QF_WinForm_26.窗体_标题栏状态_方法();
        static void 标题栏(QF_MainClass_26._连接状态_ state)
        {
            _连接状态 = state;
            title_sys.设置标题栏状态(窗体标题栏._标题栏状态, "序列号模块", "序列号模块", _连接状态);
        }

    }
}
