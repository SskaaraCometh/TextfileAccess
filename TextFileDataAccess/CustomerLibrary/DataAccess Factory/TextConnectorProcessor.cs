using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;

namespace CustomerLibrary.DataAccess_Factory.TextConnector
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            //takes in key value and returns it, the appends fileName to the end
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }

        public static List<string> LoadFile(this string file)
        {
            if(!File.Exists(file))
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }

        public static List<CustomerModel> ConvertToCustomerModel(this List<string> lines)
        {
            List<CustomerModel> output = new List<CustomerModel>();

            foreach(string line in lines)
            {
                string[] cols = line.Split(',');

                CustomerModel c = new CustomerModel();
                c.IdNumber = int.Parse(cols[0]);
                c.FirstName = cols[1];
                c.SecondName = cols[2];
                c.Url = cols[3];

                output.Add(c);
            }

            return output;
        }

        public static void SaveToCustomerFile(this List<CustomerModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            
            foreach(CustomerModel m in models)
            {
                lines.Add($"{m.IdNumber},{m.FirstName},{m.SecondName},{m.Url}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
    }
}
