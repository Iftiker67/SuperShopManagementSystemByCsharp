using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.Model
{
    public class Stock
    {
        private string stockid;
        private int branchid;
        private int quantiy;

        public int Quantity
        {
            get { return quantiy; }
            set { quantiy = value; }
        }

        public int Branchid
        {
            get { return branchid; }
            set { branchid = value; }
        }

        public string Stockid
        {
            get { return stockid; }
            set { stockid = value; }
        }

    }
}
