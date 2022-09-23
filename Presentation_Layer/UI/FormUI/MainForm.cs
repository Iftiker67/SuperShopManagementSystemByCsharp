using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.UI.FormUI
{
    public partial class MainForm : Form
    {
        LoginForm loginForm;
        internal string user;
        public MainForm()
        {
            InitializeComponent();
            this.HidePanel();
            this.OpenChildForm(new PanelUI.PanelHome());  
            this.FormBorderStyle = FormBorderStyle.None; //for border less resizing
        }
        public MainForm(LoginForm loginForm, string user,bool result)
        {
            InitializeComponent();
            this.loginForm = new LoginForm();
            this.user = user;
            this.HidePanel();
            this.OpenChildForm(new PanelUI.PanelHome());
            this.FormBorderStyle = FormBorderStyle.None; //for border less resizing
            if(!result)
            {
                employeButton.Visible = false;
                employeePanel.Visible = false;
            }
        }

        #region HidePanel
        public void HidePanel()
        {
            productPanel.Visible = false;
            sellPanel.Visible = false;
            purchasePanel.Visible = false;
            returnPanel.Visible = false;
            stockPanel.Visible = false;
            expensesPanel.Visible = false;
            reportPanel.Visible = false;
            employeePanel.Visible = false;
            customerPanel.Visible = false;
        }

        public void HideSubbUtton()
        {
            if (productPanel.Visible)
                productPanel.Visible = false;
            if (sellPanel.Visible)
                sellPanel.Visible = false;
            if (purchasePanel.Visible)
                purchasePanel.Visible = false;
            if (returnPanel.Visible)
                returnPanel.Visible = false;
            if (stockPanel.Visible)
                stockPanel.Visible = false;
            if (expensesPanel.Visible)
                expensesPanel.Visible = false;
            if (reportPanel.Visible)
                reportPanel.Visible = false;
            if (employeePanel.Visible)
                employeePanel.Visible = false;
            if (customerPanel.Visible)
                customerPanel.Visible = false;
        }

        public void SpecificPanel(Panel p)
        {
            if (p.Visible)
                p.Visible = false;
            else
            {
                HideSubbUtton();
                p.Visible = true;
            }
        }
        #endregion

        #region Button

        private void homeButton_Click(object sender, EventArgs e)
        {
            HideSubbUtton();
            OpenChildForm(new PanelUI.PanelHome());
        }

        private void contactButton_Click(object sender, EventArgs e)
        {
            HideSubbUtton();
        }
        private void productButton_Click(object sender, EventArgs e)
        {
            SpecificPanel(productPanel);
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            SpecificPanel(purchasePanel);
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            SpecificPanel(sellPanel);
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            SpecificPanel(returnPanel);
        }

        private void stockButton_Click(object sender, EventArgs e)
        {
            SpecificPanel(stockPanel);
        }

        private void expensesButton_Click(object sender, EventArgs e)
        {
            SpecificPanel(expensesPanel);
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            SpecificPanel(reportPanel);
        }

        private void employeesButton_Click(object sender, EventArgs e)
        {
            SpecificPanel(employeePanel);
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            SpecificPanel(customerPanel);
        }

        #endregion

        #region Sub Button
        private void addProductButton_Click(object sender, EventArgs e)
        {
            //AddButtonForm();
            OpenChildForm(new PanelUI.PanelAddProduct());
        }
        #endregion

        #region Open ChildPanel
        public Form activeForm = null;
        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainBarPanel.Controls.Add(childForm);
            mainBarPanel.Tag = childForm;
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            childForm.Show();
        }

        PanelUI.PanelHome ph;
        private void OpenChildForm()
        {
            //if(activeForm== ActiveForm)
            ph = new PanelUI.PanelHome();
            activeForm = ph;
            ph.TopLevel = false;
            ph.FormBorderStyle = FormBorderStyle.None;
            ph.Dock = DockStyle.Fill;
            mainBarPanel.Controls.Add(ph);
            mainBarPanel.Tag = ph;
            ph.Dock = DockStyle.Fill;
            ph.BringToFront();
            ph.Show();
        }
        //PanelUI.PanelAddProduct pah;
        //private void AddButtonForm()
        //{
        //    pah = new PanelUI.PanelAddProduct();
        //    activeForm = pah;
        //    pah.TopLevel = false;
        //    pah.FormBorderStyle = FormBorderStyle.None;
        //    pah.Dock = DockStyle.Fill;
        //    mainBarPanel.Controls.Add(ph);
        //    mainBarPanel.Tag = ph;
        //    pah.Dock = DockStyle.Fill;
        //    pah.BringToFront();
        //    pah.Show();
        //}
        #endregion

        #region Minimize Maximize Close
        private void terminateButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                restoreButton.Rotation = 180;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                restoreButton.Rotation = 0;
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Dragging

        private bool dragging;
        private Point sp = new Point(0,0);

        private void headerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            sp = new Point(e.X, e.Y);
        }

        private void headerPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.sp.X, p.Y - this.sp.Y); 
            }
        }

        private void headerPanel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion

        #region Resizing Borderless Winodw
        const int WM_NCHITTEST = 0x0084;
        const int HTCLIENT = 1;
        const int HTCAPTION = 2;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    if (m.Result == (IntPtr)HTCLIENT)
                    {
                        m.Result = (IntPtr)HTCAPTION;
                    }
                    break;
            }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x40000;
                return cp;
            }
        }


        #endregion

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            RegistrationForm rg = new RegistrationForm(this);
            this.Hide();
            rg.Show();
        }

        

        private void MainForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            //terminateButton_Click(sender,e);
        }

        #region SubButtonClick
        private void addtoStockButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PanelUI.PanelAddToStock(this));
        }

        private void viewProductbutton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PanelUI.PanelViewProductList());
        }

        private void purchaseListButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PanelUI.PanelPurchaseList());
        }

        private void salesListButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PanelUI.PanelSaleList());
        }


        #endregion

        private void addSaleButton_Click(object sender, EventArgs e)
        {

        }

        private void posTerminalbutton_Click(object sender, EventArgs e)
        {
            UI.FormUI.POSTerminalForm posTerminal = new UI.FormUI.POSTerminalForm(this);
            this.Hide();
            posTerminal.Show();
        }

        private void draftsButton_Click(object sender, EventArgs e)
        {

        }

        private void returnProductButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UI.PanelUI.PanelReturn());
        }

        private void ReturnListButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UI.PanelUI.PanelReturnList());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.loginForm.Show();
        }

        private void profitLossReportButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UI.PanelUI.PanelProfitLossReports());
        }

        private void purchaseSalebutton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UI.PanelUI.PanelPurchaseandSalesReports());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UI.PanelUI.PanelAddExpenses(user));
        }
    }
}
