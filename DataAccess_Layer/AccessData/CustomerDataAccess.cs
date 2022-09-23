using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.AccessData
{
    public class CustomerDataAccess
    {
        DataAccess dataAccess;
        public CustomerDataAccess()
        {
            dataAccess = new DataAccess();
        }

        public DataTable GetCustomerInsformation(string customerid)
        {
            return dataAccess.SqlDataTable("spGetCustomerInsformation", "customerphone", customerid);
        }

        public string AddCustomer(string cn)
        {
            int i = dataAccess.SqlExecuteNonQuery("spAddCustomerByNumber", "cn",cn);
            if(i>0)
            {
                return Convert.ToString(dataAccess.SqlExecuteScalar("spGetCustomerid","cn",cn));
            }
            return Convert.ToString(dataAccess.SqlExecuteScalar("spGetCustomerid", "cn", cn));

        }
    }
}
