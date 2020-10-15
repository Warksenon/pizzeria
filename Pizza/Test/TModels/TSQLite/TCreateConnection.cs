using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizza;
using System.Data.SQLite;

namespace Test.TModels.TSQLite
{
    class TCreateConnection
    {
        public Name name = new Name();
        public const string folderDatabase = @"c:\SQLtest\Konsola\sqlite\";
        public const string databaseFile = "SqlLitePizzaTest.sqlite";
        public const string strConnection = @"Data Source=" + folderDatabase + databaseFile + ";Version=3;";

        public SQLiteConnection CreateSQLiteConnection()
        {

            SQLiteConnection cn = new SQLiteConnection(strConnection);
            return cn;
        }
    }
}
