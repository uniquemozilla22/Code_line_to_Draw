using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Write_code_to_draw
{

    /// <summary>
    /// switches the pen or brush to be used in the application
    /// </summary>
    public class PencolorSwitcher
    {
        string[] error = { "", "" };

        /// <summary>
        /// the class takes the color as a string and converts the color of the pen or brush according to the user command
        /// </summary>
        /// <param name="color"></param> string name of the color
        public PencolorSwitcher(string color)
        {

            error[0] = "**Pen color set : " + color + "**";

            if (!Shape_Implementation.fill)
            {
                switch (color)
                {
                    case "green":
                        {

                            Shape_Implementation.Default_Pen = new Pen(Color.Green);
                            break;
                        }

                    case "blue":
                        {
                            Shape_Implementation.Default_Pen = new Pen(Color.Blue);
                            break;
                        }
                    case "brown":
                        {
                            Shape_Implementation.Default_Pen = new Pen(Color.Brown);
                            break;
                        }

                    case "yellow":
                        {
                            Shape_Implementation.Default_Pen = new Pen(Color.Yellow);
                            break;
                        }

                    case "white":
                        {
                            Shape_Implementation.Default_Pen = new Pen(Color.White);
                            break;
                        }
                    case "red":
                        {
                            Shape_Implementation.Default_Pen = new Pen(Color.Red);
                            break;
                        }
                    default:
                        {
                            error[0] = "**Pen color not found : " + color + "**";

                            break;
                        }
                }

            }
            else
            {
                switch (color)
                {
                    case "green":
                        {
                            Shape_Implementation.Default_Brush = new SolidBrush(Color.Green);
                            break;
                        }

                    case "blue":
                        {
                            Shape_Implementation.Default_Brush = new SolidBrush(Color.Blue);
                            break;
                        }
                    case "brown":
                        {
                            Shape_Implementation.Default_Brush = new SolidBrush(Color.Brown);
                            break;
                        }

                    case "yellow":
                        {
                            Shape_Implementation.Default_Brush = new SolidBrush(Color.Yellow);
                            break;
                        }

                    case "white":
                        {
                            Shape_Implementation.Default_Brush = new SolidBrush(Color.White);
                            break;
                        }
                    case "red":
                        {
                            Shape_Implementation.Default_Brush = new SolidBrush(Color.Red);
                            break;
                        }
                    default:
                        {
                            error[0] = "**Filling color not found : " + color + "**";
                            break;
                        }
                }

            }
        }

        /// <summary>
        /// Errors thown from the class is handled in an array
        /// </summary>
        /// <returns></returns> the string of array that contains the error string in the class
        public string[] error_pencolorSwitcher()
        {
            return this.error;
        }
    }
}
