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
    public partial class AcquisitionParameters : Form
    {
        AcqParameters acqPar = new AcqParameters();

        public int FFine = 65550;
        double percent_end_cur = 0;
        double percent_start_cur = 0;

        public AcquisitionParameters()
        {
            InitializeComponent();
        }

        private void AcqParam_PercentTextBox_TextChanged(object sender, EventArgs e)
        {
            AcqParam_PercentTextBox.Text = acqPar.getAcqParameter_Percents(acqPar.getAcqParameter_Number(FFine), FFine, percent_end_cur, percent_start_cur).ToString();
        }

        private void AcqParam_NumberTextBox_TextChanged(object sender, EventArgs e)
        {
            AcqParam_NumberTextBox.Text = acqPar.getAcqParameter_Number(FFine).ToString();
        }
    }
}
