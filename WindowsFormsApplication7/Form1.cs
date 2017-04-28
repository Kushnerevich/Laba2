using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            picture.Image = new Bitmap(picture.Width, picture.Height);
            Graphics graph = Graphics.FromImage(picture.Image);
            Painter DrawMyLine = new PainterLine(this, button1, graph);
            Painter DrawMySquare = new PainterSquare(this, button2, graph);
            Painter DrawnMyRectangle = new PainterRectangle(this, button3, graph);
        }
    }
}
