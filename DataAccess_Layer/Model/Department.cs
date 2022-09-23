using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.Model
{
    public class Department
    {
        private string departmentid;
        private string departmentName;
        private string departmentHead;

        public string DepartmentHead
        {
            get { return departmentHead; }
            set { departmentHead = value; }
        }

        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; }
        }

        public string Departmentid
        {
            get { return departmentid; }
            set { departmentid = value; }
        }

    }
}
