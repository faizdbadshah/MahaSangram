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
            ST.DataAvailable += new EventHandler(ST_DataAvailable);
            this.SP.Skipclicklistner(new EventHandler(newmatch4));
            this.SP.Nextclicklistner(new EventHandler(newmatch3));
            this.H.Teamsclicklistner(new EventHandler(team));
            this.H.Statsclicklistner(new EventHandler(newStats));
            this.T.Addtclicklistner(new EventHandler(add1));
            this.T.Addpclicklistner(new EventHandler(add2));
            this.P.AddNewPlayerclicklistner(new EventHandler(add3));
            this.T.NewTeamBackclicklistner(new EventHandler(back1));
            this.A.AddteambuttonBackclicklistner(new EventHandler(back2));
            this.P.AddplayerbuttonBackclicklistner(new EventHandler(back3));
            this.I.PlayerInfoBackclicklistner(new EventHandler(back4));
            this.ST.SelectTeamsBackclicklistner(new EventHandler(back5));
            this.Stats1.StatsBackclicklistner(new EventHandler(back6));
            T.DataAvailable += new EventHandler(T_DataAvailable);
            SP.DataAvailable += new EventHandler(SP_DataAvailable);
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
        
        private void add1(object sender, EventArgs e)
        {
            this.Controls.Remove(T);
            A.Dock = DockStyle.Fill;
            this.Controls.Add(A);
        }

        private void add2(object sender, EventArgs e)
        {
            abcde = T.Data.Split(new Char[] { ',' });
            if (Convert.ToInt64(abcde[0]) == 1)
            {
                this.Controls.Remove(T);
                P.Dock = DockStyle.Fill;
                this.Controls.Add(P);
            }
            else
            {
                MessageBox.Show("Please select a team from the list");
            }
        }

        private void add3(object sender, EventArgs e)
        {
            this.Controls.Remove(P);
            I.Dock = DockStyle.Fill;
            this.Controls.Add(I);
        }
        private void back1(object sender, EventArgs e)
        {
            this.Controls.Remove(T);
            H.Dock = DockStyle.Fill;
            this.Controls.Add(H);
        }
        private void back2(object sender, EventArgs e)
        {
            this.Controls.Remove(A);
            T.Dock = DockStyle.Fill;
            this.Controls.Add(T);
        }
        private void back3(object sender, EventArgs e)
        {
            this.Controls.Remove(P);
            T.Dock = DockStyle.Fill;
            this.Controls.Add(T);
        }
        private void back4(object sender, EventArgs e)
        {
            this.Controls.Remove(I);
            P.Dock = DockStyle.Fill;
            this.Controls.Add(P);
        }
        private void back5(object sender, EventArgs e)
        {
            this.Controls.Remove(ST);
            H.Dock = DockStyle.Fill;
            this.Controls.Add(H);
        }
        private void back6(object sender, EventArgs e)
        {
            this.Controls.Remove(Stats1);
            H.Dock = DockStyle.Fill;
            this.Controls.Add(H);
        }
        void ST_DataAvailable(object sender, EventArgs e)
        {
            if (ST != null && SP != null)
            {
                string data = ST.Data;
                SP.Data = data;
            }
        }

        void T_DataAvailable(object sender, EventArgs e)
        {
            if (T != null && P != null)
            {
                string data = T.Data;
                P.Data = data;
            }
        }

        void SP_DataAvailable(object sender, EventArgs e)
        {
            if (SP != null && SC != null)
            {
                string data = SP.Data;
                SC.Data = data;
            }
        }
    }
}
