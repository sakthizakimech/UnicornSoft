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
    public partial class CustomerDetails : Form
    {
        public CustomerDetails()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            CompanyData detail = CompanyManager.loadCurrent();
            CompanyDetails edit = new CompanyDetails();
            edit.Tag = "Customer";
            if (detail != null)
            {
                //edit.CompName.Text = detail.Name;
                //edit.compLine1.Text = detail.AddLineOne;
                //edit.compLine2.Text = detail.AddLineTwo;
                //edit.compLine3.Text = detail.AddLineThree;
                //edit.txtIec.Text = detail.IecCode;
                //edit.txtGst.Text = detail.GstCode;
                //edit.txtPan.Text = detail.PanCode;
                //edit.txtMail.Text = detail.Email;
                //edit.txtMobile.Text = detail.MobileNo;
            }
            edit.ShowDialog();
            edit.Tag = "";
            this.Show();
        }
    }
}
