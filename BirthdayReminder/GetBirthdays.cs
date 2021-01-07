using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace BirthdayReminder
{
    class GetBirthdays
    {        
        public static string GetBirthday()
        {
            string dbConnection = "Data Source=" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Calendar\data.db" + ";Version=3;";
            DateTime CurrentDate = DateTime.Now;

            List<string> currbirthday = new List<string>();
            string currbirthdays = null;

            using (SQLiteConnection c = new SQLiteConnection(dbConnection))
            {
                string query = "SELECT name, birthday FROM birthdays";
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, c))
                {
                    using (SQLiteDataReader read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            string date = Convert.ToDateTime(read.GetValue(read.GetOrdinal("birthday"))).ToString("MM-dd");
                            string currdate = CurrentDate.ToString("MM-dd");
                            
                            if (date == currdate)
                            {
                                currbirthday.Add(read.GetValue(read.GetOrdinal("name")).ToString());
                            }                            
                        }
                    }
                }
            }

            if (currbirthday.Count == 1)
            {
                return currbirthday[0];
            }

            else if (currbirthday.Count != 0)
            {
                for (int i = 0; i < currbirthday.Count - 1; i++) // Loop with for.
                {
                    currbirthdays += currbirthday[i] + ", ";
                }

                return currbirthdays.Remove(currbirthdays.Length - 2) + 
                    currbirthday[currbirthday.Count - 1].Replace(", ", "").Insert(0, " a ");
            }
            else
            {
                return " - ";
            }
        }
    }
}
