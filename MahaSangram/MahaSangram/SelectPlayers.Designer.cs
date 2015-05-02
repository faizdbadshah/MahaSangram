namespace MahaSangram
{
    partial class SelectPlayers
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
            this.Skip = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SelectPlayersBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Skip
            // 
            this.Skip.BackColor = System.Drawing.Color.GreenYellow;
            this.Skip.ForeColor = System.Drawing.Color.Black;
            this.Skip.Location = new System.Drawing.Point(428, 411);
            this.Skip.Name = "Skip";
            this.Skip.Size = new System.Drawing.Size(75, 39);
            this.Skip.TabIndex = 19;
            this.Skip.Text = "Skip";
            this.Skip.UseVisualStyleBackColor = false;
            this.Skip.Click += new System.EventHandler(this.Skip_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(505, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Select Playing 11 of Team 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(103, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Select Playing 11 of Team 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.ForeColor = System.Drawing.Color.White;
            this.Next.Location = new System.Drawing.Point(294, 335);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(149, 44);
            this.Next.TabIndex = 15;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.checkedListBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "database se sare players ke nam aaenge team 2 ke aur usmese 11 select karne honge" +
                ""});
            this.checkedListBox2.Location = new System.Drawing.Point(495, 155);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(365, 156);
            this.checkedListBox2.TabIndex = 14;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "database se sare players ke nam aaenge team 1 ke aur usmese 11 select karne honge" +
                ""});
            this.checkedListBox1.Location = new System.Drawing.Point(78, 155);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(365, 156);
            this.checkedListBox1.TabIndex = 16;
            // 
            // SelectPlayersBack
            // 
            this.SelectPlayersBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SelectPlayersBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectPlayersBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectPlayersBack.ForeColor = System.Drawing.Color.White;
            this.SelectPlayersBack.Location = new System.Drawing.Point(495, 335);
            this.SelectPlayersBack.Name = "SelectPlayersBack";
            this.SelectPlayersBack.Size = new System.Drawing.Size(149, 44);
            this.SelectPlayersBack.TabIndex = 20;
            this.SelectPlayersBack.Text = "Back";
            this.SelectPlayersBack.UseVisualStyleBackColor = false;
            this.SelectPlayersBack.Click += new System.EventHandler(this.SelectPlayersBack_Click);
            // 
            // SelectPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SelectPlayersBack);
            this.Controls.Add(this.Skip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "SelectPlayers";
            this.Size = new System.Drawing.Size(938, 532);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Skip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button SelectPlayersBack;
    }
}
