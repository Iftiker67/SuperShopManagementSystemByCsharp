using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class ReportService
    {
        DataAccess_Layer.AccessData.ReportDataAccess reportDataAccess;
        public ReportService()
        {
            reportDataAccess = new DataAccess_Layer.AccessData.ReportDataAccess();
        }

        //public SortedList<int,int> GetRevenGetRevenue()
        //{
        //    return reportDataAccess.GetRevenGetRevenue();
        //}
        public SortedList<string, int> GetRevenGetRevenue()
        {
            return reportDataAccess.GetRevenGetRevenue();
        }
        public SortedList<string, int> GetRevenGetRevenue(string fd, string td)
        {
            return reportDataAccess.GetRevenGetRevenue(fd,td);
        }

        public SortedList<string,int> GetIncome()
        {
            return reportDataAccess.GetIncome();
        }
        public SortedList<string, int> GetIncome(string fd, string td)
        {
            return reportDataAccess.GetIncome(fd, td);
        }

        public SortedList<string, int> GetProfitByCategoryProucts(string cn)
        {
            return reportDataAccess.GetProfitByCategoryProucts(cn);
        }
        //public SortedList<string, int> GetIncome(string fd, string td)
        //{
        //    return reportDataAccess.GetIncome(fd, td);
        //}

        public SortedList<int,int> GetSalesRate()
        {
            return reportDataAccess.GetSalesRate();
        }

        public SortedList<int, int> GetSalesRate(string fd, string td)
        {
            return reportDataAccess.GetSalesRate(fd,td);
        }
        public SortedList<string,int> GetSalesRateByProductName(string productName)
        {
            return reportDataAccess.GetSalesRateByProductName(productName);
        }


    }
}
