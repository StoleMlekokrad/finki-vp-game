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
        public Pipe topPipe;
        public Pipe bottomPipe;

        // posle koj skor pocnuvaat da se dvizat cevkite
        public int SCORE_MOVING_PIPES = 0;

        // dolzina i sirina na cevkite
        public int pipeWidth = 55;
        public int pipeHeight = 180;

        // momentalen cekor na kompirot
        public int currentStep = 0;

        // Dali igrata e aktivna
        public bool active;
        // Dali kompirot leta
        public bool isRunning;
        // Pomestuvanje pri klik
        public int step;
        // Pozicija na kompirot
        public int m_posX;
        public int m_posY;

        // Momentalni poeni
        public int points;
        // Najvisok skor
        public int highScore;

        public Scene()
        {
            this.active = true;
            this.step = 3;
            try
            {
                this.highScore = int.Parse(System.IO.File.ReadAllText("HighScores.ini"));

            }
            catch(System.IO.FileNotFoundException)
            {
                this.highScore = 0;
            }
        }

        public void showScore()
        {
            try
            {
                int score = int.Parse(System.IO.File.ReadAllText("HighScores.ini"));

                if (points > highScore)
                {
                    highScore = points;
                    System.IO.File.WriteAllText("HighScores.ini", points.ToString());
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                highScore = 0;
            }
        }
    }
}
