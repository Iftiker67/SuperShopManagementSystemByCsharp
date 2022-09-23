using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.AccessData
{
    public class EmployeeDataAccess
    {
        DataAccess_Layer.AccessData.DataAccess dataAccess;
        public EmployeeDataAccess()
        {
            dataAccess = new DataAccess_Layer.AccessData.DataAccess();
        }

        public bool ExistDuplicateNumber(string number)
        {
            if(string.IsNullOrEmpty(Convert.ToString(dataAccess.SqlExecuteScalar("spExistDuplicateNumber","pnumber",number))))
            {
                return false ;
            }
            return true;
        }
        public string CreateUser(string password,string employeeid)
        {
            //return Convert.ToString(dataAccess.SqlExecuteNonQuery("spInsertUser", "paas","eid", pass,employeeid));
            int i = dataAccess.SqlExecuteNonQuery("spInsertUser", "pass", "eid", password, employeeid);
            if (i>0)
            {
                return Convert.ToString(dataAccess.SqlExecuteScalar("spGetUserid", "eid", employeeid));
            }
            else
            {
                return string.Empty;
            }
        }
        public string InsertEmployee(Model.Employee employee,string bn, string dn, string pn)
        {
           
            if (string.IsNullOrEmpty(employee.PhotoDirectory))
            {
                //TODO-- insert employee
                //Stored procedure for insert employee not included photoDirectory
                int i = dataAccess.SqlExecuteNonQuery("spIEmployeesWithOutPhotDirectory", "en","ep","ea","jd","salary", "bid", "did", "pid",
                                                                                            employee.EmployeeName,employee.EmployeePhone,employee.Address,employee.JoiningDate.ToString(),
                                                                                            employee.Salary.ToString(),bn,dn,pn);

                if(i>0)
                {
                    return Convert.ToString(dataAccess.SqlExecuteScalar("spGetEmployeeidByNumber", "pn", employee.EmployeePhone));
                }
                else
                {
                    return string.Empty;
                }
            }
            else
            {
                //TODO --stored procedure with photodirectory Insert Employee
                int i = dataAccess.SqlExecuteNonQuery("spIEmployeesWithPhotoDirectory", "en", "ep", "ea", "jd", "salary", "bid", "did", "pid", "photDirectory",
                                                                                            employee.EmployeeName, employee.EmployeePhone, employee.Address, employee.JoiningDate.ToString(),
                                                                                            employee.Salary.ToString(), bn, dn, pn,employee.PhotoDirectory);
                
                if (i>0)
                {
                    return Convert.ToString(dataAccess.SqlExecuteScalar("spGetEmployeeidByNumber", "pn", employee.EmployeePhone));
                }
                else
                {
                    return string.Empty;
                }
            }
        }
        public string GetPositionid(string porsitionName)
        {
            Model.JobPosition jobPosition = new Model.JobPosition();
            jobPosition.PositionName = porsitionName;
            jobPosition.Positionid = dataAccess.SqlExecuteScalar("spGetPositionid", "pn",jobPosition.PositionName).ToString();
            return jobPosition.Positionid;
        }

        public string GetBranchid(string bname)
        {
            return Convert.ToString(dataAccess.SqlExecuteScalar("spGetBranchid", "bname", bname));
        }

        public string GetDpeartmentid(string dname)
        {
            return Convert.ToString(dataAccess.SqlExecuteScalar("spGetDepartmentid", "dname", dname));
        }
        public bool UserExist(string userid, string password)
        {
            int i = int.Parse(dataAccess.SqlExecuteScalar("spSearchUser", "user", "pass", userid, password).ToString());
            //int i = dataAccess.SqlExecuteQuery(userid,password);
            if (i > 0)
            {
                return true;
            }
            else
            { 
                return false; 
            }
        }

        public int GetAccessibilty(string userid)
        {
            return Convert.ToInt32(dataAccess.SqlExecuteScalar("spGetAccess", "userid", userid).ToString());
        }
        public string GetBranchName(string userid)
        {
            return Convert.ToString(dataAccess.SqlExecuteScalar("spGetBranchNameByUserid", "userid",userid));
        }
    }
}
