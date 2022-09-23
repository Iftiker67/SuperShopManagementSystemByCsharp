using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.Model
{
    public class Customer
    {
        private string customerid;
        private string customerName;
        private string customerAddress;
        private string nid;
        private float earningPoints;

        public float EarningPoints
        {
            get { return earningPoints; }
            set { earningPoints = value; }
        }

        public string Nid
        {
            get { return nid; }
            set { nid = value; }
        }

        public string CustomerAddress
        {
            get { return customerAddress; }
            set { customerAddress = value; }
        }
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public string Customerid
        {
            get { return customerid; }
            set { customerid = value; }
        }

    }
}
