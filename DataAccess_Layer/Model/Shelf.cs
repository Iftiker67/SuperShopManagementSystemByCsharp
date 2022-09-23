using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.Model
{
    public class Shelf
    {
        private int shelfno;
        private string shelfName;
        private string categoryid;

        public string Categoryid
        {
            get { return categoryid; }
            set { categoryid = value; }
        }

        public string ShelfName
        {
            get { return shelfName; }
            set { shelfName = value; }
        }

        public int Shelfno
        {
            get { return shelfno; }
            set { shelfno = value; }
        }

    }
}
