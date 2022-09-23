using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.Model
{
    public class PurchaseProduct //purchase_list table
    {
        #region Instance Member
        private string purchaseno;
        private int qunatity;
        private float grandTotal;
        private string referenceno;
        private DateTime purchaseDate;
        private DateTime expireDate;
        private string employeeid;
        private int branchid;
        private string companyProductid;
        #endregion

        #region Property
        public string CompanyProductid
        {
            get { return companyProductid; }
            set { companyProductid = value; }
        }

        
        public int Branchid
        {
            get { return branchid; }
            set { branchid = value; }
        }

        public string Employeeid
        {
            get { return employeeid; }
            set { employeeid = value; }
        }

        public DateTime ExpireDate
        {
            get { return expireDate; }
            set { expireDate = value; }
        }


        public DateTime PurchaseDate
        {
            get { return purchaseDate; }
            set { purchaseDate = value; }
        }

        public string Referenceno
        {
            get { return referenceno; }
            set { referenceno = value; }
        }

        public float GrandTotal
        {
            get { return grandTotal; }
            set { grandTotal = value; }
        }

        public int Quantity
        {
            get { return qunatity; }
            set { qunatity = value; }
        }

        public string Purchaseno
        {
            get { return purchaseno; }
            set { purchaseno = value; }
        }
        #endregion
    }
}
