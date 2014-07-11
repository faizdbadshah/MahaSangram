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
    public partial class Form1 : Form
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Faraz Siddiqui\Documents\GitHub\MahaSangram\MahaSangram\MahaSangram\MSDatabase.mdf;Integrated Security=True;User Instance=True");
        private SqlCommand query = new SqlCommand();
        private SqlDataReader data;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            functions.center_panel(panel_form1, this);
            functions.center_panel(panel2, this);
            functions.center_panel(panel3, this);
        }

        // Form1 or panel1 components defination
        private void newmatch_button_form1_click(object sender, EventArgs e)
        {
            panel_form1.Visible = false;
            load_teams();
            listBox1.SelectedIndex = 0;
            panel2.Visible = true;
            /*Form2 f2 = new Form2();
            this.Hide();
            f2.Show();*/
        }

        private void statistics_button_form1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void addteam_button_form1_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Show();
            this.Hide();
        }

        private void quit_button_form1_Click(object sender, EventArgs e)
        {
            functions.closeapp();
        }

        private void load_teams()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            connection.Open();
            query.Connection = connection;
            query.CommandText = "select * from teams";
            data = query.ExecuteReader();
            if (data.HasRows)
            {
                while (data.Read())
                {
                    listBox1.Items.Add(data[1].ToString());
                    listBox2.Items.Add(data[1].ToString());
                }
            }
        }

        // Form2 or panel2 components defination
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

        

        private void button6_Click(object sender, EventArgs e)
        {
            string team1 = listBox1.Text;
            string team2 = listBox2.Text;
            if (team1.Length != 0 && team2.Length != 0)
            {
                panel2.Visible = false;
                panel3.Visible = true;
                label6.Text = "Select Playing 11 of " + team1;
                label5.Text = "Select Playing 11 of " + team2;
            }
            else MessageBox.Show("Select both the team first!");
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            functions.closeapp(e);
        }

        

    }
}
