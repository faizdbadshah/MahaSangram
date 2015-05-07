namespace MahaSangram
{
    partial class AddTeam
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.submit = new System.Windows.Forms.Button();
            this.TeamName = new System.Windows.Forms.TextBox();
            this.TeamBranch = new System.Windows.Forms.TextBox();
            this.TeamYear = new System.Windows.Forms.TextBox();
            this.AddteambuttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.submit.ForeColor = System.Drawing.Color.White;
            this.submit.Location = new System.Drawing.Point(338, 327);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(118, 49);
            this.submit.TabIndex = 3;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // TeamName
            // 
            this.TeamName.Location = new System.Drawing.Point(338, 110);
            this.TeamName.Name = "TeamName";
            this.TeamName.Size = new System.Drawing.Size(274, 20);
            this.TeamName.TabIndex = 4;
            this.TeamName.Text = "Name of the team";
            this.TeamName.Click += new System.EventHandler(this.TeamName_Click);
            // 
            // TeamBranch
            // 
            this.TeamBranch.Location = new System.Drawing.Point(338, 249);
            this.TeamBranch.Name = "TeamBranch";
            this.TeamBranch.Size = new System.Drawing.Size(274, 20);
            this.TeamBranch.TabIndex = 5;
            this.TeamBranch.Text = "Branch";
            this.TeamBranch.Click += new System.EventHandler(this.TeamBranch_Click);
            // 
            // TeamYear
            // 
            this.TeamYear.Location = new System.Drawing.Point(338, 176);
            this.TeamYear.Name = "TeamYear";
            this.TeamYear.Size = new System.Drawing.Size(274, 20);
            this.TeamYear.TabIndex = 6;
            this.TeamYear.Text = "Year";
            this.TeamYear.Click += new System.EventHandler(this.TeamYear_Click);
            // 
            // AddteambuttonBack
            // 
            this.AddteambuttonBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AddteambuttonBack.ForeColor = System.Drawing.Color.White;
            this.AddteambuttonBack.Location = new System.Drawing.Point(494, 327);
            this.AddteambuttonBack.Name = "AddteambuttonBack";
            this.AddteambuttonBack.Size = new System.Drawing.Size(118, 49);
            this.AddteambuttonBack.TabIndex = 7;
            this.AddteambuttonBack.Text = "Back";
            this.AddteambuttonBack.UseVisualStyleBackColor = false;
            this.AddteambuttonBack.Click += new System.EventHandler(this.AddteambuttonBack_Click);
            // 
            // Addteambutton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddteambuttonBack);
            this.Controls.Add(this.TeamYear);
            this.Controls.Add(this.TeamBranch);
            this.Controls.Add(this.TeamName);
            this.Controls.Add(this.submit);
            this.Name = "Addteambutton";
            this.Size = new System.Drawing.Size(937, 562);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox TeamName;
        private System.Windows.Forms.TextBox TeamBranch;
        private System.Windows.Forms.TextBox TeamYear;
        private System.Windows.Forms.Button AddteambuttonBack;
    }
}
