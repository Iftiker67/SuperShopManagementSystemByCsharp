using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class ProductService
    {
        DataAccess_Layer.AccessData.ProductDataAccess productDataAccess;
        public ProductService()
        {
            productDataAccess = new DataAccess_Layer.AccessData.ProductDataAccess();
        }

        public DataTable ViewProductLists()
        {
            return productDataAccess.ViewProductLists();
        }

        public DataTable ViewProductListsByCategory(string categoryName)
        {
            return productDataAccess.ViewProductListsByCategory(categoryName);
        }

        public DataTable ViewProductListsByProduct(string productName)
        {
            return productDataAccess.ViewProductListsByProduct(productName);
        }
        public bool InsertAddProduct(string pn,string cid, string unit)
        {
            if(!productDataAccess.ExistProduct(pn))
            {
                return productDataAccess.InsertProduct(pn, cid, unit);
            }
            return false;
        }
        public List<string> GetAllProducts()
        {
            return productDataAccess.GetAllProducts();
        }
        public string GetProductid(string productname)
        {
            DataAccess_Layer.Model.Product product = new DataAccess_Layer.Model.Product();
            product.ProductName = productname;
            return productDataAccess.GetProductid(product);
        }
        public object GetCompanyProductPrice(string companyProductid)
        {
            return productDataAccess.GetCompanyProductPrice(companyProductid);
        }
        public object GetCompanyProductPrice(string pn,string sn)
        {
            return productDataAccess.GetCompanyProductPrice(pn, sn);
        }
        public string GetCompanyProductid(string productname,string suppliername)
        {
            return productDataAccess.GetCompanyProductid(productname, suppliername);
        }
        public string InsertCompanyProduct(string productName, string supplierName, string purchasePrice, string marginPrice,string applicationTax)
        {
            return productDataAccess.InsertCompanyProduct(productName, supplierName, purchasePrice, marginPrice, applicationTax);
            
        }
        public bool UpdateCompanyProduct(string productName, string supplierName, string purchasePrice, string marginPrice, string applicationTax)
        {
            DataAccess_Layer.Model.CompanyProduct companyProduct = new DataAccess_Layer.Model.CompanyProduct();
            companyProduct.Productid = productDataAccess.GetCompanyProductid(productName, supplierName);
            companyProduct.PurchasePrice = float.Parse(purchasePrice);
            companyProduct.Margin = float.Parse(marginPrice);
            //DataAccess_Layer.Model.Product product = new DataAccess_Layer.Model.Product();
            //product.ProductName = productName;
            //companyProduct.Productid = productDataAccess.GetProductid(product);

            //DataAccess_Layer.Model.Supplier supplier = new DataAccess_Layer.Model.Supplier();
            //supplier.SupplierName = supplierName;
            //companyProduct.Supplierid = 

            return productDataAccess.UpdateCompanyProduct(companyProduct,productName,supplierName);
            
        }

        public bool PurchaseCompanyProduct( string quantity, string gtc, string referenceNumber,string userid, string cpid,string purchaseDate,string expireDate )
        {
            DataAccess_Layer.Model.PurchaseProduct purchaseCompnyProduct = new DataAccess_Layer.Model.PurchaseProduct();
            purchaseCompnyProduct.Quantity = Convert.ToInt32(quantity);
            purchaseCompnyProduct.GrandTotal = float.Parse(gtc);
            purchaseCompnyProduct.Referenceno = referenceNumber;
            //purchaseCompnyProduct.Employeeid = get;
            purchaseCompnyProduct.CompanyProductid = cpid;
            purchaseCompnyProduct.PurchaseDate = Convert.ToDateTime(purchaseDate);
            purchaseCompnyProduct.ExpireDate = Convert.ToDateTime(expireDate);
            return productDataAccess.PurchaseCompanyProduct(purchaseCompnyProduct,userid);
            
        }

        public bool AddCompanyProduct(string userid, string companyProductid, string quantity)
        {
            return productDataAccess.AddCompanyProduct(userid, companyProductid, quantity);
        }

        public string GetProductPrice(string productName, string supplierName)
        {
            return productDataAccess.GetProductPrice(productName, supplierName);
        }
        public List<string> GetAllCompanyProducts()
        {
            return productDataAccess.GetAllCompanyProducts();
        }
        public List<string> GetAllProductsByCategory(string categoryName)
        {
            return productDataAccess.GetAllProductsByCategory(categoryName);
        }
        public List<string> GetAllSuppliernameByProductName(string productName)
        {
            return productDataAccess.GetAllSuppliernameByProductName(productName);
        }
        public string GetCategorynameByProductName(string categoryName)
        {
            return productDataAccess.GetCategorynameByProductName(categoryName);
        }

        public DataTable GetPurchaseList()
        {
            return productDataAccess.GetPurchaseList();
        }

        public DataTable GetPurchaseList(DateTime fdate, DateTime todate)
        {
            return productDataAccess.GetPurchaseList(fdate,todate);
        }
        public DataTable GetSalesList()
        {
            return productDataAccess.GetSalesList();
        }
        public DataTable GetSalesList(DateTime fdate, DateTime todate)
        {
            return productDataAccess.GetPurchaseList(fdate,todate);
        }
        public DataTable GetSalesList(string invoice, string customer)
        {
            return productDataAccess.GetSalesList(invoice,customer);
        }

        public DataTable GetSalesList(string invoice)
        {
            return productDataAccess.GetSalesList(invoice);
        }
        public bool ReturnProduct(string invoice, string pn, string sn, string quantity)
        {
            return productDataAccess.ReturnProduct(invoice, pn, sn, quantity);
        }

        public object GetTax(string pn,string sn)
        {
            return productDataAccess.GetTax(pn,sn);
        }

    }
}
