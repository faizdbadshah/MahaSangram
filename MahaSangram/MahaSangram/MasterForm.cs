using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MahaSangram
{
    public partial class MasterForm : Form
    {
        Home H = new Home();
        SelectTeams ST = new SelectTeams();
        
        public MasterForm()
        {
            InitializeComponent();
            this.H.Matchclicklistner(new EventHandler(newmatch));
        }

       
        private void MasterForm_Load(object sender, EventArgs e)
        {
            H.Dock = DockStyle.Fill;
            this.Controls.Add(H);
        }


        private void newmatch(object sender, EventArgs e)
        {
            this.Controls.Remove(H);
            ST.Dock = DockStyle.Fill;
            this.Controls.Add(ST);
        }
        
        

       
    }
}
