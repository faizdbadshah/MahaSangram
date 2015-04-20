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
    public partial class Scorecard : UserControl
    {
        int a, b, c, d, balls, runs, overs, i;
        int[] record = new int[150];
        string[] playersnames,players1,players2,teamname;
        
       

        public Scorecard()
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

        private void button1_Click(object sender, EventArgs e)
        {
            i = a = b = c = d = 0;
            if (metroRadioButton2.Checked == true)
                b = 1;
            else if (metroRadioButton3.Checked == true)
                b = 2;
            else if (metroRadioButton4.Checked == true)
                b = 3;
            else if (metroRadioButton5.Checked == true)
                b = 4;
            else if (metroRadioButton6.Checked == true)
                b = 6;

            if (metroRadioButton7.Checked == true)
                c = 1;
            else if (metroRadioButton8.Checked == true)
                c = 2;
            else if (metroRadioButton9.Checked == true)
                c = 3;
            else if (metroRadioButton10.Checked == true)
                c = 4;

            if (metroRadioButton11.Checked == true)
                d = 1;
            else if (metroRadioButton12.Checked == true)
                d = 2;
            else if (metroRadioButton13.Checked == true)
                d = 3;
            else if (metroRadioButton14.Checked == true)
                d = 4;
            else if (metroRadioButton15.Checked == true)
                d = 5;
       
            a = (100 * b) + (10 * c) + d;

            record[i] = a;
            if (c != 1 && c != 2)
            {
                balls++;
                runs += b;
            }
            else
                runs += b + 1;

            if (balls == 6)
            {
                overs++;
                balls = 0;
            }


            i++;
        }
        public string Data
        {
            set
            {
                playersnames = value.Split(new Char[] { ',' });
                getdata();
            }
        }

        private void getdata()
        {
            for(int i=0;i<11;i++)
            {
                players1[i] = playersnames[i + 1];
                players2[i] = playersnames[i + 12];
            }
            teamname[0] = playersnames[23];
            teamname[1] = playersnames[24];

            label1.Text = teamname[0];
            label2.Text = teamname[1];

            listBox1.Items.Add(teamname[0]);
            listBox1.Items.Add(teamname[1]);

            label3.Text = label5.Text = label7.Text = label9.Text = Convert.ToString("0");
            label6.Text = label10.Text = Convert.ToString("0.0");
        }
    }
}
