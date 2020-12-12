using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Write_code_to_draw
{
    public class Polygon: Shapes
    {
        int[] sides=new int[5];
        Pen pen;
        SolidBrush brush;


        /// <summary>
        /// Getts the value and sets the parameters of the triangle shape
        /// 
        /// </summary>
        /// <param name="param"></param>the integer array of the parameters given by the user to be constructed in the application
        /// <param name="Default_Pen"></param> Pen for drawing the shape if the fill is off
        public void GetValue(float[] param, Pen Default_Pen)
        {
            
            for(int i = 0; i <param.Length;i++)
            {
                int v =(int) param[i];
                sides[i] = v;
            }


            this.pen = Default_Pen;
        }

        /// <summary>
        /// Getts the value and sets the parameters of the Triangle shape
        /// 
        /// </summary>
        /// <param name="param"></param>the integer array of the parameters given by the user to be constructed in the application
        /// <param name="Default_Brush"></param>  Brush to fill inside the shape if the fill is on
        public void GetValue(float[] param, SolidBrush Default_Brush)
        {
            int i = 0;
            foreach (int side in param)
            {
                sides[i] = (int)side;
                i++;
            }
            this.brush = Default_Brush;
        }

        /// <summary>
        /// Draws the shape in the picturebox with the initial points with a brush or a pen
        /// 
        /// </summary>
        /// <param name="G"></param>  Graphics to show the shape
        /// <param name="x"></param> initial x point in the picturebox
        /// <param name="y"></param> initial y point in the picturebox
        /// <param name="fill"></param> fill on or off in the application
        public void Draw(Graphics G, float x, float y, bool fill)
        {
            int initial_positionx = (int)x;
            int initial_positiony = (int)y;
            Point p1 = new Point(initial_positionx, initial_positiony);
            Point p3 = new Point(sides[0], sides[1]);
            Point p5 = new Point(sides[2], sides[3]);
            Point p6 = new Point(sides[4], initial_positionx);



            Point[] points= { p1, p3,p5,p6};
            

            if (fill)
            {
                G.RotateTransform(Data_storing.rotating_angle);
                G.FillPolygon(brush, points);

            }
            else
            {
                G.RotateTransform(Data_storing.rotating_angle);
                G.DrawPolygon(pen, points);



            }
        }
    }
}
