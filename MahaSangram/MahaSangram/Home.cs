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
            Match.Click += new EventHandler(Match_Click);
            Teams.Click += new EventHandler(Teams_Click);
        }

        public void Matchclicklistner(EventHandler handler)
        {
            this.Match.Click += handler;
        }

        private void Match_Click(object sender, EventArgs e)
        {
            // Delegate the event to the caller
        }

        public void Teamsclicklistner(EventHandler handler)
        {
            this.Teams.Click += handler;
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

        private void Rules_Click(object sender, EventArgs e)
        {

        }
    }
}
