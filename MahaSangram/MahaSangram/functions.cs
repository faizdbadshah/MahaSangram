using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using MetroFramework.Forms;
using System.Windows.Forms;
using MetroFramework.Drawing;

namespace MahaSangram
{
    static partial class functions
    {
        public static void closeapp(IWin32Window win, SqlConnection connection)
        {
            dynamic close = MetroFramework.MetroMessageBox.Show(win, "Are you sure you want to exit the application?", "Maha Sangram 2014", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (close == DialogResult.Yes)
            {
                connection.Close();
                Application.Exit();
            }
            else if (close == DialogResult.No)
            {
                //continue
            }
        } //end closeapp

        public static void closeapp(IWin32Window win, FormClosingEventArgs e, SqlConnection connection)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                dynamic close = MetroFramework.MetroMessageBox.Show(win, "Are you sure you want to exit the application?", "Maha Sangram 2014", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (close == DialogResult.Yes)
                {
                    connection.Close();
                    e.Cancel = false;
                    Application.Exit();
                }
                else if (close == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }

        } //end closeapp overloaded method for formclosing event

        public static void center_panel(Panel panel, Form form)
        {
            panel.Left = (form.ClientSize.Width - panel.Width) / 2;
            panel.Top = (form.ClientSize.Height - panel.Height) / 2;
            
        }

        public static void back_panel(Panel source, Panel destination) {
            source.Hide();
            destination.Show();
        }
        
        //fifth function here
    }
}
