using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Data.SqlClient;
using MetroFramework.Forms;
using System.Windows.Forms;
using MetroFramework.Drawing;

namespace MahaSangram
{
    static partial class functions
    {
        public static void closeapp(Form form, IWin32Window win)
        {
            form.Opacity = 0.95;
            dynamic close = MetroFramework.MetroMessageBox.Show(win, "Are you sure you want to exit the application?", "Maha Sangram 2014", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (close == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (close == DialogResult.No)
            {
                form.Opacity = 1.0;
            }
        }

        public static void closeapp(Form form, IWin32Window win, SqlConnection connection)
        {
            form.Opacity = 0.95;
            dynamic close = MetroFramework.MetroMessageBox.Show(win, "Are you sure you want to exit the application?", "Maha Sangram 2014", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (close == DialogResult.Yes)
            {
                connection.Close();
                Application.Exit();
            }
            else if (close == DialogResult.No)
            {
                form.Opacity = 1.0;
            }
        } //end closeapp

        public static void closeapp(Form form, IWin32Window win, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                form.Opacity = 0.95;
                dynamic close = MetroFramework.MetroMessageBox.Show(win, "Are you sure you want to exit the application?", "Maha Sangram 2014", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (close == DialogResult.Yes)
                {
                    e.Cancel = false;
                    Application.Exit();
                }
                else if (close == DialogResult.No)
                {
                    form.Opacity = 1.0;
                    e.Cancel = true;
                }
            }

        }

        public static void closeapp(Form form, IWin32Window win, FormClosingEventArgs e, SqlConnection connection)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                form.Opacity = 0.95;
                dynamic close = MetroFramework.MetroMessageBox.Show(win, "Are you sure you want to exit the application?", "Maha Sangram 2014", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (close == DialogResult.Yes)
                {
                    connection.Close();
                    e.Cancel = false;
                    Application.Exit();
                }
                else if (close == DialogResult.No)
                {
                    form.Opacity = 1.0;
                    e.Cancel = true;
                }
            }

        } //end closeapp overloaded method for formclosing event

        public static void center_panel(Panel panel, Form form, int width, int height)
        {
            panel.Size = new Size(width, height);
            panel.Left = (form.ClientSize.Width - panel.Width) / 2;
            panel.Top = (form.ClientSize.Height - panel.Height) / 2;

        }

        public static void center_panel(Panel panel, UserControl UC)
        {
            panel.Left = (UC.ClientSize.Width - panel.Width) / 2;
            panel.Top = (UC.ClientSize.Height - panel.Height) / 2;

        }

        public static void back_panel(Panel source, Panel destination)
        {
            source.Hide();
            destination.Show();
        }

        //next function here
    }
}
