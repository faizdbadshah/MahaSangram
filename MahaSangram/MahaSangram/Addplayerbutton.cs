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
    public partial class Addplayerbutton : UserControl
    {
        public Addplayerbutton()
        {
            InitializeComponent();
            AddNewPlayer.Click += new EventHandler(AddNewPlayer_Click);
        }
        public void AddNewPlayerclicklistner(EventHandler handler)
        {
            this.AddNewPlayer.Click += handler;
        }


        private void AddNewPlayer_Click(object sender, EventArgs e)
        {

        }
    }
}
