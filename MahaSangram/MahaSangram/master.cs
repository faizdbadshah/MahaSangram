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
        private SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Chaitanya\Desktop\MahaSangram\MahaSangram\MahaSangram\MSDatabase.mdf;Integrated Security=True;User Instance=True");
        private SqlCommand query = new SqlCommand();
        private SqlDataReader teams, players;

        int a, b, c, d, i;
        int[] record = new int[150];

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
            functions.center_panel(metroPanel3, this, 1356, 686);
        }

        private void newmatch_button_form1_Click(object sender, EventArgs e)
        {

            load_teams("newmatch");
            listBox1.SelectedIndex = 0;
            functions.change_panel(panel_form1, panel2);
        }

        private void statistics_button_form1_Click(object sender, EventArgs e)
        {

        }

        private void addteam_button_form1_Click(object sender, EventArgs e)
        {
            load_teams("addteam");
            functions.change_panel(panel_form1, metroPanel1);
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
                        metroPanel2.Controls.Clear();
                        int location = 0;
                        while (teams.Read())
                        {
                            MetroFramework.Controls.MetroTile team = new MetroFramework.Controls.MetroTile();
                            team.ActiveControl = null;
                            team.Parent = metroPanel2;
                            team.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
                            team.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
                            team.Location = new System.Drawing.Point(0, location);
                            team.Size = new System.Drawing.Size(360, 44);
                            team.Name = teams[1].ToString();
                            team.Text = teams[1].ToString();
                            team.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                            team.TileImage = global::MahaSangram.Properties.Resources.player_icon_small;
                            team.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                            team.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
                            team.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
                            team.UseCustomBackColor = true;
                            team.UseCustomForeColor = true;
                            team.UseSelectable = true;
                            team.UseTileImage = true;
                            Application.DoEvents();
                            metroPanel2.Controls.Add(team);
                            location += 46;
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
                functions.change_panel(panel2, panel3);
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
            functions.back_panel();
        }


        private void course_branch_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string course_name = (string.IsNullOrEmpty(course.Text)) ? "" : course.Text;
            string branch_name = (string.IsNullOrEmpty(branch.Text)) ? "" : (string.IsNullOrEmpty(course.Text)) ? branch.Text : " - " + branch.Text;
            string year_name = (string.IsNullOrEmpty(year.Text)) ? "" : (string.IsNullOrEmpty(branch.Text) & string.IsNullOrEmpty(course.Text)) ? year.Text + " Year" : " - " + year.Text + " Year";
            teamname_textbox.Text = course_name + branch_name + year_name;
        }
        
       private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            teamname_textbox.Text = "";
            if (metroToggle1.Checked)
            {
                teamname_textbox.Enabled = true;
                course.Enabled = false;
                branch.Enabled = false;
                year.Enabled = false;
            }
            else if (!(metroToggle1.Checked))
            {
                teamname_textbox.Enabled = false;
                course.Enabled = true;
                branch.Enabled = true;
                year.Enabled = true;
            }
        }

       private void submit_addteam_Click(object sender, EventArgs e)
       {

           if (!(metroToggle1.Checked))
           {
               if (string.IsNullOrEmpty(course.Text) | string.IsNullOrEmpty(branch.Text) | string.IsNullOrEmpty(year.Text))
               {
                   MessageBox.Show("Select Course, Branch & Year.");
               }
               else
               {
                   //insert team into database
                   MessageBox.Show("Team Name : " + teamname_textbox.Text);
               }
           }
           else if (metroToggle1.Checked)
           {
               //insert team into database
               MessageBox.Show("Team Name : " + teamname_textbox.Text);
           }
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

        private void main_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroPanel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void metroRadioButton11_CheckedChanged(object sender, EventArgs e)  // Dot
        {
            if (metroRadioButton11.Checked == true)
            {
                button1.Enabled = true;
                metroRadioButton6.Enabled = true;
                metroRadioButton7.Enabled = true;
                metroRadioButton10.Enabled = true;
                metroRadioButton12.Enabled = true;
                metroRadioButton13.Enabled = true;
                metroRadioButton14.Enabled = true;
                metroRadioButton15.Enabled = true;
                metroRadioButton16.Enabled = true;
                metroRadioButton8.Enabled = false;
                metroRadioButton9.Enabled = false;
                metroRadioButton8.Checked = false;
                metroRadioButton9.Checked = false;
            }
        }

        
        private void metroRadioButton4_CheckedChanged(object sender, EventArgs e)  // 1 run
        {
            if (metroRadioButton4.Checked == true)
            {
                button1.Enabled = true;
                metroRadioButton6.Enabled = true;
                metroRadioButton7.Enabled = true;
                metroRadioButton8.Enabled = true;
                metroRadioButton9.Enabled = true;
                metroRadioButton14.Enabled = true;
                metroRadioButton16.Enabled = true;
                metroRadioButton10.Enabled = false;
                metroRadioButton12.Enabled = false;
                metroRadioButton13.Enabled = false;
                metroRadioButton15.Enabled = false;
                metroRadioButton10.Checked = false;
                metroRadioButton12.Checked = false;
                metroRadioButton13.Checked = false;
                metroRadioButton15.Checked = false;
            }
        }

        private void metroRadioButton5_CheckedChanged(object sender, EventArgs e)  // 2 runs
        {
            if (metroRadioButton5.Checked == true)
            {
                button1.Enabled = true;
                metroRadioButton6.Enabled = true;
                metroRadioButton7.Enabled = true;
                metroRadioButton8.Enabled = true;
                metroRadioButton9.Enabled = true;
                metroRadioButton14.Enabled = true;
                metroRadioButton16.Enabled = true;
                metroRadioButton10.Enabled = false;
                metroRadioButton12.Enabled = false;
                metroRadioButton13.Enabled = false;
                metroRadioButton15.Enabled = false;
                metroRadioButton10.Checked = false;
                metroRadioButton12.Checked = false;
                metroRadioButton13.Checked = false;
                metroRadioButton15.Checked = false;
            }
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)  // 3 runs
        {
            if (metroRadioButton2.Checked == true)
            {
                button1.Enabled = true;
                metroRadioButton6.Enabled = true;
                metroRadioButton7.Enabled = true;
                metroRadioButton8.Enabled = true;
                metroRadioButton9.Enabled = true;
                metroRadioButton14.Enabled = true;
                metroRadioButton16.Enabled = true;
                metroRadioButton10.Enabled = false;
                metroRadioButton12.Enabled = false;
                metroRadioButton13.Enabled = false;
                metroRadioButton15.Enabled = false;
                metroRadioButton10.Checked = false;
                metroRadioButton12.Checked = false;
                metroRadioButton13.Checked = false;
                metroRadioButton15.Checked = false;
            }
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)  // 4 runs
        {
            if (metroRadioButton1.Checked == true)
            {
                button1.Enabled = true;
                metroRadioButton6.Enabled = true;
                metroRadioButton7.Enabled = true;
                metroRadioButton8.Enabled = true;
                metroRadioButton9.Enabled = true;
                metroRadioButton16.Enabled = true;
                metroRadioButton10.Enabled = false;
                metroRadioButton12.Enabled = false;
                metroRadioButton13.Enabled = false;
                metroRadioButton14.Enabled = false;
                metroRadioButton15.Enabled = false;
                metroRadioButton10.Checked = false;
                metroRadioButton12.Checked = false;
                metroRadioButton13.Checked = false;
                metroRadioButton14.Checked = false;
                metroRadioButton15.Checked = false;
            }
        }

        private void metroRadioButton3_CheckedChanged(object sender, EventArgs e)   // 6 runs
        {
            if (metroRadioButton3.Checked == true)
            {
                button1.Enabled = true;
                metroRadioButton7.Enabled = true;
                metroRadioButton6.Enabled = false;
                metroRadioButton8.Enabled = false;
                metroRadioButton9.Enabled = false;
                metroRadioButton10.Enabled = false;
                metroRadioButton12.Enabled = false;
                metroRadioButton13.Enabled = false;
                metroRadioButton14.Enabled = false;
                metroRadioButton15.Enabled = false;
                metroRadioButton6.Checked = false;
                metroRadioButton8.Checked = false;
                metroRadioButton9.Checked = false;
                metroRadioButton10.Checked = false;
                metroRadioButton12.Checked = false;
                metroRadioButton13.Checked = false;
                metroRadioButton14.Checked = false;
                metroRadioButton15.Checked = false;
            }
        }

        private void metroRadioButton6_CheckedChanged(object sender, EventArgs e)  // wide ball
        {
            if (metroRadioButton6.Checked == true)
            {
                metroRadioButton13.Enabled = true;
                metroRadioButton14.Enabled = true;
                metroRadioButton15.Enabled = true;
                metroRadioButton16.Enabled = true;
                metroRadioButton10.Enabled = false;
                metroRadioButton12.Enabled = false;
                metroRadioButton10.Checked = false;
                metroRadioButton12.Checked = false;
            }
        }

        private void metroRadioButton7_CheckedChanged(object sender, EventArgs e)  // no ball
        {
            if (metroRadioButton7.Checked == true)
            {
                metroRadioButton14.Enabled = true;
                metroRadioButton16.Enabled = true; 
                metroRadioButton10.Enabled = false;
                metroRadioButton12.Enabled = false;
                metroRadioButton13.Enabled = false;
                metroRadioButton15.Enabled = false;
                metroRadioButton10.Checked = false;
                metroRadioButton12.Checked = false;
                metroRadioButton13.Checked = false;
                metroRadioButton15.Checked = false;
            }
        }

        private void metroRadioButton9_CheckedChanged(object sender, EventArgs e)  // Leg Bye
        {
            if (metroRadioButton9.Checked == true)
            {
                metroRadioButton14.Enabled = true;
                metroRadioButton16.Enabled = true; 
                metroRadioButton10.Enabled = false;
                metroRadioButton12.Enabled = false;
                metroRadioButton13.Enabled = false;
                metroRadioButton15.Enabled = false;
                metroRadioButton10.Checked = false;
                metroRadioButton12.Checked = false;
                metroRadioButton13.Checked = false;
                metroRadioButton15.Checked = false;
            }
        }

        private void metroRadioButton8_CheckedChanged(object sender, EventArgs e)   // Bye
        {
            if (metroRadioButton8.Checked == true)
            {
                metroRadioButton14.Enabled = true;
                metroRadioButton16.Enabled = true; 
                metroRadioButton10.Enabled = false;
                metroRadioButton12.Enabled = false;
                metroRadioButton13.Enabled = false;
                metroRadioButton15.Enabled = false;
                metroRadioButton10.Checked = false;
                metroRadioButton12.Checked = false;
                metroRadioButton13.Checked = false;
                metroRadioButton15.Checked = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            metroRadioButton1.Checked = false;
            metroRadioButton2.Checked = false;
            metroRadioButton3.Checked = false;
            metroRadioButton4.Checked = false;
            metroRadioButton5.Checked = false;
            metroRadioButton6.Checked = false;
            metroRadioButton7.Checked = false;
            metroRadioButton8.Checked = false;
            metroRadioButton9.Checked = false;
            metroRadioButton10.Checked = false;
            metroRadioButton11.Checked = false;
            metroRadioButton12.Checked = false;
            metroRadioButton13.Checked = false;
            metroRadioButton14.Checked = false;
            metroRadioButton15.Checked = false;
            metroRadioButton16.Checked = false;
        }   

        private void button1_Click(object sender, EventArgs e)
        {
            i = a = b = c = d = 0;
            if (metroRadioButton4.Checked == true)
                b = 1;
            else if (metroRadioButton5.Checked == true)
                b = 2;
            else if (metroRadioButton2.Checked == true)
                b = 3;
            else if (metroRadioButton1.Checked == true)
                b = 4;
            else if (metroRadioButton3.Checked == true)
                b = 6;

            if (metroRadioButton6.Checked == true)
                c = 1;
            else if (metroRadioButton7.Checked == true)
                c = 2;
            else if (metroRadioButton9.Checked == true)
                c = 3;
            else if (metroRadioButton8.Checked == true)
                c = 4;

            if (metroRadioButton12.Checked == true)
                d = 1;
            else if (metroRadioButton10.Checked == true)
                d = 2;
            else if (metroRadioButton14.Checked == true)
                d = 3;
            else if (metroRadioButton15.Checked == true)
                d = 4;
            else if (metroRadioButton13.Checked == true)
                d = 5;
            else if (metroRadioButton16.Checked == true)
                d = 6;


            a = (100 * b) + (10 * c) + d;

            record[i] = a;
            i++;
    
        }

       





        
    }
}
