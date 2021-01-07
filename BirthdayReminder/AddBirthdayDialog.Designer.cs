namespace BirthdayReminder
{
    partial class AddBirthdayDialog
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
            this.AddDialog_date = new System.Windows.Forms.DateTimePicker();
            this.AddDialog_Save = new System.Windows.Forms.Button();
            this.AddDialog_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddDialog_Cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddDialog_date
            // 
            this.AddDialog_date.CustomFormat = "";
            this.AddDialog_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AddDialog_date.Location = new System.Drawing.Point(59, 47);
            this.AddDialog_date.Name = "AddDialog_date";
            this.AddDialog_date.Size = new System.Drawing.Size(233, 20);
            this.AddDialog_date.TabIndex = 0;
            // 
            // AddDialog_Save
            // 
            this.AddDialog_Save.Location = new System.Drawing.Point(136, 91);
            this.AddDialog_Save.Name = "AddDialog_Save";
            this.AddDialog_Save.Size = new System.Drawing.Size(75, 23);
            this.AddDialog_Save.TabIndex = 1;
            this.AddDialog_Save.Text = "Uložit";
            this.AddDialog_Save.UseVisualStyleBackColor = true;
            this.AddDialog_Save.Click += new System.EventHandler(this.AddDialog_Save_Click);
            // 
            // AddDialog_name
            // 
            this.AddDialog_name.Location = new System.Drawing.Point(59, 12);
            this.AddDialog_name.Name = "AddDialog_name";
            this.AddDialog_name.Size = new System.Drawing.Size(233, 20);
            this.AddDialog_name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Jméno:";
            // 
            // AddDialog_Cancel
            // 
            this.AddDialog_Cancel.Location = new System.Drawing.Point(217, 91);
            this.AddDialog_Cancel.Name = "AddDialog_Cancel";
            this.AddDialog_Cancel.Size = new System.Drawing.Size(75, 23);
            this.AddDialog_Cancel.TabIndex = 4;
            this.AddDialog_Cancel.Text = "Zavřít";
            this.AddDialog_Cancel.UseVisualStyleBackColor = true;
            this.AddDialog_Cancel.Click += new System.EventHandler(this.AddDialog_Cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Datum:";
            // 
            // AddDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 126);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddDialog_Cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddDialog_name);
            this.Controls.Add(this.AddDialog_Save);
            this.Controls.Add(this.AddDialog_date);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDialog";
            this.Text = "Přidat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker AddDialog_date;
        private System.Windows.Forms.Button AddDialog_Save;
        private System.Windows.Forms.TextBox AddDialog_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddDialog_Cancel;
        private System.Windows.Forms.Label label2;
    }
}