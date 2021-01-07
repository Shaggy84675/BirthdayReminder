namespace BirthdayReminder
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.CurrentDate = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Add_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddBirthday_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMeniny_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditBirthdays_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMeniny_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Settings_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ukončitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CurrentNarozeniny = new System.Windows.Forms.Label();
            this.CurrentMeniny = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.DebugText = new System.Windows.Forms.Label();
            this.DebugText2 = new System.Windows.Forms.Label();
            this.debugButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CurrentDate
            // 
            this.CurrentDate.AutoSize = true;
            this.CurrentDate.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.CurrentDate.Location = new System.Drawing.Point(12, 24);
            this.CurrentDate.Name = "CurrentDate";
            this.CurrentDate.Size = new System.Drawing.Size(288, 28);
            this.CurrentDate.TabIndex = 0;
            this.CurrentDate.Text = "Získávám aktuální datum a čas...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_ToolStripMenuItem,
            this.Edit_ToolStripMenuItem,
            this.Settings_ToolStripMenuItem,
            this.ukončitToolStripMenuItem,
            this.Exit_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(735, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Add_ToolStripMenuItem
            // 
            this.Add_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddBirthday_ToolStripMenuItem,
            this.AddMeniny_ToolStripMenuItem});
            this.Add_ToolStripMenuItem.Name = "Add_ToolStripMenuItem";
            this.Add_ToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.Add_ToolStripMenuItem.Text = "Přidat";
            // 
            // AddBirthday_ToolStripMenuItem
            // 
            this.AddBirthday_ToolStripMenuItem.Name = "AddBirthday_ToolStripMenuItem";
            this.AddBirthday_ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.AddBirthday_ToolStripMenuItem.Text = "Narozeniny";
            this.AddBirthday_ToolStripMenuItem.Click += new System.EventHandler(this.AddBirthday_ToolStripMenuItem_Click);
            // 
            // AddMeniny_ToolStripMenuItem
            // 
            this.AddMeniny_ToolStripMenuItem.Name = "AddMeniny_ToolStripMenuItem";
            this.AddMeniny_ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.AddMeniny_ToolStripMenuItem.Text = "Meniny";
            this.AddMeniny_ToolStripMenuItem.Click += new System.EventHandler(this.AddMeniny_ToolStripMenuItem_Click);
            // 
            // Edit_ToolStripMenuItem
            // 
            this.Edit_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditBirthdays_ToolStripMenuItem,
            this.EditMeniny_ToolStripMenuItem});
            this.Edit_ToolStripMenuItem.Name = "Edit_ToolStripMenuItem";
            this.Edit_ToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.Edit_ToolStripMenuItem.Text = "Správa";
            // 
            // EditBirthdays_ToolStripMenuItem
            // 
            this.EditBirthdays_ToolStripMenuItem.Name = "EditBirthdays_ToolStripMenuItem";
            this.EditBirthdays_ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.EditBirthdays_ToolStripMenuItem.Text = "Narozeniny";
            this.EditBirthdays_ToolStripMenuItem.Click += new System.EventHandler(this.EditBirthdays_ToolStripMenuItem_Click);
            // 
            // EditMeniny_ToolStripMenuItem
            // 
            this.EditMeniny_ToolStripMenuItem.Name = "EditMeniny_ToolStripMenuItem";
            this.EditMeniny_ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.EditMeniny_ToolStripMenuItem.Text = "Meniny";
            this.EditMeniny_ToolStripMenuItem.Click += new System.EventHandler(this.EditMeniny_ToolStripMenuItem_Click);
            // 
            // Settings_ToolStripMenuItem
            // 
            this.Settings_ToolStripMenuItem.Name = "Settings_ToolStripMenuItem";
            this.Settings_ToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.Settings_ToolStripMenuItem.Text = "Nastavení aplikace";
            this.Settings_ToolStripMenuItem.Click += new System.EventHandler(this.Settings_ToolStripMenuItem_Click);
            // 
            // ukončitToolStripMenuItem
            // 
            this.ukončitToolStripMenuItem.Name = "ukončitToolStripMenuItem";
            this.ukončitToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.ukončitToolStripMenuItem.Text = "O programu";
            this.ukončitToolStripMenuItem.Click += new System.EventHandler(this.About_ToolStripMenuItem_Click);
            // 
            // Exit_ToolStripMenuItem
            // 
            this.Exit_ToolStripMenuItem.Name = "Exit_ToolStripMenuItem";
            this.Exit_ToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.Exit_ToolStripMenuItem.Text = "Ukončit";
            this.Exit_ToolStripMenuItem.Click += new System.EventHandler(this.Exit_ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // CurrentNarozeniny
            // 
            this.CurrentNarozeniny.AutoSize = true;
            this.CurrentNarozeniny.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.CurrentNarozeniny.Location = new System.Drawing.Point(12, 80);
            this.CurrentNarozeniny.Name = "CurrentNarozeniny";
            this.CurrentNarozeniny.Size = new System.Drawing.Size(260, 28);
            this.CurrentNarozeniny.TabIndex = 2;
            this.CurrentNarozeniny.Text = "Načítám dnešní narozeniny...";
            // 
            // CurrentMeniny
            // 
            this.CurrentMeniny.AutoSize = true;
            this.CurrentMeniny.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.CurrentMeniny.Location = new System.Drawing.Point(12, 52);
            this.CurrentMeniny.Name = "CurrentMeniny";
            this.CurrentMeniny.Size = new System.Drawing.Size(228, 28);
            this.CurrentMeniny.TabIndex = 3;
            this.CurrentMeniny.Text = "Načítám dnešní meniny...";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Kalendář";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.NotifyIcon1_Click);
            // 
            // DebugText
            // 
            this.DebugText.AutoSize = true;
            this.DebugText.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.DebugText.Location = new System.Drawing.Point(361, 42);
            this.DebugText.Name = "DebugText";
            this.DebugText.Size = new System.Drawing.Size(117, 28);
            this.DebugText.TabIndex = 4;
            this.DebugText.Text = "DebugText...";
            // 
            // DebugText2
            // 
            this.DebugText2.AutoSize = true;
            this.DebugText2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.DebugText2.Location = new System.Drawing.Point(361, 70);
            this.DebugText2.Name = "DebugText2";
            this.DebugText2.Size = new System.Drawing.Size(128, 28);
            this.DebugText2.TabIndex = 5;
            this.DebugText2.Text = "DebugText2...";
            // 
            // debugButton
            // 
            this.debugButton.Location = new System.Drawing.Point(366, 102);
            this.debugButton.Name = "debugButton";
            this.debugButton.Size = new System.Drawing.Size(85, 23);
            this.debugButton.TabIndex = 6;
            this.debugButton.Text = "DebugButton";
            this.debugButton.UseVisualStyleBackColor = true;
            this.debugButton.Click += new System.EventHandler(this.DebugButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 135);
            this.Controls.Add(this.debugButton);
            this.Controls.Add(this.DebugText2);
            this.Controls.Add(this.DebugText);
            this.Controls.Add(this.CurrentMeniny);
            this.Controls.Add(this.CurrentNarozeniny);
            this.Controls.Add(this.CurrentDate);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Kalendář";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentDate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Add_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Edit_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Settings_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ukončitToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem Exit_ToolStripMenuItem;
        private System.Windows.Forms.Label CurrentNarozeniny;
        private System.Windows.Forms.Label CurrentMeniny;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label DebugText;
        private System.Windows.Forms.Label DebugText2;
        private System.Windows.Forms.Button debugButton;
        private System.Windows.Forms.ToolStripMenuItem AddBirthday_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddMeniny_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditBirthdays_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditMeniny_ToolStripMenuItem;
    }
}

