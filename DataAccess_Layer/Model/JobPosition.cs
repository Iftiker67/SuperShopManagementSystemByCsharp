using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.Model
{
    public class JobPosition
    {
        private string positionid;
        private string positionName;

        public string PositionName
        {
            get { return positionName; }
            set { positionName = value; }
        }

        public string Positionid
        {
            get { return positionid; }
            set { positionid = value; }
        }

    }
}
