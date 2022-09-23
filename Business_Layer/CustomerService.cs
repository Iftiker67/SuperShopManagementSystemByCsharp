using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class CustomerService
    {
        DataAccess_Layer.AccessData.CustomerDataAccess customerDataAccess;
        public CustomerService()
        {
            customerDataAccess = new DataAccess_Layer.AccessData.CustomerDataAccess();
        }

        public DataTable GetCustomerInsformation(string customerid)
        {
            return customerDataAccess.GetCustomerInsformation(customerid);
        }
        public string AddCustomer(string cn)
        {
            return customerDataAccess.AddCustomer(cn);
        }
    }
}
