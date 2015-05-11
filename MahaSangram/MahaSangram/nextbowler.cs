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
    public partial class NextBowler : UserControl
    {
        string[] bowler;
        int i;


        public NextBowler()
        {
            InitializeComponent();
        }

        public string Data
        {
            get
            {
                return comboBox1.Text;
            }
            set
            {
                bowler = value.Split(new Char[] { ',' });
            }
        }

        public void button1clicklistner(EventHandler handler)
        {
            this.button1.Click += handler;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void initiate()
        {
            comboBox1.Items.Clear();
            comboBox1.Text = "Select The Next Bowler";
            for (i = 0; i < bowler.Length; i++)
            {
                comboBox1.Items.Add(bowler[i]);
            }
        }

        

    }
}
