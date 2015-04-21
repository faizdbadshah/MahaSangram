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
        Newteam T = new Newteam();
        SelectTeams ST = new SelectTeams();
        SelectPlayers SP = new SelectPlayers();
        Scorecard SC = new Scorecard();
        Stats Stats1 = new Stats();
        Addteambutton A = new Addteambutton();
        Addplayerbutton P = new Addplayerbutton();
        PlayerInfo I = new PlayerInfo();
        string[] abcde;

        public MasterForm()
        {
            InitializeComponent();
            this.H.Matchclicklistner(new EventHandler(newmatch1));
            this.ST.Nextclicklistner(new EventHandler(newmatch2));
            ST.DataAvailable += new EventHandler(child_DataAvailable);
            this.SP.Skipclicklistner(new EventHandler(newmatch4));
            this.SP.Nextclicklistner(new EventHandler(newmatch3));
            this.H.Teamsclicklistner(new EventHandler(team));
            this.H.Statsclicklistner(new EventHandler(newStats));
            this.T.Addtclicklistner(new EventHandler(add1));
            this.T.Addpclicklistner(new EventHandler(add2));
            this.P.AddNewPlayerclicklistner(new EventHandler(add3));
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
            abcde = ST.Data.Split(new Char[] { ',' });
            if(Convert.ToInt64(abcde[0])==1)
            {
                this.Controls.Remove(ST);
                SP.Dock = DockStyle.Fill;
                this.Controls.Add(SP);
            }
            else
            {
                MessageBox.Show("Please select both the teams first");
            }
            
        }

        private void newmatch3(object sender, EventArgs e)
        {
            abcde = SP.Data.Split(new Char[] { ',' });
            if (Convert.ToInt64(abcde[0]) == 1)
            {
                this.Controls.Remove(SP);
                SC.Dock = DockStyle.Fill;
                this.Controls.Add(SC);
            }
            else
            {
                MessageBox.Show("Please select 11 players from both the teams ");
            }
        }

        private void newmatch4(object sender, EventArgs e)
        {
            this.Controls.Remove(SP);
            SC.Dock = DockStyle.Fill;
            this.Controls.Add(SC);
        }

        private void team(object sender, EventArgs e)
        {
            this.Controls.Remove(H);
            T.Dock = DockStyle.Fill;
            this.Controls.Add(T);
        }


        private void newStats(object sender, EventArgs e)
        {
            this.Controls.Remove(H);
            Stats1.Dock = DockStyle.Fill;
            this.Controls.Add(Stats1);
        }


        
        //child1.DataAvailable += new EventHandler(child_DataAvailable);

        private void add1(object sender, EventArgs e)
        {
            this.Controls.Remove(T);
            A.Dock = DockStyle.Fill;
            this.Controls.Add(A);
        }
        private void add2(object sender, EventArgs e)
        {
            this.Controls.Remove(T);
            P.Dock = DockStyle.Fill;
            this.Controls.Add(P);
        }
        private void add3(object sender, EventArgs e)
        {
            this.Controls.Remove(P);
            I.Dock = DockStyle.Fill;
            this.Controls.Add(I);
        }


        
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
