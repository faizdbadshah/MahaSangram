namespace MahaSangram
{
    partial class Newteam
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
            this.Addt = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Addp = new System.Windows.Forms.Button();
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
            // Addt
            // 
            this.Addt.Location = new System.Drawing.Point(184, 387);
            this.Addt.Name = "Addt";
            this.Addt.Size = new System.Drawing.Size(132, 58);
            this.Addt.TabIndex = 1;
            this.Addt.Text = "Add Team";
            this.Addt.UseVisualStyleBackColor = true;
            this.Addt.Click += new System.EventHandler(this.Addt_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(387, 388);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(132, 58);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete Team";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Addp
            // 
            this.Addp.Location = new System.Drawing.Point(588, 388);
            this.Addp.Name = "Addp";
            this.Addp.Size = new System.Drawing.Size(132, 58);
            this.Addp.TabIndex = 3;
            this.Addp.Text = "Add Player";
            this.Addp.UseVisualStyleBackColor = true;
            this.Addp.Click += new System.EventHandler(this.Addp_Click);
            // 
            // Newteam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Addp);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Addt);
            this.Controls.Add(this.listBox1);
            this.Name = "Newteam";
            this.Size = new System.Drawing.Size(933, 515);
            this.Load += new System.EventHandler(this.Newteam_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Addt;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Addp;
    }
}
