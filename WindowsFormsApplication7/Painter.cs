using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    abstract class Painter
    {
        public Form1 frm;
        public Button btn;
        public Graphics graph;

        protected abstract void Draw();

        protected void button_Click(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
