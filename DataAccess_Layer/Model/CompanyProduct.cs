using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.Model
{
    public class CompanyProduct
    {
        private string companyProductid;
        private string productid;
        private string supplierid;
        private float purchasePrice;
        private float margin;
        private string tax;

        public string Tax
        {
            get { return tax; }
            set { tax = value; }
        }


        public float Margin
        {
            get { return margin; }
            set { margin = value; }
        }
        public float PurchasePrice
        {
            get { return purchasePrice; }
            set { purchasePrice = value; }
        }
        public string Supplierid
        {
            get { return supplierid; }
            set { supplierid = value; }
        }

        public string Productid
        {
            get { return productid; }
            set { productid = value; }
        }

        public string CompanyProductid
        {
            get { return companyProductid; }
            set { companyProductid = value; }
        }

    }
}
