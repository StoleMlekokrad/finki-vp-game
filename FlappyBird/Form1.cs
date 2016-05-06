﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        Scene scene = new Scene();
        Pipe pipe = new Pipe(55, 140, 180);

        public Form1()
        {
            InitializeComponent();
        }

        private void Die()
        {
            scene.isRunning = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            button1.Visible = true;
            button1.Enabled = true;

            scene.showScore();
            lblScore.Text = scene.highScore.ToString();
            scene.points = 0;

            pBox.Location = new Point(scene.m_posX, scene.m_posY);

            scene.resetPipes = true;

            scene.width.Clear();
        }

        private void Start()
        {
            scene.resetPipes = false;

            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;

            Random r = new Random();
            int number = r.Next(40, this.Height - pipe.posY);
            int sNumber = number + pipe.posY;

            scene.width.Clear();
            scene.width.Add(this.Width);
            scene.width.Add(number);
            scene.width.Add(this.Width);
            scene.width.Add(sNumber);

            number = r.Next(40, (this.Height - pipe.posY));
            sNumber = number + pipe.posY;
            scene.height.Clear();
            scene.height.Add(this.Width + pipe.posX);
            scene.height.Add(number);
            scene.height.Add(this.Width + pipe.posX);
            scene.height.Add(sNumber);

            button1.Visible = false;
            button1.Enabled = false;
            scene.isRunning = true;

            Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void lblTextScore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your score is: " + lblScore.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            scene.m_posX = pBox.Location.X;
            scene.m_posY = pBox.Location.Y;
            if (!File.Exists("HighScores.ini"))
            {
                File.Create("HighScores.ini").Dispose();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (scene.width[0] + pipe.width <= 0 | scene.start == true)
            {
                Random rnd = new Random();
                int px = this.Width;
                int py = rnd.Next(40, (this.Height - pipe.posY));
                var p2x = px;
                var p2y = py + pipe.posY;
                scene.width.Clear();
                scene.width.Add(px);
                scene.width.Add(py);
                scene.width.Add(p2x);
                scene.width.Add(p2y);
            }
            else
            {
                scene.width[0] = scene.width[0] - 2;
                scene.width[2] = scene.width[2] - 2;
            }

            if (scene.height[0] + pipe.width <= 0)
            {
                Random rnd = new Random();
                int px = this.Width;
                int py = rnd.Next(40, (this.Height - pipe.posY));
                var p2x = px;
                var p2y = py + pipe.posY;
                int[] p1 = { px, py, p2x, p2y };
                scene.height.Clear();
                scene.height.Add(px);
                scene.height.Add(py);
                scene.height.Add(p2x);
                scene.height.Add(p2y);
            }
            else
            {
                scene.height[0] = scene.height[0] - 2;
                scene.height[2] = scene.height[2] - 2;
            }

            if (scene.start == true)
                scene.start = false;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (!scene.resetPipes && scene.width.Any() && scene.height.Any())
            {
                e.Graphics.FillRectangle(Brushes.DarkGreen, new Rectangle(scene.width[0], 0, pipe.width, scene.height[1]));
                e.Graphics.FillRectangle(Brushes.DarkGreen, new Rectangle(scene.width[0] - 10, scene.width[3] - pipe.posY, 75, 15));

                e.Graphics.FillRectangle(Brushes.DarkGreen, new Rectangle(scene.width[2], scene.width[3], pipe.width, this.Height - scene.width[3]));
                e.Graphics.FillRectangle(Brushes.DarkGreen, new Rectangle(scene.width[2] - 10, scene.width[3], 75, 15));
                
                e.Graphics.FillRectangle(Brushes.DarkGreen, new Rectangle(scene.width[0], 0, pipe.width, scene.height[1]));
                e.Graphics.FillRectangle(Brushes.DarkGreen, new Rectangle(scene.width[0] - 10, scene.height[3] - pipe.posY, 75, 15));
                
                e.Graphics.FillRectangle(Brushes.DarkGreen, new Rectangle(scene.width[2], scene.height[3], pipe.width, this.Height - scene.height[3]));
                e.Graphics.FillRectangle(Brushes.DarkGreen, new Rectangle(scene.width[2] - 10, scene.height[3], 75, 15));

            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pBox.Location = new Point(pBox.Location.X, pBox.Location.Y + scene.step);
            if (pBox.Location.Y < 0)
            {
                pBox.Location = new Point(pBox.Location.X, 0);
            }
            if (pBox.Location.Y + pBox.Height > this.ClientSize.Height)
            {
                pBox.Location = new Point(pBox.Location.X, this.ClientSize.Height - pBox.Height);
            }
            CheckForCollision();
            if (scene.isRunning)
            {
                CheckForPoint();
            }

            lblTextScore.Text = scene.points.ToString();
    }
        private void CheckForPoint()
        {
            Rectangle rec1 = pBox.Bounds;
            Rectangle rec2 = new Rectangle(scene.width[2] + 20, scene.width[3] - pipe.posY, 15, pipe.posY);
            Rectangle rec3 = new Rectangle(scene.height[2] + 20, scene.height[3] - pipe.posY, 15, pipe.posY);
            Rectangle intersect1 = Rectangle.Intersect(rec1, rec2);
            Rectangle intersect2 = Rectangle.Intersect(rec1, rec3);
            if(!scene.resetPipes | scene.start)
            {
                if(intersect1 != Rectangle.Empty | intersect2 != Rectangle.Empty)
                {
                    if (!scene.hitPipe)
                    {
                        scene.points++;
                        scene.hitPipe = true;
                    }
                }
                else
                {
                    scene.hitPipe = false;
                }
            }
        }
        private void CheckForCollision()
        {
            Rectangle rec1 = pBox.Bounds;
            Rectangle rec2 = new Rectangle(scene.width[0], 0, pipe.width, scene.width[1]);
            Rectangle rec3 = new Rectangle(scene.width[2], scene.width[3], pipe.width, this.Height - scene.width[3]);
            Rectangle rec4 = new Rectangle(scene.height[0], 0, pipe.width, scene.width[1]);
            Rectangle rec5 = new Rectangle(scene.width[2], scene.width[3], pipe.width, this.Height - scene.width[3]);
            Rectangle intersect1 = Rectangle.Intersect(rec1, rec2);
            Rectangle intersect2 = Rectangle.Intersect(rec1, rec3);
            Rectangle intersect3 = Rectangle.Intersect(rec1, rec4);
            Rectangle intersect4 = Rectangle.Intersect(rec1, rec5);


            if (!scene.resetPipes | scene.start)
            {
                if (intersect1 != Rectangle.Empty | intersect2 != Rectangle.Empty | intersect3 != Rectangle.Empty | intersect4 != Rectangle.Empty)
                {
                    Die();
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    scene.step = -5;
                break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    scene.step = 5;
                break;
            }
        }

    }
}
