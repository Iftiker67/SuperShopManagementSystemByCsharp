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
    public partial class PanelHome : Form
    {
        public PanelHome()
        {
            
            InitializeComponent();
        }

        /// <summary>
        /// Its for all task after the Panel home is Loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelHome_Load(object sender, EventArgs e)
        {
            timerAtHome.Start();
        }

        private void TimerAtHome_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            dateLabel.Text = DateTime.Now.ToString("dd MMM yy");
        }
    }
}
