using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.AccessData
{
    public enum Procedures
    {
        spExistProduct,


    }
    public class ProductDataAccess
    {
        DataAccess dataAccess;
        public ProductDataAccess()
        {
            dataAccess = new DataAccess();
        }

        public DataTable ViewProductLists()
        {
            return dataAccess.SqlDataTable("spViewProductList");
        }
        public DataTable ViewProductListsByCategory_Product(string categoryName, string productName)
        {
            return dataAccess.SqlDataTable("spViewProductListByCategory_Product","categoryname", "productname", categoryName,productName);
        }
        public DataTable ViewProductListsByCategory(string categoryName)
        {
            return dataAccess.SqlDataTable("spViewProductListByCategoryname", "categoryname",categoryName);
        }
        public DataTable ViewProductListsByProduct(string productName)
        {
            return dataAccess.SqlDataTable("spViewProductListByProductName", "productname",productName);
        }

        public object GetCompanyProductPrice(string companyProductid)
        {
            return dataAccess.SqlExecuteScalar("spGetCompanyProductPrice","companyproductid",companyProductid);
        }

        public object GetCompanyProductPrice(string pn, string sn)
        {
            return dataAccess.SqlExecuteScalar("spGetSellPrice","pn","sn",pn, sn);
        }
        //public object GetCompnayProductPrice(string pn, string sn)
        //{
        //    return dataAccess.SqlExecuteScalar("spGetSellPrice", "pn", "sn",pn,sn);
        //}
        public bool ExistProduct(string productName)
        {
            int i = int.Parse(dataAccess.SqlExecuteScalar(Procedures.spExistProduct.ToString(), "productname", productName).ToString());
            //dataAccess.Dispose();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool InsertProduct(string pn, string cid, string unit)
        {
            DataAccess_Layer.Model.Product product = new Model.Product(pn, unit, cid);
            int i = dataAccess.SqlExecuteNonQuery("spInsertProduct", "productname", "categoryid", "unit", product.ProductName, product.Categoryid, product.Unit);
            if (i > 0)
            {
                return true;
            }
            return false;
        }

        public List<string> GetAllProducts()
        {
            List<string> products = new List<string>();
            SqlDataReader sdr = dataAccess.SqlExecuteReader("spGetAllProducts");
            if(sdr.HasRows)
            {
                while(sdr.Read())
                {
                    Model.Product product = new Model.Product();
                    product.ProductName = sdr["product_name"].ToString();
                    products.Add(product.ProductName);
                }
            }
            sdr.Close();
            dataAccess.Dispose();
            return products;
        }

        public string GetProductid(Model.Product product)
        {
            return Convert.ToString(dataAccess.SqlExecuteScalar("spGetProductid", "productname", product.ProductName));
        }

        public string GetCompanyProductid(Model.CompanyProduct cp)
        {
            return Convert.ToString(dataAccess.SqlExecuteScalar("spGetCompanyProductid", "productid", "supplierid", cp.Productid, cp.Supplierid));
        }
        public string GetCompanyProductid(string pn, string sp)
        {
            return Convert.ToString(dataAccess.SqlExecuteScalar("spGetCompanyProductidByProductNameSupplierName", "pn", "sp", pn, sp));
        }

        public string InsertCompanyProduct(string productName, string supplierName, string purchasePrice, string marginPrice, string applicationTax)
        {
            int i = dataAccess.SqlExecuteNonQuery("spInsertCompanyProduct", "pn", "sp", "pp", "mp", "tax", productName, supplierName, purchasePrice, marginPrice, applicationTax);
            if (i > 0)
            {
                return GetCompanyProductid(productName, supplierName);
            }
            return string.Empty;
        }

        public bool UpdateCompanyProduct(Model.CompanyProduct cp,string productName,string supplierName)
        {
            int i = dataAccess.SqlExecuteNonQuery("spUpdateCompanyProduct", "pn", "sp", "pp", "mp", "tax", productName, supplierName, cp.PurchasePrice, cp.Margin, cp.Tax);
            if(i>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PurchaseCompanyProduct(Model.PurchaseProduct purchaseCP,string userid)
        {
            int i;
            if(!string.IsNullOrEmpty(purchaseCP.Referenceno))
            {
                i = dataAccess.SqlExecuteNonQuery("spInsertPurchaseList", "@quantity",
                                                                            "@gtc",
                                                                            "@refrence",
                                                                            "@userid",
                                                                            "@supplyid",
                                                                            "@purchasedate",
                                                                            "@expireddate",
                                                                            purchaseCP.Quantity.ToString(),
                                                                            purchaseCP.GrandTotal.ToString(),
                                                                            purchaseCP.Referenceno,
                                                                            userid,
                                                                            purchaseCP.CompanyProductid,
                                                                            purchaseCP.PurchaseDate.ToString(),
                                                                            purchaseCP.ExpireDate.ToString());
            }
            else
            {
                i = dataAccess.SqlExecuteNonQuery("spInsertPurchaseListWithoutReference", "@quantity",
                                                                            "@gtc",
                                                                            "@userid",
                                                                            "@supplyid",
                                                                            "@purchasedate",
                                                                            "@expireddate",
                                                                            purchaseCP.Quantity.ToString(),
                                                                            purchaseCP.GrandTotal.ToString(),
                                                                            userid,
                                                                            purchaseCP.CompanyProductid,
                                                                            purchaseCP.PurchaseDate.ToString(),
                                                                            purchaseCP.ExpireDate.ToString());
            }
            if(i>0)
            {
                //dataAccess.SqlExecuteNonQuery()
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AddCompanyProduct(string userid, string companyProductid, string quantity)
        {
            int i = dataAccess.SqlExecuteNonQuery("spAddCompanyProduct", "userid","companyproduct","quantity",userid,companyProductid,quantity);
            if(i>0)
            {
                return true;
            }
            return false;
        }


        public string GetProductPrice(string productName, string supplierName)
        {
            return Convert.ToString(dataAccess.SqlExecuteScalar("spGetProductPriceBY_productname_suppliername", "pn", "sn", productName, supplierName));
        }

        public List<string> GetAllCompanyProducts()
        {
            List<string> companyProducts = new List<string>();
            SqlDataReader sdr = dataAccess.SqlExecuteReader("spGetAllCompanyProducts");
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    Model.Product companyProduct = new Model.Product();
                    companyProduct.ProductName = sdr[0].ToString();
                    companyProducts.Add(companyProduct.ProductName);
                }
            }
            sdr.Close();
            dataAccess.Dispose();
            return companyProducts;
        }
        public List<string> GetAllProductsByCategory(string categoryName)
        {
            List<string> categoryProducts = new List<string>();
            SqlDataReader sdr = dataAccess.SqlExecuteReader("spGetAllCompanyProductsBYCategoryName","categoryname",categoryName);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    Model.Product categoryProdut = new Model.Product();
                    categoryProdut.ProductName = sdr[0].ToString();
                    categoryProducts.Add(categoryProdut.ProductName);
                }
            }
            sdr.Close();
            dataAccess.Dispose();
            return categoryProducts;
        }

        public List<string> GetAllSupplierName(string categoryName)
        {
            List<string> categoryProducts = new List<string>();
            SqlDataReader sdr = dataAccess.SqlExecuteReader("spGetAllCompanyProductsBYCategoryName", "categoryname", categoryName);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    Model.Product categoryProdut = new Model.Product();
                    categoryProdut.ProductName = sdr[0].ToString();
                    categoryProducts.Add(categoryProdut.ProductName);
                }
            }
            sdr.Close();
            dataAccess.Dispose();
            return categoryProducts;
        }
        public List<string> GetAllSuppliernameByProductName(string productName)
        {
            List<string> suppliers = new List<string>();
            SqlDataReader sdr = dataAccess.SqlExecuteReader("spGetAllSuppliernameByProductName", "productname", productName);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    Model.Supplier supplier = new Model.Supplier();
                    supplier.SupplierName = sdr[0].ToString();
                    suppliers.Add(supplier.SupplierName);
                }
            }
            sdr.Close();
            dataAccess.Dispose();
            return suppliers;
        }

        public string GetCategorynameByProductName(string productName)
        {
            string categoryName =Convert.ToString( dataAccess.SqlExecuteScalar("spGetCategoryNameByProductName", "productname", productName));
            return categoryName;
        }

        public DataTable GetPurchaseList()
        {
            return dataAccess.SqlDataTable("spGetPurchaseList");
        }

        public DataTable GetPurchaseList(DateTime fdate, DateTime todate)
        {
            return dataAccess.SqlDataTable("spGetPurchaseListByDate", "fdate", "todate", fdate.ToString(), todate.ToString());
        }

        public DataTable GetSalesList()
        {
            return dataAccess.SqlDataTable("spGetSalesList");
        }

        public DataTable GetSalesList(DateTime fdate, DateTime todate)
        {
            return dataAccess.SqlDataTable("spGetPurchaseListByDate", "fdate","todate",fdate.ToString(),todate.ToString());
        }
        public DataTable GetSalesList(string invoice, string customer)
        {
            return dataAccess.SqlDataTable("spGetSalesListByInvoiceNumber_and_Customer", "invoice","customer",invoice,customer);
        }
        public DataTable GetSalesList(string invoice)
        {
            return dataAccess.SqlDataTable("spGetSalesListByInvoiceNumber", "invoice", invoice);
        }

        public bool ReturnProduct(string invoice, string pn, string sn, string quantity)
        {
            int i = dataAccess.SqlExecuteNonQuery("spReturnToaStock", "invoice","pn","sn","quantity",invoice,pn,sn,quantity);
            if(i>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public object GetTax(string pn,string sn)
        {
            return dataAccess.SqlExecuteScalar("spGetTaxByProductName_SupplierName","pn","sn",pn,sn);
        }
    }
}
