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
    public partial class Stats : UserControl
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
        private SqlCommand query = new SqlCommand();
        private SqlDataReader teams, Players, matches;
        
        public Stats()
        {
            InitializeComponent();
            connection.Open();
            query.Connection = connection;
        }

        private void Stats_Load(object sender, EventArgs e)
        {
            
        }
        public void StatsBackclicklistner(EventHandler handler)
        {
            this.StatsBack.Click += handler;
        }

        private void StatsBack_Click(object sender, EventArgs e)
        {

        }

        public void initiate()
        {
            query.CommandText = "select * from teams";
            teams = query.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(teams);
            dataGridView1.DataSource = dt;

            query.CommandText = "select * from Players";
            Players = query.ExecuteReader();

            DataTable dt2 = new DataTable();
            dt2.Load(Players);
            dataGridView2.DataSource = dt2;

            query.CommandText = "select * from matches";
            matches = query.ExecuteReader();

            DataTable dt3 = new DataTable();
            dt3.Load(matches);
            dataGridView3.DataSource = dt3;
        }
    }
}
