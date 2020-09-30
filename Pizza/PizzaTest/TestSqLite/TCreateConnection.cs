using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizza;
using static System.Net.Mime.MediaTypeNames;

namespace PizzaTest
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
