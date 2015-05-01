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
    public partial class overs : UserControl
    {
        public overs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        public string Data
        {
            get
            {
                if (textBox1.Text != null)
                {
                    return textBox1.Text;
                }
                else
                {
                    return Convert.ToString(0);
                }
            }
        }

        public void button1clicklistner(EventHandler handler)
        {
            this.button1.Click += handler;
        }

        
    }
}
