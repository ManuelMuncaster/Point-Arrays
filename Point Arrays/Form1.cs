using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {

            Point point1 = new Point();

            point1.X = 50;
            point1.Y = 40;

            Point point2 = new Point(140, 100);
            Point point3 = new Point(90, 250);

            Pen drawPen = new Pen(Color.Black);
            Brush drawBrush = new SolidBrush(Color.Pink);
            Graphics formGraphics = this.CreateGraphics();

            /*    formGraphics.DrawLine(drawPen, point1, point2);
                formGraphics.DrawLine(drawPen, point2, point3);
                formGraphics.DrawLine(drawPen, point1, point3);
                */
            Point[] triangle = new Point[3];
            triangle[0] = point1;
            triangle[1] = point2;
            triangle[2] = point3;

            Point[] triangle2 = { point1, point2, point3 };

            formGraphics.DrawPolygon(drawPen, triangle);
            formGraphics.FillPolygon(drawBrush, triangle);
            
        }
    }
}
