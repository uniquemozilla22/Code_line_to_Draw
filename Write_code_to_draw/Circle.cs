using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Write_code_to_draw
{
    /// <summary>
    /// Class for executing the Circle shape
    /// 
    /// </summary>
    public class Circle : Shapes
    {

        int radius;
        Pen pen;
        SolidBrush brush;


        /// <summary>
        /// Getts the value and sets the parameters of the Circle shape
        /// </summary>
        /// <param name="param"></param> the integer array of the parameters given by the user to be constructed in the application
        /// <param name="Default_Pen"></param> Pen for drawing the shape if the fill is off
        public void GetValue(int[] param,Pen Default_Pen)
        {
            this.radius = param[0];
            this.pen = Default_Pen;
        }

        /// <summary>
        /// Getts the value and sets the parameters of the Circle shape
        /// </summary>
        /// <param name="param"></param> the integer array of the parameters given by the user to be constructed in the application
        /// <param name="Default_Pen"></param> Pen for drawing the shape if the fill is off
        public void GetValue(int[] param, SolidBrush Default_Brush)
        {
            this.radius = param[0];
            this.brush= Default_Brush;
        }


        /// <summary>
        /// Draws the shape in the picturebox with the initial points with a brush or a pen
        /// </summary>
        /// <param name="G"></param> Graphics to show the shape
        /// <param name="x"></param> initial x point in the picturebox
        /// <param name="y"></param> initial y point in the picturebox
        /// <param name="fill"></param> fill on or off in the application
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
