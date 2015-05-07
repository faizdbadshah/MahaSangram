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
                return comboBox1.Text;
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
            comboBox1.Items.Clear();
            for (i = 0; i < batsmen.Length; i++)
            {
                comboBox1.Items.Add(batsmen[i]);
            }
        }
    }
}
