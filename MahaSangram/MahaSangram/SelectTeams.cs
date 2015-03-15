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
        private SqlDataReader teams, players;
        public SelectTeams()
        {
            InitializeComponent();
        }


        private void SelectTeams_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            query.CommandText = "select * from teams";
            teams = query.ExecuteReader();
            listBox1.Items.Add(teams[1].ToString());
            listBox2.Items.Add(teams[1].ToString());
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
          //  string team1 = listBox1.Text;
          //  string team2 = listBox2.Text;
          //  if (team1.Length != 0 && team2.Length != 0)
          //  {
          //      functions.change_panel(panel2, panel3);
          //      label6.Text = "Select Playing 11 of \n" + team1;
          //      label5.Text = "Select Playing 11 of \n" + team2;
          //      load_team_players(team1, checkedListBox1);
          //      load_team_players(team2, checkedListBox2);
          //  }
          //  else
          //  {
          //      dynamic close = MetroFramework.MetroMessageBox.Show(this, "Select both the team first!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          //  }
        }

        
    }
}
