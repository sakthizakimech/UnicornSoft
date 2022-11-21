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
    public partial class FolderBrowser : Form
    {
        public FolderBrowser()
        {
            InitializeComponent();
        }

        private void FolderBrowser_Load(object sender, EventArgs e)
        {
            this.Text = FullControl.AppName +"-"+ this.Tag;
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            browserDialog.ShowDialog();

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Tag = browserDialog.SelectedPath;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Tag = "";
        }
    }
}
