using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLibrary
{
    public interface IDataAccess
    {
        CustomerModel CreateCustomer(CustomerModel model);
    }
}
