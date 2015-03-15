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
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Match_Click(object sender, EventArgs e)
        {
           // load_teams("newmatch");
            //listBox1.SelectedIndex = 0;
            //functions.change_panel(panel_form1, panel2);
        }

        private void Teams_Click(object sender, EventArgs e)
        {
           // load_teams("addteam");
           // functions.change_panel(panel_form1, metroPanel1);
        }

        private void quit_button_form1_Click(object sender, EventArgs e)
        {
            //functions.closeapp(this, this, connection);
        }
    }
}
