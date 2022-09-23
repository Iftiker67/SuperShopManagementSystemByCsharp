using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;

namespace Presentation_Layer.UI.FormUI
{
    public partial class LoginForm : Form
    {
        Business_Layer.EmployeeService employeeService;
        public LoginForm()
        {
            InitializeComponent();
            employeeService = new Business_Layer.EmployeeService();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
        private void loginButton_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string pass = txtpass.Text;

            if (id != string.Empty & pass != string.Empty)
            {
                if (employeeService.UserExist(txtID.Text,txtpass.Text))
                {
                    if(employeeService.GetAccessbility(id)==1)
                    {
                        MainForm mp = new MainForm(this, txtID.Text,true);
                        mp.Show();
                        this.Hide();

                    }
                    else
                    {
                        MainForm mp = new MainForm(this, txtID.Text,false);
                        mp.Show();
                        this.Hide();
                    }
                    //User user = new User(id, pass);
                    //Mainpage mp = new Mainpage();
                    
                }
                else
                {
                    MessageBox.Show("Please, Enter");
                }

            }
            else
            {
                MessageBox.Show("ID or Password is incorrect");
            }
        }

    }
}
