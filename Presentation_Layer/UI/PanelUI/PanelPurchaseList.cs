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
    public partial class PanelPurchaseList : Form
    {
        Business_Layer.ProductService productService = new Business_Layer.ProductService();
        public PanelPurchaseList()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].HeaderText = "Purchase Date";
            dataGridView1.Columns[1].HeaderText = "Product Name";
            dataGridView1.Columns[2].HeaderText = "Category";
            dataGridView1.Columns[3].HeaderText = "Supplier Name";
            dataGridView1.Columns[4].HeaderText = "Unit";
            dataGridView1.Columns[5].HeaderText = "Branch Name";
            dataGridView1.Columns[6].HeaderText = "Quantity";
            
            DataTable dt = productService.GetPurchaseList();
            dataGridView1.DataSource = dt;

            dataGridView1.Columns[0].DataPropertyName = "pdate";
            dataGridView1.Columns[1].DataPropertyName = "pn";
            dataGridView1.Columns[2].DataPropertyName = "cn";
            dataGridView1.Columns[3].DataPropertyName = "sn";
            dataGridView1.Columns[4].DataPropertyName = "unit";
            dataGridView1.Columns[5].DataPropertyName = "bname";
            dataGridView1.Columns[6].DataPropertyName = "quantity";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void PanelPurchaseList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = productService.GetPurchaseList();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if( (todatetimepickr.Value - fromdateTimepickr.Value).TotalDays <1 )
            {
                MessageBox.Show("Select date properly");
            }
            else
            {
                
                dataGridView1.DataSource = productService.GetPurchaseList( fromdateTimepickr.Value, todatetimepickr.Value);
            }
        }
    }
}
