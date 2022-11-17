using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MarkSoft
{
    public partial class CompanyDetails : Form
    {
        public CompanyDetails()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.Tag == "Customer")
                SaveCustomer();
            else if(this.Tag=="me")
                SaveMe();
            
        }
        public void SaveMe()
        {
            CompanyManager man = new CompanyManager();
            CompanyData detail = new CompanyData();
            detail.Name = CompName.Text;
            detail.AddLineOne = compLine1.Text;
            detail.AddLineTwo = compLine2.Text;
            detail.AddLineThree = compLine3.Text;
            detail.IecCode = txtIec.Text;
            detail.GstCode = txtGst.Text;
            detail.PanCode = txtPan.Text;
            detail.Email = txtMail.Text;
            detail.MobileNo = txtMobile.Text;
            man.save(detail);
        }
        public void SaveCustomer()
        {
            CustomerManager man = new CustomerManager();
            CompanyData detail = new CompanyData();
            detail.Name = CompName.Text;
            detail.AddLineOne = compLine1.Text;
            detail.AddLineTwo = compLine2.Text;
            detail.AddLineThree = compLine3.Text;
            detail.IecCode = txtIec.Text;
            detail.GstCode = txtGst.Text;
            detail.PanCode = txtPan.Text;
            detail.Email = txtMail.Text;
            detail.MobileNo = txtMobile.Text;
            man.save(detail);
        }
    }
}
