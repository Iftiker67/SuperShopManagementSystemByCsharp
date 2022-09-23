using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class BranchService
    {
        DataAccess_Layer.AccessData.BranchDataAccess branchDataAccess;
        public BranchService()
        {
            branchDataAccess = new DataAccess_Layer.AccessData.BranchDataAccess();
        }
        public List<string> GetAllBranches()
        {
            //TODO--
            return branchDataAccess.GetAllBranches();
        }

        public List<string> GetAllDepartments()
        {
            //TODO--
            return branchDataAccess.GetAllDepartments();
        }

        public List<string> GetAllTitles()
        {
            return branchDataAccess.GetAllTitles();
        }
    }
}
