namespace MahaSangram
{
    partial class Addplayerbutton
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
            this.AddNewPlayer = new System.Windows.Forms.Button();
            this.RemovePlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(63, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(539, 329);
            this.listBox1.TabIndex = 0;
            // 
            // AddNewPlayer
            // 
            this.AddNewPlayer.Location = new System.Drawing.Point(185, 390);
            this.AddNewPlayer.Name = "AddNewPlayer";
            this.AddNewPlayer.Size = new System.Drawing.Size(119, 48);
            this.AddNewPlayer.TabIndex = 1;
            this.AddNewPlayer.Text = "Add";
            this.AddNewPlayer.UseVisualStyleBackColor = true;
            // 
            // RemovePlayer
            // 
            this.RemovePlayer.Location = new System.Drawing.Point(362, 390);
            this.RemovePlayer.Name = "RemovePlayer";
            this.RemovePlayer.Size = new System.Drawing.Size(119, 48);
            this.RemovePlayer.TabIndex = 3;
            this.RemovePlayer.Text = "Remove";
            this.RemovePlayer.UseVisualStyleBackColor = true;
            // 
            // Addplayerbutton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RemovePlayer);
            this.Controls.Add(this.AddNewPlayer);
            this.Controls.Add(this.listBox1);
            this.Name = "Addplayerbutton";
            this.Size = new System.Drawing.Size(734, 513);
            this.Load += new System.EventHandler(this.Addplayerbutton_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button AddNewPlayer;
        private System.Windows.Forms.Button RemovePlayer;
    }
}
