namespace BirthdayReminder
{
    partial class SettingsDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.notifyTime = new System.Windows.Forms.DateTimePicker();
            this.notifyDelay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SettingsDialog_Save = new System.Windows.Forms.Button();
            this.SettingsDialog_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nastavení času pro zobrazení notifikací:";
            // 
            // notifyTime
            // 
            this.notifyTime.CustomFormat = "H:mm";
            this.notifyTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.notifyTime.Location = new System.Drawing.Point(285, 12);
            this.notifyTime.Name = "notifyTime";
            this.notifyTime.ShowUpDown = true;
            this.notifyTime.Size = new System.Drawing.Size(200, 20);
            this.notifyTime.TabIndex = 1;
            // 
            // notifyDelay
            // 
            this.notifyDelay.Location = new System.Drawing.Point(285, 38);
            this.notifyDelay.Name = "notifyDelay";
            this.notifyDelay.Size = new System.Drawing.Size(91, 20);
            this.notifyDelay.TabIndex = 2;
            this.notifyDelay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.notifyDelay_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nastavení času zobrazené notifikace:";
            // 
            // SettingsDialog_Save
            // 
            this.SettingsDialog_Save.Location = new System.Drawing.Point(329, 64);
            this.SettingsDialog_Save.Name = "SettingsDialog_Save";
            this.SettingsDialog_Save.Size = new System.Drawing.Size(75, 23);
            this.SettingsDialog_Save.TabIndex = 4;
            this.SettingsDialog_Save.Text = "Uložit";
            this.SettingsDialog_Save.UseVisualStyleBackColor = true;
            this.SettingsDialog_Save.Click += new System.EventHandler(this.SettingsDialog_Save_Click);
            // 
            // SettingsDialog_Cancel
            // 
            this.SettingsDialog_Cancel.Location = new System.Drawing.Point(410, 64);
            this.SettingsDialog_Cancel.Name = "SettingsDialog_Cancel";
            this.SettingsDialog_Cancel.Size = new System.Drawing.Size(75, 23);
            this.SettingsDialog_Cancel.TabIndex = 5;
            this.SettingsDialog_Cancel.Text = "Zavřít";
            this.SettingsDialog_Cancel.UseVisualStyleBackColor = true;
            this.SettingsDialog_Cancel.Click += new System.EventHandler(this.SettingsDialog_Cancel_Click);
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 94);
            this.Controls.Add(this.SettingsDialog_Cancel);
            this.Controls.Add(this.SettingsDialog_Save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.notifyDelay);
            this.Controls.Add(this.notifyTime);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Nastavení aplikace";
            this.Load += new System.EventHandler(this.SettingsDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker notifyTime;
        private System.Windows.Forms.TextBox notifyDelay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SettingsDialog_Save;
        private System.Windows.Forms.Button SettingsDialog_Cancel;
    }
}