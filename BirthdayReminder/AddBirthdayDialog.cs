using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace BirthdayReminder
{
    public partial class AddBirthdayDialog : Form
    {
        public AddBirthdayDialog()
        {
            InitializeComponent();
        }

        private void AddDialog_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddDialog_Save_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Calendar\data.db";
            SQLiteConnection dbConnection = new SQLiteConnection("Data Source=" + path + ";Version=3;");
            dbConnection.Open();
            string name = AddDialog_name.Text;
            string date = AddDialog_date.Value.ToString("yyyy-MM-dd");


            string query = "SELECT COUNT(*) FROM birthdays WHERE name = '" + name + "' AND birthday = '" + date + "'";
            SQLiteCommand command = new SQLiteCommand(query, dbConnection);
            int count = Convert.ToInt32(command.ExecuteScalar());
            if (count == 0)
            {
                if (name != "")
                {
                    command.CommandText = "INSERT INTO birthdays (id, name, birthday, added) VALUES (NULL, '" + name + "', '" + date + "', '" + DateTime.Now + "')";
                    command.ExecuteNonQuery();

                    MessageBox.Show("Záznam narozenin byl úspěšně vytvořen", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddDialog_name.Text = "";
                }
                else
                {
                    MessageBox.Show("Nelze vytvořit záznam, pokud není vyplněné jméno", "Chyba - Neznámé jméno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Přidaný záznam již existuje", "Chyba - Existující záznam", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
