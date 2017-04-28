using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication7
{
    public class Circle:Line
    {
        protected int radius;
        public Circle(int x1,int y1,int radius):base(x1,y1)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.radius = radius;
        }
        public override void Draw(Graphics graph)
        {
            Pen pen = new Pen(Color.Green);
            graph.DrawEllipse(pen, x1, y1, radius, radius);
            pen.Dispose();

        }
    }
}
