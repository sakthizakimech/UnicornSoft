namespace MarkSoft
{
    partial class CustomerDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CustomerTable = new System.Windows.Forms.DataGridView();
            this.colSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.GBRowsControl = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerTable)).BeginInit();
            this.GBRowsControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerTable
            // 
            this.CustomerTable.AllowUserToAddRows = false;
            this.CustomerTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CustomerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSno,
            this.colName,
            this.colCity,
            this.colGst,
            this.colPan,
            this.colIec,
            this.colContact,
            this.colEmail});
            this.CustomerTable.Enabled = false;
            this.CustomerTable.Location = new System.Drawing.Point(12, 12);
            this.CustomerTable.Name = "CustomerTable";
            this.CustomerTable.RowHeadersWidth = 51;
            this.CustomerTable.RowTemplate.Height = 24;
            this.CustomerTable.Size = new System.Drawing.Size(1338, 498);
            this.CustomerTable.TabIndex = 0;
            // 
            // colSno
            // 
            this.colSno.HeaderText = "S No.";
            this.colSno.MinimumWidth = 6;
            this.colSno.Name = "colSno";
            this.colSno.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 200;
            // 
            // colCity
            // 
            this.colCity.HeaderText = "Location";
            this.colCity.MinimumWidth = 6;
            this.colCity.Name = "colCity";
            this.colCity.ReadOnly = true;
            this.colCity.Width = 150;
            // 
            // colGst
            // 
            this.colGst.HeaderText = "GST No.";
            this.colGst.MinimumWidth = 6;
            this.colGst.Name = "colGst";
            this.colGst.ReadOnly = true;
            this.colGst.Width = 200;
            // 
            // colPan
            // 
            this.colPan.HeaderText = "PAN No.";
            this.colPan.MinimumWidth = 6;
            this.colPan.Name = "colPan";
            this.colPan.ReadOnly = true;
            this.colPan.Width = 150;
            // 
            // colIec
            // 
            this.colIec.HeaderText = "IEC No.";
            this.colIec.MinimumWidth = 6;
            this.colIec.Name = "colIec";
            this.colIec.ReadOnly = true;
            this.colIec.Width = 150;
            // 
            // colContact
            // 
            this.colContact.HeaderText = "Contact";
            this.colContact.MinimumWidth = 6;
            this.colContact.Name = "colContact";
            this.colContact.ReadOnly = true;
            this.colContact.Width = 150;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "E-Mail Id";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 300;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(19, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // GBRowsControl
            // 
            this.GBRowsControl.AutoSize = true;
            this.GBRowsControl.Controls.Add(this.btnDelete);
            this.GBRowsControl.Controls.Add(this.btnAdd);
            this.GBRowsControl.Location = new System.Drawing.Point(44, 528);
            this.GBRowsControl.Name = "GBRowsControl";
            this.GBRowsControl.Size = new System.Drawing.Size(214, 72);
            this.GBRowsControl.TabIndex = 2;
            this.GBRowsControl.TabStop = false;
            this.GBRowsControl.Text = "Customer Detail";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(111, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // CustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 624);
            this.Controls.Add(this.GBRowsControl);
            this.Controls.Add(this.CustomerTable);
            this.Name = "CustomerDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CustomerDetails";
            ((System.ComponentModel.ISupportInitialize)(this.CustomerTable)).EndInit();
            this.GBRowsControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomerTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGst;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.GroupBox GBRowsControl;
        private System.Windows.Forms.Button btnDelete;
    }
}