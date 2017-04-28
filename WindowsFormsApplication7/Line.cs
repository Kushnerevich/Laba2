using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication7
{
    public class Line
    {
        protected int x1, y1;
        public Line(int x, int y)
        {
            this.x1 = x;
            this.y1 = y;
        }
        public virtual void Draw(Graphics graph) 
        {
            Pen pen = new Pen(Color.Red);
            graph.DrawLine(pen, x1, y1, x1 + 60, y1 + 60);
            pen.Dispose();
        }
    }
}
