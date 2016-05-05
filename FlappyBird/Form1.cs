using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
    }
}
