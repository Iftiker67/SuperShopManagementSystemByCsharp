using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class EmployeeService
    {
        DataAccess_Layer.AccessData.EmployeeDataAccess employeeDataAccess;
        public EmployeeService()
        {
            employeeDataAccess = new DataAccess_Layer.AccessData.EmployeeDataAccess();
        }

        public string AddEmployee(string fn, string pn,string bloodG, string email, DateTime time, string jobTitle, string gender, string address, string photoId,string branchName,string departmentName,bool account)
        {
            DataAccess_Layer.Model.Employee employee = new DataAccess_Layer.Model.Employee();
            employee.EmployeeName = fn;
            employee.EmployeePhone = pn;
            employee.BloodGroup = bloodG;
            employee.Email = email;
            employee.JoiningDate = time;
            employee.Positionid = employeeDataAccess.GetPositionid(jobTitle);
            employee.Branchid = employeeDataAccess.GetBranchid(branchName);
            employee.Departmentid = employeeDataAccess.GetDpeartmentid(departmentName);
            employee.Gender = gender;
            employee.Address = address;
            employee.PhotoDirectory = photoId;
            employee.Employeeid = employeeDataAccess.InsertEmployee(employee,employee.Branchid,employee.Departmentid,employee.Positionid);
            string employeeInformation = "Employeename: "+employee.EmployeeName + "\n";
            if (!string.IsNullOrEmpty(employee.Employeeid))
            {
                if (account)
                {
                    employee.UserProfile = new DataAccess_Layer.Model.User();
                    DataAccess_Layer.Model.GeneratePassword gp = new DataAccess_Layer.Model.GeneratePassword();
                    employee.UserProfile.Password = gp.Pass;
                    //employeeDataAccess = new DataAccess_Layer.AccessData.EmployeeDataAccess();
                    string userid = employeeDataAccess.CreateUser(employee.UserProfile.Password, employee.Employeeid);
                    employeeInformation = employeeInformation +"Userid:"+ userid+"\nPass:"+employee.UserProfile.Password;
                    return employeeInformation;
                }
                else
                {
                    return employeeInformation;
                }

            }
            else
            {
                return string.Empty;
            }
        }

        public int GetAccessbility(string userid)
        {
            return employeeDataAccess.GetAccessibilty(userid);
        }
        public bool UserExist(string userid, string password)
        {
            bool result = employeeDataAccess.UserExist(userid, password);
            if (result)
            {
                return true;
            }
            return false;
        }
        public bool ExistDuplicateNumber(string number)
        {
            return employeeDataAccess.ExistDuplicateNumber(number);
        }

        public string GetBranchName(string userid)
        {
            return employeeDataAccess.GetBranchName(userid);
        }
    }
}
