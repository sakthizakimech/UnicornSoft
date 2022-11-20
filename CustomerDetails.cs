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
        public void DisplayCustomer()
        {
            int index, cnt = 1 ;
            CustomerManager.loadCurrent();
            Dictionary<string, CompanyData> custList = CustomerManager.current.customers;
            if (custList.Count > 1)
            {
                CustomerTable.Rows.Clear();
                foreach (var kv in custList)
                {
                    index = CustomerTable.Rows.Add();
                    DataGridViewCellCollection cells = CustomerTable.Rows[index].Cells;
                    cells[0].Value = cnt++;
                    cells[1].Value = kv.Value.Name;
                    cells[2].Value = kv.Value.AddLineThree;
                    cells[3].Value = kv.Value.GstCode;
                    cells[4].Value = kv.Value.PanCode;
                    cells[5].Value = kv.Value.IecCode;
                    cells[6].Value = kv.Value.MobileNo;
                    cells[7].Value = kv.Value.Email;

                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            CompanyDetails addNew = new CompanyDetails();
            addNew.Tag = "Customer";
            addNew.ShowDialog();
            addNew.Tag = "";
            DisplayCustomer();
            this.Show();
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {
            DisplayCustomer();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection cells = CustomerTable.CurrentRow.Cells;
            string cmpName = cells[1].Value.ToString();
            CustomerManager man = new CustomerManager();
            CustomerManager.loadCurrent();
            man.customers = CustomerManager.current.customers;
            man.DeleteCompany(cmpName);
            man.save();
            DisplayCustomer();

        }
    }
}
