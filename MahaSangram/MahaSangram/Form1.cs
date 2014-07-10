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
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
         }

        private void button3_Click(object sender, EventArgs e)
        {
            functions.closeapp();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            functions.closeapp(e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Show();
            this.Hide();
        }

     }
}
