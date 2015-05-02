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
    public partial class Toss : UserControl
    {
        string[] abcd = new string[3];
        string[] sakshi;

        public Toss()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Batting")
            {
                abcd[0] = Convert.ToString(1);
                abcd[2] = "Batting";
            }
            else
            {
                abcd[0] = Convert.ToString(0);
                abcd[1]= button1.Text;
                label1.Text = " Select Batting or Bowling ";
                button1.Text = "Batting";
                button2.Text = "Fielding";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Fielding")
            {
                abcd[0] = Convert.ToString(1);
                abcd[2] = "Fielding";
            }
            else
            {
                abcd[0] = Convert.ToString(0);
                abcd[1]= button2.Text;
                label1.Text = " Select Batting or Bowling ";
                button1.Text = "Batting";
                button2.Text = "Fielding";
            }
        }

        public string Data
        {
            get
            {
                return abcd[0] + "," + abcd[1] +  "," + abcd[2] ;
            }

            set
            {
                sakshi = value.Split(new Char[] { ',' });
                button1.Text = sakshi[0];
                button2.Text = sakshi[1];
            }
        }

        public void button1clicklistner(EventHandler handler)
        {
            this.button1.Click += handler;
        }

        public void button2clicklistner(EventHandler handler)
        {
            this.button2.Click += handler;
        }
    }
}
