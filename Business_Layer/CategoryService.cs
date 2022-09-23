using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class CategoryService
    {
        DataAccess_Layer.AccessData.CategoryDataAccess categoryDataAccess;
        public CategoryService()
        {
            this.categoryDataAccess = new DataAccess_Layer.AccessData.CategoryDataAccess();
        }

        public DataTable GetCategoryOriginInformation(string categoryName)
        {
            DataTable dataTable = new DataTable();
            dataTable = categoryDataAccess.GetCategoryOriginInformation(categoryName);
            return dataTable;
        }

        public bool InsertCategoryOrigin(string categoryid, string categoryOriginName,float tax)
        {
            bool result;
            DataAccess_Layer.Model.CategoryOrigin co = new DataAccess_Layer.Model.CategoryOrigin(categoryOriginName,tax);
            DataAccess_Layer.Model.Category category = new DataAccess_Layer.Model.Category();
            category.Categoryid = categoryid;
            result = categoryDataAccess.SqlInsertCategoryOrigin(category,co);
            return result;
        }

        public bool UpdatecategoryOrigin(string categoryid, string categoryOriginName, float tax)
        {
            bool result;
            DataAccess_Layer.Model.CategoryOrigin co = new DataAccess_Layer.Model.CategoryOrigin();
            co.CategroryOriginName = categoryOriginName;
            co.Tax = tax;
            DataAccess_Layer.Model.Category category = new DataAccess_Layer.Model.Category();
            category.Categoryid = categoryid;
            result = categoryDataAccess.SqlUpdateCategoryOrigin(category, co);
            return result;
        }
        public List<string> GetAllCategory()
        {
            return categoryDataAccess.GetAllCategory();
        }
        public string InsertCategory(string categoryName)
        {
            string result = categoryDataAccess.SqlInsertQuery(categoryName);
            return result;
        }
        public string ExistCategoryOrigin(string categoryid, string categoryOriginName)
        {
            DataAccess_Layer.Model.Category category = new DataAccess_Layer.Model.Category();
            category.Categoryid = categoryid;

            DataAccess_Layer.Model.CategoryOrigin categoryOrigin = new DataAccess_Layer.Model.CategoryOrigin();
            categoryOrigin.CategroryOriginName = categoryOriginName;

            return categoryDataAccess.ExistCategoryOrigin(category,categoryOrigin);
        }

        public string GetCategoryOrigin(string categoryid, string categoryOriginName)
        {
            DataAccess_Layer.Model.Category category = new DataAccess_Layer.Model.Category();
            category.Categoryid = categoryid;

            categoryDataAccess = new DataAccess_Layer.AccessData.CategoryDataAccess();
            DataAccess_Layer.Model.CategoryOrigin categoryOrigin = new DataAccess_Layer.Model.CategoryOrigin();
            categoryOrigin.CategroryOriginName = categoryOriginName;
            categoryOrigin.COid = categoryDataAccess.ExistCategoryOrigin(category, categoryOrigin);
            if (!string.IsNullOrEmpty(categoryOrigin.COid))
            {
                return categoryOrigin.COid;
            }
            else
            {
                return string.Empty;
            }
            //category.CategoryName = categoryName;
            //category.Categoryid = categoryDataAccess.GetCategoryid(category.CategoryName);
            //DataAccess_Layer.Model.CategoryOrigin categoryOrigin= new DataAccess_Layer.Model.CategoryOrigin();
            //categoryOrigin.COid = category.Categoryid + categoryName;
            //bool result = categoryDataAccess.ExistCategoryOrigin(categoryOrigin);
            //return category.Categoryid;
        }

        public string GetCategoryID(string categoryName)
        {
            string result = categoryDataAccess.GetCategoryid(categoryName);
            return result;
        }



    }
}
