using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.Model
{
    public class Category
    {
        //private static int count = 1;
        private string categoryid;
        private string categoryName;

        private List<CategoryOrigin> categoryOrigins = new List<CategoryOrigin>();

        public List<CategoryOrigin> CategoryOrigins
        {
            get { return categoryOrigins; }
            set { this.categoryOrigins = value; }
        }
        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }

        public string Categoryid
        {
            get { return categoryid; }
            set 
            {
                categoryid = value;
            }
        }
        public Category()
        {
            this.categoryName = string.Empty;
            this.categoryid = string.Empty;
        }
        public Category(string cn)
        {
            this.categoryName = cn;
        }
        public Category(string categoryid,string cn)
        {
            this.categoryid = categoryid;
            this.categoryName = cn;
        }
        public Category(string categoryid, string cn,List<CategoryOrigin> categoryOrigins)
        {
            this.categoryid = categoryid;
            this.categoryName = cn;
            this.categoryOrigins = categoryOrigins;
        }
    }
}
