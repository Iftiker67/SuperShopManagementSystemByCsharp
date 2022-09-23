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

namespace Presentation_Layer.UI.FormUI
{
    public partial class RegistrationForm : Form
    {
        Form mf;
        int minAge = 18;
        public RegistrationForm(Form mf)
        {
            this.mf = mf;
            InitializeComponent();
        }
        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Hide();
            //this.mf.Show();
            Application.Exit();
        }
        string path;
        static int count = 0;
        private void pictureBox_Click(object sender, EventArgs e)
        {
            path = string.Empty;
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Doccuments|*.jpg", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    count++;
                    pictureBox.Image = new Bitmap(sfd.FileName);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    path = @"C:\Users\Sabbir\Desktop\Project doccument\ProjectProfile\" + count + ".jpg";
                    File.Copy(sfd.FileName, path, true);
                }
            }
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("wnter");
            if (FormValidation())
            {
                string pn = phoneNumberTextBox.Text;
                Business_Layer.EmployeeService employeeService = new Business_Layer.EmployeeService();
                if (!employeeService.ExistDuplicateNumber(pn))
                {
                    MessageBox.Show("hi");
                    string fn = fullNameTextBox.Text;
                    
                    string bg = bloodComboBox.Text;
                    string email = emailTextbox.Text.ToLower();
                    DateTime dateTime = dateTimePicker.Value;
                    string title = jobTitle.Text;
                    string address = addressBox.Text;
                    string gender;
                    string branchName = branchCmoboBox.Text;
                    string departmentName = departmentComboBox.Text;
                    if (maleRadioButton.Checked)
                    {
                        MessageBox.Show("Male box checked");
                        gender = maleRadioButton.Text;
                    }
                    else
                    {
                        MessageBox.Show("famale box checked");
                        gender = femaleRadioButton.Text;
                    }

                    
                    if (checkBox.Checked)
                    {
                        MessageBox.Show("Access box checked");
                        string id = employeeService.AddEmployee(fn, pn, bg, email, dateTime, title, gender, address, path, branchName, departmentName, true);
                        if (!string.IsNullOrEmpty(id))
                        {
                            MessageBox.Show(id);
                        }
                        else
                        {
                            MessageBox.Show("Something is wrong");
                        }
                    }
                    else
                    {
                        MessageBox.Show("not checked box checked");
                        string id = employeeService.AddEmployee(fn, pn, bg, email, dateTime, title, gender, address, path, branchName, departmentName, false);
                        if (!string.IsNullOrEmpty(id))
                        {
                            MessageBox.Show(id);
                        }
                        else
                        {
                            MessageBox.Show("Something is wrong");
                        }
                    } 
                }
                else
                {
                    MessageBox.Show("Number is allready exist");
                }

            }
            else
            {
                MessageBox.Show("Something is wrong");
            }
            BlankTheComponent();

        }

        public void BlankTheComponent()
        {
            fullNameTextBox.Text = string.Empty;
            phoneNumberTextBox.Text = string.Empty;
            bloodComboBox.Text= string.Empty; 
            emailTextbox.Text = string.Empty;
            jobTitle.Text= string.Empty; ;
            departmentComboBox.Text= string.Empty; 
            branchCmoboBox.Text = string.Empty;
            maleRadioButton.Checked = false;
            femaleRadioButton.Checked = false;
            addressBox.Text= string.Empty;
            checkBox.Checked = false;
            pictureBox.Image = null;
            //pictureBox.Image.Dispose();
            path = string.Empty;
        }

        private bool FormValidation()
        {
            if (string.IsNullOrEmpty(fullNameTextBox.Text))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(phoneNumberTextBox.Text))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(emailTextbox.Text))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(addressBox.Text))
            {
                return false;
            }
            else if (!bloodComboBox.Items.Contains(bloodComboBox.SelectedItem.ToString()))
            {
                return false;
            }
            else if (!jobTitle.Items.Contains(jobTitle.SelectedItem.ToString()))
            {
                return false;
            }
            else if (!departmentComboBox.Items.Contains(departmentComboBox.SelectedItem.ToString()))
            {
                return false;
            }
            else if (!branchCmoboBox.Items.Contains(branchCmoboBox.SelectedItem.ToString()))
            {
                return false;
            }
            else if (!maleRadioButton.Checked && !femaleRadioButton.Checked)
            {
                return false;
            }

            else if ((DateTime.Now - Convert.ToDateTime(dateTimePicker.Value.ToString())).TotalDays < 18 * 365)
            {
                return false;
            }
            else
            { return true; }
        }

        private void cancelButon_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            Business_Layer.BranchService bs = new Business_Layer.BranchService();
            jobTitle.DataSource = bs.GetAllTitles();
            departmentComboBox.DataSource = bs.GetAllDepartments();
            branchCmoboBox.DataSource = bs.GetAllBranches();
        }
    }
}
