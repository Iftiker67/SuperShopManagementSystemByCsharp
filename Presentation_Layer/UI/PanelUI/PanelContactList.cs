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
    public partial class PanelContactList : Form
    {
        public PanelContactList()
        {
            InitializeComponent();
            contactListDataGridView.AutoGenerateColumns = false;
            contactListDataGridView.ColumnCount = 6;
            contactListDataGridView.Columns[0].HeaderText = "Invoice No";
            contactListDataGridView.Columns[0].DataPropertyName = "invoice_id";
            contactListDataGridView.Columns[1].HeaderText = "Customer Id";
            contactListDataGridView.Columns[1].DataPropertyName = "customer_id";
            contactListDataGridView.Columns[2].HeaderText = "Sold Date";
            contactListDataGridView.Columns[2].DataPropertyName = "solddate";
            contactListDataGridView.Columns[3].HeaderText = "Product Name";
            contactListDataGridView.Columns[3].DataPropertyName = "product_name";
            contactListDataGridView.Columns[4].HeaderText = "Quantity";
            contactListDataGridView.Columns[4].DataPropertyName = "quantity";
            contactListDataGridView.Columns[5].HeaderText = "Subtotal";
            contactListDataGridView.Columns[5].DataPropertyName = "subtotal";
            contactListDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
    }
}
