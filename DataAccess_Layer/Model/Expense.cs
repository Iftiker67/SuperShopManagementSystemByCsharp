using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.Model
{
    public class Expense
    {
        private int expenseid;
        private string expenseName;

        public string ExpenseName
        {
            get { return expenseName; }
            set { expenseName = value; }
        }

        public int Expenseid
        {
            get { return expenseid; }
            set { expenseid = value; }
        }

    }
}
