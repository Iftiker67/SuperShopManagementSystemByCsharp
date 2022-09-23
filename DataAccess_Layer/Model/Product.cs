using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.Model
{
    public class Product
    {
        private string productid;
        private string productName;
        private string unit;
        private int totalQuantity;
        private string catergoryid;

        public string Productid 
        {
            get { return productid; }
            set { this.productid = value; } 
        }
        public string ProductName 
        { 
            get { return this.productName; } 
            set { this.productName = value; } 
        }
        public string Unit
        {
            get { return unit; }
            set { this.unit = value; }
        }
        public int TotalQuantity 
        {
            get { return totalQuantity; }
            set { this.totalQuantity = value; }
        }
        public string Categoryid 
        {
            get { return catergoryid; }
            set { this.catergoryid = value; }
        }

        public Product()
        {
            this.productid = string.Empty;
            this.productName = string.Empty;
            this.unit = string.Empty;
            this.totalQuantity = 0;
            this.catergoryid = string.Empty;
        }
        public Product(string pn, string unit, string categoryid)
        {
            this.productName = pn;
            this.unit = unit;
            this.catergoryid = categoryid;
        }
        public Product(string pid,string pn, string unit, string categoryid)
        {
            this.productid = pid;
            this.productName = pn;
            this.unit = unit;
            this.catergoryid = categoryid;
        }


    }
}
