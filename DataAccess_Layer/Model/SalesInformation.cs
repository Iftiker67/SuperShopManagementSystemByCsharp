using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.Model
{
    public class SalesInformation
    {
        private string salesid;
        private string supplyid;
        private string invoiceNumber;
        private int quantity;
        private float sellPrice;
        private float discount;

        public float Discount
        {
            get { return discount; }
            set { discount = value; }
        }
        public float SellPrice
        {
            get { return sellPrice; }
            set { sellPrice = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public string InvoiceNumber
        {
            get { return invoiceNumber; }
            set { invoiceNumber = value; }
        }
        public string Supplyid
        {
            get { return supplyid; }
            set { supplyid = value; }
        }

        public string Salesid
        {
            get { return salesid; }
            set { salesid = value; }
        }

    }
}
