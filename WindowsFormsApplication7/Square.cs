using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication7
{
    public class Square:Line 
    {
        protected int length;
        public Square(int x1, int y1, int length):base(x1,y1)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.length = length;
        }
        public override void Draw(Graphics graph)
        {
            Pen pen = new Pen(Color.Brown);
            graph.DrawRectangle(pen, x1, y1, length, length);
            pen.Dispose();
        }
    }
}
