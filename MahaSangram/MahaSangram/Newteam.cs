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
    public partial class Newteam : UserControl
    {
        public Newteam()
        {
            InitializeComponent();

            Addt.Click += new EventHandler(Addt_Click);
            Addp.Click += new EventHandler(Addp_Click);

        }
        
        public void Addtclicklistner(EventHandler handler)
        {
            this.Addt.Click += handler;
        }

        public void Addpclicklistner(EventHandler handler)
        {
            this.Addp.Click += handler;
        }
        
        private void Addt_Click(object sender, EventArgs e)
        {

        }

        private void Addp_Click(object sender, EventArgs e)
        {

        }

    }
}
