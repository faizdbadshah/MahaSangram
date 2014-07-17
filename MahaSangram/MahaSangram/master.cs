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
            this.Size = new Size(800, 600);
            connection.Open();
            query.Connection = connection;
        }

        private void master_Load(object sender, EventArgs e)
        {
            functions.center_panel(panel_form1, this, 152, 197);
            functions.center_panel(panel2, this, 597, 275);
            functions.center_panel(panel3, this, 840, 282);
            functions.center_panel(metroPanel1, this, 803, 503);
        }

        private void newmatch_button_form1_Click(object sender, EventArgs e)
        {

            panel_form1.Visible = false;
            load_teams("newmatch");
            listBox1.SelectedIndex = 0;
            panel2.Visible = true;
        }

        private void statistics_button_form1_Click(object sender, EventArgs e)
        {

        }

        private void addteam_button_form1_Click(object sender, EventArgs e)
        {
            panel_form1.Visible = false;
            load_teams("addteam");
            metroPanel1.Visible = true;
        }

        private void quit_button_form1_Click(object sender, EventArgs e)
        {
            functions.closeapp(this, this, connection);
        }



        private void load_teams(string usefor)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            query.CommandText = "select * from teams";
            teams = query.ExecuteReader();
            if (teams.HasRows)
            {
                try
                {
                    if (usefor == "newmatch")
                    {
                        while (teams.Read())
                        {
                            listBox1.Items.Add(teams[1].ToString());
                            listBox2.Items.Add(teams[1].ToString());
                        }
                    }
                    else if (usefor == "addteam")
                    {
                        while (teams.Read())
                        {
                            listBox3.Items.Add(teams[1].ToString());
                        }
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


        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(year.Text))
                teamname_textbox.Text = branch.Text;
            else
                teamname_textbox.Text = branch.Text + " - " + year.Text + " Year";
        }

        private void Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(branch.Text))
                teamname_textbox.Text = year.Text + " Year";
            else
                teamname_textbox.Text = branch.Text + " - " + year.Text + " Year";

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
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
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
        }// Movable form end

        //shadow
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84) //WM_NCHITTEST = 0x84
            {
                int x = m.LParam.ToInt32() & 0xffff;
                int y = m.LParam.ToInt32() >> 16;
                int codex, codey;
                Point p = PointToClient(new Point(x, y));
                codey = p.Y < 5 ? 2 : p.Y > ClientSize.Height - 5 ? 1 : 0;
                codex = p.X < 5 ? 2 : p.X > ClientSize.Width - 5 ? 1 : 0;
                switch (codex + (codey << 2))
                {
                    case 10://Top-Left
                        m.Result = (IntPtr)13;
                        return;
                    case 8://Top
                        m.Result = (IntPtr)12;
                        return;
                    case 9://Top-Right
                        m.Result = (IntPtr)14;
                        return;
                    case 2://Left
                        m.Result = (IntPtr)10;
                        return;
                    case 1://Right
                        m.Result = (IntPtr)11;
                        return;
                    case 6://Bottom-Left
                        m.Result = (IntPtr)16;
                        return;
                    case 4://Bottom
                        m.Result = (IntPtr)15;
                        return;
                    case 5://Bottom-Right;
                        m.Result = (IntPtr)17;
                        return;
                }
            }
            base.WndProc(ref m);
        }

        private void metroToolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            teamname_textbox.Text = "";
            if (metroToggle1.Checked)
            {
                teamname_textbox.Enabled = true;
                branch.Enabled = false;
                year.Enabled = false;
            }
            else if (!(metroToggle1.Checked))
            {
                teamname_textbox.Enabled = false;
                branch.Enabled = true;
                year.Enabled = true;
            }
        }//shadow


    }
}
