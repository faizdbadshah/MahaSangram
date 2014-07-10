using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MahaSangram
{
    public partial class Form2 : Form
    {   
        private SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Faraz Siddiqui\Documents\GitHub\MahaSangram\MahaSangram\MahaSangram\MSDatabase.mdf;Integrated Security=True;User Instance=True");
        private SqlCommand query = new SqlCommand();
        private SqlDataReader data;
        
        public Form2()
        {   
            InitializeComponent();
            load_teams();
        }

        private void load_teams() {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            connection.Open();
            query.Connection = connection;
            query.CommandText = "select * from teams";
            data = query.ExecuteReader();
            if(data.HasRows){
                while(data.Read()){
                    listBox1.Items.Add(data[1].ToString());
                    listBox2.Items.Add(data[1].ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.getteamname1 = listBox1.Text; // defined in form3
            f3.getteamname2 = listBox2.Text;
            f3.Show();
            this.Hide();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            functions.closeapp(e);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox1.SelectedItem);
        }
    }
}
