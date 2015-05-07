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
    public partial class Teams : UserControl
    {

        private SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Github\MahaSangram\MahaSangram\MahaSangram\MSDatabase.mdf;Integrated Security=True;User Instance=True");
        private SqlCommand query = new SqlCommand();
        private SqlDataReader teams, players;

        public Teams()
        {
            InitializeComponent();
            connection.Open();
            query.Connection = connection;
        }
        
        public void Addtclicklistner(EventHandler handler)
        {
            this.AddT.Click += handler;
        }
        public void TeamsBackclicklistner(EventHandler handler)
        {
            this.TeamsBack.Click += handler;
        }

        public void PlayersInfoclicklistner(EventHandler handler)
        {
            this.PlayersInfo.Click += handler;
        }
        
        private void Addt_Click(object sender, EventArgs e)
        {

        }
    
        private void Delete_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems.Count==1)
            {
                string message = "Do You Really Want to Delete the team " + listBox1.Text + "\n The team will be deleted with all of its players";
                string caption = "Delete";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(this, message, caption, buttons);

                if (result == DialogResult.Yes)
                {
                    query.CommandText = "delete from Players where Team ='" + listBox1.Text + "'";
                    players = query.ExecuteReader();
                    players.Close();

                    query.CommandText = "delete from teams where team_name ='" + listBox1.Text + "'";
                    teams = query.ExecuteReader();
                    teams.Close();

                    initiate();
                }
            }
            else
            {
                MessageBox.Show("Please select the team you want to delete");
            }
        }

        public string Data
        {
            get
            {
                if (listBox1.SelectedItems.Count == 1)
                {
                    return 1 + "," + listBox1.Text;
                }
                else
                {
                    return 0 + "," + listBox1.Text;
                }
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

        public void initiate()
        {
            listBox1.Items.Clear();
            query.CommandText = "select * from teams";
            teams = query.ExecuteReader();
            while (teams.Read())
            {
                listBox1.Items.Add(teams[1].ToString());
            }
            teams.Close();
        }

        private void PlayersInfo_Click(object sender, EventArgs e)
        {
            OnDataAvailable(null);
        }

        private void TeamsBack_Click(object sender, EventArgs e)
        {

        }
    }
}
