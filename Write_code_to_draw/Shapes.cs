using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Write_code_to_draw
{
    /// <summary>
    /// interface to draw the shapes in the graphical area
    /// </summary>
    public interface Shapes
    {
        /// <summary>
        /// Draws the shape in the picturebox with the initial points with a brush or a pen
        /// </summary>
        /// <param name="G"></param> Graphics to show the shape
        /// <param name="x"></param> initial x point in the picturebox
        /// <param name="y"></param> initial y point in the picturebox
        /// <param name="fill"></param> fill on or off in the application
        void Draw(Graphics G, float x, float y,bool fill);



        /// <summary>
        /// Getts the value and sets the parameters of any shape
        /// </summary>
        /// <param name="param"></param> the integer array of the parameters given by the user to be constructed in the application
        /// <param name="Default_Pen"></param> Pen for drawing the shape if the fill is off
        void GetValue(float[] parameters,Pen Default_Pen);

        /// <summary>
        /// Getts the value and sets the parameters of any shape passed into it
        /// </summary>
        /// <param name="param"></param> the integer array of the parameters given by the user to be constructed in the application
        /// <param name="Default_Pen"></param> Pen for drawing the shape if the fill is off
        void GetValue(float[] parameters, SolidBrush Default_Brush);

    }
}
