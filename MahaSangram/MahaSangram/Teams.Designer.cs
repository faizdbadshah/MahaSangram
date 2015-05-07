namespace MahaSangram
{
    partial class Teams
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AddT = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.PlayersInfo = new System.Windows.Forms.Button();
            this.TeamsBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(154, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(592, 329);
            this.listBox1.TabIndex = 0;
            // 
            // AddT
            // 
            this.AddT.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AddT.ForeColor = System.Drawing.Color.White;
            this.AddT.Location = new System.Drawing.Point(154, 388);
            this.AddT.Name = "AddT";
            this.AddT.Size = new System.Drawing.Size(132, 58);
            this.AddT.TabIndex = 1;
            this.AddT.Text = "Add Team";
            this.AddT.UseVisualStyleBackColor = false;
            this.AddT.Click += new System.EventHandler(this.Addt_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(306, 388);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(132, 58);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete Team";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // PlayersInfo
            // 
            this.PlayersInfo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.PlayersInfo.ForeColor = System.Drawing.Color.White;
            this.PlayersInfo.Location = new System.Drawing.Point(458, 388);
            this.PlayersInfo.Name = "PlayersInfo";
            this.PlayersInfo.Size = new System.Drawing.Size(132, 58);
            this.PlayersInfo.TabIndex = 3;
            this.PlayersInfo.Text = "Players";
            this.PlayersInfo.UseVisualStyleBackColor = false;
            this.PlayersInfo.Click += new System.EventHandler(this.PlayersInfo_Click);
            // 
            // TeamsBack
            // 
            this.TeamsBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.TeamsBack.ForeColor = System.Drawing.Color.White;
            this.TeamsBack.Location = new System.Drawing.Point(614, 388);
            this.TeamsBack.Name = "TeamsBack";
            this.TeamsBack.Size = new System.Drawing.Size(132, 58);
            this.TeamsBack.TabIndex = 4;
            this.TeamsBack.Text = "Back";
            this.TeamsBack.UseVisualStyleBackColor = false;
            this.TeamsBack.Click += new System.EventHandler(this.TeamsBack_Click);
            // 
            // Teams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TeamsBack);
            this.Controls.Add(this.PlayersInfo);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.AddT);
            this.Controls.Add(this.listBox1);
            this.Name = "Teams";
            this.Size = new System.Drawing.Size(939, 557);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button AddT;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button PlayersInfo;
        private System.Windows.Forms.Button TeamsBack;
    }
}
