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
    public partial class PanelSaleList : Form
    {
        Business_Layer.ProductService productService = new Business_Layer.ProductService();
        public PanelSaleList()
        {
            InitializeComponent();
            saleListDataGridView.AutoGenerateColumns = false;
            saleListDataGridView.ColumnCount = 7;
            saleListDataGridView.Columns[0].HeaderText = "Invoice No";
            saleListDataGridView.Columns[0].DataPropertyName = "invoice";
            saleListDataGridView.Columns[1].HeaderText = "Customer Id";
            saleListDataGridView.Columns[1].DataPropertyName = "cid";
            saleListDataGridView.Columns[2].HeaderText = "Sold Date";
            saleListDataGridView.Columns[2].DataPropertyName = "solddate";
            saleListDataGridView.Columns[3].HeaderText = "Product Name";
            saleListDataGridView.Columns[3].DataPropertyName = "pn";
            saleListDataGridView.Columns[4].HeaderText = "Supplier Name";
            saleListDataGridView.Columns[4].DataPropertyName = "sn";
            saleListDataGridView.Columns[5].HeaderText = "Quantity";
            saleListDataGridView.Columns[5].DataPropertyName = "quantity";
            saleListDataGridView.Columns[6].HeaderText = "Subtotal";
            saleListDataGridView.Columns[6].DataPropertyName = "subtotal";
            saleListDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void PanelSaleList_Load(object sender, EventArgs e)
        {
            saleListDataGridView.DataSource = productService.GetSalesList();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if ((dateTimePicker2.Value - dateTimePicker1.Value).TotalDays >= 0)
            {
                saleListDataGridView.DataSource = productService.GetSalesList(dateTimePicker1.Value, dateTimePicker2.Value);

            }
            else
            {
                MessageBox.Show("Select Date properly");
            }
        }
    }
}
