using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Write_code_to_draw
{
    public class Circle : Shapes
    {

        int radius;
        Pen pen;
        SolidBrush brush;
        public void GetValue(int[] param,Pen Default_Pen)
        {
            this.radius = param[0];
            this.pen = Default_Pen;
        }
       public void GetValue(int[] param, SolidBrush Default_Brush)
        {
            this.radius = param[0];
            this.brush= Default_Brush;
        }
        public void Draw(Graphics G, int x, int y, bool fill)
        {
            if(!fill)
            {
                G.DrawEllipse(pen, x, y, radius, radius);
            }
            else
            {
                G.FillEllipse(brush, x, y, radius, radius);

            }
        }




    }
}
