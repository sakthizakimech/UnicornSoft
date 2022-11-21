namespace MarkSoft
{
    partial class BusinessManager
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
            this.LGHomeTab = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnProfile = new System.Windows.Forms.ToolStripButton();
            this.btnDb = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnCust = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.LGHomeTab.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LGHomeTab
            // 
            this.LGHomeTab.Controls.Add(this.listView1);
            this.LGHomeTab.Controls.Add(this.toolStrip1);
            this.LGHomeTab.Controls.Add(this.btnCust);
            this.LGHomeTab.Controls.Add(this.btnInvoice);
            this.LGHomeTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LGHomeTab.Location = new System.Drawing.Point(0, 0);
            this.LGHomeTab.Name = "LGHomeTab";
            this.LGHomeTab.Size = new System.Drawing.Size(1059, 609);
            this.LGHomeTab.TabIndex = 0;
            this.LGHomeTab.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnProfile,
            this.btnDb,
            this.btnExit});
            this.toolStrip1.Location = new System.Drawing.Point(3, 18);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1053, 67);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnProfile
            // 
            this.btnProfile.Image = global::MarkSoft.Properties.Resources.profile;
            this.btnProfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(56, 64);
            this.btnProfile.Text = "Profile";
            this.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnDb
            // 
            this.btnDb.Image = global::MarkSoft.Properties.Resources.icons8_database_administrator_50;
            this.btnDb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDb.Name = "btnDb";
            this.btnDb.Size = new System.Drawing.Size(131, 64);
            this.btnDb.Text = "Product Database";
            this.btnDb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDb.Click += new System.EventHandler(this.btnDb_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::MarkSoft.Properties.Resources.icons8_logout_72;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 64);
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCust
            // 
            this.btnCust.Location = new System.Drawing.Point(178, 547);
            this.btnCust.Name = "btnCust";
            this.btnCust.Size = new System.Drawing.Size(147, 50);
            this.btnCust.TabIndex = 3;
            this.btnCust.Text = "Customers";
            this.btnCust.UseVisualStyleBackColor = true;
            this.btnCust.Click += new System.EventHandler(this.btnCust_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.Location = new System.Drawing.Point(12, 547);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(147, 50);
            this.btnInvoice.TabIndex = 0;
            this.btnInvoice.Text = "Invoice";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(163, 180);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // BusinessManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1059, 609);
            this.Controls.Add(this.LGHomeTab);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BusinessManager";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Business Manager";
            this.LGHomeTab.ResumeLayout(false);
            this.LGHomeTab.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LGHomeTab;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btnCust;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnProfile;
        private System.Windows.Forms.ToolStripButton btnDb;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListView listView1;
    }
}

