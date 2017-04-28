using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    class PainterSquare:Painter
    {
        public PainterSquare(Form1 frm, Button btn, Graphics graph)
        {
            this.frm = frm;
            this.btn = btn;
            this.graph = graph;
            btn.Click += new EventHandler(button_Click);
        }
        protected override void Draw()
        {
            Square sq = new Square();
            graph.DrawRectangle(new Pen(Color.Yellow), sq.x1 = Convert.ToInt32(frm.textBox10.Text), sq.y1 = Convert.ToInt32(frm.textBox11.Text), sq.length = Convert.ToInt32(frm.textBox12.Text), sq.length);
            frm.picture.Refresh();
        }
    }
}
