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
    public partial class Addteambutton : UserControl
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Github\MahaSangram\MahaSangram\MahaSangram\MSDatabase.mdf;Integrated Security=True;User Instance=True");
        private SqlCommand query = new SqlCommand();
        private SqlDataReader teams;
        
        public Addteambutton()
        {
            InitializeComponent();
            connection.Open();
            query.Connection = connection;
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
            if (TeamName.Text != "Name of the team" && TeamYear.Text != "Year" && TeamBranch.Text != "Branch")
            {
                query.CommandText = "insert into teams(team_name) values('" + TeamName.Text + "')";
                teams = query.ExecuteReader();
                teams.Close();
            }
            else
            {
                MessageBox.Show("Please Enter all the required values first");
            }
            
        }

        private void TeamName_Click(object sender, EventArgs e)
        {
            if(TeamName.Text =="Name of the team")
            {
                TeamName.Text = "";
            }
        }

        private void TeamYear_Click(object sender, EventArgs e)
        {
            if (TeamYear.Text == "Year")
            {
                TeamYear.Text = "";
            }
        }

        private void TeamBranch_Click(object sender, EventArgs e)
        {
            if (TeamBranch.Text == "Branch")
            {
                TeamBranch.Text = "";
            }
        }
    }
}
