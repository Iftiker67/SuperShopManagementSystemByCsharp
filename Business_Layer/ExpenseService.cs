using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class ExpenseService
    {
        DataAccess_Layer.AccessData.ExpenseDataAccess expenseDataAccess;
        public ExpenseService()
        {
            expenseDataAccess = new DataAccess_Layer.AccessData.ExpenseDataAccess();
        }
        public int AddtoExpenseList(string expenseName, string expenseDetails, string reference, string userid, string clearDate,string amount)
        {
            return expenseDataAccess.AddtoExpenseList(expenseName, expenseDetails, reference, userid, clearDate,amount);
        }

        public List<string> GetAllExpenseCategory()
        {
            return expenseDataAccess.GetAllExpenseCategory();
        }
    }
}
