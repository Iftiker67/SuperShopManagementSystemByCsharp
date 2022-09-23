using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.AccessData
{
    public class ExpenseDataAccess
    {
        DataAccess dataAccess;
        public ExpenseDataAccess()
        {
            dataAccess = new DataAccess();
        }
        public int AddtoExpenseList(string expenseName,string expenseDetails,string reference, string userid, string clearDate,string amount)
        {
            int i = 0;
            if(string.IsNullOrEmpty(expenseDetails) && string.IsNullOrEmpty(reference))
            {
                i = dataAccess.SqlExecuteNonQuery("spInsertAddtoExpenseWithout_Expense_Refer", "en", "userid", "d","am", expenseName, userid, clearDate,amount);
                return i;
            }
            else if(string.IsNullOrEmpty(expenseDetails))
            {
                i = dataAccess.SqlExecuteNonQuery("spInsertAddtoExpenseWithout_ExpenseDetails", "en", "reference", "userid", "d","am", expenseName,  reference, userid, clearDate,amount);
                return i;
            }
            else if(string.IsNullOrEmpty(reference))
            {
               i = dataAccess.SqlExecuteNonQuery("spInsertAddtoExpenseWithout_Refer", "en", "ed",  "userid", "d","am", expenseName, expenseDetails, userid, clearDate,amount);
                return i;
            }
            else
            {
               i = dataAccess.SqlExecuteNonQuery("spInsertAddtoExpense", "en", "ed", "reference", "userid", "d","am", expenseName, expenseDetails, reference, userid, clearDate,amount);
                return i;
            }

        }

        public List<string> GetAllExpenseCategory()
        {
            List<string> expensesName = new List<string>();
            SqlDataReader sdr = dataAccess.SqlExecuteReader("spGetAllEpensesName");
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    Model.Expense expense = new Model.Expense();
                    expense.ExpenseName = sdr[0].ToString();
                    expensesName.Add(expense.ExpenseName);
                }
            }
            sdr.Close();
            dataAccess.Dispose();
            return expensesName;
        }
    }
}
