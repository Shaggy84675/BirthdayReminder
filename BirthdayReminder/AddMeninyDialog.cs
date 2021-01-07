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
    public partial class AddMeninyDialog : Form
    {
        public AddMeninyDialog()
        {
            InitializeComponent();
            BindingSource source = new BindingSource();
            source.DataSource = SeznamMenin.meno.Values;
            AddMeninyDialog_name.DataSource = source;
        }

        private void AddDialog_Save_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Calendar\data.db";
            SQLiteConnection dbConnection = new SQLiteConnection("Data Source=" + path + ";Version=3;");
            dbConnection.Open();

            string name = AddMeninyDialog_name.Text;

            string query = "SELECT COUNT(*) FROM meniny WHERE name = '" + name + "'";
            SQLiteCommand command = new SQLiteCommand(query, dbConnection);
            int count = Convert.ToInt32(command.ExecuteScalar());
            if (count == 0)
            {
                if (name != "")
                {
                    command.CommandText = "INSERT INTO meniny (id, name, added) VALUES (NULL, '" + name + "', '" + DateTime.Now + "')";
                    command.ExecuteNonQuery();

                    MessageBox.Show("Záznam menin byl úspěšně vytvořen", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddMeninyDialog_name.Text = "";
                }
                /*else
                {
                    MessageBox.Show("Nelze vytvořit záznam, pokud není vyplněné jméno", "Chyba - Neznámé jméno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/

            }
            else
            {
                MessageBox.Show("Přidaný záznam již existuje", "Chyba - Existující záznam", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AddDialog_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
