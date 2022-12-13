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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusinessManager));
            this.LGHomeTab = new System.Windows.Forms.GroupBox();
            this.MainLoader = new System.Windows.Forms.ProgressBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.HomeComDisplay = new System.Windows.Forms.ListBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.MainTab = new System.Windows.Forms.TabControl();
            this.tabIcreate = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabImanage = new System.Windows.Forms.TabPage();
            this.tabPcreate = new System.Windows.Forms.TabPage();
            this.tabPmanage = new System.Windows.Forms.TabPage();
            this.tabMonthReport = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnProfile = new System.Windows.Forms.ToolStripButton();
            this.toolInvoice = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnIcreate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImanage = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIupdate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolPurchase = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnPcreate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPmanage = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPupdate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCustomer = new System.Windows.Forms.ToolStripButton();
            this.btnDb = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BiggerHolder = new System.Windows.Forms.TableLayoutPanel();
            this.LGHomeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.MainTab.SuspendLayout();
            this.tabIcreate.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.BiggerHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // LGHomeTab
            // 
            this.LGHomeTab.Controls.Add(this.MainLoader);
            this.LGHomeTab.Controls.Add(this.splitContainer1);
            this.LGHomeTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LGHomeTab.Location = new System.Drawing.Point(6, 68);
            this.LGHomeTab.Margin = new System.Windows.Forms.Padding(4);
            this.LGHomeTab.Name = "LGHomeTab";
            this.LGHomeTab.Padding = new System.Windows.Forms.Padding(4);
            this.LGHomeTab.Size = new System.Drawing.Size(1784, 536);
            this.LGHomeTab.TabIndex = 0;
            this.LGHomeTab.TabStop = false;
            // 
            // MainLoader
            // 
            this.MainLoader.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.MainLoader.Location = new System.Drawing.Point(16, 863);
            this.MainLoader.Margin = new System.Windows.Forms.Padding(4);
            this.MainLoader.Name = "MainLoader";
            this.MainLoader.Size = new System.Drawing.Size(192, 28);
            this.MainLoader.TabIndex = 7;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(4, 19);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Panel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.MainTab);
            this.splitContainer1.Size = new System.Drawing.Size(1776, 513);
            this.splitContainer1.SplitterDistance = 613;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.Controls.Add(this.HomeComDisplay, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Logo, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(611, 511);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // HomeComDisplay
            // 
            this.HomeComDisplay.BackColor = System.Drawing.Color.CadetBlue;
            this.HomeComDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HomeComDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.HomeComDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeComDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeComDisplay.FormattingEnabled = true;
            this.HomeComDisplay.ItemHeight = 22;
            this.HomeComDisplay.Location = new System.Drawing.Point(13, 190);
            this.HomeComDisplay.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.HomeComDisplay.Name = "HomeComDisplay";
            this.HomeComDisplay.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.HomeComDisplay.Size = new System.Drawing.Size(585, 309);
            this.HomeComDisplay.TabIndex = 0;
            // 
            // Logo
            // 
            this.Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logo.Location = new System.Drawing.Point(4, 4);
            this.Logo.Margin = new System.Windows.Forms.Padding(4);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(603, 170);
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.tabIcreate);
            this.MainTab.Controls.Add(this.tabImanage);
            this.MainTab.Controls.Add(this.tabPcreate);
            this.MainTab.Controls.Add(this.tabPmanage);
            this.MainTab.Controls.Add(this.tabMonthReport);
            this.MainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTab.Location = new System.Drawing.Point(0, 0);
            this.MainTab.Margin = new System.Windows.Forms.Padding(4);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(1156, 511);
            this.MainTab.TabIndex = 0;
            // 
            // tabIcreate
            // 
            this.tabIcreate.BackColor = System.Drawing.Color.CadetBlue;
            this.tabIcreate.Controls.Add(this.tableLayoutPanel1);
            this.tabIcreate.Location = new System.Drawing.Point(4, 25);
            this.tabIcreate.Margin = new System.Windows.Forms.Padding(4);
            this.tabIcreate.Name = "tabIcreate";
            this.tabIcreate.Padding = new System.Windows.Forms.Padding(4);
            this.tabIcreate.Size = new System.Drawing.Size(1148, 482);
            this.tabIcreate.TabIndex = 0;
            this.tabIcreate.Text = "Create Invoice";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.17575F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.82425F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1140, 474);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabImanage
            // 
            this.tabImanage.BackColor = System.Drawing.Color.CadetBlue;
            this.tabImanage.Location = new System.Drawing.Point(4, 25);
            this.tabImanage.Margin = new System.Windows.Forms.Padding(4);
            this.tabImanage.Name = "tabImanage";
            this.tabImanage.Padding = new System.Windows.Forms.Padding(4);
            this.tabImanage.Size = new System.Drawing.Size(1148, 482);
            this.tabImanage.TabIndex = 1;
            this.tabImanage.Text = "Manage Invoice";
            // 
            // tabPcreate
            // 
            this.tabPcreate.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPcreate.Location = new System.Drawing.Point(4, 25);
            this.tabPcreate.Margin = new System.Windows.Forms.Padding(4);
            this.tabPcreate.Name = "tabPcreate";
            this.tabPcreate.Size = new System.Drawing.Size(1148, 482);
            this.tabPcreate.TabIndex = 2;
            this.tabPcreate.Text = "Create Purchase Order";
            // 
            // tabPmanage
            // 
            this.tabPmanage.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPmanage.Location = new System.Drawing.Point(4, 25);
            this.tabPmanage.Margin = new System.Windows.Forms.Padding(4);
            this.tabPmanage.Name = "tabPmanage";
            this.tabPmanage.Size = new System.Drawing.Size(1148, 482);
            this.tabPmanage.TabIndex = 3;
            this.tabPmanage.Text = "Manage Purchase Order";
            // 
            // tabMonthReport
            // 
            this.tabMonthReport.BackColor = System.Drawing.Color.CadetBlue;
            this.tabMonthReport.Location = new System.Drawing.Point(4, 25);
            this.tabMonthReport.Margin = new System.Windows.Forms.Padding(4);
            this.tabMonthReport.Name = "tabMonthReport";
            this.tabMonthReport.Size = new System.Drawing.Size(1148, 482);
            this.tabMonthReport.TabIndex = 4;
            this.tabMonthReport.Text = "Monthly Report";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnProfile,
            this.toolInvoice,
            this.toolPurchase,
            this.btnCustomer,
            this.btnDb,
            this.btnExit});
            this.toolStrip1.Location = new System.Drawing.Point(6, 6);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(4);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1784, 52);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "Invoice";
            // 
            // btnProfile
            // 
            this.btnProfile.Image = global::MarkSoft.Properties.Resources.profile;
            this.btnProfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(66, 49);
            this.btnProfile.Text = "Profile";
            this.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // toolInvoice
            // 
            this.toolInvoice.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIcreate,
            this.btnImanage,
            this.btnIupdate});
            this.toolInvoice.Image = ((System.Drawing.Image)(resources.GetObject("toolInvoice.Image")));
            this.toolInvoice.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolInvoice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolInvoice.Name = "toolInvoice";
            this.toolInvoice.Size = new System.Drawing.Size(82, 49);
            this.toolInvoice.Text = "Invoice";
            this.toolInvoice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnIcreate
            // 
            this.btnIcreate.Name = "btnIcreate";
            this.btnIcreate.Size = new System.Drawing.Size(162, 30);
            this.btnIcreate.Text = "Create";
            this.btnIcreate.Click += new System.EventHandler(this.btnIcreate_Click);
            // 
            // btnImanage
            // 
            this.btnImanage.Name = "btnImanage";
            this.btnImanage.Size = new System.Drawing.Size(162, 30);
            this.btnImanage.Text = "Manage";
            this.btnImanage.Click += new System.EventHandler(this.btnImanage_Click);
            // 
            // btnIupdate
            // 
            this.btnIupdate.Name = "btnIupdate";
            this.btnIupdate.Size = new System.Drawing.Size(162, 30);
            this.btnIupdate.Text = "Update";
            // 
            // toolPurchase
            // 
            this.toolPurchase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPcreate,
            this.btnPmanage,
            this.btnPupdate});
            this.toolPurchase.Image = ((System.Drawing.Image)(resources.GetObject("toolPurchase.Image")));
            this.toolPurchase.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolPurchase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPurchase.Name = "toolPurchase";
            this.toolPurchase.Size = new System.Drawing.Size(147, 49);
            this.toolPurchase.Text = "Purchase Order";
            this.toolPurchase.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolPurchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnPcreate
            // 
            this.btnPcreate.Name = "btnPcreate";
            this.btnPcreate.Size = new System.Drawing.Size(162, 30);
            this.btnPcreate.Text = "Create";
            this.btnPcreate.Click += new System.EventHandler(this.btnPcreate_Click);
            // 
            // btnPmanage
            // 
            this.btnPmanage.Name = "btnPmanage";
            this.btnPmanage.Size = new System.Drawing.Size(162, 30);
            this.btnPmanage.Text = "Manage";
            this.btnPmanage.Click += new System.EventHandler(this.btnPmanage_Click);
            // 
            // btnPupdate
            // 
            this.btnPupdate.Name = "btnPupdate";
            this.btnPupdate.Size = new System.Drawing.Size(162, 30);
            this.btnPupdate.Text = "Update";
            // 
            // btnCustomer
            // 
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(126, 49);
            this.btnCustomer.Text = "Customer Details";
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnDb
            // 
            this.btnDb.Image = global::MarkSoft.Properties.Resources.icons8_database_administrator_50;
            this.btnDb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDb.Name = "btnDb";
            this.btnDb.Size = new System.Drawing.Size(157, 49);
            this.btnDb.Text = "Product Database";
            this.btnDb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDb.Click += new System.EventHandler(this.btnDb_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::MarkSoft.Properties.Resources.icons8_logout_72;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 49);
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // BiggerHolder
            // 
            this.BiggerHolder.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.BiggerHolder.ColumnCount = 1;
            this.BiggerHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BiggerHolder.Controls.Add(this.toolStrip1, 0, 0);
            this.BiggerHolder.Controls.Add(this.LGHomeTab, 0, 1);
            this.BiggerHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BiggerHolder.Location = new System.Drawing.Point(0, 0);
            this.BiggerHolder.Margin = new System.Windows.Forms.Padding(4);
            this.BiggerHolder.Name = "BiggerHolder";
            this.BiggerHolder.RowCount = 2;
            this.BiggerHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.BiggerHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.BiggerHolder.Size = new System.Drawing.Size(1796, 610);
            this.BiggerHolder.TabIndex = 1;
            // 
            // BusinessManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1796, 610);
            this.Controls.Add(this.BiggerHolder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BusinessManager";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Business Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BusinessManager_Load);
            this.LGHomeTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.MainTab.ResumeLayout(false);
            this.tabIcreate.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.BiggerHolder.ResumeLayout(false);
            this.BiggerHolder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LGHomeTab;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnProfile;
        private System.Windows.Forms.ToolStripButton btnDb;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox HomeComDisplay;
        private System.Windows.Forms.ProgressBar MainLoader;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.ToolStripDropDownButton toolPurchase;
        private System.Windows.Forms.ToolStripMenuItem btnPcreate;
        private System.Windows.Forms.ToolStripMenuItem btnPmanage;
        private System.Windows.Forms.ToolStripMenuItem btnPupdate;
        private System.Windows.Forms.ToolStripDropDownButton toolInvoice;
        private System.Windows.Forms.ToolStripMenuItem btnIcreate;
        private System.Windows.Forms.ToolStripMenuItem btnImanage;
        private System.Windows.Forms.ToolStripMenuItem btnIupdate;
        private System.Windows.Forms.ToolStripButton btnCustomer;
        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage tabIcreate;
        private System.Windows.Forms.TabPage tabImanage;
        private System.Windows.Forms.TabPage tabPcreate;
        private System.Windows.Forms.TabPage tabPmanage;
        private System.Windows.Forms.TabPage tabMonthReport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel BiggerHolder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

