using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.Model
{
    public class Supplier
    {
        private string supplierid;
        private string supplierName;
        private string supplierPhone;
        private string supplierLandLine;
        private string supplierTaxNumber;

        public string Supplierid { get; set; }
        public string SupplierName { get; set; }
        public string SupplierPhone { get; set; }
        public string SupplierLandLine { get; set; }

        public string SupplierTaxNumber
        {
            get { return supplierTaxNumber; }
            set { supplierTaxNumber = value; }
        }

        public Supplier()
        {
            this.supplierid = string.Empty;
            this.supplierName = string.Empty;
            this.supplierPhone = string.Empty;
            this.SupplierLandLine = string.Empty;
            this.supplierTaxNumber = string.Empty;
        }

    }
}
