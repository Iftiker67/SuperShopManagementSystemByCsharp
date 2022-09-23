using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.Model
{
    public class CategoryOrigin
    {
        private string coid;
        private float tax;
        private string catregoryOriginName;

        public string CategroryOriginName
        {
            get { return catregoryOriginName; }
            set { catregoryOriginName = value; }
        }

        public float Tax
        {
            get { return tax; }
            set { tax = value; }
        }

        public string COid
        {
            get { return coid; }
            set { coid = value; }
        }

        public CategoryOrigin()
        {

        }
        public CategoryOrigin(string categoryOriginName, float tax)
        {
            this.catregoryOriginName = categoryOriginName;
            this.tax = tax;
        }
        public CategoryOrigin(string categoryOriginName, string coid,float tax)
        {
            this.catregoryOriginName = categoryOriginName;
            this.coid = coid;
            this.tax = tax;
        }
        public enum Origin
        {
            Local,
            Foreign
        }
    }
}
