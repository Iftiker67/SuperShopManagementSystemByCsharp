using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.AccessData
{
    public class SupplierDataAccess
    {
        DataAccess dataAccess;
        public SupplierDataAccess()
        {
            dataAccess = new DataAccess();
        }

        public List<string> SqlGetAllSuppliers()
        {
            List<string> suppliers = new List<string>();
            SqlDataReader sdr = dataAccess.SqlExecuteReader("spGetAllSuppliers");
            if(sdr.HasRows)
            {
                while(sdr.Read())
                {
                    Model.Supplier supplier = new Model.Supplier();
                    supplier.SupplierName = sdr["supplier_name"].ToString();
                    suppliers.Add(supplier.SupplierName);
                }
            }
            dataAccess.Dispose();
            return suppliers;
        }

        public string GetSupplierid(Model.Supplier supplier)
        {
            supplier.Supplierid = Convert.ToString(dataAccess.SqlExecuteScalar("spGetSupplierid", "suppliername", supplier.SupplierName));
            return supplier.Supplierid;
        }
    }
}
