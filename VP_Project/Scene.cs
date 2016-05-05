using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Project
{
    class Scene
    {
        public bool start;
        public bool isRunning;
        public int step;
        public int m_posX;
        public int m_posY;
        public bool resetPipes;
        public int points;
        public bool hitPipe;
        public int score;
        public int scoreDifferent;

        Scene()
        {
            this.start = true;
            this.step = 5;
            this.resetPipes = false;
            this.hitPipe = false;
        }
    }

}
