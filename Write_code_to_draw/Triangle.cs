using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Write_code_to_draw
{
    public class Triangle:Shapes
    {
        int side1,side2,side3;
        Pen pen;
        SolidBrush brush;
        public void GetValue(int[] param, Pen Default_Pen)
        {
            this.side1 = param[0];
            this.side2 = param[1];

            this.side3 = param[2];


            this.pen = Default_Pen;
        }
        public void GetValue(int[] param, SolidBrush Default_Brush)
        {

            this.side1 = param[0];
            this.side2 = param[1];

            this.side3 = param[2];
            this.brush = Default_Brush;
        }
        public void Draw(Graphics G, int x, int y, bool fill)
        {

            Point p1 = new Point(x, y);
            Point p2 = new Point(side1, y);
            Point p3 = new Point(side2, side3);

            Point[] points = { p1, p2, p3 };

            if (fill)
            {
                G.FillPolygon(brush, points);
            }
            else
            {
                G.DrawPolygon(pen, points);

            }
        }


    }
}
