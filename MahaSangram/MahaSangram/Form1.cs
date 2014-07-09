using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MahaSangram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2=new Form2();
            f2.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form5 f1 = new Form5();
            f1.Hide();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }

       
    }
}
