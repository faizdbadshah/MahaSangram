using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace MahaSangram
{
    public partial class Form3 : MetroForm
    {
        private string team1, team2;

        public string getteamname1 
        {
            get { return team1; }
            set { team1 = value; }
        }

        public string getteamname2
        {
            get { return team2; }
            set { team2 = value; }
        }

        public Form3()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            this.Close();
            f.Show();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            teamname1.Text = "Select Playing 11 of " + team1;
            teamname2.Text = "Select Playing 11 of " + team2;
        }

    }
}
