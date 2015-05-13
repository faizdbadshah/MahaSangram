using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MahaSangram
{
    public partial class Home : UserControl
    {

        private SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Github\MahaSangram\MahaSangram\MahaSangram\MSDatabase.mdf;Integrated Security=True;User Instance=True");
        private SqlCommand query = new SqlCommand();
        private SqlDataReader teams, players;


        int a;
      
        public Home()
        {
            InitializeComponent();
            connection.Open();
            query.Connection = connection;
          
            if (Properties.Settings.Default.TournamentStart == true)
            {
                Teams.Enabled = false;
                Match.Text = "Match";
                button1.Visible = true;
            }
        }

        public void Matchclicklistner(EventHandler handler)
        {
            this.Match.Click += handler;
        }

        private void Match_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.TournamentStart == false)
            {
                string message = "Do You Really Want to Start tournament ???? \n After starting you won't be able to add team or make changes in teams.";
                string caption = "Start";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(this, message, caption, buttons);

                if (result == DialogResult.Yes)
                {
                    Properties.Settings.Default.TournamentStart = true;
                    Properties.Settings.Default.Save();
                    Teams.Enabled = false;
                    Match.Text = "Match";
                    button1.Visible = true;
                    a = 0;
                }
                else
                {
                    a = 0;
                }
            }
            else
            {
                a = 1;
            }

            OnDataAvailable(null);
        }

        public void Teamsclicklistner(EventHandler handler)
        {
            this.Teams.Click += handler;
        }

        private void Teams_Click(object sender, EventArgs e)
        {
           
        }

        private void Statistics_Click(object sender, EventArgs e)
        {

        }

        public void Statsclicklistner(EventHandler handler)
        {
            this.Statistics.Click += handler;
        }
        
        private void Rules_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.TournamentStart = false;
            Properties.Settings.Default.Save();
            Teams.Enabled = true;
            Match.Text = "Start Tournament";

            query.CommandText = "update Players set Matches_Played = 0 , Innings = 0 , Runs = 0 , Balls_Played = 0";
            teams = query.ExecuteReader();
            teams.Close();
        }

        private void Settings_Click(object sender, EventArgs e)
        {

        }

        private void Quit_Click(object sender, EventArgs e)
        {
            string message = "Do You Really Want to QUIT";
            string caption = "QUIT";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(this, message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public string Data
        {
            get
            {
                return Convert.ToString(a);
            }
        }

        public event EventHandler DataAvailable;

        protected virtual void OnDataAvailable(EventArgs e)
        {
            EventHandler eh = DataAvailable;
            if (eh != null)
            {
                eh(this, e);
            }
        }
    }
}
