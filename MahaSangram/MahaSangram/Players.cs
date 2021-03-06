﻿using System;
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
    public partial class Players : UserControl
    {

        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
        private SqlCommand query = new SqlCommand();
        private SqlDataReader players;
        string[] teamname;

        public Players()
        {
            InitializeComponent();
            connection.Open();
            query.Connection = connection;
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
            OnDataAvailable(null);
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
            get
            {
                return teamname[1];
            }
        }
               
        private void RemovePlayer_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 1)
            {
                string message = "Do You Really Want to Remove the player " + listBox1.Text;
                string caption = "Delete";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(this, message, caption, buttons);

                if (result == DialogResult.Yes)
                {
                    query.CommandText = "delete from Players where Name ='" + listBox1.Text + "'";
                    players = query.ExecuteReader();
                    players.Close();

                    initiate();
                }
            }
            else
            {
                MessageBox.Show("Please select the player you want to remove");
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
