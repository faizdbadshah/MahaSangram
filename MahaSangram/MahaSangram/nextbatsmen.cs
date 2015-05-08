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
    public partial class NextBatsmen : UserControl
    {
        string[] batsmen;
        int i;

        public NextBatsmen()
        {
            InitializeComponent();
        }

        public string Data
        {
            get
            {
                return comboBox1.Text + "," + comboBox2.Text;
            }
            set
            {
                batsmen = value.Split(new Char[] { ',' });
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
            comboBox2.Visible = false;
            comboBox1.Items.Clear();
            comboBox1.Text = "Select The Next Batsmen";
            for (i = 0; i < batsmen.Length; i++)
            {
                comboBox1.Items.Add(batsmen[i]);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            for (i = 0; i < batsmen.Length; i++)
            {
                if (comboBox1.Text != batsmen[i])
                {
                    comboBox2.Items.Add(batsmen[i]);
                }
            }
        }

        public void initiate2()
        {
            comboBox1.Text = "Select The Batsman At The Strikers End";
            comboBox2.Text = "Select The Batsman At The Non-Strikers End";
            comboBox2.Visible = true;
            comboBox2.Items.Clear();
            for (i = 0; i < batsmen.Length; i++)
            {
                comboBox2.Items.Add(batsmen[i]);
            }
        }
    }
}
