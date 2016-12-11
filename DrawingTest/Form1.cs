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
        private void DrawEllipse()
        {
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            formGraphics.DrawEllipse(myPen, new Rectangle(0, 0, 200, 200));
            myPen.Dispose();
            formGraphics.Dispose();
        }
        private void DrawRectangle()
        {
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            formGraphics.DrawRectangle(myPen, new Rectangle(0, 0, 200, 200));
            myPen.Dispose();
            formGraphics.Dispose();
        }
        private void DrawLine()
        {
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Blue);
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            formGraphics.DrawLine(myPen, 0, 0, 200, 200);
            myPen.Dispose();
            formGraphics.Dispose();
        }
        private void cmdDraw_Click(object sender, EventArgs e)
        {
            DrawEllipse();
            DrawRectangle();
            DrawLine();
        }

    }
}
