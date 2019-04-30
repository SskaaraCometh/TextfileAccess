using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerLibrary.DataAccess_Factory.TextConnector;

namespace CustomerLibrary
{

    class TextConnector: IDataAccess
    {
        private const string CustomerFile = "CustomerModel.csv";
        List<CustomerModel> customers = new List<CustomerModel>();

        public CustomerModel CreateCustomer(CustomerModel model)
        {
            List<CustomerModel> customers = CustomerFile.FullFilePath().LoadFile().ConvertToCustomerModel();

            int currentId = 1;

            customers.Add(model);
      
            customers.SaveToCustomerFile(CustomerFile);
            return model;
        }
    }
}
