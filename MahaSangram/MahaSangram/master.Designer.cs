namespace MahaSangram
{
    partial class master
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(master));
            this.top = new System.Windows.Forms.Panel();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.restore_down = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.minimize = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.exit = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.footer = new System.Windows.Forms.Panel();
            this.main_panel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.back_button_form3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button6 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_form1 = new System.Windows.Forms.Panel();
            this.dump_label_form1 = new System.Windows.Forms.Label();
            this.quit_button_form1 = new System.Windows.Forms.Button();
            this.newmatch_button_form1 = new System.Windows.Forms.Button();
            this.addteam_button_form1 = new System.Windows.Forms.Button();
            this.statistics_button_form1 = new System.Windows.Forms.Button();
            this.top.SuspendLayout();
            this.main_panel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_form1.SuspendLayout();
            this.SuspendLayout();
            // 
            // top
            // 
            this.top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.top.Controls.Add(this.shapeContainer2);
            this.top.Location = new System.Drawing.Point(0, 0);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(1378, 39);
            this.top.TabIndex = 0;
            this.top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.master_MouseDown);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.restore_down,
            this.minimize,
            this.exit});
            this.shapeContainer2.Size = new System.Drawing.Size(1378, 39);
            this.shapeContainer2.TabIndex = 0;
            this.shapeContainer2.TabStop = false;
            // 
            // restore_down
            // 
            this.restore_down.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(208)))), ((int)(((byte)(42)))));
            this.restore_down.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.restore_down.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(187)))), ((int)(((byte)(85)))));
            this.restore_down.Location = new System.Drawing.Point(34, 10);
            this.restore_down.Name = "restore_down";
            this.restore_down.SelectionColor = System.Drawing.Color.Transparent;
            this.restore_down.Size = new System.Drawing.Size(13, 13);
            this.restore_down.Click += new System.EventHandler(this.restore_down_Click);
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(11)))));
            this.minimize.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.minimize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(179)))), ((int)(((byte)(13)))));
            this.minimize.Location = new System.Drawing.Point(53, 10);
            this.minimize.Name = "minimize";
            this.minimize.SelectionColor = System.Drawing.Color.Transparent;
            this.minimize.Size = new System.Drawing.Size(13, 13);
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(79)))));
            this.exit.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.exit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(84)))), ((int)(((byte)(76)))));
            this.exit.Location = new System.Drawing.Point(16, 10);
            this.exit.Name = "exit";
            this.exit.SelectionColor = System.Drawing.Color.Transparent;
            this.exit.Size = new System.Drawing.Size(13, 13);
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 712);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(1362, 28);
            this.footer.TabIndex = 2;
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.White;
            this.main_panel.Controls.Add(this.panel3);
            this.main_panel.Controls.Add(this.panel2);
            this.main_panel.Controls.Add(this.panel_form1);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(0, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1362, 740);
            this.main_panel.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.back_button_form3);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.checkedListBox2);
            this.panel3.Controls.Add(this.checkedListBox1);
            this.panel3.Location = new System.Drawing.Point(278, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(129, 132);
            this.panel3.TabIndex = 10;
            this.panel3.Visible = false;
            // 
            // back_button_form3
            // 
            this.back_button_form3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(213)))));
            this.back_button_form3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button_form3.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button_form3.ForeColor = System.Drawing.Color.White;
            this.back_button_form3.Location = new System.Drawing.Point(316, 235);
            this.back_button_form3.Name = "back_button_form3";
            this.back_button_form3.Size = new System.Drawing.Size(48, 44);
            this.back_button_form3.TabIndex = 13;
            this.back_button_form3.Text = "<";
            this.back_button_form3.UseVisualStyleBackColor = false;
            this.back_button_form3.Click += new System.EventHandler(this.back_button_form3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "form3";
            this.label7.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(213)))));
            this.label5.Location = new System.Drawing.Point(547, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Select Playing 11 of Team 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(213)))));
            this.label6.Location = new System.Drawing.Point(58, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Select Playing 11 of Team 1";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(213)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(379, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 44);
            this.button2.TabIndex = 10;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.checkedListBox2.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "database se sare players ke nam aaenge team 2 ke aur usmese 11 select karne honge" +
                ""});
            this.checkedListBox2.Location = new System.Drawing.Point(472, 104);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(365, 84);
            this.checkedListBox2.TabIndex = 6;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.checkedListBox1.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "database se sare players ke nam aaenge team 1 ke aur usmese 11 select karne honge" +
                ""});
            this.checkedListBox1.Location = new System.Drawing.Point(7, 104);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(365, 84);
            this.checkedListBox1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.listBox2);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(128, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 132);
            this.panel2.TabIndex = 6;
            this.panel2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "form2";
            this.label3.Visible = false;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 18;
            this.listBox2.Items.AddRange(new object[] {
            "Team 2"});
            this.listBox2.Location = new System.Drawing.Point(316, 83);
            this.listBox2.Margin = new System.Windows.Forms.Padding(5);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(270, 90);
            this.listBox2.TabIndex = 6;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(213)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(224, 231);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(149, 44);
            this.button6.TabIndex = 4;
            this.button6.Text = "Next";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Items.AddRange(new object[] {
            "Team 1"});
            this.listBox1.Location = new System.Drawing.Point(11, 83);
            this.listBox1.Margin = new System.Windows.Forms.Padding(5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(268, 90);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(213)))));
            this.label2.Location = new System.Drawing.Point(396, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Team 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(213)))));
            this.label1.Location = new System.Drawing.Point(76, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Team 1";
            // 
            // panel_form1
            // 
            this.panel_form1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_form1.BackColor = System.Drawing.Color.Transparent;
            this.panel_form1.Controls.Add(this.dump_label_form1);
            this.panel_form1.Controls.Add(this.quit_button_form1);
            this.panel_form1.Controls.Add(this.newmatch_button_form1);
            this.panel_form1.Controls.Add(this.addteam_button_form1);
            this.panel_form1.Controls.Add(this.statistics_button_form1);
            this.panel_form1.Location = new System.Drawing.Point(3, 49);
            this.panel_form1.Name = "panel_form1";
            this.panel_form1.Size = new System.Drawing.Size(116, 132);
            this.panel_form1.TabIndex = 5;
            // 
            // dump_label_form1
            // 
            this.dump_label_form1.AutoSize = true;
            this.dump_label_form1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dump_label_form1.Location = new System.Drawing.Point(27, 47);
            this.dump_label_form1.Name = "dump_label_form1";
            this.dump_label_form1.Size = new System.Drawing.Size(66, 25);
            this.dump_label_form1.TabIndex = 9;
            this.dump_label_form1.Text = "form1";
            this.dump_label_form1.Visible = false;
            // 
            // quit_button_form1
            // 
            this.quit_button_form1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(213)))));
            this.quit_button_form1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quit_button_form1.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit_button_form1.ForeColor = System.Drawing.Color.White;
            this.quit_button_form1.Location = new System.Drawing.Point(0, 150);
            this.quit_button_form1.Name = "quit_button_form1";
            this.quit_button_form1.Size = new System.Drawing.Size(149, 44);
            this.quit_button_form1.TabIndex = 2;
            this.quit_button_form1.Text = "Quit";
            this.quit_button_form1.UseVisualStyleBackColor = false;
            this.quit_button_form1.Click += new System.EventHandler(this.quit_button_form1_Click);
            // 
            // newmatch_button_form1
            // 
            this.newmatch_button_form1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(213)))));
            this.newmatch_button_form1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newmatch_button_form1.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newmatch_button_form1.ForeColor = System.Drawing.Color.White;
            this.newmatch_button_form1.Location = new System.Drawing.Point(0, 0);
            this.newmatch_button_form1.Name = "newmatch_button_form1";
            this.newmatch_button_form1.Size = new System.Drawing.Size(149, 44);
            this.newmatch_button_form1.TabIndex = 3;
            this.newmatch_button_form1.Text = "New Match";
            this.newmatch_button_form1.UseVisualStyleBackColor = false;
            this.newmatch_button_form1.Click += new System.EventHandler(this.newmatch_button_form1_Click);
            // 
            // addteam_button_form1
            // 
            this.addteam_button_form1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(213)))));
            this.addteam_button_form1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addteam_button_form1.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addteam_button_form1.ForeColor = System.Drawing.Color.White;
            this.addteam_button_form1.Location = new System.Drawing.Point(0, 100);
            this.addteam_button_form1.Name = "addteam_button_form1";
            this.addteam_button_form1.Size = new System.Drawing.Size(149, 44);
            this.addteam_button_form1.TabIndex = 3;
            this.addteam_button_form1.Text = "Add Team";
            this.addteam_button_form1.UseVisualStyleBackColor = false;
            this.addteam_button_form1.Click += new System.EventHandler(this.addteam_button_form1_Click);
            // 
            // statistics_button_form1
            // 
            this.statistics_button_form1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(213)))));
            this.statistics_button_form1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statistics_button_form1.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statistics_button_form1.ForeColor = System.Drawing.Color.White;
            this.statistics_button_form1.Location = new System.Drawing.Point(0, 50);
            this.statistics_button_form1.Name = "statistics_button_form1";
            this.statistics_button_form1.Size = new System.Drawing.Size(149, 44);
            this.statistics_button_form1.TabIndex = 1;
            this.statistics_button_form1.Text = "Statistics";
            this.statistics_button_form1.UseVisualStyleBackColor = false;
            this.statistics_button_form1.Click += new System.EventHandler(this.statistics_button_form1_Click);
            // 
            // master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1362, 740);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.top);
            this.Controls.Add(this.main_panel);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "master";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maha Sangram 2014";
            this.TransparencyKey = System.Drawing.Color.Lavender;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.master_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.master_MouseDown);
            this.top.ResumeLayout(false);
            this.main_panel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_form1.ResumeLayout(false);
            this.panel_form1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top;
        private Microsoft.VisualBasic.PowerPacks.OvalShape exit;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.OvalShape restore_down;
        private Microsoft.VisualBasic.PowerPacks.OvalShape minimize;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel panel_form1;
        private System.Windows.Forms.Button quit_button_form1;
        private System.Windows.Forms.Button newmatch_button_form1;
        private System.Windows.Forms.Button addteam_button_form1;
        private System.Windows.Forms.Button statistics_button_form1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dump_label_form1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button back_button_form3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}