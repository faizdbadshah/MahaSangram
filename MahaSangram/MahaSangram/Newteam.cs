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
    public partial class Newteam : UserControl
    {

        private SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Github\MahaSangram\MahaSangram\MahaSangram\MSDatabase.mdf;Integrated Security=True;User Instance=True");
        private SqlCommand query = new SqlCommand();
        private SqlDataReader teams, players;

        public Newteam()
        {
            InitializeComponent();
            connection.Open();
            query.Connection = connection;
            Addt.Click += new EventHandler(Addt_Click);
            Addp.Click += new EventHandler(Addp_Click);
            NewTeamBack.Click += new EventHandler(NewTeamBack_Click);
        }
        
        public void Addtclicklistner(EventHandler handler)
        {
            this.Addt.Click += handler;
        }
        public void NewTeamBackclicklistner(EventHandler handler)
        {
            this.NewTeamBack.Click += handler;
        }
        public void Addpclicklistner(EventHandler handler)
        {
            this.Addp.Click += handler;
        }
        
        private void Addt_Click(object sender, EventArgs e)
        {

        }
        private void NewTeamBack_Click(object sender, EventArgs e)
        {

        }

        private void Addp_Click(object sender, EventArgs e)
        {
            OnDataAvailable(null);
        }

        private void Newteam_Load(object sender, EventArgs e)
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
                    query.CommandText = "delete from Players where Team =" + listBox1.Text;
                    players = query.ExecuteReader();
                    players.Close();
                    query.CommandText = "delete from teams where team_name =" + listBox1.Text;
                    players = query.ExecuteReader();
                    players.Close();
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
    }
}
