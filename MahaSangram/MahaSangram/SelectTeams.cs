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
    public partial class SelectTeams : UserControl
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Github\MahaSangram\MahaSangram\MahaSangram\MSDatabase.mdf;Integrated Security=True;User Instance=True");
        private SqlCommand query = new SqlCommand();
        private SqlDataReader teams;
        
        public SelectTeams()
        {
            InitializeComponent();
            connection.Open();
            query.Connection = connection;
            Next.Click += new EventHandler(Next_Click);
        }

        public void Nextclicklistner(EventHandler handler)
        {
            this.Next.Click += handler;
        }

        private void SelectTeams_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            query.CommandText = "select * from teams";
            teams = query.ExecuteReader();
            while (teams.Read())
            {
                listBox1.Items.Add(teams[1].ToString());
                listBox2.Items.Add(teams[1].ToString());
            }
            teams.Close();
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selectedteam = listBox1.SelectedItem;
            listBox2.Items.Clear();
            foreach (object obj in listBox1.Items)
            {
                if (obj != selectedteam)
                {
                    listBox2.Items.Add(obj);
                }
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            OnDataAvailable(null);
        }



        public string Data
        {
            get
            {
                return listBox1.Text + "," + listBox2.Text;
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
