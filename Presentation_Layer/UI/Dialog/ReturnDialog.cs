using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.UI.Dialog
{
    public partial class ReturnDialog : Form
    {
        UI.FormUI.MainForm mf;
        public string number;
        public ReturnDialog(UI.FormUI.MainForm mf)
        {
            this.mf = mf;
            InitializeComponent();
        }
        public ReturnDialog()
        {
            InitializeComponent();
        }

        private void customerPhonenumber_Click(object sender, EventArgs e)
        {

        }


        private void okbutton_Click(object sender, EventArgs e)
        {
            number = numberTextbbox.Text;
        }
    }
}
