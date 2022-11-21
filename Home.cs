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


        private void btnInvoice_Click(object sender, EventArgs e)
        {
            controler.ObjInvoice.ShowDialog();
        }
        private void btnCust_Click(object sender, EventArgs e)
        {
            CustomerDetails customer = new CustomerDetails();
            customer.ShowDialog();
            //scslsfdo ne
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
            this.Show();
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
    }
}
