using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MarkSoft
{
    public class CompanyData
    {
        public string Name;
        public string AddLineOne;
        public string AddLineTwo;
        public string AddLineThree;
        public string IecCode;
        public string GstCode;
        public string PanCode;
        public string Email;
        public string MobileNo;

    }
    public class CompanyManager
    {
        static string Cpath = FullControl.mPath + "seller.details";
        public void save(CompanyData details)
        {
            StreamWriter sw;
                sw=File.CreateText(Cpath);
            string data = JsonConvert.SerializeObject(details,Formatting.Indented);
            sw.Write(data);
            sw.Close();
        }
        public static CompanyData loadCurrent()
        {
            CompanyData data=new CompanyData();
            if(File.Exists(Cpath))
            {
                string text=File.ReadAllText(Cpath);
                if (string.IsNullOrEmpty(text))
                    return null;
                JsonConvert.PopulateObject(text, data);
                return data;
            }
            return null;
        }
    }
    public class CustomerManager
    {
        static string Cpath = FullControl.mPath + "customers.details";
        public static CustomerManager current;
        Dictionary<string, CompanyData> customers = new Dictionary<string, CompanyData>();

        public void save()
        {
            StreamWriter sw;
            sw = File.CreateText(Cpath);
            string data = JsonConvert.SerializeObject(this, Formatting.Indented);
            sw.Write(data);
            sw.Close();
        }
        public static void loadCurrent()
        {
            CustomerManager data = new CustomerManager();
            current = data;
            if (File.Exists(Cpath))
            {
                string text = File.ReadAllText(Cpath);
                if (string.IsNullOrEmpty(text))
                    return;
                JsonConvert.PopulateObject(text, data);
            }
        }
    }
}
