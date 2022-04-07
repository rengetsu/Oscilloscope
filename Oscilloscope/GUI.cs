using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using Oscilloscope.Properties;

namespace Oscilloscope
{
    public partial class GUI : Form
    {
        //  Calls to other classes
        OpenGL gl = new OpenGL();
        Calibrations cal = new Calibrations();

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
            leftMainTab.Visible = true;
            //  Child Form Object
            Acquire_Form acquireform = new Acquire_Form();
            acquireform.TopLevel = false;
            leftMainTab.Controls.Add(acquireform);
            acquireform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            acquireform.Dock = DockStyle.Fill;

            //  Define MDI parent form
            acquireform.Show();
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

        private void ChannelOne_SmallUpButton_Click(object sender, EventArgs e)
        {
            ChannelOne_TextBox.Text = cal.Channel_SmallStep_Up(1);
        }

        private void ChannelOne_BigUpButton_Click(object sender, EventArgs e)
        {
            ChannelOne_TextBox.Text = cal.Channel_BigStep_Up(1);
        }

        private void ChannelOne_BigDownButton_Click(object sender, EventArgs e)
        {
            ChannelOne_TextBox.Text = cal.Channel_BigStep_Down(1);
        }

        private void ChannelOne_SmallDownButton_Click(object sender, EventArgs e)
        {
            ChannelOne_TextBox.Text = cal.Channel_SmallStep_Down(1);
        }

        private void ChannelOne_Button_Click(object sender, EventArgs e)
        {
            double w = glControl1.Width;
            double h = glControl1.Height;
            double ar = w / h;
            gl.Render(1, w, h, ar);
            glControl1.SwapBuffers();
        }

        private void adjustmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccessAdjustment AdjAcc = new AccessAdjustment();
            AdjAcc.Show();
        }

        private void instrumentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Information info = new Information();
            MessageBox.Show(info.getVersionUpdateInfo());
        }
    }
}
