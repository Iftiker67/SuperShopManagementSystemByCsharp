using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.Model
{
    public class Bill
    {
        private string invoiceNumber;
        private string customerid;
        private string employeeid;
        private DateTime soldDate;
        private float totalAmount;

        public float TotalAmount
        {
            get { return totalAmount; }
            set { totalAmount = value; }
        }
        public DateTime SoldDate
        {
            get { return soldDate; }
            set { soldDate = value; }
        }
        public string Employeeid
        {
            get { return employeeid; }
            set { employeeid = value; }
        }
        public string Customerid
        {
            get { return customerid; }
            set { customerid = value; }
        }

        public string InvoiceNumber
        {
            get { return invoiceNumber; }
            set { invoiceNumber = value; }
        }

    }
}
