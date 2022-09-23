using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class SupplierService
    {
        DataAccess_Layer.AccessData.SupplierDataAccess supplierDataAccess;
        public SupplierService()
        {
            supplierDataAccess = new DataAccess_Layer.AccessData.SupplierDataAccess();
        }

        public List<string> GetAllSupplier()
        {
            return supplierDataAccess.SqlGetAllSuppliers();
        }
        public string GetSupplierid(string supppliername)
        {
            DataAccess_Layer.Model.Supplier supplier = new DataAccess_Layer.Model.Supplier();
            supplier.SupplierName = supppliername;
            return supplierDataAccess.GetSupplierid(supplier);
        }
    }
}
