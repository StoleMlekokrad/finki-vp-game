using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBird
{
    public class Pipe
    {
        public int width;
        public int posX;
        public int posY;
        // test change
        public Pipe(int _width, int _posX, int _posY)
        {
            this.width = _width;
            this.posX = _posX;
            this.posY = _posY;
        }
    }
}
