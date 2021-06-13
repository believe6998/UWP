using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLitePCL;
using System.IO;
using Windows.Storage;

namespace assigment.Adapters
{
    class SQLiteHelper
    {
        private readonly string _dbName = "undefined_team";

        private static SQLiteHelper _sQLiteHelper;

        public static SQLiteHelper GetInstance()
        {
            return _sQLiteHelper ?? (_sQLiteHelper = new SQLiteHelper());
        }

        private SQLiteHelper()
        {
            string path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, _dbName);
            SQLiteConnection = new SQLiteConnection(path); // tao db - để tên db cũng được
            CreateCartTable();
        }

        public SQLiteConnection SQLiteConnection { get; private set; }

        public void CreateCartTable() // tao bang cart
        {
            var sql_txt = @"CREATE TABLE IF NOT EXISTS Cart(id integer primary key, name varchar(200), image varchar(200), price integer, qty integer)";
            var statement = SQLiteConnection.Prepare(sql_txt);
            statement.Step();
        }
    }

}
