using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class BillService
    {
        DataAccess_Layer.AccessData.BillDataAccess billDataAccess;
        public BillService()
        {
            billDataAccess = new DataAccess_Layer.AccessData.BillDataAccess();
        }
        public string GenarateBill(string userid, string purchaseDate)
        {
            return billDataAccess.GenarateBill(userid, purchaseDate);
        }

        public bool AddtoSales(string pname, string sname, string invoice, string quantity)
        {
            return billDataAccess.AddtoSales(pname, sname, invoice, quantity);
        }

        public string UpdateInvoice(string invoice)
        {
            return billDataAccess.UpdateInvoice(invoice);
        }

        public string GetTotalAmountSpecificInvoice(string invoice)
        {
            return billDataAccess.GetTotalAmountSpecificInvoice(invoice);
        }

        public bool UpdateCustomer(string invoice,string cn)
        {
            return billDataAccess.UpdateCustomer(invoice,cn);
        }
    }
}
