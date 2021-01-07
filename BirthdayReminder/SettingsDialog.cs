using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirthdayReminder
{
    public partial class SettingsDialog : Form
    {
        string dbConnection = "Data Source=" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Calendar\data.db" + ";Version=3;";
        public DateTime notifytime;
        public string notifydelay;

        public SettingsDialog()
        {
            InitializeComponent();

            using (SQLiteConnection c = new SQLiteConnection(dbConnection))
            {
                c.Open();
                string query = "SELECT notifytime, notifydelay FROM settings";
                using (SQLiteCommand cmd = new SQLiteCommand(query, c))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            notifytime = DateTime.Parse(reader["notifytime"].ToString());
                            notifydelay = reader["notifydelay"].ToString();
                        }
                    }
                }
            }
        }

        private void notifyDelay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void SettingsDialog_Load(object sender, EventArgs e)
        {
            notifyTime.Value = notifytime;
            notifyDelay.Text = notifydelay;
        }

        private void SettingsDialog_Save_Click(object sender, EventArgs e)
        {
            if (notifyDelay.Text != "")
            {
                using (SQLiteConnection c = new SQLiteConnection(dbConnection))
                {
                    c.Open();
                    string command = "UPDATE settings SET notifytime = '" + notifyTime.Value.ToString("HH:mm") + "', notifydelay = '" + notifyDelay.Text + "' WHERE id=1";
                    using (SQLiteCommand cmd = new SQLiteCommand(command, c))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                
                MessageBox.Show("Nastavení dat bylo úspěšně aktualizováno", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nelze uložit nastavení, jelikož nejsou vyplněna všechna pole!", "Chyba - Neznámá data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SettingsDialog_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
