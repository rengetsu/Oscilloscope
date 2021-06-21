using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oscilloscope
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  Child Form Object
            Channels_Form channelsform = new Channels_Form();
            channelsform.TopLevel = false;
            leftMainTab.Controls.Add(channelsform);
            channelsform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            channelsform.Dock = DockStyle.Fill;

            //  Define MDI parent form
            channelsform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //  Child From Object
            Trigger_Form triggerform = new Trigger_Form();
            triggerform.TopLevel = false;
            rightMainTab.Controls.Add(triggerform);
            triggerform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            triggerform.Dock = DockStyle.Fill;

            //  Define MDI parent form
            triggerform.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
