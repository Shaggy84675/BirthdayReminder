using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace BirthdayReminder
{
    public partial class MainWindow : Form
    {
        private string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Calendar\data.db";
        private bool isRunning;
        AboutDialog about = new AboutDialog();
        NotificationWindow notifywindow;
        SettingsDialog settingwindow;

        public MainWindow()
        {
            InitializeComponent();

            this.Text += " v" + GetVersion();

            //Debug components
            this.DebugText.Visible = false;
            this.DebugText2.Visible = false;
            this.debugButton.Visible = false;

            if (!File.Exists("System.Data.SQLite.dll"))
            {
                MessageBox.Show("Nebyl nalezen potřebný soubor System.Data.SQLite.dll",
                     "Nebyl nalezen potřebný soubor", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Environment.Exit(0);
            }

            timer1 = new System.Windows.Forms.Timer()
            {
                Interval = 500
            };
            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Start();
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
            }
        }

        private void NotifyIcon1_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            CurrentDate.Text = "Dnes je: " + DateTime.Now.ToString();
            CurrentMeniny.Text = "Dnes má meniny: " + SeznamMenin.DnesniMeniny();
            CurrentNarozeniny.Text = "Dnes má narozeniny: " + GetBirthdays.GetBirthday();

            settingwindow = new SettingsDialog();
            notifywindow = new NotificationWindow();

            if (DateTime.Now.Hour == settingwindow.notifytime.Hour &&
                DateTime.Now.Minute == settingwindow.notifytime.Minute &&
                DateTime.Now.Second == settingwindow.notifytime.Second &&
                IsFormOpened(notifywindow) == false && GetBirthdays.GetBirthday() != " - ")
            {                
                notifywindow.delay = Convert.ToInt16(settingwindow.notifydelay);
                notifywindow.Show();
            }
        }

        private void AddBirthday_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBirthdayDialog Dialog = new AddBirthdayDialog()
            {
                Text = "Přidat narozeniny"
            };
            Dialog.Show();
        }

        private void Exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EditBirthdays_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBirthdayDialog.type = "Birthdays";
            EditBirthdayDialog Dialog = new EditBirthdayDialog();
            Dialog.Show();
        }

        private void EditMeniny_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBirthdayDialog.type = "Meniny";
            EditBirthdayDialog Dialog = new EditBirthdayDialog();
            Dialog.Show();
        }

        private void About_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutDialog Dialog = new AboutDialog();
            Dialog.Show();
        }

        private void Settings_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsDialog Dialog = new SettingsDialog();
            Dialog.Show();
        }

        private string GetVersion()
        {
            string[] version = about.AssemblyVersion.Split('.');

            return version[0] + "." + version[1] + (version[2] != "0" ? "." + version[2] : "") +
                (version[3] == "1" ? " Beta" : "");
        }

        private bool IsFormOpened(Form form)
        {
            form = Application.OpenForms[form.Text];
            if (form != null)
                return true;
            else
                return false;
        }

        private void DebugButton_Click(object sender, EventArgs e)
        {
            /*notifywindow = new NotificationWindow();
            notifywindow.delay = Convert.ToInt16(settingwindow.notifydelay);
            notifywindow.Show();*/
            MessageBox.Show(GetMeniny.MeninyDate("Alexandra").ToString());
        }

        private void AddMeniny_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMeninyDialog Dialog = new AddMeninyDialog()
            {
                Text = "Přidat narozeniny"
            };
            Dialog.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
