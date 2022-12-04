using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarkSoft
{
    public partial class DataBase : Form
    {
        public DataBase()
        {
            InitializeComponent();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void Paste()
        {
            try
            {
                ProductTable.Focus();
                ProductTable.CurrentCell = ProductTable[1, 1];
                string s = Clipboard.GetText();
                string[] lines = s.Replace("\n", "").Split('\r');
                string[] fields;
                int row = 0;
                int column = 0;
                foreach (string l in lines)
                {
                    fields = l.Split('\t');
                    foreach (string f in fields)
                        ProductTable[column++, row].Value = f;
                    row++;
                    column = 0;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            ProductTable.Rows.Add();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            productManager manage = new productManager();
            foreach (DataGridViewRow data in ProductTable.Rows)
            {
                DataGridViewCellCollection cells = data.Cells;
                if (cells[0].Value!=null)
                {
                    product details = new product(cells);
                    manage.tempDict.Add(details.productDesc, details);
                }
                
            }
            manage.Save();
            MessageBox.Show("Product Details updated");
            display();
        }
        private void display()
        {
            productManager.getProductDetails();
            if (productManager.CurrentProducts.tempDict.Count < 1)
                return;

            foreach(var data in productManager.CurrentProducts.tempDict)
            {
                ProductTable.Rows.Clear();
                ProductTable.Rows.Add();
                int index = ProductTable.Rows.Count - 2;
                DataGridViewCellCollection cells = ProductTable.Rows[index].Cells;
                cells[0].Value = data.Value.productDesc;
                cells[1].Value = data.Value.productType;
                cells[2].Value = data.Value.productColor ;
                cells[3].Value = data.Value.productHsn ;
                cells[4].Value = data.Value.productPrice ;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ProductTable.Rows.Remove(ProductTable.CurrentRow);
        }

        private void DataBase_Load(object sender, EventArgs e)
        {
            display();
        }
    }
    class productManager
    {
        static string DbPath = FullControl.mPath+@"Product\Product.db";
        public Dictionary<string, product> tempDict = new Dictionary<string, product>();
        public static productManager CurrentProducts;
        public void Save()
        {
            if (!File.Exists(DbPath))
            {
                File.Create(DbPath);
            }
            string data = JsonConvert.SerializeObject(this,Formatting.Indented);
            File.WriteAllText(DbPath, data);
        }
        public static void getProductDetails()
        {
            productManager prod = new productManager();
            CurrentProducts = prod;
            if (File.Exists(DbPath))
            {
                
                string dbData = File.ReadAllText(DbPath);
                JsonConvert.PopulateObject(dbData, prod);
            }
        }
    }
    class product
    {
        public string productDesc;
        public string productType;
        public string productColor;
        public string productPrice;
        public string productHsn;
        public product(DataGridViewCellCollection cells)
        {
            productDesc = cells[0].Value.ToString();
            productType = cells[1].Value.ToString();
            productColor = cells[2].Value.ToString();
            productPrice = cells[4].Value.ToString();
            productHsn = cells[3].Value.ToString();

        }
        public product()
        { }

        }
}
