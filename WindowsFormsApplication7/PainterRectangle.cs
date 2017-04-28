using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    class PainterRectangle:Painter
    {
        public PainterRectangle(Form1 frm, Button btn, Graphics graph)
        {
            this.frm = frm;
            this.btn = btn;
            this.graph = graph;
            btn.Click += new EventHandler(button_Click);
        }
        protected override void Draw()
        {
            Rectangle rec = new Rectangle();
            graph.DrawRectangle(new Pen(Color.Yellow), rec.x1 = Convert.ToInt32(frm.textBox13.Text), rec.y2 = Convert.ToInt32(frm.textBox14.Text), rec.width = Convert.ToInt32(frm.textBox15.Text), rec.height = Convert.ToInt32(frm.textBox16.Text));
            frm.picture.Refresh();
        }
    }
}
