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
    public partial class PanelAddExpenses : Form
    {
        Business_Layer.ExpenseService expenseService;
        string userid;
        public PanelAddExpenses(string userid)
        {
            InitializeComponent();
            this.userid = userid;
            expenseService = new Business_Layer.ExpenseService();

            expenseGridView.AutoGenerateColumns = false;
            expenseGridView.ColumnCount = 4;
            expenseGridView.Columns[0].HeaderText = "Expense Name";
            //expenseGridView.Columns[0].DataPropertyName = "invoice_id";
            expenseGridView.Columns[1].HeaderText = "Expense Details";
            //expenseGridView.Columns[1].DataPropertyName = "customer_id";
            expenseGridView.Columns[2].HeaderText = "Referense No";
            //expenseGridView.Columns[2].DataPropertyName = "";
            expenseGridView.Columns[3].HeaderText = "Ammount";
            //expenseGridView.Columns[3].DataPropertyName = "am";

            expenseGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            expenseCategoryComboBox.DataSource = new Business_Layer.ExpenseService().GetAllExpenseCategory();
        }

        //int count = 0;
        private void btnStockAdd_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                string expensename = expenseCategoryComboBox.SelectedItem.ToString();
                float amount = float.Parse(expenseAmmount.Text);
                string expenseDeatils = expenseDetailstextBox.Text;
                string reference = referenceTextBox.Text;
                if (rowNumber >= 0)
                {
                    
                    expenseGridView.Rows.RemoveAt(rowNumber);
                    expenseGridView.Rows.Insert(rowNumber, expensename, expenseDeatils, reference, amount);
                    rowNumber = -1;
                }
                else
                {
                    expenseGridView.Rows.Add(expensename, expenseDeatils, reference, amount);
                }
            }
            else
            {
                MessageBox.Show("NOt Valid");
            }
            rowNumber = -1;
            checknumber = -1;
        }

        private bool ValidateForm()
        {
            if (!expenseCategoryComboBox.Items.Contains(expenseCategoryComboBox.SelectedItem.ToString()))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(expenseAmmount.Text))
            {
                return false;
            }
            else if (!float.TryParse(expenseAmmount.Text, out float exect))
            {
                return false;
            }
            else
                return true;
        }
        int rowNumber=-1;
        int checknumber = -1;
        private void expenseGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (expenseGridView.Rows[e.RowIndex].Cells[0].Selected)
            {
                expenseCategoryComboBox.Text = expenseGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                expenseAmmount.Text = expenseGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                expenseDetailstextBox.Text = expenseGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                referenceTextBox.Text = expenseGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                rowNumber = e.RowIndex;
                checknumber = e.RowIndex;
            }
        }

        private void deletedButton_Click(object sender, EventArgs e)
        {
            if(checknumber>=0)
            {
                expenseGridView.Rows.RemoveAt(checknumber);
            }
            checknumber = -1;
            rowNumber = -1;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            string expensename = expenseCategoryComboBox.SelectedItem.ToString();
            float amount = float.Parse(expenseAmmount.Text);
            string expenseDeatils = expenseDetailstextBox.Text;
            string reference = referenceTextBox.Text;

            if (expenseGridView.ColumnCount>0)
            {
                int count = 0;
                for(int i=0; i< expenseGridView.ColumnCount;i++)
                {
                    expenseService = new Business_Layer.ExpenseService();
                    count =count + expenseService.AddtoExpenseList(expensename, expenseDeatils, reference,userid,DateTime.Now.ToString(),amount.ToString());
                }
                if(count== expenseGridView.ColumnCount)
                {
                    MessageBox.Show("Successfuly included");
                }
                expenseGridView.Rows.Clear();
                expenseGridView.Refresh();
            }
        }
    }
}
