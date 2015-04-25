﻿using System;
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
        int a, b, c, d, balls, runs, overs, i, k, l, wickets;
        int[] record = new int[150];
        string[] playersnames, players1, players2, teamname;
        double[] povers= new double[11];
        int[] x1val = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; //array for balls for team A&B
        int[] y1val = new int[9] { 6, 2, 4, 1, 0, 5, 6, 2, 1 }; //array for runs-teamA
        int[] y2val = new int[9] { 4, 3, 1, 1, 2, 6, 0, 4, 1 };//array for runs teamB

        public Scorecard()
        {
            InitializeComponent();
            ScorecardBack.Click += new EventHandler(ScorecardBack_Click);
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Submit.Enabled = true;
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Submit.Enabled = true;
            metroRadioButton11.Checked = false;
            metroRadioButton12.Checked = false;
            metroRadioButton14.Checked = false;
            metroRadioButton15.Checked = false;
            metroRadioButton16.Checked = false;
        }

        private void metroRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Submit.Enabled = true;
            metroRadioButton11.Checked = false;
            metroRadioButton12.Checked = false;
            metroRadioButton14.Checked = false;
            metroRadioButton15.Checked = false;
            metroRadioButton16.Checked = false;
        }

        private void metroRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Submit.Enabled = true;
            metroRadioButton11.Checked = false;
            metroRadioButton12.Checked = false;
            metroRadioButton14.Checked = false;
            metroRadioButton15.Checked = false;
            metroRadioButton16.Checked = false;
        }

        private void metroRadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Submit.Enabled = true;
            metroRadioButton11.Checked = false;
            metroRadioButton12.Checked = false;
            metroRadioButton13.Checked = false;
            metroRadioButton14.Checked = false;
            metroRadioButton15.Checked = false;
            metroRadioButton16.Checked = false;
        }

        private void metroRadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Submit.Enabled = true;
            metroRadioButton7.Checked = false;
            metroRadioButton9.Checked = false;
            metroRadioButton10.Checked = false;
            metroRadioButton11.Checked = false;
            metroRadioButton12.Checked = false;
            metroRadioButton13.Checked = false;
            metroRadioButton14.Checked = false;
            metroRadioButton15.Checked = false;
            metroRadioButton16.Checked = false;
        }

        private void metroRadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            Submit.Enabled = true;
            metroRadioButton6.Checked = false;
            metroRadioButton11.Checked = false;
            metroRadioButton12.Checked = false;
            metroRadioButton14.Checked = false;
        }

        private void metroRadioButton8_CheckedChanged(object sender, EventArgs e)
        {
            Submit.Enabled = true;
            metroRadioButton11.Checked = false;
            metroRadioButton12.Checked = false;
            metroRadioButton14.Checked = false;
            metroRadioButton15.Checked = false;
            metroRadioButton16.Checked = false;
        }

        private void metroRadioButton9_CheckedChanged(object sender, EventArgs e)
        {
            Submit.Enabled = true;
            metroRadioButton6.Checked = false;
            metroRadioButton11.Checked = false;
            metroRadioButton12.Checked = false;
            metroRadioButton14.Checked = false;
            metroRadioButton15.Checked = false;
        }

        private void metroRadioButton10_CheckedChanged(object sender, EventArgs e)
        {
            Submit.Enabled = true;
            metroRadioButton6.Checked = false;
            metroRadioButton11.Checked = false;
            metroRadioButton12.Checked = false;
            metroRadioButton14.Checked = false;
            metroRadioButton15.Checked = false;
        }

        private void metroRadioButton11_CheckedChanged(object sender, EventArgs e)
        {
            Submit.Enabled = true;
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
            Submit.Enabled = true;
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
            Submit.Enabled = true;
            metroRadioButton5.Checked = false;
            metroRadioButton6.Checked = false;
        }

        private void metroRadioButton14_CheckedChanged(object sender, EventArgs e)
        {
            Submit.Enabled = true;
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
            Submit.Enabled = true;
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

        private void metroRadioButton16_CheckedChanged(object sender, EventArgs e)
        {
            Submit.Enabled = true;
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

        public string Data
        {
            set
            {
                playersnames = value.Split(new Char[] { ',' });
            }
        }
              
        public void ScorecardBackclicklistner(EventHandler handler)
        {
            this.ScorecardBack.Click += handler;
        }

        private void ScorecardBack_Click(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Submit.Enabled = false;
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
            metroRadioButton11.Checked = false;
            metroRadioButton12.Checked = false;
            metroRadioButton13.Checked = false;
            metroRadioButton14.Checked = false;
            metroRadioButton15.Checked = false;
            metroRadioButton16.Checked = false;
        }

        private void Submit_Click(object sender, EventArgs e)
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
            else if (metroRadioButton16.Checked == true)
                d = 6;

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

            if (d > 0 && d < 7)
            {
                wickets++;
            }



            i++;



            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = "Chaitanya";
            row.Cells[1].Value = "bas ho gaya ab out";
            row.Cells[2].Value = 50;
            row.Cells[3].Value = 20;
            dataGridView1.Rows.Add(row);

            generateGraph(); 
        }

        public void initiate()
        {
            /* for (i = 0; i < 11; i++)
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

            DataGridViewRow row;
            for (i = 0; i < 11; i++)
            {
                row = (DataGridViewRow)dataGridView1.Rows[i].Clone();
                row.Cells[0].Value = players1[i];
                row.Cells[1].Value = "Still To Play";

                row = (DataGridViewRow)dataGridView2.Rows[i].Clone();
                row.Cells[0].Value = players1[i];

            }*/
        }
       
         public void generateGraph()
        {
            chart1.Series["teamA"].Points.DataBindXY(x1val, y1val);
            chart1.Series["teamB"].Points.DataBindXY(x1val, y2val);
        }


        public void generateScorecard()
         {   
             //jb team1 ki batting
             label3.Text = Convert.ToString(runs);
             label5.Text = Convert.ToString(wickets);
             label6.Text = Convert.ToString(overs);

             // teAM 2 ki batting
             label7.Text = Convert.ToString(runs);
             label9.Text = Convert.ToString(wickets);
             label10.Text = Convert.ToString(overs);

            if(c==1)
            {
                label16.Text = Convert.ToString( Convert.ToInt32(label16.Text) + Convert.ToInt32(1)) ;
               
            }

            else if (c==2)
            {
                label17.Text = Convert.ToString( Convert.ToInt32(label17.Text) + Convert.ToInt32(1));

            }

            else if (c==3)
            {
                label18.Text = Convert.ToString( Convert.ToInt32(label18.Text) + Convert.ToInt32(b));

            }
            else if (c == 4)
            {
                label19.Text = Convert.ToString(Convert.ToInt32(label19.Text) + Convert.ToInt32(b));

            }

            if (c > 0 && c < 5)
            {
                label13.Text = Convert.ToString(Convert.ToInt32(label16.Text) + Convert.ToInt32(label17.Text) + Convert.ToInt32(label18.Text) + Convert.ToInt32(label19.Text));

            }

            if (d > 0 && d < 7)
            {

                label15.Text = label15.Text + runs + "/" + wickets + "(" + "jo bhi player out hua hoga" + "," + overs + ")";
            }



         }
    }
}
