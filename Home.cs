using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarkSoft
{
    
    public partial class BusinessManager : Form
    {
        FullControl controler;
        public BusinessManager()
        {
            InitializeComponent();
            controler = new FullControl();
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            CompanyData detail = CompanyManager.loadCurrent();
            CompanyDetails edit = new CompanyDetails();
            edit.Tag = "me";
            if (detail != null)
            {
                edit.CompName.Text = detail.Name;
                edit.compLine1.Text = detail.AddLineOne;
                edit.compLine2.Text = detail.AddLineTwo;
                edit.compLine3.Text = detail.AddLineThree;
                edit.txtIec.Text = detail.IecCode;
                edit.txtGst.Text = detail.GstCode;
                edit.txtPan.Text = detail.PanCode;
                edit.txtMail.Text = detail.Email;
                edit.txtMobile.Text = detail.MobileNo;
            }
            edit.ShowDialog();
            edit.Tag = "me";
            DisplayComDetails();
            this.Show();
        }
        private void DisplayComDetails()
        {
            CompanyData detail = CompanyManager.loadCurrent();
            HomeComDisplay.Items.Clear();
            CompanyDetails edit = new CompanyDetails();
            if (detail != null)
            {
                HomeComDisplay.Items.Add(detail.Name);
                HomeComDisplay.Items.Add(detail.AddLineOne);
                HomeComDisplay.Items.Add(detail.AddLineTwo);
                HomeComDisplay.Items.Add(detail.AddLineThree);
                HomeComDisplay.Items.Add(detail.IecCode);
                HomeComDisplay.Items.Add(detail.GstCode);
                HomeComDisplay.Items.Add(detail.PanCode);
                HomeComDisplay.Items.Add(detail.Email);
                HomeComDisplay.Items.Add(detail.MobileNo);
            }
        }
        private void btnDb_Click(object sender, EventArgs e)
        {

            controler.ObjDB.ShowDialog();
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close ?", FullControl.AppName, MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }

        private void BusinessManager_Load(object sender, EventArgs e)
        {
            DisplayComDetails();
            dictTabs();

        }
        private Dictionary<string, TabPage> tabs = null;

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomerDetails customer = new CustomerDetails();
            customer.ShowDialog();
            //scslsfdo necontroler.ObjInvoice.ShowDialog();
        }
        void dictTabs()
        {
            tabs = new Dictionary<string, TabPage>();
            foreach (TabPage tab in MainTab.TabPages)
            {
                tabs.Add(tab.Name,tab);
                MainTab.TabPages.Remove(tab);
            }
            show("tabMonthReport");
        }
        private void show(string tabname)
        {
            MainTab.TabPages.Clear();
            if (tabs.TryGetValue(tabname, out TabPage current) == true)
                MainTab.TabPages.Add(current);
        }
        private void btnIcreate_Click(object sender, EventArgs e)
        {
            show("tabIcreate");
        }

        private void btnImanage_Click(object sender, EventArgs e)
        {
            show("tabImanage");
        }

        private void btnPmanage_Click(object sender, EventArgs e)
        {
            show("tabPmanage");
        }

        private void btnPcreate_Click(object sender, EventArgs e)
        {
            show("tabPcreate");
        }

      
    }
}
