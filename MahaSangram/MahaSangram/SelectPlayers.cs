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
    public partial class SelectPlayers : UserControl
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Github\MahaSangram\MahaSangram\MahaSangram\MSDatabase.mdf;Integrated Security=True;User Instance=True");
        private SqlCommand query = new SqlCommand();
        private SqlDataReader players;
        string[] teamnames;
        string[] team1 = new string[] {};
        string[] team2 = new string[] {};

        public SelectPlayers()
        {
            InitializeComponent();
            connection.Open();
            query.Connection = connection;
            Skip.Click += new EventHandler(Skip_Click);
            Next.Click += new EventHandler(Next_Click);
            
        }
        
        public string Data
        {
            set
            {
                teamnames = value.Split(new Char[] { ',' });
            }
            get
            {
                if (checkedListBox1.SelectedItems.Count == 11 && checkedListBox2.SelectedItems.Count == 11)
                {
                    return 1 + "," + team1[0] + "," + team1[1] + "," + team1[2] + "," + team1[3] + "," + team1[4] + "," + team1[5] + "," + team1[6] + "," + team1[7] + "," + team1[8] + "," + team1[9] + "," + team1[10] + "," + team2[0] + "," + team2[1] + "," + team2[2] + "," + team2[3] + "," + team2[4] + "," + team2[5] + "," + team2[6] + "," + team2[7] + "," + team2[8] + "," + team2[9] + "," + team2[10] + "," + teamnames[1] + "," + teamnames[2];
                }
                else
                {
                    return Convert.ToString("0") ;
                }
            }
        }

        private void Skip_Click(object sender, EventArgs e)
        {

        }
        public void Skipclicklistner(EventHandler handler)
        {
            this.Skip.Click += handler;
        }
       
      
        private void Next_Click(object sender, EventArgs e)
        {
            team1 = checkedListBox1.CheckedItems.OfType<string>().ToArray();
            team2 = checkedListBox2.CheckedItems.OfType<string>().ToArray();
            OnDataAvailable(null);
        }

        public void Nextclicklistner(EventHandler handler)
        {
            this.Next.Click += handler;
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

        private void SelectPlayers_Load(object sender, EventArgs e)
        {
            label1.Text = "SELECT PLAYING 11 OF \n" + teamnames[1];
            label2.Text = "SELECT PLAYING 11 OF \n" + teamnames[2];
            checkedListBox1.Items.Clear();
            checkedListBox2.Items.Clear();
            query.CommandText = "select Name from players where Team = '" + teamnames[1] + "'";
            players = query.ExecuteReader();
            while (players.Read())
            {
                checkedListBox1.Items.Add(players[0].ToString());
            }
            players.Close();
            query.CommandText = "select Name from players where Team = '" + teamnames[2] + "'";
            players = query.ExecuteReader();
            while (players.Read())
            {
                checkedListBox2.Items.Add(players[0].ToString());
            }
            players.Close();
        }
    }
}
