using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.Model
{
    public class User
    {
        private string userid;
        private string password;

        public string Userid
        { get { return userid; } set { this.userid = value; } }
        public string Password 
        {
            get { return password; }
            set { this.password = value; }
        }

        public User()
        {
            this.Userid = string.Empty;
            this.Password = string.Empty;
        }

        public User(string userid, string password)
        {
            this.Userid = userid;
            this.Password = password;
        }
    }
}
