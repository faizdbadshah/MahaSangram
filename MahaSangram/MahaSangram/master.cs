using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace MahaSangram
{
    
    public partial class master : Form
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Faraz Siddiqui\Documents\GitHub\MahaSangram\MahaSangram\MahaSangram\MSDatabase.mdf;Integrated Security=True;User Instance=True");
        private SqlCommand query = new SqlCommand();
        private SqlDataReader teams, players;
        
        public master()
        {
            InitializeComponent();
            connection.Open();
            query.Connection = connection;
        }

        private void master_Load(object sender, EventArgs e)
        {
            functions.center_panel(panel_form1, this, 152, 197);
            functions.center_panel(panel2, this, 597, 275);
            functions.center_panel(panel3, this, 844, 279);
        }

        private void newmatch_button_form1_Click(object sender, EventArgs e)
        {
            
            panel_form1.Visible = false;
            load_teams();
            listBox1.SelectedIndex = 0;
            panel2.Visible = true;
        }

        private void statistics_button_form1_Click(object sender, EventArgs e)
        {

        }

        private void addteam_button_form1_Click(object sender, EventArgs e)
        {

        }

        private void quit_button_form1_Click(object sender, EventArgs e)
        {
            functions.closeapp(this, this, connection);
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
            else
            {
                dynamic close = MetroFramework.MetroMessageBox.Show(this, "Select both the team first!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void back_button_form3_Click(object sender, EventArgs e)
        {
            functions.back_panel(panel3, panel2);
        }
        
        // Default functions
        
        public virtual void exit_Click(object sender, EventArgs e)
        {
            functions.closeapp(this, this);
        }

        public virtual void minimize_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized)
                WindowState = FormWindowState.Minimized;
        }

        public virtual void restore_down_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized){
                WindowState = FormWindowState.Normal;
                this.Size = new Size(800, 600);
            }
                
            else if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
        }

        private void master_FormClosing(object sender, FormClosingEventArgs e)
        {
            functions.closeapp(this, this, e, connection);
        }

        //Movable Form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void master_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        } // Movable form end
    }
}
