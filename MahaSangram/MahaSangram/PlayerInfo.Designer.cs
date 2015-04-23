namespace MahaSangram
{
    partial class PlayerInfo
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
            this.button1 = new System.Windows.Forms.Button();
            this.PlayerInfoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayerName
            // 
            this.PlayerName.Location = new System.Drawing.Point(310, 193);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(267, 20);
            this.PlayerName.TabIndex = 0;
            this.PlayerName.Text = "Name of Player-";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(310, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // PlayerInfoBack
            // 
            this.PlayerInfoBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.PlayerInfoBack.ForeColor = System.Drawing.Color.White;
            this.PlayerInfoBack.Location = new System.Drawing.Point(465, 275);
            this.PlayerInfoBack.Name = "PlayerInfoBack";
            this.PlayerInfoBack.Size = new System.Drawing.Size(112, 47);
            this.PlayerInfoBack.TabIndex = 4;
            this.PlayerInfoBack.Text = "Back";
            this.PlayerInfoBack.UseVisualStyleBackColor = false;
            // 
            // PlayerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PlayerInfoBack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PlayerName);
            this.Name = "PlayerInfo";
            this.Size = new System.Drawing.Size(938, 561);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PlayerName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PlayerInfoBack;
    }
}
