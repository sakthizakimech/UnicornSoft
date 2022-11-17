namespace MarkSoft
{
    partial class Home
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
            this.LGHomeTab = new System.Windows.Forms.GroupBox();
            this.btnCust = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnDB = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.BtnProfile = new System.Windows.Forms.Button();
            this.LGHomeTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // LGHomeTab
            // 
            this.LGHomeTab.Controls.Add(this.btnCust);
            this.LGHomeTab.Controls.Add(this.BtnProfile);
            this.LGHomeTab.Controls.Add(this.BtnExit);
            this.LGHomeTab.Controls.Add(this.BtnDB);
            this.LGHomeTab.Controls.Add(this.btnInvoice);
            this.LGHomeTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LGHomeTab.Location = new System.Drawing.Point(0, 0);
            this.LGHomeTab.Name = "LGHomeTab";
            this.LGHomeTab.Size = new System.Drawing.Size(800, 450);
            this.LGHomeTab.TabIndex = 0;
            this.LGHomeTab.TabStop = false;
            // 
            // btnCust
            // 
            this.btnCust.Location = new System.Drawing.Point(289, 28);
            this.btnCust.Name = "btnCust";
            this.btnCust.Size = new System.Drawing.Size(147, 50);
            this.btnCust.TabIndex = 3;
            this.btnCust.Text = "Customers";
            this.btnCust.UseVisualStyleBackColor = true;
            this.btnCust.Click += new System.EventHandler(this.btnCust_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(641, 28);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(147, 50);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnDB
            // 
            this.BtnDB.Location = new System.Drawing.Point(459, 28);
            this.BtnDB.Name = "BtnDB";
            this.BtnDB.Size = new System.Drawing.Size(147, 50);
            this.BtnDB.TabIndex = 1;
            this.BtnDB.Text = "Database";
            this.BtnDB.UseVisualStyleBackColor = true;
            this.BtnDB.Click += new System.EventHandler(this.BtnDB_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.Location = new System.Drawing.Point(125, 28);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(147, 50);
            this.btnInvoice.TabIndex = 0;
            this.btnInvoice.Text = "Invoice";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // BtnProfile
            // 
            this.BtnProfile.Image = global::MarkSoft.Properties.Resources.ProfileIco;
            this.BtnProfile.Location = new System.Drawing.Point(21, 21);
            this.BtnProfile.Name = "BtnProfile";
            this.BtnProfile.Size = new System.Drawing.Size(71, 64);
            this.BtnProfile.TabIndex = 1;
            this.BtnProfile.UseVisualStyleBackColor = true;
            this.BtnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LGHomeTab);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Home";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.LGHomeTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LGHomeTab;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnDB;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button BtnProfile;
        private System.Windows.Forms.Button btnCust;
    }
}

