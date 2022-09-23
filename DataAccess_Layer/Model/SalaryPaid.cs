using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.Model
{
    public class SalaryPaid
    {
        private int salaryPaidid;
        private string employeeid;
        private DateTime paidDate;

        public DateTime PaidDate
        {
            get { return paidDate; }
            set { paidDate = value; }
        }

        public string Employeeid
        {
            get { return employeeid; }
            set { employeeid = value; }
        }

        public int SalaryPaidid
        {
            get { return salaryPaidid; }
            set { salaryPaidid = value; }
        }

    }
}
