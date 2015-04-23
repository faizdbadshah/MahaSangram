using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MahaSangram
{
    public partial class PlayerInfo : UserControl
    {
        public PlayerInfo()
        {
            InitializeComponent();
            PlayerInfoBack.Click += new EventHandler(PlayerInfoBack_Click);
        }
        public void PlayerInfoBackclicklistner(EventHandler handler)
        {
            this.PlayerInfoBack.Click += handler;
        }
        
        private void PlayerInfoBack_Click(object sender, EventArgs e)
        {

        }
        private void PlayerYear_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
