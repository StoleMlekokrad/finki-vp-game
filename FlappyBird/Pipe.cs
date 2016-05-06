using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FlappyBird
{
    public class Pipe
    {
        public int width;
        public int height;
        public int posX;
        public int posY;

        // up or down
        public int orientation;

        public Pipe(int _width, int _height, int _posX, int _posY)
        {
            this.width = _width;
            this.height = _height;
            this.posX = _posX;
            this.posY = _posY;
        }

        public void Draw(Graphics g)
        {
            SolidBrush brush = new SolidBrush(Color.DarkGreen);
            g.FillRectangle(brush, posX - width / 2, posY - width / 2, width, height);
            brush.Dispose();
        }
    }
}
