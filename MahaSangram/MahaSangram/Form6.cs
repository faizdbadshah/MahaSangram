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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0 && textBox2.TextLength != 0 && textBox3.TextLength != 0 && textBox4.TextLength != 0 && textBox5.TextLength != 0 && textBox6.TextLength != 0 && textBox7.TextLength != 0 && textBox8.TextLength != 0 && textBox9.TextLength != 0 && textBox10.TextLength != 0 && textBox11.TextLength != 0 && textBox12.TextLength != 0 && textBox13.TextLength != 0 && textBox14.TextLength != 0 && textBox15.TextLength != 0 && textBox16.TextLength != 0)
            {
                
                //yahan pe se sara data database me store hona hai
                
                
                Form1 f = new Form1();
                f.Show();
                this.Close();
            }
            else MessageBox.Show("Enter the name of the Team and all the Players");
        }

       
       

        

    

      
    }
}
