namespace MarkSoft
{
    partial class DataBase
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
            this.ProductTable = new System.Windows.Forms.DataGridView();
            this.ProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodHsn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbRow = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductTable)).BeginInit();
            this.gbRow.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductTable
            // 
            this.ProductTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductDescription,
            this.prodColor,
            this.ProdType,
            this.prodHsn,
            this.prod});
            this.ProductTable.Location = new System.Drawing.Point(12, 51);
            this.ProductTable.Name = "ProductTable";
            this.ProductTable.RowHeadersWidth = 51;
            this.ProductTable.RowTemplate.Height = 24;
            this.ProductTable.Size = new System.Drawing.Size(1290, 451);
            this.ProductTable.TabIndex = 0;
            // 
            // ProductDescription
            // 
            this.ProductDescription.HeaderText = "Product Description";
            this.ProductDescription.MinimumWidth = 6;
            this.ProductDescription.Name = "ProductDescription";
            this.ProductDescription.Width = 350;
            // 
            // prodColor
            // 
            this.prodColor.HeaderText = "COLOR";
            this.prodColor.MinimumWidth = 6;
            this.prodColor.Name = "prodColor";
            this.prodColor.Width = 150;
            // 
            // ProdType
            // 
            this.ProdType.HeaderText = "Type";
            this.ProdType.MinimumWidth = 6;
            this.ProdType.Name = "ProdType";
            this.ProdType.Width = 150;
            // 
            // prodHsn
            // 
            this.prodHsn.HeaderText = "HSN CODE";
            this.prodHsn.MinimumWidth = 6;
            this.prodHsn.Name = "prodHsn";
            this.prodHsn.Width = 200;
            // 
            // prod
            // 
            this.prod.HeaderText = "Price";
            this.prod.MinimumWidth = 6;
            this.prod.Name = "prod";
            this.prod.Width = 125;
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(222, 529);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(79, 39);
            this.btnPaste.TabIndex = 1;
            this.btnPaste.Text = "Paste";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(17, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 39);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1187, 529);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 39);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(102, 22);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 39);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbRow
            // 
            this.gbRow.Controls.Add(this.btnAdd);
            this.gbRow.Controls.Add(this.btnDelete);
            this.gbRow.Location = new System.Drawing.Point(16, 508);
            this.gbRow.Name = "gbRow";
            this.gbRow.Size = new System.Drawing.Size(200, 67);
            this.gbRow.TabIndex = 5;
            this.gbRow.TabStop = false;
            this.gbRow.Text = "Rows";
            // 
            // DataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 597);
            this.Controls.Add(this.gbRow);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.ProductTable);
            this.Name = "DataBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Material Database";
            this.Load += new System.EventHandler(this.DataBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductTable)).EndInit();
            this.gbRow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdType;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodHsn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbRow;
    }
}