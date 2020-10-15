using System;

using System.IO;
using System.Collections.Generic;
using System.Data;
using Pizza;
using System.Data.SQLite;

namespace Test.TModels.TSQLite
{
    class TCreateTabeles : TCreateConnection
    {
        public void CreateSQLiteTables()
        {
            CreateSQLiteDatabaseFile();
            CreateSQLitePriceAll(CreateSQLiteConnection());
            CreateSQLiteDishes(CreateSQLiteConnection());
        }

        private void CreateSQLiteDatabaseFile()
        {
            DirectoryInfo di = new DirectoryInfo(folderDatabase);
            if (!di.Exists)
            {
                try
                {
                    di.Create();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Błąd programu podczas tworzenia folderu\n" + ex);
                }
            }

            FileInfo fi = new FileInfo(folderDatabase + databaseFile);

            if (!fi.Exists)
            {
                SQLiteConnection.CreateFile(folderDatabase + databaseFile);
                Console.WriteLine("Utworzono bazę danych", "Informacja");
            }
            else
            {
                Console.WriteLine("Istnieje już plik bazy danych", "Informacja");
            }
        }

        private void CreateSQLitePriceAll(SQLiteConnection cn)
        {
            using (cn)
            {
                string sql = "CREATE TABLE '" + name.PriceAll + "'('id' INTEGER PRIMARY KEY , '" + name.Price + "' TEXT, '" + name.Date + "' TEXT, '" + name.Comments + "' TEXT);";
                try
                {
                    cn.Open();
                    SQLiteCommand cmd = new SQLiteCommand(sql, cn);
                    cmd.ExecuteNonQuery();
                    cmd.Cancel();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Nie utworzono tabeli danych \n" + e);
                }
                cn.Close();
            }
        }

        private void CreateSQLiteDishes(SQLiteConnection cn)
        {
            using (cn)
            {
                string sql2 = "CREATE TABLE '" + name.Dishes + "'('id' INTEGER PRIMARY KEY,'" + name.IdPrice + "' int, '" + name.Dish + "' TEXT ,'" + name.Price + "' TEXT,'" + name.SidesDishes + "' );";
                try
                {
                    cn.Open();
                    SQLiteCommand cmd = new SQLiteCommand(sql2, cn);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Utworzono tabelę 2 w bazie danych", "Informacja");
                }
                catch (Exception e)
                {
                    Console.WriteLine("nie utowrzono 2 bazy danych\n" + e);
                }
                cn.Close();
            }
        }
    }
}
