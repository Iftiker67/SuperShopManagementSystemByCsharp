using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.Model
{
    public class Employee
    {
        private string employeeid;
        private string employeeName;
        private string employeePhone;
        private string nid;
        private string address;
        private string bloodGroup;
        private DateTime joiningDate;
        private int salary;
        private float totalSale;
        private float comm;
        private string branchid;
        private string positionid;
        private string departmentid;
        private string email;
        private string gender;
        private User userProfile;
        public User UserProfile
        {
            get { return  this.userProfile; }
            set { this.userProfile = value; }
        }

        public string PhotoDirectory { get; set; }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string BloodGroup
        {
            get { return bloodGroup; }
            set { bloodGroup = value; }
        }
        public string Departmentid
        {
            get { return departmentid; }
            set { departmentid = value; }
        }

        public string Positionid
        {
            get { return positionid; }
            set { positionid = value; }
        }

        //TODO --
        public string Branchid
        {
            get { return branchid; }
            set { branchid = value; }
        }

        public float Comm
        {
            get { return comm; }
            set { comm = value; }
        }


        public float TotalSale
        {
            get { return totalSale; }
            set { totalSale = value; }
        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public DateTime JoiningDate
        {
            get { return joiningDate; }
            set { joiningDate = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Nid
        {
            get { return nid; }
            set { nid = value; }
        }

        public string EmployeePhone
        {
            get { return employeePhone; }
            set { employeePhone = value; }
        }

        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        public string Employeeid
        {
            get { return employeeid; }
            set { employeeid = value; }
        }
        public Employee()
        {
            
        }
    }
}
