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
    public partial class PlayerInfo : UserControl
    {

        private SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Github\MahaSangram\MahaSangram\MahaSangram\MSDatabase.mdf;Integrated Security=True;User Instance=True");
        private SqlCommand query = new SqlCommand();
        private SqlDataReader players;
        string teamname;
        int count;

        public PlayerInfo()
        {
            InitializeComponent();
            connection.Open();
            query.Connection = connection;
            PlayerInfoBack.Click += new EventHandler(PlayerInfoBack_Click);
        }
        public void PlayerInfoBackclicklistner(EventHandler handler)
        {
            this.PlayerInfoBack.Click += handler;
        }
        
        private void PlayerInfoBack_Click(object sender, EventArgs e)
        {

        }
        private void PlayerYear_TextChanged(object sender, EventArgs e)
        {

        }

        public string Data
        {
            set
            {
                teamname = value;
            }
        }

        private void PlayerName_Click(object sender, EventArgs e)
        {
            if (PlayerName.Text == "Name of Player")
            {
                PlayerName.Text = "";
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            query.CommandText = "SELECT COUNT(*) FROM Players";
            players = query.ExecuteReader();
            while(players.Read())
            {
                count = Convert.ToInt32(players[0]);
            }
           
            players.Close();
            MessageBox.Show("insert into Players values('" + count+1 + "' , '" + PlayerName.Text + "' , '" + teamname + "')");
            if (count < 15)
            {
                query.CommandText = "insert into Players values ('" + count+1 + "','" + PlayerName.Text + "','" + teamname + "')";
                players = query.ExecuteReader();
                players.Close();
            }
            else
            {
                MessageBox.Show("The Team is full, all 15 players have been added, please remove an existing player to add a new player");
            }
            PlayerName.Text = "Name of Player";
        }
    }
}
