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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerTable)).BeginInit();
            this.GBRowsControl.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerTable
            // 
            this.CustomerTable.AllowUserToAddRows = false;
            this.CustomerTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.CustomerTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerTable.Location = new System.Drawing.Point(2, 2);
            this.CustomerTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CustomerTable.Name = "CustomerTable";
            this.CustomerTable.RowHeadersWidth = 51;
            this.CustomerTable.RowTemplate.Height = 24;
            this.CustomerTable.Size = new System.Drawing.Size(1401, 532);
            this.CustomerTable.TabIndex = 0;
            // 
            // colSno
            // 
            this.colSno.HeaderText = "S No.";
            this.colSno.MinimumWidth = 6;
            this.colSno.Name = "colSno";
            this.colSno.ReadOnly = true;
            this.colSno.Width = 125;
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
            this.btnAdd.Location = new System.Drawing.Point(14, 17);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 24);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // GBRowsControl
            // 
            this.GBRowsControl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GBRowsControl.AutoSize = true;
            this.GBRowsControl.Controls.Add(this.btnDelete);
            this.GBRowsControl.Controls.Add(this.btnAdd);
            this.GBRowsControl.Location = new System.Drawing.Point(2, 538);
            this.GBRowsControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GBRowsControl.Name = "GBRowsControl";
            this.GBRowsControl.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GBRowsControl.Size = new System.Drawing.Size(142, 56);
            this.GBRowsControl.TabIndex = 2;
            this.GBRowsControl.TabStop = false;
            this.GBRowsControl.Text = "Customer Detail";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(78, 17);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 24);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.CustomerTable, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GBRowsControl, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1405, 596);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // CustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 596);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomerDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CustomerDetails";
            this.Load += new System.EventHandler(this.CustomerDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerTable)).EndInit();
            this.GBRowsControl.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}