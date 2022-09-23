using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.AccessData
{
    public class CategoryDataAccess
    {
        AccessData.DataAccess dataAccess;
        Model.Category category;
        public CategoryDataAccess()
        {
            dataAccess = new DataAccess();
        }

        public DataTable GetCategoryOriginInformation(string categoryName)
        {
            return dataAccess.SqlDataTable("spSearchByCategoryName", "categoryname", categoryName);
        }

        public bool SqlInsertCategoryOrigin(Model.Category category,Model.CategoryOrigin co)
        {
            int result = dataAccess.SqlExecuteNonQuery("spInsertCategoryOrigin", "categoryid", "categoryorigin", "tax" ,category.Categoryid,co.CategroryOriginName, co.Tax.ToString());
            if(result>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SqlUpdateCategoryOrigin(Model.Category category, Model.CategoryOrigin co)
        {
            int result = dataAccess.SqlExecuteNonQuery("spUpdateCategoryOrigin", "categoryid", "categoryorigin", "tax", category.Categoryid,co.CategroryOriginName, co.Tax.ToString());
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<string> GetAllCategory()
        {
            SqlDataReader sdr = dataAccess.SqlExecuteReader("spGetAllCategories");
            List<string> categories = new List<string>();
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    Model.Category category = new Model.Category();
                    category.CategoryName = sdr[0].ToString();
                    categories.Add(category.CategoryName);
                }
            }
            dataAccess.Dispose();
            return categories;
        }
        public string SqlInsertQuery(string cn)
        {
            category = new Model.Category();
            category.CategoryName = cn;
            int i = dataAccess.SqlExecuteNonQuery("spInsertCategory", "categoryname",category.CategoryName);
            if(i>0)
            {
                category.Categoryid = Convert.ToString(dataAccess.SqlExecuteScalar("spGetCategoryid", "categoryname", category.CategoryName));
                return category.Categoryid;
            }
            return string.Empty;
        }

        public string GetCategoryid(string cn)
        {
            category = new Model.Category();
            category.CategoryName = cn;
            category.Categoryid = dataAccess.GetId("spGetCategoryid", "categoryname", category.CategoryName);
            return category.Categoryid;
        }
        public string GetCategoryid(Model.Category category)
        {
            category.Categoryid = dataAccess.GetId("spGetCategoryid", "categoryname", category.CategoryName);
            return category.Categoryid;
        }

        //public bool CategoryOriginExist(string categoryid, string categoryOriginName)
        //{
        //    //categoryOrigin.Tax = tax;
        //    string categoriOriginid = Convert.ToString(dataAccess.SqlExecuteScalar("spExistCategoryOrigin", "categoryid", "categoryorigin",categoryid,categoryOriginName).ToString());
        //    if(!string.IsNullOrEmpty(categoriOriginid))
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        public string ExistCategoryOrigin(Model.Category category, Model.CategoryOrigin categoryOrigin)
        {
             return Convert.ToString(dataAccess.SqlExecuteScalar("spExistCategoryOrigin", "categoryid", "categoryorigin", category.Categoryid,categoryOrigin.CategroryOriginName));
            //if(i>0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
    }
}
