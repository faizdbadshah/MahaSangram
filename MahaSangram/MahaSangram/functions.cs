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
        static Panel global_destination;
        public static List<Panel> panels = new List<Panel>();
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

        public static void back_panel()
        {
            if (panels.Count != 0) {
               Panel last = panels.Last();
               panels.Remove(last);
               global_destination.Visible = false;
               last.Visible = true;
            }
            
        }

        public static void change_panel(Panel source_panel, Panel destination_panel)
        {
            global_destination = destination_panel;
            panels.Add(source_panel);
            source_panel.Visible = false;
            destination_panel.Visible = true;
        }
       
        //next function here
    }
}
