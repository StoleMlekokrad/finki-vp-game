namespace FlappyBird
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTextScore = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblHighScoreText = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picturePanel = new System.Windows.Forms.PictureBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelBest = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePanel)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTextScore
            // 
            this.lblTextScore.AutoSize = true;
            this.lblTextScore.BackColor = System.Drawing.Color.Transparent;
            this.lblTextScore.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTextScore.Location = new System.Drawing.Point(88, 29);
            this.lblTextScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTextScore.Name = "lblTextScore";
            this.lblTextScore.Size = new System.Drawing.Size(49, 14);
            this.lblTextScore.TabIndex = 2;
            this.lblTextScore.Text = "Score:";
            this.lblTextScore.Click += new System.EventHandler(this.lblTextScore_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblScore.Location = new System.Drawing.Point(140, 29);
            this.lblScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(14, 14);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "0";
            // 
            // timer2
            // 
            this.timer2.Interval = 2200;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblHighScoreText
            // 
            this.lblHighScoreText.AutoSize = true;
            this.lblHighScoreText.BackColor = System.Drawing.Color.Transparent;
            this.lblHighScoreText.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblHighScoreText.Location = new System.Drawing.Point(53, 50);
            this.lblHighScoreText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHighScoreText.Name = "lblHighScoreText";
            this.lblHighScoreText.Size = new System.Drawing.Size(84, 14);
            this.lblHighScoreText.TabIndex = 4;
            this.lblHighScoreText.Text = "High Score:";
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.BackColor = System.Drawing.Color.Transparent;
            this.lblHighScore.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblHighScore.Location = new System.Drawing.Point(140, 50);
            this.lblHighScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(14, 14);
            this.lblHighScore.TabIndex = 5;
            this.lblHighScore.Text = "0";
            // 
            // timer3
            // 
            this.timer3.Interval = 5;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.labelBest);
            this.panel1.Controls.Add(this.labelScore);
            this.panel1.Controls.Add(this.picturePanel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(23, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 250);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FlappyBird.Properties.Resources.GameOver;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pBox
            // 
            this.pBox.BackColor = System.Drawing.Color.Transparent;
            this.pBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pBox.ErrorImage = null;
            this.pBox.Image = global::FlappyBird.Properties.Resources.flappy;
            this.pBox.InitialImage = null;
            this.pBox.Location = new System.Drawing.Point(11, 190);
            this.pBox.Margin = new System.Windows.Forms.Padding(2);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(28, 32);
            this.pBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox.TabIndex = 1;
            this.pBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Lucida Console", 8.25F);
            this.button1.Image = global::FlappyBird.Properties.Resources.flappyButton;
            this.button1.Location = new System.Drawing.Point(82, 350);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 56);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // picturePanel
            // 
            this.picturePanel.Image = global::FlappyBird.Properties.Resources.panel;
            this.picturePanel.Location = new System.Drawing.Point(0, 59);
            this.picturePanel.Name = "picturePanel";
            this.picturePanel.Size = new System.Drawing.Size(221, 167);
            this.picturePanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePanel.TabIndex = 3;
            this.picturePanel.TabStop = false;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.labelScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelScore.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelScore.Location = new System.Drawing.Point(149, 112);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(2, 16);
            this.labelScore.TabIndex = 4;
            // 
            // labelBest
            // 
            this.labelBest.AutoSize = true;
            this.labelBest.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.labelBest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelBest.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBest.Location = new System.Drawing.Point(149, 174);
            this.labelBest.Name = "labelBest";
            this.labelBest.Size = new System.Drawing.Size(2, 16);
            this.labelBest.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 421);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.lblHighScoreText);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTextScore);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.Label lblTextScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblHighScoreText;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBest;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.PictureBox picturePanel;
    }
}

