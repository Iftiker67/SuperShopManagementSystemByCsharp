using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.UI.PanelUI
{
    public partial class PanelProfitLossReports : Form
    {
        Business_Layer.CategoryService categoryService;
        Business_Layer.ProductService productService;
        Business_Layer.ReportService reportService;
        public PanelProfitLossReports()
        {
            InitializeComponent();
            categoryService = new Business_Layer.CategoryService();
            productService = new Business_Layer.ProductService();
            reportService = new Business_Layer.ReportService();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimePicker1.Value<dateTimePicker2.Value && dateTimePicker1.Value<DateTime.Now)
            {
               SortedList<string,int> incomes = reportService.GetIncome(dateTimePicker1.Value.ToString(),dateTimePicker2.Value.ToString());
               incomeChart.Series[0].Points.DataBindXY(incomes.Keys.ToArray(), incomes.Values.ToArray());
            }
            else
            {
                MessageBox.Show("Select Date properly");
            }
        }



        private void PanelProfitLossReports_Load(object sender, EventArgs e)
        {
            categoryCombobox.DataSource = categoryService.GetAllCategory();
            productCombobox.DataSource = productService.GetAllCompanyProducts();
            revenueChart.Series[0].Points.DataBindXY(reportService.GetRevenGetRevenue().Keys.ToArray(), reportService.GetRevenGetRevenue().Values.ToArray());
            incomeChart.Series[0].Points.DataBindXY(reportService.GetIncome().Keys.ToArray(),reportService.GetIncome().Values.ToArray());
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimePicker3.Value<dateTimePicker4.Value && dateTimePicker3.Value<DateTime.Now)
            {
                //Todo--
                SortedList<string, int> revenue = reportService.GetRevenGetRevenue(dateTimePicker3.Value.ToString(), dateTimePicker4.Value.ToString());
                revenueChart.Series[0].Points.DataBindXY(revenue.Keys.ToArray(),revenue.Values.ToArray());
            }
            else
            {
                MessageBox.Show("Please Select Date Properly");
            }
        }

        private void categoryCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("hi");
            if(categoryCombobox.Items.Contains(categoryCombobox.SelectedItem.ToString()))
            {
                //MessageBox.Show("bye");
                SortedList<string,int> sorted =reportService.GetProfitByCategoryProucts(categoryCombobox.SelectedItem.ToString());
                categoryChart.Series[0].Points.DataBindXY(sorted.Keys.ToArray(),sorted.Values.ToArray());
            }
        }
    }
}
