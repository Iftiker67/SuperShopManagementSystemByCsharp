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
    public partial class PanelAddToStock : Form
    {
        Business_Layer.ProductService productService ;
        FormUI.MainForm mainForm;
        List<string> productList = new List<string>();
        List<string> supplierList = new List<string>();
        public PanelAddToStock(FormUI.MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            productList.AddRange(new Business_Layer.ProductService().GetAllProducts());
            productComboBox.DataSource = productList;
            productNameComboBox2.DataSource = productList;

            supplierList.AddRange(new Business_Layer.SupplierService().GetAllSupplier());
            supplierComboBox.DataSource = supplierList;
            supplierNameComboBox2.DataSource = supplierList;
        }

        private void PanelAddToStock_Load(object sender, EventArgs e)
        {

            productComboBox.DataSource = new Business_Layer.ProductService().GetAllProducts();
            productNameComboBox2.DataSource = productComboBox.DataSource;
            supplierComboBox.DataSource = new Business_Layer.SupplierService().GetAllSupplier();
            supplierNameComboBox2.DataSource = supplierComboBox.DataSource;
        }

        private void addSupplierButton_Click(object sender, EventArgs e)
        {
            //mainForm.OpenChildForm(new PanelUI.PanelAddSupplier())
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            if(ValidateOfAddCompanyPrdouct())
            {
                productService = new Business_Layer.ProductService();
                //string productid = productService.GetProductid(productComboBox.Text);
                //string companyProductid = productService.GetCompanyProductid(productid,)

                string companyProductid = productService.GetCompanyProductid(productComboBox.Text,supplierComboBox.Text);
                if(string.IsNullOrEmpty(companyProductid))
                {
                    string cpid = productService.InsertCompanyProduct(productComboBox.SelectedItem.ToString(), supplierComboBox.Text, purchasePriceTextBox.Text, marginNumericButton.Value.ToString(),applicationComboBox.Text);
                    if(!string.IsNullOrEmpty(cpid))
                    {
                        bool successfull = productService.AddCompanyProduct(mainForm.user, cpid, quantityNumericUpdDown.Value.ToString());
                        if (successfull)
                        {
                            MessageBox.Show($"\tAdded\nProducname:\t{productComboBox.Text}\nSuppliername:\t{supplierComboBox.Text}");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Not inserted properly\nProducname:\t{productComboBox.Text}\nSuppliername:\t{supplierComboBox.Text}");
                    }
                   
                }
                else
                {
                    MessageBox.Show("Already Inserted");
                    
                }
            }
            else
            {
                MessageBox.Show("Insert every fields information properly");
            }
        }

        private bool ValidateOfAddCompanyPrdouct()
        {
            
            if (!productComboBox.Items.Contains(productComboBox.SelectedItem.ToString()))
            {
                return false;
            }
            else if (!supplierComboBox.Items.Contains(supplierComboBox.SelectedItem.ToString()))
            {
                return false;
            }
            else if (!float.TryParse(purchasePriceTextBox.Text,out float pPrice))
            {
                return false;
            }

            else if(!applicationComboBox.Items.Contains(applicationComboBox.Text.ToString()))
            {
                return false;
            }
            else if (!float.TryParse(marginNumericButton.Text, out float marginPrice))
            {
                return false;
            }
            return true ;
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Entered");
            if(ValidateAddToStockForm())
            {
                //MessageBox.Show("Validated");
                string refer = Convert.ToString(referenceTextBox.Text);
                productService = new Business_Layer.ProductService();
                string companyProductid = productService.GetCompanyProductid(productComboBox.Text, supplierComboBox.Text);
                if (!string.IsNullOrEmpty(companyProductid))
                {
                    //MessageBox.Show("CompanyProduct id Not null");
                    float productPrice = float.Parse(productService.GetCompanyProductPrice(companyProductid).ToString());
                    float grandTotal = float.Parse(quantityNumericUpdDown.Value.ToString()) * productPrice;
                    MessageBox.Show(quantityNumericUpdDown.Value.ToString());
                    bool inserted = productService.PurchaseCompanyProduct(quantityNumericUpdDown.Value.ToString(),
                                                                            grandTotal.ToString(),
                                                                            referenceTextBox.Text,
                                                                            mainForm.user,
                                                                            companyProductid,
                                                                            DateTime.Now.ToString(),
                                                                            expireDateTextBox.Text
                                                                          );
                    if (inserted)
                    {
                       //productService.AddtoStock(mainForm.user, companyProductid, quantityNumericUpdDown.Value.ToString());
                        MessageBox.Show($"Inserted\nProductname: {productNameComboBox2.Text}\nSuppliername:{supplierNameComboBox2.Text}\nQuantity: {quantityNumericUpdDown.Value.ToString()}");
                    }
                    else
                    {
                        MessageBox.Show("Properly not inserted");
                    }
                }
                else
                {
                    MessageBox.Show("Please, add the Product to Company Product");
                }
            }
            else
            {
                MessageBox.Show("Not Validated");
            }
        }

        private bool ValidateAddToStockForm()
        {
            int quantity;
            if (!productNameComboBox2.Items.Contains(productNameComboBox2.SelectedItem.ToString()))
            {
                return false;
            }
            else if (!supplierNameComboBox2.Items.Contains(supplierNameComboBox2.SelectedItem.ToString()))
            {
                return false;
            }
            else if (!int.TryParse(quantityNumericUpdDown.Value.ToString(), out quantity))
            {
                return false;
            }
            else if ((expireDateTextBox.Value - DateTime.Now).TotalDays < 1)
            {
                //MessageBox.Show((DateTime.Now - Convert.ToDateTime(expireDateTextBox.Text.ToString())).ToString());
                return false;
            }
            return true;
        }

    }
}
