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
    public partial class PanelViewProductList : Form
    {
        Business_Layer.ProductService productService = new Business_Layer.ProductService();
        Business_Layer.CategoryService categoryService = new Business_Layer.CategoryService();
        public PanelViewProductList()
        {
            InitializeComponent();
            productGridView.AutoGenerateColumns = false;
            productGridView.ColumnCount = 6;
            productGridView.Columns[0].HeaderText = "Product Name";
            productGridView.Columns[1].HeaderText = "Category";
            productGridView.Columns[2].HeaderText = "Supplier Name";
            productGridView.Columns[3].HeaderText = "Unit";
            productGridView.Columns[4].HeaderText = "Branch Name"; 
            productGridView.Columns[5].HeaderText = "Quantity";
            DataTable dt = productService.ViewProductLists();
            productGridView.DataSource = dt;
            productGridView.Columns[0].DataPropertyName = "pn";
            productGridView.Columns[1].DataPropertyName = "cn";
            productGridView.Columns[2].DataPropertyName= "sn";
            productGridView.Columns[3].DataPropertyName = "unit";
            productGridView.Columns[4].DataPropertyName = "bn";
            productGridView.Columns[5].DataPropertyName = "quantity";
            productGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                if(categorycomboBox.Items.Contains(categorycomboBox.SelectedItem.ToString()) && !string.IsNullOrEmpty(productNameTextBox.Text))
                {
                    //TODO-- search  by category Name and product name
                    productGridView.DataSource= productService.ViewProductLists();
                    //MessageBox.Show("1");

                }
                if(!string.IsNullOrEmpty(productNameTextBox.Text))
                {
                    //Todo -- search by product name;
                    //MessageBox.Show("Product");
                    DataTable art  = productService.ViewProductListsByProduct(productNameTextBox.Text);
                    productGridView.DataSource = art;
                }
                else
                {
                    //TODO--search  by ctaegoryname;
                    //MessageBox.Show("3");
                    DataTable art = productService.ViewProductListsByCategory(categorycomboBox.Text);
                    productGridView.DataSource = art;
                }

            }
            else
            {
                MessageBox.Show("Select a category name or insert a product name that has already exist");
            }
        }
        public bool ValidateForm()
        {
            if (categorycomboBox.Items.Contains(categorycomboBox.SelectedItem.ToString()) || !string.IsNullOrEmpty(productNameTextBox.Text))
            {
                return true;
            }
            return false;
        }

        private void productNameTextBox_Click(object sender, EventArgs e)
        {
            productNameTextBox.Text = "";
        }

        private void PanelViewProductList_Load(object sender, EventArgs e)
        {
            DataTable dt = productService.ViewProductLists();
            productGridView.DataSource = dt;
            categorycomboBox.DataSource = categoryService.GetAllCategory();
        }
    }
}
