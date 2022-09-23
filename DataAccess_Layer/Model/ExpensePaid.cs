using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.Model
{
    public class ExpensePaid //expenselist table
    {
        private string expensePaidid;
        private int expenseid;
        private int branchid;
        private DateTime clearDate;

        public DateTime ClearDate
        {
            get { return clearDate; }
            set { clearDate = value; }
        }

        public int Branchid
        {
            get { return branchid; }
            set { branchid = value; }
        }

        public int Expenseid
        {
            get { return expenseid; }
            set { expenseid = value; }
        }

        public string ExpensePaidid
        {
            get { return expensePaidid; }
            set { expensePaidid = value; }
        }

    }
}
