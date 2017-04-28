using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication7
{
    class Rectangle:Square
    {
        protected int width;
        public Rectangle(int x1, int y1, int len, int width): base(x1,y1,len)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.length = len;
            this.width = width;
        }
        public override void Draw(Graphics graph)//int x1, int y1, int _height, int _width
        {
            Pen pen = new Pen(Color.DarkBlue);
            graph.DrawRectangle(pen, x1, y1, width, length );
            pen.Dispose();
        }
    }
}
