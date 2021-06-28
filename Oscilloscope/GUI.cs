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

        private void downMenu_ChannelsButton_Click(object sender, EventArgs e)
        {
            leftMainTab.Visible = true;
            //  Child Form Object
            Channels_Form channelsform = new Channels_Form();
            channelsform.TopLevel = false;
            leftMainTab.Controls.Add(channelsform);
            channelsform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            channelsform.Dock = DockStyle.Fill;

            //  Define MDI parent form
            channelsform.Show();
        }

        private void downMenu_AcquireButton_Click(object sender, EventArgs e)
        {
            
        }

        private void downMenu_TriggerButton_Click(object sender, EventArgs e)
        {
            rightMainTab.Visible = true;
            //  Child From Object
            Trigger_Form triggerform = new Trigger_Form();
            triggerform.TopLevel = false;
            rightMainTab.Controls.Add(triggerform);
            triggerform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            triggerform.Dock = DockStyle.Fill;

            //  Define MDI parent form
            triggerform.Show();
        }

        private void downMenu_DisplayButton_Click(object sender, EventArgs e)
        {

        }

        private void downMenu_SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void downMenu_MarkerButton_Click(object sender, EventArgs e)
        {

        }

        private void downMenu_MeasureButton_Click(object sender, EventArgs e)
        {

        }

        private void downMenu_MathButton_Click(object sender, EventArgs e)
        {

        }

        private void downMenu_HistogramButton_Click(object sender, EventArgs e)
        {

        }

        private void downMenu_DiagramButton_Click(object sender, EventArgs e)
        {

        }

        private void downMenu_MaskButton_Click(object sender, EventArgs e)
        {

        }

        private void downMenu_UtilityButton_Click(object sender, EventArgs e)
        {

        }

        private void leftTopTab_CancelButton_Click(object sender, EventArgs e)
        {
            leftMainTab.Visible = false;
        }

        private void rightTopTab_CancelButton_Click(object sender, EventArgs e)
        {
            rightMainTab.Visible = false;
        }
    }
}
