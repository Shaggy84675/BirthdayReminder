using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace BirthdayReminder
{
    public class InitialConfig
    {
        string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Calendar";
        string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();

        public void Create()
        {
            if (IfMainDirExist() == false)
            {
                Directory.CreateDirectory(path);
            }

            if (IfMainFileExist() == false)
            {
                SQLiteConnection.CreateFile(path + @"\data.db");
            }
        }

        public void SQLCreate()
        {
            using (SQLiteConnection dbConnection = new SQLiteConnection("Data Source=" + path + @"\data.db;Version=3;"))

            using (SQLiteCommand query = dbConnection.CreateCommand())
            {
                dbConnection.Open();

                if (IsTableExists(dbConnection, "birthdays") == false)
                {
                    query.CommandText = "CREATE TABLE birthdays (id INTEGER PRIMARY KEY AUTOINCREMENT, name VARCHAR(30), birthday DATE, added DATETIME)";
                    query.ExecuteNonQuery();
                }

                if (IsTableExists(dbConnection, "meniny") == false)
                {
                    query.CommandText = "CREATE TABLE meniny (id INTEGER PRIMARY KEY AUTOINCREMENT, name VARCHAR(30), added DATETIME)";
                    query.ExecuteNonQuery();
                }

                if (IsTableExists(dbConnection, "settings") == false)
                {
                    query.CommandText = "CREATE TABLE settings (id INTEGER PRIMARY KEY AUTOINCREMENT, notifytime DATETIME, notifydelay INT)";
                    query.ExecuteNonQuery();
                    query.CommandText = "INSERT INTO settings (notifytime, notifydelay) VALUES ('" + DateTime.Now.ToString("HH:mm") + "', 3000)";
                    query.ExecuteNonQuery();
                }

                if (IsColumnExists(dbConnection, "settings", "config_version") == false)
                {
                    query.CommandText = "ALTER TABLE settings ADD COLUMN config_version VARCHAR(10)";
                    query.ExecuteNonQuery();
                }

                query.CommandText = "UPDATE settings SET config_version = '" + version + "' WHERE id = 1";
                query.ExecuteNonQuery();

                dbConnection.Close();
            }
        }

        public static bool IsTableExists(SQLiteConnection conn, string table_name)
        {
            return conn.GetSchema("Tables").Select("Table_Name = '" + table_name + "'").Length > 0;
        }

        public static bool IsColumnExists(SQLiteConnection conn, string table_name, string column_name)
        {
            return conn.GetSchema("Columns").Select("Table_Name = '" + table_name + "' AND Column_Name = '" + column_name + "'").Length > 0;
        }

        public bool IfMainDirExist()
        {
            if (Directory.Exists(path))
            {
                return true;
            }
            return false;
        }

        public bool IfMainFileExist()
        {
            if (File.Exists(path + @"\data.db"))
            {
                return true;
            }
            return false;
        }

        /*private string GetVersion()
        {
            AboutDialog about = new AboutDialog();
            string[] version = about.AssemblyVersion.Split('.');

            return version[0] + "." + version[1] + "." + version[2] + "." + version[3] == "1" ? " Beta" : "";
        }*/
    }
}
