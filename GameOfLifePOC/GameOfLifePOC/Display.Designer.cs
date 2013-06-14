namespace GameOfLifePOC
{
    partial class Display
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_Seed = new System.Windows.Forms.Button();
            this.bt_startTimer = new System.Windows.Forms.Button();
            this.bt_blank = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.nup_gridSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nup_cellSize = new System.Windows.Forms.NumericUpDown();
            this.lbl_generations = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_gridSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_cellSize)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // bt_Seed
            // 
            this.bt_Seed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Seed.Location = new System.Drawing.Point(432, 100);
            this.bt_Seed.Name = "bt_Seed";
            this.bt_Seed.Size = new System.Drawing.Size(108, 23);
            this.bt_Seed.TabIndex = 1;
            this.bt_Seed.Text = "Random Grid";
            this.bt_Seed.UseVisualStyleBackColor = true;
            this.bt_Seed.Click += new System.EventHandler(this.bt_Seed_Click);
            // 
            // bt_startTimer
            // 
            this.bt_startTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_startTimer.Location = new System.Drawing.Point(432, 387);
            this.bt_startTimer.Name = "bt_startTimer";
            this.bt_startTimer.Size = new System.Drawing.Size(108, 23);
            this.bt_startTimer.TabIndex = 2;
            this.bt_startTimer.Text = "Start Timer";
            this.bt_startTimer.UseVisualStyleBackColor = true;
            this.bt_startTimer.Click += new System.EventHandler(this.bt_startTimer_Click);
            // 
            // bt_blank
            // 
            this.bt_blank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_blank.Location = new System.Drawing.Point(432, 129);
            this.bt_blank.Name = "bt_blank";
            this.bt_blank.Size = new System.Drawing.Size(108, 23);
            this.bt_blank.TabIndex = 3;
            this.bt_blank.Text = "Blank Grig";
            this.bt_blank.UseVisualStyleBackColor = true;
            this.bt_blank.Click += new System.EventHandler(this.bt_blank_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.LargeChange = 100;
            this.trackBar1.Location = new System.Drawing.Point(431, 336);
            this.trackBar1.Maximum = 500;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(108, 45);
            this.trackBar1.SmallChange = 50;
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Value = 1;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Speed [ fast--> slow ]";
            // 
            // nup_gridSize
            // 
            this.nup_gridSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nup_gridSize.Location = new System.Drawing.Point(434, 74);
            this.nup_gridSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nup_gridSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nup_gridSize.Name = "nup_gridSize";
            this.nup_gridSize.Size = new System.Drawing.Size(105, 20);
            this.nup_gridSize.TabIndex = 7;
            this.nup_gridSize.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Grid Size";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cell Size";
            // 
            // nup_cellSize
            // 
            this.nup_cellSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nup_cellSize.Location = new System.Drawing.Point(434, 29);
            this.nup_cellSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nup_cellSize.Name = "nup_cellSize";
            this.nup_cellSize.Size = new System.Drawing.Size(105, 20);
            this.nup_cellSize.TabIndex = 9;
            this.nup_cellSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lbl_generations
            // 
            this.lbl_generations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_generations.AutoSize = true;
            this.lbl_generations.Location = new System.Drawing.Point(432, 155);
            this.lbl_generations.Name = "lbl_generations";
            this.lbl_generations.Size = new System.Drawing.Size(76, 13);
            this.lbl_generations.TabIndex = 11;
            this.lbl_generations.Text = "Generations: 0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Click in grid to invert value of a cell";
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 442);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_generations);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nup_cellSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nup_gridSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.bt_blank);
            this.Controls.Add(this.bt_startTimer);
            this.Controls.Add(this.bt_Seed);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(568, 480);
            this.Name = "Display";
            this.Text = "Conways Game Of Life";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Display_FormClosing);
            this.Load += new System.EventHandler(this.Display_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_gridSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_cellSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_Seed;
        private System.Windows.Forms.Button bt_startTimer;
        private System.Windows.Forms.Button bt_blank;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nup_gridSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nup_cellSize;
        private System.Windows.Forms.Label lbl_generations;
        private System.Windows.Forms.Label label4;
    }
}