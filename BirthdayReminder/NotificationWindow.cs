using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirthdayReminder
{
    public partial class NotificationWindow : Form
    {
        Timer t1 = new Timer();
        Timer t2 = new Timer();
        public int delay;
        private bool fadeOut = false;

        public NotificationWindow()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            var screen = Screen.FromPoint(this.Location);
            this.Location = new Point(screen.WorkingArea.Right - this.Width - 10, screen.WorkingArea.Bottom - this.Height - 10);
            base.OnLoad(e);
            birthdayNames.Text = GetBirthdays.GetBirthday();
        }

        private void NotificationWindow_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            t1.Interval = 10;
            t1.Tick += new EventHandler(Show_Notification);
            t1.Start();
        }

        private async void Show_Notification(object sender, EventArgs e)
        {
            if (!fadeOut)
            {
                if (this.Opacity <= 0.8)
                {
                    this.Opacity += 0.005;
                }
                else
                {
                    t1.Stop();
                    await Task.Delay(delay);
                    t2.Interval = 10;
                    t2.Tick += new EventHandler(Hide_Notification);                    
                    t2.Start();
                }
            }
            else
            {
                if (this.Opacity >= 0)
                {
                    this.Opacity -= 0.005;
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void Hide_Notification(object sender, EventArgs e)
        {
            fadeOut = true;
            t2.Stop();
            t1.Start();
        }

        private void NotificationWindow_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NotificationWindow_MouseHover(object sender, EventArgs e)
        {
            //this.Opacity = 1;
        }
    }
}
