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
    public partial class Addteambutton : UserControl
    {
        public Addteambutton()
        {
            InitializeComponent();
            AddteambuttonBack.Click += new EventHandler(AddteambuttonBack_Click);
        }
        public void AddteambuttonBackclicklistner(EventHandler handler)
        {
            this.AddteambuttonBack.Click += handler;
        }
        private void AddteambuttonBack_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {

        }
    }
}
