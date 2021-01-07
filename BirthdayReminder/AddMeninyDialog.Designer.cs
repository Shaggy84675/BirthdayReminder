namespace BirthdayReminder
{
    partial class AddMeninyDialog
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
            this.AddDialog_Cancel = new System.Windows.Forms.Button();
            this.AddDialog_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AddMeninyDialog_name = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // AddDialog_Cancel
            // 
            this.AddDialog_Cancel.Location = new System.Drawing.Point(224, 54);
            this.AddDialog_Cancel.Name = "AddDialog_Cancel";
            this.AddDialog_Cancel.Size = new System.Drawing.Size(75, 23);
            this.AddDialog_Cancel.TabIndex = 6;
            this.AddDialog_Cancel.Text = "Zavřít";
            this.AddDialog_Cancel.UseVisualStyleBackColor = true;
            this.AddDialog_Cancel.Click += new System.EventHandler(this.AddDialog_Cancel_Click);
            // 
            // AddDialog_Save
            // 
            this.AddDialog_Save.Location = new System.Drawing.Point(143, 54);
            this.AddDialog_Save.Name = "AddDialog_Save";
            this.AddDialog_Save.Size = new System.Drawing.Size(75, 23);
            this.AddDialog_Save.TabIndex = 5;
            this.AddDialog_Save.Text = "Uložit";
            this.AddDialog_Save.UseVisualStyleBackColor = true;
            this.AddDialog_Save.Click += new System.EventHandler(this.AddDialog_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Jméno:";
            // 
            // AddMeninyDialog_name
            // 
            this.AddMeninyDialog_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddMeninyDialog_name.FormattingEnabled = true;
            this.AddMeninyDialog_name.Location = new System.Drawing.Point(59, 12);
            this.AddMeninyDialog_name.Name = "AddMeninyDialog_name";
            this.AddMeninyDialog_name.Size = new System.Drawing.Size(240, 21);
            this.AddMeninyDialog_name.Sorted = true;
            this.AddMeninyDialog_name.TabIndex = 9;
            // 
            // AddMeninyDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 89);
            this.Controls.Add(this.AddMeninyDialog_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddDialog_Cancel);
            this.Controls.Add(this.AddDialog_Save);
            this.Name = "AddMeninyDialog";
            this.Text = "AddMeninyDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddDialog_Cancel;
        private System.Windows.Forms.Button AddDialog_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AddMeninyDialog_name;
    }
}