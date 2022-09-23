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
    public partial class PanelPurchaseandSalesReports : Form
    {
        Business_Layer.CategoryService categoryService;
        Business_Layer.ProductService productService;
        Business_Layer.ReportService reportService;
        public PanelPurchaseandSalesReports()
        {
            InitializeComponent();
            categoryService = new Business_Layer.CategoryService();
            productService = new Business_Layer.ProductService();
            reportService = new Business_Layer.ReportService();
        }

        private void PanelPurchaseandSalesReports_Load(object sender, EventArgs e)
        {
            categoryComboBox.DataSource = categoryService.GetAllCategory();
            productCombobox.DataSource = productService.GetAllCompanyProducts();
            SortedList<int, int> sorted = reportService.GetSalesRate();
            sellsRateChart.Series[0].Points.DataBindXY(sorted.Keys.ToArray(), sorted.Values.ToArray());
        }

        private void categoryCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("hi");
            if (categoryComboBox.Items.Contains(categoryComboBox.SelectedItem.ToString()))
            {
                //MessageBox.Show("bye");
                SortedList<string, int> sorted = reportService.GetProfitByCategoryProucts(categoryComboBox.SelectedItem.ToString());
                categoryChart.Series[0].Points.DataBindXY(sorted.Keys.ToArray(), sorted.Values.ToArray());
            }
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void productChart_Click(object sender, EventArgs e)
        {

        }
        //TODO - working process
        string fromdate;
        string todate;
        private void toDateFormat_ValueChanged(object sender, EventArgs e)
        {
            if (fromdateFormat.Value < toDateFormat.Value && fromdateFormat.Value < DateTime.Now)
            {
                SortedList<string, int> incomes = reportService.GetIncome(fromdateFormat.Value.ToString(), toDateFormat.Value.ToString());
                sellsRateChart.Series[0].Points.DataBindXY(incomes.Keys.ToArray(), incomes.Values.ToArray());
                fromdate = fromdateFormat.Value.ToString();
                todate = toDateFormat.Value.ToString();
            }
            else
            {
                MessageBox.Show("Select Date properly");
            }
        }
        //TODo-- working processs
        private void productCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(productCombobox.Items.Contains(productCombobox.SelectedItem.ToString()))
            {
                //MessageBox.Show("bye");
                //SortedList<string, int> sorted = reportService.GetProfitByCategoryProucts(categoryComboBox.SelectedItem.ToString());
                //categoryChart.Series[0].Points.DataBindXY(sorted.Keys.ToArray(), sorted.Values.ToArray());
                SortedList<string, int> sorted = reportService.GetSalesRateByProductName(productCombobox.SelectedItem.ToString());
                productChart.Series[0].Points.DataBindXY(sorted.Keys,sorted.Values);
            }
            else
            {
                MessageBox.Show("Select properly");
            }
        }
    }
}
