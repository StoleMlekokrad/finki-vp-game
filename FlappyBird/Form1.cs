using FlappyBird.Properties;
using System;
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
        Scene scene;
        Image image;

        // Broj za kolku ja kratime cevkata
        private int offset;
        // Broj za kolku se pomestuvaat cevkite
        private int moveOffset;
        // Dali cevkite se dvizat 
        private int moveTurn;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.moveOffset = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;

            if (!File.Exists("HighScores.ini"))
            {
                File.Create("HighScores.ini").Dispose();
                System.IO.File.WriteAllText("HighScores.ini", "0");
            }

            scene = new Scene();
            scene.m_posX = pBox.Location.X;
            scene.m_posY = pBox.Location.Y;
            lblHighScore.Text = System.IO.File.ReadAllText("HighScores.ini");
            Stream stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("FlappyBird.bg.png");
            image = Image.FromStream(stream);

        }

        private void Die()
        {
            if(scene.points > scene.highScore)
            {
                scene.highScore = scene.points;
                lblHighScore.Text = scene.points.ToString();
                System.IO.File.WriteAllText("HighScores.ini", scene.points.ToString());

            }
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;

            moveOffset = 0;

            button1.Visible = true;
            button1.Enabled = true;
            lblScore.Visible = true;
            lblTextScore.Visible = true;

            scene.active = false;
            scene.currentStep = 0;
            scene.points = 0;

            pBox.Location = new Point(scene.m_posX, scene.m_posY);
        }

        private void Start()
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;

            button1.Visible = false;
            button1.Enabled = false;
            lblScore.Text = 0 + "";
            lblHighScore.Text = scene.highScore.ToString();

            scene.active = true;

            Random r = new Random();
            offset = r.Next(-10, 10);
            offset *= 10;
            offset += pBox.Height;

            moveTurn = r.Next(0, 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Start(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CheckForCollision();

            Rectangle r2 = new Rectangle(scene.topPipe.posX - scene.topPipe.width / 2, scene.topPipe.posY - scene.topPipe.width / 2, scene.topPipe.width, scene.topPipe.height);
            Rectangle r3 = new Rectangle(scene.bottomPipe.posX - scene.bottomPipe.width / 2, scene.bottomPipe.posY - scene.bottomPipe.width / 2, scene.bottomPipe.width, scene.bottomPipe.height);

            if (!Screen.AllScreens.Any(s => s.WorkingArea.IntersectsWith(r2)) || !Screen.AllScreens.Any(s => s.WorkingArea.IntersectsWith(r3)))
                timer3.Enabled = false;

            scene.currentStep += 2;
            pBox.Location = new Point(pBox.Location.X, pBox.Location.Y + scene.step);

            if(pBox.Location.Y < 0 | this.ClientSize.Height < pBox.Location.Y + pBox.Height)
            {
                Die();
            }

            Invalidate(scene.active);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int x = (scene.currentStep / 2) % image.Width;
            e.Graphics.DrawImage(image, new Point(-x, 0));
            e.Graphics.DrawImage(image, new Point(-scene.currentStep + image.Width, 0));

            if (scene.points >= scene.SCORE_MOVING_PIPES)
            {
                if (moveTurn == 0)
                {
                    scene.topPipe = new Pipe(scene.pipeWidth, scene.pipeHeight - offset + moveOffset, Width - scene.pipeWidth / 2 - scene.currentStep, 0, false);
                    scene.bottomPipe = new Pipe(scene.pipeWidth, scene.pipeHeight + offset - moveOffset, Width - scene.pipeWidth / 2 - scene.currentStep, Height - scene.pipeHeight - offset + moveOffset, true);
                }
                else
                {
                    scene.topPipe = new Pipe(scene.pipeWidth, scene.pipeHeight - offset - moveOffset, Width - scene.pipeWidth / 2 - scene.currentStep, 0, false);
                    scene.bottomPipe = new Pipe(scene.pipeWidth, scene.pipeHeight + offset + moveOffset, Width - scene.pipeWidth / 2 - scene.currentStep, Height - scene.pipeHeight - offset - moveOffset, true);
                }
            }
            else
            {
                scene.topPipe = new Pipe(scene.pipeWidth, scene.pipeHeight - offset, Width - scene.pipeWidth / 2 - scene.currentStep, 0, false);
                scene.bottomPipe = new Pipe(scene.pipeWidth, scene.pipeHeight + offset, Width - scene.pipeWidth / 2 - scene.currentStep, Height - scene.pipeHeight - offset, true);
            }

            scene.topPipe.Draw(e.Graphics);
            scene.bottomPipe.Draw(e.Graphics);

            if (scene.step < 4 && scene.step > -4)
            {
                scene.step++;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            offset = r.Next(-10, 10);
            offset *= 10;
            offset += pBox.Height;

            timer3.Enabled = true;

            moveOffset = 0;
            moveTurn = r.Next(0, 2);

            scene.currentStep = 0;
            scene.points++;
            lblScore.Text = scene.points.ToString();

            Invalidate(scene.active);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            moveOffset += 1;
            Invalidate(scene.active);
        }

        private void lblTextScore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your score is: " + lblScore.Text);
        }

        private void CheckForCollision()
        {
            Rectangle r1 = pBox.Bounds;
            Rectangle r2 = new Rectangle(scene.topPipe.posX - scene.topPipe.width / 2, scene.topPipe.posY - scene.topPipe.width / 2, scene.topPipe.width, scene.topPipe.height);
            Rectangle r3 = new Rectangle(scene.bottomPipe.posX - scene.bottomPipe.width / 2, scene.bottomPipe.posY - scene.bottomPipe.width / 2, scene.bottomPipe.width, scene.bottomPipe.height);

            if (r1.IntersectsWith(r2) | r1.IntersectsWith(r3))
            {
                Die();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    e.Handled = e.SuppressKeyPress = true;
                    scene.step = -4;
                    pBox.Image = Resources.flappy;
                    if (!scene.active)
                        Start();
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    e.Handled = e.SuppressKeyPress = true;
                    scene.step = -3;
                    pBox.Image = Resources.flappyDown;            
                break;
            }
        }
    }
}
