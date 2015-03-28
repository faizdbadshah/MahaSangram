using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MahaSangram
{
    public partial class scorecard : UserControl
    {
        public scorecard()
        {
            InitializeComponent();
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            metroRadioButton11.Checked = false;
            metroRadioButton12.Checked = false;
            metroRadioButton14.Checked = false;
            metroRadioButton15.Checked = false;
        }

        private void metroRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            metroRadioButton11.Checked = false;
            metroRadioButton12.Checked = false;
            metroRadioButton14.Checked = false;
            metroRadioButton15.Checked = false;
        }

        private void metroRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            metroRadioButton11.Checked = false;
            metroRadioButton12.Checked = false;
            metroRadioButton14.Checked = false;
            metroRadioButton15.Checked = false;
        }

        private void metroRadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            metroRadioButton11.Checked = false;
            metroRadioButton12.Checked = false;
            metroRadioButton13.Checked = false;
            metroRadioButton14.Checked = false;
            metroRadioButton15.Checked = false;
        }

        private void metroRadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            metroRadioButton7.Checked = false;
            metroRadioButton9.Checked = false;
            metroRadioButton10.Checked = false;
            metroRadioButton11.Checked = false;
            metroRadioButton12.Checked = false;
            metroRadioButton13.Checked = false;
            metroRadioButton14.Checked = false;
            metroRadioButton15.Checked = false;
        }

        private void metroRadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            metroRadioButton6.Checked = false;
            metroRadioButton11.Checked = false;
            metroRadioButton12.Checked = false;
        }

        private void metroRadioButton8_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            metroRadioButton11.Checked = false;
            metroRadioButton12.Checked = false;
            metroRadioButton14.Checked = false;
            metroRadioButton15.Checked = false;
        }

        private void metroRadioButton9_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            metroRadioButton6.Checked = false;
            metroRadioButton11.Checked = false;
            metroRadioButton12.Checked = false;
            metroRadioButton14.Checked = false;
        }

        private void metroRadioButton10_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            metroRadioButton6.Checked = false;
            metroRadioButton11.Checked = false;
            metroRadioButton12.Checked = false;
            metroRadioButton14.Checked = false;
        }

        private void metroRadioButton11_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            metroRadioButton1.Checked = false;
            metroRadioButton2.Checked = false;
            metroRadioButton3.Checked = false;
            metroRadioButton4.Checked = false;
            metroRadioButton5.Checked = false;
            metroRadioButton6.Checked = false;
            metroRadioButton7.Checked = false;
            metroRadioButton8.Checked = false;
            metroRadioButton9.Checked = false;
            metroRadioButton10.Checked = false;
        }

        private void metroRadioButton12_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            metroRadioButton1.Checked = false;
            metroRadioButton2.Checked = false;
            metroRadioButton3.Checked = false;
            metroRadioButton4.Checked = false;
            metroRadioButton5.Checked = false;
            metroRadioButton6.Checked = false;
            metroRadioButton7.Checked = false;
            metroRadioButton8.Checked = false;
            metroRadioButton9.Checked = false;
            metroRadioButton10.Checked = false;
        }

        private void metroRadioButton13_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            metroRadioButton5.Checked = false;
            metroRadioButton6.Checked = false;
        }

        private void metroRadioButton14_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            metroRadioButton1.Checked = false;
            metroRadioButton2.Checked = false;
            metroRadioButton3.Checked = false;
            metroRadioButton4.Checked = false;
            metroRadioButton5.Checked = false;
            metroRadioButton6.Checked = false;
            metroRadioButton8.Checked = false;
            metroRadioButton9.Checked = false;
            metroRadioButton10.Checked = false;
        }

        private void metroRadioButton15_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            metroRadioButton1.Checked = false;
            metroRadioButton2.Checked = false;
            metroRadioButton3.Checked = false;
            metroRadioButton4.Checked = false;
            metroRadioButton5.Checked = false;
            metroRadioButton6.Checked = false;
            metroRadioButton8.Checked = false;
            metroRadioButton9.Checked = false;
            metroRadioButton10.Checked = false;
        }
    }
}
