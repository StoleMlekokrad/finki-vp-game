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
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.pBox = new System.Windows.Forms.PictureBox();
            this.lblTextScore = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(110, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 69);
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
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            // 
            // pBox
            // 
            this.pBox.Location = new System.Drawing.Point(121, 87);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(100, 50);
            this.pBox.TabIndex = 1;
            this.pBox.TabStop = false;
            // 
            // lblTextScore
            // 
            this.lblTextScore.AutoSize = true;
            this.lblTextScore.Location = new System.Drawing.Point(118, 36);
            this.lblTextScore.Name = "lblTextScore";
            this.lblTextScore.Size = new System.Drawing.Size(49, 17);
            this.lblTextScore.TabIndex = 2;
            this.lblTextScore.Text = "Score:";
            this.lblTextScore.Click += new System.EventHandler(this.lblTextScore_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(173, 36);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(16, 17);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 529);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTextScore);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.Label lblTextScore;
        private System.Windows.Forms.Label lblScore;
    }
}

