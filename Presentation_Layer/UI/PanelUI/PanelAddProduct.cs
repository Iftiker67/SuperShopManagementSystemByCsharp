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
    public partial class PanelAddProduct : Form
    {
        List<string> categoryList = new List<string>(); 
        public PanelAddProduct()
        {
            InitializeComponent();
            productTableGridView.AutoGenerateColumns = false;
            productTableGridView.ColumnCount = 3;
            productTableGridView.Columns[0].HeaderText = "Product Name";
            productTableGridView.Columns[1].HeaderText = "Category";
            productTableGridView.Columns[2].HeaderText = "Unit";
            productTableGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            categoryTableGridView.AutoGenerateColumns = false;
            categoryTableGridView.ColumnCount = 3;
            categoryTableGridView.Columns[0].HeaderText = "Category";
            categoryTableGridView.Columns[0].DataPropertyName = "category_name";
            categoryTableGridView.Columns[1].HeaderText = "Origin";
            categoryTableGridView.Columns[1].DataPropertyName = "SubstringName";
            categoryTableGridView.Columns[2].HeaderText = "Tax";
            categoryTableGridView.Columns[2].DataPropertyName = "tax";
            categoryTableGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            categoryList.AddRange(new Business_Layer.CategoryService().GetAllCategory());
            categoryNameComboBox1.DataSource = categoryList;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            if(AddCategorySuccessfull())
            {

                CategoryComboBoxTextContain(sender, e);
                //Business_Layer.CategoryService categoryService = new Business_Layer.CategoryService();
                //string categoryid = categoryService.InsertCategory(categoryNameComboBox2.Text);
                //if (localCategoryOriginRadioButton.Checked)
                //{
                //    MessageBox.Show(localCategoryOriginRadioButton.Text+"  "+taxTextBox.Text);
                //    bool result = categoryService.InsertCategoryOrigin(categoryid,localCategoryOriginRadioButton.Text.ToUpper(),float.Parse(taxTextBox.Text));
                //    if(result)
                //    {
                //        MessageBox.Show($"\tInserted\nCategory Name: {categoryNameComboBox2.Text}\nOrigin: {localCategoryOriginRadioButton.Text}\nTax: {taxTextBox.Text}");
                //        //categoryNameComboBox2.Text = "";
                //        //taxTextBox.Text = "";
                //        //localCategoryOriginRadioButton.Checked = false;
                //        AfterClickOnAddCategoryButton(foreignCategoryOriginRadioButton);
                //        this.PanelAddProduct_Load(sender,e);
                //        //categoryList.Add(categoryNameComboBox2.Text);
                //        //categoryNameComboBox2.DataSource = categoryList;
                //    }
                //    else
                //    {
                //        MessageBox.Show("Category not inserted");
                //    }
                //}
                //else
                //{
                //    MessageBox.Show(foreignCategoryOriginRadioButton.Text + "  " + taxTextBox.Text);
                //    bool result = categoryService.InsertCategoryOrigin(categoryid, localCategoryOriginRadioButton.Text.ToUpper(), float.Parse(taxTextBox.Text));
                //    if (result)
                //    {
                //        MessageBox.Show($"\tInserted\nCategory Name: {categoryNameComboBox2.Text}\nOrigin: {foreignCategoryOriginRadioButton.Text}\nTax: {taxTextBox.Text}");
                //        //categoryNameComboBox2.Text = "";
                //        //taxTextBox.Text = "";
                //        //foreignCategoryOriginRadioButton.Checked = false;
                //        AfterClickOnAddCategoryButton(foreignCategoryOriginRadioButton);
                //        this.PanelAddProduct_Load(sender, e);
                //        //categoryList.Add(categoryNameComboBox2.Text);
                //        //categoryNameComboBox2.DataSource = categoryList;
                //    }
                //    else
                //    {
                //        MessageBox.Show("Category not inserted");
                //    }
                //}
            }

            else
            {
                MessageBox.Show("Fill up correcty");
            }
        }
        private void AfterClickOnAddCategoryButton(RadioButton rb,string categoryName)
        {
            categoryNameComboBox2.Text = categoryName;
            taxTextBox.Text = "";
            rb.Checked = false;
           
        }
        private void CategoryComboBoxTextContain(object sender, EventArgs e)
        {
            #region Not Contain
            if (!categoryNameComboBox2.Items.Contains(categoryNameComboBox2.Text.ToUpper()))
            {
                Business_Layer.CategoryService categoryService = new Business_Layer.CategoryService();
                string categoryid = categoryService.InsertCategory(categoryNameComboBox2.Text.ToUpper());
                if (localCategoryOriginRadioButton.Checked && !string.IsNullOrEmpty(categoryid))
                {
                    MessageBox.Show(localCategoryOriginRadioButton.Text + "  " + taxTextBox.Text);
                    bool result = categoryService.InsertCategoryOrigin(categoryid, localCategoryOriginRadioButton.Text.ToUpper(), float.Parse(taxTextBox.Text));
                    if (result)
                    {
                        MessageBox.Show($"\tInserted\nCategory Name: {categoryNameComboBox2.Text}\nOrigin: {localCategoryOriginRadioButton.Text}\nTax: {taxTextBox.Text}");
                        
                        
                        this.PanelAddProduct_Load(sender, e);
                        UpdateCategoryTable(categoryNameComboBox2.SelectedItem.ToString());
                        AfterClickOnAddCategoryButton(foreignCategoryOriginRadioButton, categoryNameComboBox2.SelectedItem.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Category not inserted");
                    }
                }
                else if(foreignCategoryOriginRadioButton.Checked && !string.IsNullOrEmpty(categoryid))
                {
                    MessageBox.Show(foreignCategoryOriginRadioButton.Text + "  " + taxTextBox.Text);
                    bool result = categoryService.InsertCategoryOrigin(categoryid, foreignCategoryOriginRadioButton.Text.ToUpper(), float.Parse(taxTextBox.Text));
                    if (result)
                    {
                        MessageBox.Show($"\tInserted\nCategory Name: {categoryNameComboBox2.Text}\nOrigin: {foreignCategoryOriginRadioButton.Text}\nTax: {taxTextBox.Text}");
                       
                        //AfterClickOnAddCategoryButton(foreignCategoryOriginRadioButton);
                        this.PanelAddProduct_Load(sender, e);
                        UpdateCategoryTable(categoryNameComboBox2.SelectedItem.ToString());
                        AfterClickOnAddCategoryButton(foreignCategoryOriginRadioButton, categoryNameComboBox2.SelectedItem.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Category not inserted");
                    }
                }
                else
                {
                    MessageBox.Show("Category not inserted");
                }
            }
            #endregion

            #region CategoryName is Exits in The Items
            else
            {

                Business_Layer.CategoryService categoryService = new Business_Layer.CategoryService();
                string categoryid = categoryService.GetCategoryID(categoryNameComboBox2.Text);
                //string categoryid = categoryService.ExistCategoryOrigin(categoryNameComboBox2.Text,);
                if (localCategoryOriginRadioButton.Checked)
                {
                    //string categoryOriginid = categoryService.GetCategoryOrigin(categoryid, localCategoryOriginRadioButton.Text);
                    //bool exist = categoryService.ExistCategoryOrigin(categoryid,localCategoryOriginRadioButton.Text);
                    string categoryOriginid = categoryService.ExistCategoryOrigin(categoryid, localCategoryOriginRadioButton.Text);
                    if (!string.IsNullOrEmpty(categoryOriginid))
                    {
                        bool updated = categoryService.UpdatecategoryOrigin(categoryid, localCategoryOriginRadioButton.Text.ToUpper(), float.Parse(taxTextBox.Text));
                        if (updated)
                        {
                            MessageBox.Show($"\tUpdated\nCategory Name: {categoryNameComboBox2.Text}\nOrigin: {localCategoryOriginRadioButton.Text}\nTax: {taxTextBox.Text}");
                            //AfterClickOnAddCategoryButton(localCategoryOriginRadioButton);
                            this.PanelAddProduct_Load(sender, e);
                            UpdateCategoryTable(categoryNameComboBox2.SelectedItem.ToString());
                            AfterClickOnAddCategoryButton(localCategoryOriginRadioButton, categoryNameComboBox2.SelectedItem.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Category not inserted");
                        }
                    }
                    else
                    {
                        bool inserted = categoryService.InsertCategoryOrigin(categoryid, localCategoryOriginRadioButton.Text.ToUpper(), float.Parse(taxTextBox.Text));
                        if(inserted)
                        {
                            MessageBox.Show($"\tInserted\nCategory Name: {categoryNameComboBox2.Text}\nOrigin: {localCategoryOriginRadioButton.Text}\nTax: {taxTextBox.Text}");
                            //AfterClickOnAddCategoryButton(localCategoryOriginRadioButton);
                            this.PanelAddProduct_Load(sender, e);
                            UpdateCategoryTable(categoryNameComboBox2.SelectedItem.ToString());
                            AfterClickOnAddCategoryButton(localCategoryOriginRadioButton, categoryNameComboBox2.SelectedItem.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Category not inserted");
                        }
                    }
                }
                else
                {
                    //string categoryOriginid = categoryService.GetCategoryOrigin(categoryid, foreignCategoryOriginRadioButton.Text);
                    string categoryOriginid = categoryService.ExistCategoryOrigin(categoryid, foreignCategoryOriginRadioButton.Text);
                    if (!string.IsNullOrEmpty(categoryOriginid))
                    {
                        bool updated = categoryService.UpdatecategoryOrigin(categoryid, foreignCategoryOriginRadioButton.Text.ToUpper(), float.Parse(taxTextBox.Text));
                        if (updated)
                        {
                            MessageBox.Show($"\tUpdated\nCategory Name: {categoryNameComboBox2.Text}\nOrigin: {foreignCategoryOriginRadioButton.Text}\nTax: {taxTextBox.Text}");
                            //AfterClickOnAddCategoryButton(foreignCategoryOriginRadioButton);
                            this.PanelAddProduct_Load(sender, e);
                            UpdateCategoryTable(categoryNameComboBox2.SelectedItem.ToString());
                            AfterClickOnAddCategoryButton(foreignCategoryOriginRadioButton, categoryNameComboBox2.SelectedItem.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Category not inserted");
                        }
                    }
                    else
                    {
                        bool inserted = categoryService.InsertCategoryOrigin(categoryid, foreignCategoryOriginRadioButton.Text.ToUpper(), float.Parse(taxTextBox.Text));
                        if (inserted)
                        {
                            MessageBox.Show($"\tInserted\nCategory Name: {categoryNameComboBox2.Text}\nOrigin: {foreignCategoryOriginRadioButton.Text}\nTax: {taxTextBox.Text}");
                            //AfterClickOnAddCategoryButton(foreignCategoryOriginRadioButton);
                            this.PanelAddProduct_Load(sender, e);
                            UpdateCategoryTable(categoryNameComboBox2.SelectedItem.ToString());
                            AfterClickOnAddCategoryButton(foreignCategoryOriginRadioButton, categoryNameComboBox2.SelectedItem.ToString());
                            //searchCategoryButton_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Category not inserted");
                        }
                    }
                }

            }
            #endregion
        }

        private void UpdateCategoryTable(string selectedItem)
        {
            Business_Layer.CategoryService categoryService = new Business_Layer.CategoryService();
            categoryTableGridView.DataSource = categoryService.GetCategoryOriginInformation(selectedItem);
        }
        private bool AddCategorySuccessfull()
        {
            bool result = true;
            if(string.IsNullOrEmpty(categoryNameComboBox2.Text))
            {
                //result = false;
                return false;
            }
            //else if(!categoryNameComboBox2.Items.Contains(categoryNameComboBox2.Text))
            //{
                else if (!localCategoryOriginRadioButton.Checked && !foreignCategoryOriginRadioButton.Checked)
                {
                    result = false;
                    return result;
                }
                else if(string.IsNullOrEmpty(taxTextBox.Text))
                {
                    result = false;
                    return result;
                }
                else
                {
                    return true;
                }
            //}
            //else
            //{
            //    return true;
            //}
        }


        private void addProductButton_Click(object sender, EventArgs e)
        {
            if(productNameTextBox.Text ==string.Empty)
            {
                MessageBox.Show("Product text box is empty!!!");
            }
            else if(!unitComboBox.Items.Contains(unitComboBox.SelectedItem))
            {
                MessageBox.Show("Please select correct Unit");
            }
            else if(!categoryNameComboBox1.Items.Contains(categoryNameComboBox1.SelectedItem))
            {
                MessageBox.Show("Please select existing category or add new category");
            }
            else
            {
                Business_Layer.CategoryService categoryService = new Business_Layer.CategoryService();
                string cid = categoryService.GetCategoryID(categoryNameComboBox1.SelectedItem.ToString());
                if (!string.IsNullOrEmpty(cid))
                {
                    Business_Layer.ProductService productService = new Business_Layer.ProductService();
                    bool result = productService.InsertAddProduct(productNameTextBox.Text, cid, unitComboBox.Text);
                    if (result)
                    {
                        MessageBox.Show($"Inserted\nProduct Name: {productNameTextBox.Text}\nCategory Name: {categoryNameComboBox1.SelectedItem}\nUnit: {unitComboBox.Text}");
                        AfterClickAddProductButton();
                    }
                    else
                    {
                        MessageBox.Show("Allready Product Inserted");
                        AfterClickAddProductButton();
                    }
                } 
            }
            //MessageBox.Show("Category is not inserted yet\n"+ categoryNameComboBox1.SelectedItem.ToString());

        }

        private void AfterClickAddProductButton()
        {
            productNameTextBox.Text = "";
            unitComboBox.Text = "";
        }
        private void searchCategoryButton_Click(object sender, EventArgs e)
        {
            Business_Layer.CategoryService categoryService = new Business_Layer.CategoryService();
            categoryTableGridView.DataSource = categoryService.GetCategoryOriginInformation(categoryNameComboBox2.SelectedItem.ToString());
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {

        }

        private void PanelAddProduct_Load(object sender, EventArgs e)
        {
            categoryNameComboBox1.DataSource = new Business_Layer.CategoryService().GetAllCategory();
            categoryNameComboBox2.DataSource = new Business_Layer.CategoryService().GetAllCategory();
        }

        private void categoryNameComboBox2_Click(object sender, EventArgs e)
        {
            categoryNameComboBox2.Text = "";
        }

        private void categoryNameComboBox1_Click(object sender, EventArgs e)
        {
            categoryNameComboBox1.Text = "";
        }

        private void categoryTableGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(categoryTableGridView.Rows[e.RowIndex].Cells[0].Selected)
            {
                categoryNameComboBox2.Text = categoryTableGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                taxTextBox.Text = categoryTableGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                if(categoryTableGridView.Rows[e.RowIndex].Cells[1].Value.ToString() == "LOCAL")
                {
                    localCategoryOriginRadioButton.Checked = true;
                }
                else
                {
                    foreignCategoryOriginRadioButton.Checked = true;
                }
            }
        }
    }
}
