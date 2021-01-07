namespace BirthdayReminder
{
    partial class EditBirthdayDialog
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
            this.EditingDialog_DataView = new System.Windows.Forms.DataGridView();
            this.EditingDialog_Exit = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditingDialog_Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.EditingDialog_DataView)).BeginInit();
            this.SuspendLayout();
            // 
            // EditingDialog_DataView
            // 
            this.EditingDialog_DataView.AllowUserToAddRows = false;
            this.EditingDialog_DataView.AllowUserToDeleteRows = false;
            this.EditingDialog_DataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EditingDialog_DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditingDialog_DataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.birthday,
            this.EditingDialog_Delete});
            this.EditingDialog_DataView.Location = new System.Drawing.Point(0, 0);
            this.EditingDialog_DataView.MultiSelect = false;
            this.EditingDialog_DataView.Name = "EditingDialog_DataView";
            this.EditingDialog_DataView.ReadOnly = true;
            this.EditingDialog_DataView.Size = new System.Drawing.Size(737, 365);
            this.EditingDialog_DataView.TabIndex = 0;
            this.EditingDialog_DataView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.EditingDialog_DataView_CellMouseClick);
            // 
            // EditingDialog_Exit
            // 
            this.EditingDialog_Exit.Location = new System.Drawing.Point(650, 381);
            this.EditingDialog_Exit.Name = "EditingDialog_Exit";
            this.EditingDialog_Exit.Size = new System.Drawing.Size(75, 23);
            this.EditingDialog_Exit.TabIndex = 1;
            this.EditingDialog_Exit.Text = "Zavřít";
            this.EditingDialog_Exit.UseVisualStyleBackColor = true;
            this.EditingDialog_Exit.Click += new System.EventHandler(this.EditingDialog_Exit_Click);
            // 
            // name
            // 
            this.name.FillWeight = 121.6288F;
            this.name.HeaderText = "Jméno";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // birthday
            // 
            this.birthday.FillWeight = 121.6288F;
            this.birthday.HeaderText = "Datum narození";
            this.birthday.Name = "birthday";
            this.birthday.ReadOnly = true;
            // 
            // EditingDialog_Delete
            // 
            this.EditingDialog_Delete.FillWeight = 36.48863F;
            this.EditingDialog_Delete.HeaderText = "";
            this.EditingDialog_Delete.Name = "EditingDialog_Delete";
            this.EditingDialog_Delete.ReadOnly = true;
            this.EditingDialog_Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EditingDialog_Delete.Text = "";
            // 
            // EditingDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 416);
            this.Controls.Add(this.EditingDialog_Exit);
            this.Controls.Add(this.EditingDialog_DataView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditingDialog";
            this.Text = "Správa";
            ((System.ComponentModel.ISupportInitialize)(this.EditingDialog_DataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EditingDialog_DataView;
        private System.Windows.Forms.Button EditingDialog_Exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthday;
        private System.Windows.Forms.DataGridViewButtonColumn EditingDialog_Delete;
    }
}