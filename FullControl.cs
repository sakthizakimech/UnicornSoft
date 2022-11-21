using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarkSoft
{
    public class FullControl
    {

        private InvoiceMaker InvoiceForm;
        private DataBase DbForm;
        public static string AppName
        {
            get
            {
                return "UNICORN BUSINESS MANAGER";
            }
        }
        public InvoiceMaker ObjInvoice
        {
            get {
                return new InvoiceMaker();
            }
            set {
                InvoiceForm = value;
            }
            
        }
        public static string mPath
        {
            get { 
            
                string path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)+ @"\UNICORNSOFT\";
                if (!System.IO.Directory.Exists(path))
                    System.IO.Directory.CreateDirectory(path);
                return path;
            }
        }
        public DataBase ObjDB
        {
            get {
                return new DataBase();
            }
            set {
                DbForm = value;
            }
            
        }
        
    }
}
