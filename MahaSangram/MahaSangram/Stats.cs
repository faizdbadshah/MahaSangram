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
    public partial class Stats : UserControl
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Github\MahaSangram\MahaSangram\MahaSangram\MSDatabase.mdf;Integrated Security=True;User Instance=True");
        private SqlCommand query = new SqlCommand();
        private SqlDataReader teams, Players;
        
        public Stats()
        {
            InitializeComponent();
            connection.Open();
            query.Connection = connection;
        }

       

        private void tStats_Click(object sender, EventArgs e)
        {
        
        }

        private void teamStats_Load(object sender, EventArgs e)
        {
            query.CommandText = "select * from teams";
            teams = query.ExecuteReader();
             //while(teams.Read())
            DataTable dt = new DataTable();
            dt.Load(teams);
            dataGridView1.DataSource = dt;

            query.CommandText = "select * from Players";
            Players = query.ExecuteReader();

            DataTable dt2 = new DataTable();
            dt2.Load(Players);
            dataGridView2.DataSource = dt2;

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

      
    }
}
