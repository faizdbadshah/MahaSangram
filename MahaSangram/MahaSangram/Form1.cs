using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using MetroFramework.Forms;

namespace MahaSangram
{
    public partial class Form1 : MetroForm
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Faraz Siddiqui\Documents\GitHub\MahaSangram\MahaSangram\MahaSangram\MSDatabase.mdf;Integrated Security=True;User Instance=True");
        private SqlCommand query = new SqlCommand();
        private SqlDataReader teams, players;

        public Form1()
        {
            InitializeComponent();
            connection.Open();
            query.Connection = connection;
            
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
            functions.closeapp(this);
        }

        private void load_teams()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            query.CommandText = "select * from teams";
            teams = query.ExecuteReader();
            if (teams.HasRows)
            {
                try
                {
                    while (teams.Read())
                    {
                        listBox1.Items.Add(teams[1].ToString());
                        listBox2.Items.Add(teams[1].ToString());
                    }
                }
                catch (Exception e)
                {
                    Console.Write(e);
                }
            }
            teams.Close();
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
                load_team_players(team1, checkedListBox1);
                load_team_players(team2, checkedListBox2);
            }
            else MessageBox.Show("Select both the team first!");
        }

        private void load_team_players(string team, CheckedListBox box)
        {
            box.Items.Clear();
            query.CommandText = "select Name from players where Team = '" + team + "'";
            players = query.ExecuteReader();
            if (players.HasRows)
            {
                try
                {
                    while (players.Read())
                    {
                        box.Items.Add(players[0].ToString());
                    }
                }
                catch (Exception e)
                {
                    Console.Write(e);
                }
            }
            players.Close();
        }

        private void back_button_form3_Click(object sender, EventArgs e)
        {
            functions.back_panel(panel3, panel2);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
            functions.closeapp(this, e);
        }
    }
}
