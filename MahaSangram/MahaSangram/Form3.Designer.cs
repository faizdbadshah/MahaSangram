namespace MahaSangram
{
    partial class Form3
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.teamname1 = new System.Windows.Forms.Label();
            this.teamname2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "database se sare players ke nam aaenge team 1 ke aur usmese 11 select karne honge" +
                ""});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 236);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(443, 94);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "database se sare players ke nam aaenge team 2 ke aur usmese 11 select karne honge" +
                ""});
            this.checkedListBox2.Location = new System.Drawing.Point(487, 236);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(456, 94);
            this.checkedListBox2.TabIndex = 1;
            // 
            // teamname1
            // 
            this.teamname1.AutoSize = true;
            this.teamname1.Location = new System.Drawing.Point(194, 154);
            this.teamname1.Name = "teamname1";
            this.teamname1.Size = new System.Drawing.Size(140, 13);
            this.teamname1.TabIndex = 2;
            this.teamname1.Text = "Select Playing 11 of Team 1";
            // 
            // teamname2
            // 
            this.teamname2.AutoSize = true;
            this.teamname2.Location = new System.Drawing.Point(608, 154);
            this.teamname2.Name = "teamname2";
            this.teamname2.Size = new System.Drawing.Size(140, 13);
            this.teamname2.TabIndex = 3;
            this.teamname2.Text = "Select Playing 11 of Team 2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 463);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.teamname2);
            this.Controls.Add(this.teamname1);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Label teamname1;
        private System.Windows.Forms.Label teamname2;
        private System.Windows.Forms.Button button1;
    }
}