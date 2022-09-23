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
    public partial class PanelReturn : Form
    {
        Business_Layer.ProductService productService = new Business_Layer.ProductService();
        public PanelReturn()
        {
            InitializeComponent();
            purchaseHistoryDataGridView.AutoGenerateColumns = false;
            purchaseHistoryDataGridView.ColumnCount = 6;
            purchaseHistoryDataGridView.Columns[0].HeaderText = "Invoice No";
            purchaseHistoryDataGridView.Columns[0].DataPropertyName = "invoice";
            purchaseHistoryDataGridView.Columns[1].HeaderText = "Customer Id";
            purchaseHistoryDataGridView.Columns[1].DataPropertyName = "cid";
            purchaseHistoryDataGridView.Columns[2].HeaderText = "Product Name";
            purchaseHistoryDataGridView.Columns[2].DataPropertyName = "pn";
            purchaseHistoryDataGridView.Columns[3].HeaderText = "Supplier Name";
            purchaseHistoryDataGridView.Columns[3].DataPropertyName = "sn";
            purchaseHistoryDataGridView.Columns[4].HeaderText = "Quantity";
            purchaseHistoryDataGridView.Columns[4].DataPropertyName = "quantity";
            purchaseHistoryDataGridView.Columns[5].HeaderText = "Subtotal";
            purchaseHistoryDataGridView.Columns[5].DataPropertyName = "subtotal";
            purchaseHistoryDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        string invoicenumber;
        private void searchButton_Click(object sender, EventArgs e)
        {
            invoicenumber = string.Empty;
            string invoice = textBox1.Text;
            string customer = textBox2.Text;
            if (!string.IsNullOrEmpty(invoice) && !string.IsNullOrEmpty(customer))
            {
                purchaseHistoryDataGridView.DataSource = productService.GetSalesList(invoice, customer);
            }    
            else if(!string.IsNullOrEmpty(invoice) || !string.IsNullOrEmpty(customer))
            {
                if(!string.IsNullOrEmpty(invoice))
                {
                    purchaseHistoryDataGridView.DataSource = productService.GetSalesList(invoice);
                }
                else
                {
                    MessageBox.Show("Give invoice number as well");
                }
            }
            else
            {
                MessageBox.Show("Give some information");
            }
        }
        int quantity;
        string customerid;
        private void purchaseHistoryDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (purchaseHistoryDataGridView.Rows[e.RowIndex].Cells[2].Selected)
            {
                invoicenumber = purchaseHistoryDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                productNamelabel.Text = purchaseHistoryDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                supplierNameLabel.Text = purchaseHistoryDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                
                numericUpDown.Value = decimal.Parse(purchaseHistoryDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
                quantity = (int)numericUpDown.Value;
                customerid= purchaseHistoryDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void cleanbutton_Click(object sender, EventArgs e)
        {
            productNamelabel.Text = string.Empty;
            supplierNameLabel.Text = string.Empty;
            numericUpDown.Value = 0;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            int returnValue=(int)numericUpDown.Value;
            if(quantity<returnValue)
            {
                MessageBox.Show("Not Applicable");
            }
            else if(returnValue >=1 )
            {
                Business_Layer.BillService billService = new Business_Layer.BillService();
                
                if (string.IsNullOrEmpty(customerid))
                {
                    UI.Dialog.ReturnDialog returnDialog = new Dialog.ReturnDialog();
                    if (returnDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        string cn = returnDialog.number;
                        if (!string.IsNullOrEmpty(cn))
                        {
                           
                            Business_Layer.CustomerService customerService = new Business_Layer.CustomerService();
                            string cid = customerService.AddCustomer(cn);
                            if (!string.IsNullOrEmpty(cid))
                            {
                                if (billService.UpdateCustomer(invoicenumber, cid))
                                {
                                    bool returnSuccessfull = productService.ReturnProduct(invoicenumber, productNamelabel.Text, supplierNameLabel.Text, returnValue.ToString());
                                    if (returnSuccessfull)
                                    {
                                        MessageBox.Show("return successfull");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Not returned successfully");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Not updated");
                                }

                            }
                        }
                    } 
                }
                else
                {
                     bool returnSuccessfull = productService.ReturnProduct(invoicenumber, productNamelabel.Text, supplierNameLabel.Text, returnValue.ToString());
                     if (returnSuccessfull)
                     {
                        MessageBox.Show("return successfull");
                     }
                  

                }
            }
            else
            {
                MessageBox.Show("At least 1 has to be returned");
            }
        }
    }
}
