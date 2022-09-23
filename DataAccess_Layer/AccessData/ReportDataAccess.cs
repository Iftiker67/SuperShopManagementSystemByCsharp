using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.AccessData
{
    public class ReportDataAccess
    {
        DataAccess dataAccess;
        public ReportDataAccess()
        {
            dataAccess = new DataAccess();
        }

        //public SortedList<int, int> GetRevenGetRevenue()
        //{
        //    SortedList<int, int> getRevenue = new SortedList<int, int>();
        //    SqlDataReader sdr = dataAccess.SqlExecuteReader("spGetProfit");
        //    if (sdr.HasRows)
        //    {
        //        while (sdr.Read())
        //        {
        //            getRevenue.Add(Convert.ToInt32(sdr.GetString(0)), Convert.ToInt32(sdr.GetString(1)));
        //        }
        //    }
        //    dataAccess.Dispose();
        //    return getRevenue;
        //}
        public SortedList<string, int> GetRevenGetRevenue()
        {
            SortedList<string, int> getRevenue = new SortedList<string, int>();
            SqlDataReader sdr = dataAccess.SqlExecuteReader("spGetProfit");
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    getRevenue.Add(sdr.GetString(0),Convert.ToInt32(sdr.GetString(1)));
                }
            }
            dataAccess.Dispose();
            return getRevenue;
        }
        public SortedList<string, int> GetRevenGetRevenue(string fd,string td)
        {
            SortedList<string, int> getRevenue = new SortedList<string, int>();
            SqlDataReader sdr = dataAccess.SqlExecuteReader("spGetProfitByDate", "fd","td",fd,td);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    getRevenue.Add(sdr.GetString(0), Convert.ToInt32(sdr.GetString(1)));
                }
            }
            dataAccess.Dispose();
            return getRevenue;
        }

        public SortedList<string, int> GetIncome()
        {
            SortedList<string, int> getIncome = new SortedList<string, int>();
            SqlDataReader sdr = dataAccess.SqlExecuteReader("spGetIncome");
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    getIncome.Add(Convert.ToString(sdr.GetInt32(0)), (int)sdr.GetDouble(1));
                }
            }
            dataAccess.Dispose();
            return getIncome;
        }
        public SortedList<string, int> GetIncome(string fd, string td)
        {
            SortedList<string, int> getIncome = new SortedList<string, int>();
            SqlDataReader sdr = dataAccess.SqlExecuteReader("spGetIncomeBydate", "fd","td",fd,td);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    getIncome.Add(Convert.ToString(sdr.GetInt32(0)), (int)sdr.GetDouble(1));
                }
            }
            dataAccess.Dispose();
            return getIncome;
        }

        //TODO working------
        public SortedList<string, int> GetProfitByCategoryProucts(string cn)
        {
            SortedList<string, int> getIncome = new SortedList<string, int>();
            SqlDataReader sdr = dataAccess.SqlExecuteReader("spGetProfitByCategoryProucts","categoryname",cn);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    getIncome.Add(sdr.GetString(0), sdr.GetInt32(1));
                }
            }
            dataAccess.Dispose();
            return getIncome;
        }

        public SortedList<int, int> GetSalesRate()
        {
            SortedList<int, int> getIncome = new SortedList<int, int>();
            SqlDataReader sdr = dataAccess.SqlExecuteReader("spShowSales");
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    getIncome.Add(sdr.GetInt32(0), sdr.GetInt32(1));
                }
            }
            dataAccess.Dispose();
            return getIncome;
        }

        public SortedList<int, int> GetSalesRate(string fd, string td)
        {
            SortedList<int, int> getIncome = new SortedList<int, int>();
            SqlDataReader sdr = dataAccess.SqlExecuteReader("spShowSalesByDate","fd","td",fd,td);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    getIncome.Add(sdr.GetInt32(0), sdr.GetInt32(1));
                }
            }
            dataAccess.Dispose();
            return getIncome;
        }
        public SortedList<string, int> GetSalesRateByProductName(string pn)
        {
            SortedList<string, int> getIncome = new SortedList<string, int>();
            SqlDataReader sdr = dataAccess.SqlExecuteReader("spGetSalesRateBYProductname", "pn",pn);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    getIncome.Add(sdr.GetString(0), sdr.GetInt32(1));
                }
            }
            dataAccess.Dispose();
            return getIncome;
        }


    }
}
