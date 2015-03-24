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
        string a;
        public SelectPlayers()
        {
            InitializeComponent();
            connection.Open();
            query.Connection = connection;
        }


        void initiate()
        {
            label6.Text = "SELECT PLAYING 11 OF \n" + teamnames[0];
            label5.Text = "SELECT PLAYING 11 OF \n" + teamnames[1];
            checkedListBox1.Items.Clear();
            checkedListBox2.Items.Clear();
            query.CommandText = "select Name from players where Team = '" + teamnames[0] + "'";
            players = query.ExecuteReader();
            while (players.Read())
            {
                checkedListBox1.Items.Add(players[0].ToString());
            }
            players.Close();
            query.CommandText = "select Name from players where Team = '" + teamnames[1] + "'";
            players = query.ExecuteReader();
            while (players.Read())
            {
                checkedListBox2.Items.Add(players[0].ToString());
            }
            players.Close();
        }

        public string Data
        {
            set
            {
                a = value;
                teamnames = a.Split(new Char[] { ','});
                initiate();
            }
        }
    }
}
