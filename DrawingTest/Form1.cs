using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void DrawEllipse(int x1, int y1, int x2, int y2)
        {
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            formGraphics.DrawEllipse(myPen, new Rectangle(x1, y1, x2, y2));
            myPen.Dispose();
            formGraphics.Dispose();
        }
        private void DrawRectangle(int x1, int y1, int x2, int y2)
        {
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            formGraphics.DrawRectangle(myPen, new Rectangle(x1, y1, x2, y2));
            myPen.Dispose();
            formGraphics.Dispose();
        }
        private void DrawLine(float x1, float y1, float x2, float y2)
        {
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Blue);
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            formGraphics.DrawLine(myPen, x1, y1, x2, y2);
            myPen.Dispose();
            formGraphics.Dispose();
        }
        private void cmdDraw_Click(object sender, EventArgs e)
        {
            DrawEllipse(100,100,200,200);
            DrawRectangle(100,100,200,200);
            DrawLine(0,0,200,200);
            DrawLine(200, 0, 0, 200);
        }

    }
}
