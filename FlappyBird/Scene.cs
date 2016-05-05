using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FlappyBird
{
    public class Scene
    {
        public List<int> width = new List<int>();
        public List<int> height = new List<int>();

        public bool start;
        public bool isRunning;
        public int step;
        public int m_posX;
        public int m_posY;
        public bool resetPipes;
        public int points;
        public bool hitPipe;
        public int highScore;

        public Scene()
        {
            this.start = true;
            this.step = 5;
            this.resetPipes = false;
            this.hitPipe = false;
            this.highScore = int.Parse(System.IO.File.ReadAllText("HighScores.ini"));
        }

        public void showScore()
        {
            int score = int.Parse(System.IO.File.ReadAllText("HighScores.ini"));

            if(points > highScore)
            {
                highScore = points;
                System.IO.File.WriteAllText("HighScores.ini", points.ToString());
            }
        }
    }
}
