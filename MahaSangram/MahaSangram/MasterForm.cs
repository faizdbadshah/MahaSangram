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
    public partial class MasterForm : Form
    {
        Home H = new Home();
        SelectTeams ST = new SelectTeams();
        SelectPlayers SP = new SelectPlayers();
        Scorecard SC = new Scorecard();

        public MasterForm()
        {
            InitializeComponent();
            this.H.Matchclicklistner(new EventHandler(newmatch1));
            this.ST.Nextclicklistner(new EventHandler(newmatch2));
            ST.DataAvailable += new EventHandler(child_DataAvailable);
            this.SP.Skipclicklistner(new EventHandler(newmatch3));
        }
                   
        private void MasterForm_Load(object sender, EventArgs e)
        {
            H.Dock = DockStyle.Fill;
            this.Controls.Add(H);
        }
        
        private void newmatch1(object sender, EventArgs e)
        {
            this.Controls.Remove(H);
            ST.Dock = DockStyle.Fill;
            this.Controls.Add(ST);
        }

        private void newmatch2(object sender, EventArgs e)
        {
            this.Controls.Remove(ST);
            SP.Dock = DockStyle.Fill;
            this.Controls.Add(SP);
        }

        private void newmatch3(object sender, EventArgs e)
        {
            this.Controls.Remove(SP);
            SC.Dock = DockStyle.Fill;
            this.Controls.Add(SC);
        }

        

        
        //child1.DataAvailable += new EventHandler(child_DataAvailable);
        
        void child_DataAvailable(object sender, EventArgs e)
        {
            if (ST != null && SP != null)
            {
                string data = ST.Data;
                SP.Data = data;
            }
        }


       
    }
}
