using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Write_code_to_draw
{
    public class Rectangle :Shapes
    {

        int side1, side2;
        Pen pen;
        SolidBrush brush;
        public void GetValue(int[] param, Pen Default_Pen)
        {
            this.side1 = param[0];
            this.side2 = param[1];
            this.pen = Default_Pen;
        }
        public void GetValue(int[] param, SolidBrush Default_Brush)
        {

            this.side1 = param[0];
            this.side2 = param[1];

            this.brush = Default_Brush;
        }
        public void Draw(Graphics G, int x, int y, bool fill)
        {
            if (fill)
            {
                G.FillRectangle(brush, x,y,side2,side1);
            }
            else
            {
                G.DrawRectangle(pen, x, y, side2, side1);


            }
        }
    }
}
