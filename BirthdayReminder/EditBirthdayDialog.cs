using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BirthdayReminder
{
    public partial class EditBirthdayDialog : Form
    {
        public static string type;

        public EditBirthdayDialog()
        {
            InitializeComponent();

            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Calendar\data.db";
            SQLiteConnection dbConnection = new SQLiteConnection("Data Source=" + path + ";Version=3;");
            dbConnection.Open();
            if (type == "Birthdays")
            {
                SQLiteCommand comm_birthdays = new SQLiteCommand("SELECT name,birthday FROM birthdays", dbConnection);
                using (SQLiteDataReader read = comm_birthdays.ExecuteReader())
                {
                    while (read.Read())
                    {
                        EditingDialog_DataView.Rows.Add(new object[] {
                        read.GetValue(read.GetOrdinal("name")),
                        //read.GetValue(read.GetOrdinal("birthday")),
                        Convert.ToDateTime(read.GetValue(read.GetOrdinal("birthday"))).ToString("d. M. yyyy"),
                        "Odstranit"
                    });
                    }
                }
            }
            else if (type == "Meniny")
            {
                birthday.HeaderText = "Meniny";
                SQLiteCommand comm_meniny = new SQLiteCommand("SELECT name FROM meniny", dbConnection);
                using (SQLiteDataReader read = comm_meniny.ExecuteReader())
                {
                    while (read.Read())
                    {
                        EditingDialog_DataView.Rows.Add(new object[] {
                        read.GetValue(read.GetOrdinal("name")),
                        //read.GetValue(read.GetOrdinal("birthday")),
                        GetMeniny.MeninyDate(read.GetValue(read.GetOrdinal("name")).ToString()).ToString("d. M."),
                        //Convert.ToDateTime(read.GetValue(read.GetOrdinal("birthday"))).ToString("d. M. yyyy"),
                        "Nuke this shit!"
                    });
                    }
                }
            }
            else
            {
                EditingDialog_DataView.Rows.Add(new object[] {
                "Něco se stalo :("
            });
                birthday.Visible = false;
                EditingDialog_Delete.Visible = false;
            }

        }

        private void EditingDialog_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditingDialog_DataView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex != -1)
            {
                string name = EditingDialog_DataView.Rows[EditingDialog_DataView.Rows[e.RowIndex].Index].Cells[0].Value.ToString();
                string date = Convert.ToDateTime(EditingDialog_DataView.Rows[EditingDialog_DataView.Rows[e.RowIndex].Index].Cells[1].Value.ToString()).ToString("yyyy-MM-dd");
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Calendar\data.db";
                SQLiteConnection dbConnection = new SQLiteConnection("Data Source=" + path + ";Version=3;");

                dbConnection.Open();
                if (type == "Birthdays")
                {
                    SQLiteCommand command = new SQLiteCommand("DELETE FROM birthdays WHERE name = '" + name + "' AND birthday = '" + date + "'", dbConnection);
                    command.ExecuteNonQuery();
                    EditingDialog_DataView.Rows.Remove(EditingDialog_DataView.Rows[e.RowIndex]);
                }
                else if (type == "Meniny")
                {
                    SQLiteCommand command = new SQLiteCommand("DELETE FROM meniny WHERE name = '" + name + "'", dbConnection);
                    command.ExecuteNonQuery();
                    EditingDialog_DataView.Rows.Remove(EditingDialog_DataView.Rows[e.RowIndex]);
                }
                else
                {
                    MessageBox.Show("Něco se stalo :(",
                     "Nespecifikovaná chyba při odstraňování", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }         
            }
        }
    }
}
