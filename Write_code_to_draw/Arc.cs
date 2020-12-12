using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Write_code_to_draw
{
    public class Arc :Shapes
    {
        float startAngle,SweepAngle,width,height;
        Pen pen;
        SolidBrush brush;


        /// <summary>
        /// Getts the value and sets the parameters of the Arc shape
        /// </summary>
        /// <param name="param"></param> the integer array of the parameters given by the user to be constructed in the application
        /// <param name="Default_Pen"></param> Pen for drawing the shape if the fill is off
        public void GetValue(float[] param, Pen Default_Pen)
        {
            this.width = param[0];
            this.height = param[1];
            this.startAngle = param[2];
            this.SweepAngle = param[3];
            this.pen = Default_Pen;
        }

        /// <summary>
        /// Getts the value and sets the parameters of the Circle shape
        /// </summary>
        /// <param name="param"></param> the integer array of the parameters given by the user to be constructed in the application
        /// <param name="Default_Pen"></param> Pen for drawing the shape if the fill is off
        public void GetValue(float[] param, SolidBrush Default_Brush)
        {

            this.width = param[0];
            this.height = param[1];
            this.startAngle = param[2];
            this.SweepAngle = param[3];
            this.brush = Default_Brush;
        }


        /// <summary>
        /// Draws the shape in the picturebox with the initial points with a brush or a pen
        /// </summary>
        /// <param name="G"></param> Graphics to show the shape
        /// <param name="x"></param> initial x point in the picturebox
        /// <param name="y"></param> initial y point in the picturebox
        /// <param name="fill"></param> fill on or off in the application
        public void Draw(Graphics G, float x, float y, bool fill)
        {
            if(fill)
            {
                G.RotateTransform(Data_storing.rotating_angle);
                G.DrawArc(pen, x, y, width, height, startAngle, SweepAngle);

            }
            else
            {

                G.RotateTransform(Data_storing.rotating_angle);
                G.DrawArc(pen, x, y, width, height, startAngle, SweepAngle);
            }
        }

    }
}
