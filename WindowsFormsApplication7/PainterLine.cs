﻿using System;
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
    class PainterLine:Painter
    {
        public PainterLine(Form1 frm, Button btn,Graphics graph)
        {
            this.frm = frm;
            this.btn = btn;
            this.graph = graph;
            btn.Click += new EventHandler(button_Click);
        }
        protected override void Draw()
        {
            Line line = new Line();
            graph.DrawLine(new Pen(Color.Red), line.x1=200,line.y1=100,line.x2=200, line.y2=200);
            frm.picture.Refresh();
        }
    }
}
