using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace MahaSangram
{
    public partial class SelectTeams : UserControl
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
        private SqlCommand query = new SqlCommand();
        private SqlDataReader teams;
        
        public SelectTeams()
        {
            InitializeComponent();
            connection.Open();
            query.Connection = connection;
        }

        public void Nextclicklistner(EventHandler handler)
        {
            this.Next.Click += handler;
        }
        public void SelectTeamsBackclicklistner(EventHandler handler)
        {
            this.SelectTeamsBack.Click += handler;
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
        private void SelectTeamsBack_Click(object sender, EventArgs e)
        {
          
        }
        

        public string Data
        {
            get
            {
                if (listBox1.SelectedItems.Count == 1 && listBox2.SelectedItems.Count == 1)
                {
                    return 1 + "," + listBox1.Text + "," + listBox2.Text;
                }
                else
                {
                    return 0 + "," + listBox1.Text + "," + listBox2.Text;
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

        public void Initiate()
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

    }
}
