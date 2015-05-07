namespace MahaSangram
{
    partial class AddPlayer
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
            this.PlayerName = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.PlayerInfoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayerName
            // 
            this.PlayerName.Location = new System.Drawing.Point(354, 192);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(267, 20);
            this.PlayerName.TabIndex = 0;
            this.PlayerName.Text = "Name of Player";
            this.PlayerName.Click += new System.EventHandler(this.PlayerName_Click);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Submit.ForeColor = System.Drawing.Color.White;
            this.Submit.Location = new System.Drawing.Point(329, 266);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(112, 47);
            this.Submit.TabIndex = 3;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // PlayerInfoBack
            // 
            this.PlayerInfoBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.PlayerInfoBack.ForeColor = System.Drawing.Color.White;
            this.PlayerInfoBack.Location = new System.Drawing.Point(539, 266);
            this.PlayerInfoBack.Name = "PlayerInfoBack";
            this.PlayerInfoBack.Size = new System.Drawing.Size(112, 47);
            this.PlayerInfoBack.TabIndex = 4;
            this.PlayerInfoBack.Text = "Back";
            this.PlayerInfoBack.UseVisualStyleBackColor = false;
            this.PlayerInfoBack.Click += new System.EventHandler(this.PlayerInfoBack_Click);
            // 
            // AddPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PlayerInfoBack);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.PlayerName);
            this.Name = "AddPlayer";
            this.Size = new System.Drawing.Size(949, 523);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PlayerName;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button PlayerInfoBack;
    }
}
