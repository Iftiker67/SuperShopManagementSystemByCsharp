using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.AccessData
{
    public class BranchDataAccess
    {
        DataAccess dataAccess;
        public BranchDataAccess()
        {
            dataAccess = new DataAccess();
        }

        public List<string> GetAllBranches()
        {
            List<string> branches = new List<string>();
            SqlDataReader sdr = dataAccess.SqlExecuteReader("spGetAllBranchName");
            if(sdr.HasRows)
            {
                while(sdr.Read())
                {
                    Model.Branch branch =new Model.Branch();
                    branch.BranchName = sdr[0].ToString();
                    branches.Add(branch.BranchName);
                }
            }
            this.dataAccess.Dispose();
            return branches;
        }

        public List<string> GetAllDepartments()
        {
            List<string> departments = new List<string>();
            SqlDataReader sdr = dataAccess.SqlExecuteReader("spGetAllDepartmentName");
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    Model.Department department = new Model.Department();
                    department.DepartmentName = sdr[0].ToString();
                    departments.Add(department.DepartmentName);
                }
            }
            this.dataAccess.Dispose();
            return departments;
        }
        public List<string> GetAllTitles()
        {
            List<string> titles = new List<string>();
            SqlDataReader sdr = dataAccess.SqlExecuteReader("spGetALLTites");
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    Model.JobPosition title = new Model.JobPosition();
                    title.PositionName = sdr[0].ToString();
                    titles.Add(title.PositionName);
                }
            }
            this.dataAccess.Dispose();
            return titles;
        }

    }
}
