using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.Model
{
    public class Branch
    {
        private int branchid;
        private string branchName;

        public string BranchName
        {
            get { return branchName; }
            set { branchName = value; }
        }

        public int Branchid
        {
            get { return branchid; }
            set { branchid = value; }
        }

    }
}
