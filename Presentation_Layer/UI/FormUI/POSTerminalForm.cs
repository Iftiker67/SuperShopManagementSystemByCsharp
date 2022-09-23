using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Presentation_Layer.UI.FormUI
{
    public partial class POSTerminalForm : Form
    {
        UI.FormUI.MainForm mainForm;
        //List<string> productList = new List<string>();
        //List<string> supplierList = new List<string>();
        Business_Layer.EmployeeService employeeService;
        Business_Layer.ProductService productService;
        int count;
        public POSTerminalForm()
        {
            InitializeComponent();
            count = 0;
            InitializeComponent();
            addtocartGridView.AutoGenerateColumns = false;
            addtocartGridView.ColumnCount = 5;
            addtocartGridView.ForeColor = Color.Black;
            addtocartGridView.Columns[0].HeaderText = "Product Name";
            addtocartGridView.Columns[1].HeaderText = "Supplier Name";
            //addtocartGridView.Columns[0].DataPropertyName = "product_supplier";
            addtocartGridView.Columns[2].HeaderText = "Price";
            //addtocartGridView.Columns[1].DataPropertyName = "price";
            addtocartGridView.Columns[3].HeaderText = "Quantity";
            //addtocartGridView.Columns[2].DataPropertyName = "quantity";
            addtocartGridView.Columns[4].HeaderText = "Sub Total";
            //addtocartGridView.Columns[3].DataPropertyName = "";
            addtocartGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public POSTerminalForm(UI.FormUI.MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            addtocartGridView.AutoGenerateColumns = false;
            addtocartGridView.ColumnCount = 5;
            addtocartGridView.ForeColor = Color.Black;
            addtocartGridView.Columns[0].HeaderText = "Product Name";
            addtocartGridView.Columns[1].HeaderText = "Supplier Name";
            //addtocartGridView.Columns[0].DataPropertyName = "product_supplier";
            addtocartGridView.Columns[2].HeaderText = "Price";
            //addtocartGridView.Columns[1].DataPropertyName = "price";
            addtocartGridView.Columns[3].HeaderText = "Quantity";
            //addtocartGridView.Columns[2].DataPropertyName = "quantity";
            addtocartGridView.Columns[4].HeaderText = "Sub Total";
            //addtocartGridView.Columns[3].DataPropertyName = "";
            addtocartGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }

        private void POSTerminalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void customerShoppingLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.mainForm.Show();
        }

        private void POSTerminalForm_Load(object sender, EventArgs e)
        {
            productsComboBox.DataSource = new Business_Layer.ProductService().GetAllCompanyProducts();
            supplierComboBox.DataSource = new Business_Layer.SupplierService().GetAllSupplier();
            employeeService = new Business_Layer.EmployeeService();
            branchLabel.Text = employeeService.GetBranchName(mainForm.user);
            categoryComboBox.DataSource = new Business_Layer.CategoryService().GetAllCategory();
            employeeLabel.Text = mainForm.user;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(customerTextBox.Text))
            {
                Business_Layer.CustomerService customerService = new Business_Layer.CustomerService();
                DataTable dt = customerService.GetCustomerInsformation(customerTextBox.Text);
                if (dt.Rows.Count>0)
                {
                    nameLabel.Text = dt.Rows[0][0].ToString();
                    contactLabel.Text = dt.Rows[0][1].ToString();
                    pointsLabel.Text = dt.Rows[0][2].ToString(); 
                }
                else
                {
                    MessageBox.Show("NO customer");
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        
        private void addtocartButton_Click(object sender, EventArgs e)
        {
            if(FormValidate())
            {
                string productName = productsComboBox.SelectedItem.ToString();
                string supplierName = supplierComboBox.SelectedItem.ToString();
                productService = new Business_Layer.ProductService();
                int quantity = Int32.Parse(quantityNumericUpDown.Value.ToString());
                float productPrice = float.Parse(productService.GetProductPrice(productName, supplierName));
                if(!string.IsNullOrEmpty(customerTextBox.Text))
                {
                    customerLabel.Text = customerTextBox.Text;
                }
                //addtocartGridView.Rows[count].Cells[0].Value = productName;
                //addtocartGridView.Rows[count].Cells[1].Value = productPrice;
                //addtocartGridView.Rows[count].Cells[2].Value = quantity;
                //addtocartGridView.Rows[count].Cells[3].Value = productPrice * quantity;
                bool result = true ;
                for(int i=0;i<addtocartGridView.Rows.Count;i++)
                {
                    if (addtocartGridView.Rows[i].Cells[0].Value == productName && addtocartGridView.Rows[i].Cells[1].Value == supplierName)
                    {
                        //quantity = int.Parse(addtocartGridView.Rows[i].Cells[3].Value.ToString()) + quantity;
                        addtocartGridView.Rows[i].Cells[3].Value = quantity;
                        addtocartGridView.Rows[i].Cells[4].Value = productPrice * quantity;
                        result = false;
                        //MessageBox.Show("The Product allready added to cart");
                        break;
                    }
                }
                if(result)
                {
                    addtocartGridView.Rows.Add(productName, supplierName, productPrice, quantity, productPrice * quantity);
                }
                
            }
            else
            {
                MessageBox.Show("Something is wrong");
            }
        }

        public bool FormValidate()
        {
            if(!productsComboBox.Items.Contains(productsComboBox.SelectedItem.ToString()))
            {
                return false;
            }    
            else if(!supplierComboBox.Items.Contains(supplierComboBox.SelectedItem.ToString()))
            {
                return false;
            }
            else if(Convert.ToInt32(quantityNumericUpDown.Value)<=0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        DataTable dt = new DataTable();
        private void confirmButton_Click(object sender, EventArgs e)
        {
            
            if(addtocartGridView.Rows.Count>0)
            {
                Business_Layer.BillService billService = new Business_Layer.BillService();
                string invoice = billService.GenarateBill(mainForm.user, DateTime.Now.ToString());
                MessageBox.Show("Invoice  " + invoice);
                if (!string.IsNullOrEmpty(invoice))
                {
                    //Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                    //PdfWriter pdf = PdfWriter.GetInstance(doc, new FileStream(invoice +".pdf", FileMode.Create));
                    //doc.Open();
                    //Paragraph p = new Paragraph("\tInvoice Number : " + invoice);
                    //Paragraph p2 = new Paragraph("\tCustomer Number: " + customerLabel.Text);
                    //Paragraph p3 = new Paragraph("\tDate Time: " + DateTime.Now.ToString());
                    //Paragraph p4 = new Paragraph("\tCashier: " + mainForm.user);
                    //Paragraph blank = new Paragraph("\n");
                    //Paragraph total = new Paragraph("\nTotal : ");
                    //doc.Add(p);
                    //doc.Add(p2);
                    //doc.Add(p3);
                    //doc.Add(blank);
                    //doc.Add(p4);

                    //PdfPTable pdfTable = new PdfPTable(4);
                    //for(int i = 0; i < addtocartGridView.ColumnCount; i++)
                    //{
                    //    PdfPCell cell = new PdfPCell(new Phrase(addtocartGridView.Columns[i].HeaderText));
                    //    cell.Colspan = 1;
                    //    cell.HorizontalAlignment = 1;
                    //    pdfTable.AddCell(cell);
                    //}
                    for (int i = 0; i < addtocartGridView.Rows.Count; i++)
                    {
                        string pn = addtocartGridView.Rows[i].Cells[0].Value.ToString();
                        string sn = addtocartGridView.Rows[i].Cells[1].Value.ToString();
                        string quantity = addtocartGridView.Rows[i].Cells[3].Value.ToString();
                        bool result = billService.AddtoSales(pn, sn, invoice, quantity);
                        if (!result)
                        {
                            string price = Convert.ToString(productService.GetCompanyProductPrice(pn, sn));
                            //float tax = float.Parse(productService.GetTax(pn,sn).ToString());
                            string subtotal = (float.Parse(price)*float.Parse(quantity)).ToString();
                            //dt.Rows.Add(pn,sn,quantity,sellprice,subtotal);
                            MessageBox.Show(pn + "\tnot added");
                            //pdfTable.AddCell(pn);
                            //pdfTable.AddCell(sn);
                            //pdfTable.AddCell(price);
                            //pdfTable.AddCell(quantity);
                            //pdfTable.AddCell(subtotal);
                            //doc.Add(pdfTable);
                        }
                        else
                        {
                            MessageBox.Show(pn + "\tadded");
                        }
                    }
                    
                    
                    string totalamount = billService.GetTotalAmountSpecificInvoice(invoice);
                    MessageBox.Show(totalamount);
                    //Paragraph to = new Paragraph("\nTotal : "+totalamount);
                    //doc.Add(to);
                    //doc.Close();
                }
                else
                {
                    MessageBox.Show("No bills generated");
                }
            }
            else
            {
                MessageBox.Show("No product in the cart");
            }
            CleanCart();
            CleanCustomerGroupBox();
            POSTerminalForm_Load(sender, e);
        }

        #region Making pdf

        public void CraeatTable(string invoice)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter pdf = PdfWriter.GetInstance(doc, new FileStream(invoice + ".pdf", FileMode.Create));
            doc.Open();
            Paragraph p = new Paragraph("\tInvoice Number : " +invoice);
            Paragraph p2 = new Paragraph("\tCustomer Number: " + customerLabel.Text);
            Paragraph p3 = new Paragraph("\tDate Time: " + DateTime.Now.ToString());
            Paragraph p4 = new Paragraph("\tCashier: "+mainForm.user);
            Paragraph blank = new Paragraph("\n");
            doc.Add(p);
            doc.Add(p2);
            doc.Add(p3);
            doc.Add(p4);
            PdfPTable pdfTable = new PdfPTable(4);
            


         }

        public void ExportToPdf(DataTable dt, string strFilePath)
        {
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(strFilePath, FileMode.Create));
            document.Open();
            iTextSharp.text.Font font5 = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA, 5);

            PdfPTable table = new PdfPTable(dt.Columns.Count);
            PdfPRow row = null;
            float[] widths = new float[dt.Columns.Count];
            for (int i = 0; i < dt.Columns.Count; i++)
                widths[i] = 4f;

            table.SetWidths(widths);

            table.WidthPercentage = 100;
            int iCol = 0;
            string colname = "";
            PdfPCell cell = new PdfPCell(new Phrase("Products"));

            cell.Colspan = dt.Columns.Count;

            foreach (DataColumn c in dt.Columns)
            {
                table.AddCell(new Phrase(c.ColumnName, font5));
            }

            foreach (DataRow r in dt.Rows)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int h = 0; h < dt.Columns.Count; h++)
                    {
                        table.AddCell(new Phrase(r[h].ToString(), font5));
                    }
                }
            }
            document.Add(table);
            document.Close();
        }

        #endregion

        private void addtocartGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            productsComboBox.Text = addtocartGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            supplierComboBox.Text = addtocartGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            quantityNumericUpDown.Value = Convert.ToDecimal(addtocartGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
        }

        private void searchCategory_Click(object sender, EventArgs e)
        {
            productsComboBox.DataSource = new Business_Layer.ProductService().GetAllProductsByCategory(categoryComboBox.SelectedItem.ToString());
        }

        private void searchButtonByProductName_Click(object sender, EventArgs e)
        {
            productService = new Business_Layer.ProductService();
            string productName = productsComboBox.SelectedItem.ToString();
            supplierComboBox.DataSource = productService.GetAllSuppliernameByProductName(productName);
            categoryComboBox.Text = productService.GetCategorynameByProductName(productName);

        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            POSTerminalForm_Load(sender, e);
            quantityNumericUpDown.Value = decimal.Zero;
            //customerLabel.Text = string.Empty;
            //customerTextBox.Text = string.Empty;
        }

        private void cleanButton2_Click(object sender, EventArgs e)
        {
            CleanCart();
            CleanCustomerGroupBox();
            POSTerminalForm_Load(sender, e);
        }

        private void CleanCart()
        {
            customerLabel.Text = string.Empty;
            customerTextBox.Text = string.Empty;
            addtocartGridView.Rows.Clear();
            addtocartGridView.Refresh();
        }
        
        private void CleanCustomerGroupBox()
        {
            nameLabel.Text = string.Empty;
            contactLabel.Text = string.Empty;
            pointsLabel.Text = string.Empty;
        }
    }
}
