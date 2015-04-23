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
    public partial class Addplayerbutton : UserControl
    {

        private SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Github\MahaSangram\MahaSangram\MahaSangram\MSDatabase.mdf;Integrated Security=True;User Instance=True");
        private SqlCommand query = new SqlCommand();
        private SqlDataReader players;
        string[] teamname;

        public Addplayerbutton()
        {
            InitializeComponent();
            connection.Open();
            query.Connection = connection;
            AddNewPlayer.Click += new EventHandler(AddNewPlayer_Click);
            AddplayerbuttonBack.Click += new EventHandler(AddplayerbuttonBack_Click);
        }

        public void AddNewPlayerclicklistner(EventHandler handler)
        {
            this.AddNewPlayer.Click += handler;
        }
        public void AddplayerbuttonBackclicklistner(EventHandler handler)
        {
            this.AddplayerbuttonBack.Click += handler;
        }

        private void AddNewPlayer_Click(object sender, EventArgs e)
        {

        }
        private void AddplayerbuttonBack_Click(object sender, EventArgs e)
        {

        }

        public string Data
        {
            set
            {
                teamname = value.Split(new Char[] { ',' });
            }
        }
               
        private void Addplayerbutton_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            query.CommandText = "select * from Players where Team = '" + teamname[1] + "'";
            players = query.ExecuteReader();
            while (players.Read())
            {
                listBox1.Items.Add(players[1].ToString());
            }
            players.Close();
        }
    }
}
