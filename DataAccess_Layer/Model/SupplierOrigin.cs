using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.Model
{
    public class SupplierOrigin
    {
        private string originid;
        private string originName;

        public string OriginName
        {
            get { return originName; }
            set { originName = value; }
        }

        public string Originid
        {
            get { return originid; }
            set { originid = value; }
        }

    }
}
