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
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTextScore = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblHighScoreText = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(82, 350);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTextScore
            // 
            this.lblTextScore.AutoSize = true;
            this.lblTextScore.Location = new System.Drawing.Point(88, 29);
            this.lblTextScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTextScore.Name = "lblTextScore";
            this.lblTextScore.Size = new System.Drawing.Size(38, 13);
            this.lblTextScore.TabIndex = 2;
            this.lblTextScore.Text = "Score:";
            this.lblTextScore.Click += new System.EventHandler(this.lblTextScore_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(130, 29);
            this.lblScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(13, 13);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "0";
            // 
            // pBox
            // 
            this.pBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pBox.Location = new System.Drawing.Point(11, 190);
            this.pBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(28, 32);
            this.pBox.TabIndex = 1;
            this.pBox.TabStop = false;
            this.pBox.Click += new System.EventHandler(this.pBox_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 2200;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblHighScoreText
            // 
            this.lblHighScoreText.AutoSize = true;
            this.lblHighScoreText.Location = new System.Drawing.Point(63, 50);
            this.lblHighScoreText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHighScoreText.Name = "lblHighScoreText";
            this.lblHighScoreText.Size = new System.Drawing.Size(63, 13);
            this.lblHighScoreText.TabIndex = 4;
            this.lblHighScoreText.Text = "High Score:";
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Location = new System.Drawing.Point(128, 50);
            this.lblHighScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(13, 13);
            this.lblHighScore.TabIndex = 5;
            this.lblHighScore.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 430);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.lblHighScoreText);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTextScore);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
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
    }
}

