﻿using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Write_code_to_draw
{
    /// <summary>
    /// Class for executing the Triangle shape
    /// 
    /// </summary>
    public class Triangle:Shapes
    {
        int side1,side2,side3;
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
            this.side1 = (int)param[0];
            this.side2 = (int)param[1];
            this.side3 = (int)param[2];


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

            this.side1 = (int)param[0];
            this.side2 = (int)param[1];
            this.side3 = (int)param[2];
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
            Point p2 = new Point(side1, initial_positiony);
            Point p3 = new Point(side2, side3);

            Point[] points = { p1, p2, p3 };

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
