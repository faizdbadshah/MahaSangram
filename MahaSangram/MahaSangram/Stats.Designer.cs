namespace MahaSangram
{
    partial class Stats
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tStats = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pStats = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.mStats = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.StatsBack = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.mStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tStats);
            this.tabControl1.Controls.Add(this.pStats);
            this.tabControl1.Controls.Add(this.mStats);
            this.tabControl1.Location = new System.Drawing.Point(19, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(920, 435);
            this.tabControl1.TabIndex = 0;
            // 
            // tStats
            // 
            this.tStats.Controls.Add(this.dataGridView1);
            this.tStats.Location = new System.Drawing.Point(4, 22);
            this.tStats.Name = "tStats";
            this.tStats.Padding = new System.Windows.Forms.Padding(3);
            this.tStats.Size = new System.Drawing.Size(912, 392);
            this.tStats.TabIndex = 0;
            this.tStats.Text = "Team Stats";
            this.tStats.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(809, 339);
            this.dataGridView1.TabIndex = 1;
            // 
            // pStats
            // 
            this.pStats.Controls.Add(this.dataGridView2);
            this.pStats.Location = new System.Drawing.Point(4, 22);
            this.pStats.Name = "pStats";
            this.pStats.Padding = new System.Windows.Forms.Padding(3);
            this.pStats.Size = new System.Drawing.Size(912, 409);
            this.pStats.TabIndex = 1;
            this.pStats.Text = "Player Stats";
            this.pStats.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(38, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(809, 335);
            this.dataGridView2.TabIndex = 0;
            // 
            // mStats
            // 
            this.mStats.Controls.Add(this.dataGridView3);
            this.mStats.Location = new System.Drawing.Point(4, 22);
            this.mStats.Name = "mStats";
            this.mStats.Size = new System.Drawing.Size(912, 489);
            this.mStats.TabIndex = 2;
            this.mStats.Text = "Match Stats";
            this.mStats.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(37, 27);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(809, 349);
            this.dataGridView3.TabIndex = 0;
            // 
            // StatsBack
            // 
            this.StatsBack.Location = new System.Drawing.Point(407, 452);
            this.StatsBack.Name = "StatsBack";
            this.StatsBack.Size = new System.Drawing.Size(146, 23);
            this.StatsBack.TabIndex = 3;
            this.StatsBack.Text = "Back";
            this.StatsBack.UseVisualStyleBackColor = true;
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StatsBack);
            this.Controls.Add(this.tabControl1);
            this.Name = "Stats";
            this.Size = new System.Drawing.Size(942, 532);
            this.tabControl1.ResumeLayout(false);
            this.tStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.mStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tStats;
        private System.Windows.Forms.TabPage pStats;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage mStats;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button StatsBack;


    }
}
