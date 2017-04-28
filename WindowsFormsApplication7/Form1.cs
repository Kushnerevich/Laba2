using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Bitmap bmp;
        public Graphics graph;
        public Pen pen;
        List<Line> shapes = new List<Line>();
        public Form1()
        {
            InitializeComponent();
            InitImage();
            InitFigures();
            Draw_All_Figures();

        }


        public void InitImage()
        {
            bmp = new Bitmap(picture.Height, picture.Width);
            graph = Graphics.FromImage(bmp);
            pen = new Pen(Color.DarkRed);
            picture.Image = bmp;
        }
        public void InitFigures()
        {
            shapes.Add(new Line(300, 180));
            shapes.Add(new Circle(50, 50, 50));
            shapes.Add(new Square(100, 100, 70));
            shapes.Add(new Rectangle(250, 250, 70, 150));
            

        }
        public void Draw_All_Figures()
        {

            foreach (Line shape in shapes)
            {
                shape.Draw(graph);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Visible=false;
            label3.Visible=false;
            label3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            radioButton1.Checked = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
