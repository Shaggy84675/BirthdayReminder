namespace BirthdayReminder
{
    partial class NotificationWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.NotificationWindow_Close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.birthdayNames = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.meninyName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(178)))), ((int)(((byte)(234)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kalendář";
            // 
            // NotificationWindow_Close
            // 
            this.NotificationWindow_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.NotificationWindow_Close.FlatAppearance.BorderSize = 0;
            this.NotificationWindow_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotificationWindow_Close.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotificationWindow_Close.ForeColor = System.Drawing.Color.White;
            this.NotificationWindow_Close.Location = new System.Drawing.Point(428, 0);
            this.NotificationWindow_Close.Name = "NotificationWindow_Close";
            this.NotificationWindow_Close.Size = new System.Drawing.Size(39, 29);
            this.NotificationWindow_Close.TabIndex = 1;
            this.NotificationWindow_Close.Text = "";
            this.NotificationWindow_Close.UseVisualStyleBackColor = false;
            this.NotificationWindow_Close.Click += new System.EventHandler(this.NotificationWindow_Close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(467, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dnes má narozeniny:";
            // 
            // birthdayNames
            // 
            this.birthdayNames.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.birthdayNames.Location = new System.Drawing.Point(13, 119);
            this.birthdayNames.Name = "birthdayNames";
            this.birthdayNames.Size = new System.Drawing.Size(443, 60);
            this.birthdayNames.TabIndex = 4;
            this.birthdayNames.Text = "Načítám data...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(14, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dnes má meniny:";
            // 
            // meninyName
            // 
            this.meninyName.AutoSize = true;
            this.meninyName.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.meninyName.Location = new System.Drawing.Point(13, 57);
            this.meninyName.Name = "meninyName";
            this.meninyName.Size = new System.Drawing.Size(136, 25);
            this.meninyName.TabIndex = 6;
            this.meninyName.Text = "Načítám data...";
            // 
            // NotificationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(467, 189);
            this.Controls.Add(this.meninyName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NotificationWindow_Close);
            this.Controls.Add(this.birthdayNames);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NotificationWindow";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "NotificationWindow";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.NotificationWindow_Load);
            this.MouseHover += new System.EventHandler(this.NotificationWindow_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NotificationWindow_Close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label birthdayNames;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label meninyName;
    }
}