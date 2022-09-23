using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.AccessData
{
    public class BillDataAccess
    {
        DataAccess dataAccess;
        public BillDataAccess()
        {
            dataAccess = new DataAccess();
        }
        public string GenarateBill(string userid, string purchaseDate)
        {
            string result = dataAccess.SqlExecuteNonQueryWithoutParameter("spGenerateBill","@invoice", "userid", "selldate", userid,purchaseDate);
            if(string.IsNullOrEmpty(result))
            {
                return string.Empty;
            }
            else
            {
                return result;
            }
        }

        public bool AddtoSales(string pname, string sname, string invoice, string quantity)
        {
            int i = dataAccess.SqlExecuteNonQuery("spAddToSales", "pname", "sname", "invoice", "quantity", pname, sname, invoice, quantity);
            if(i>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string UpdateInvoice(string invoice)
        {
            return string.Empty;
            //todo-- allready did in trggier 
            //return dataAccess.SqlExecuteNonQuery("spUpdateBills",)
        }

        public string GetTotalAmountSpecificInvoice(string invoice)
        {
            return Convert.ToString(dataAccess.SqlExecuteScalar("spGetTotalAmmount", "invoice",invoice));
        }

        public bool UpdateCustomer(string invoice,string cn)
        {
            int i = dataAccess.SqlExecuteNonQuery("spUpdateInvoice_Customerid", "invoice", "customerid", invoice, cn);
            return true;
        }

    }
}
