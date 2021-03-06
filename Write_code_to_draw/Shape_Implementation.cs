﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Write_code_to_draw
{

    /// <summary>
    /// This class is for implementing the user given input and runs the given data in the application
    /// </summary>
    public class Shape_Implementation
    {
        string[] errors = { "", "" };
        string firstname;
        Graphics graphics = Panel.graphic;
        string[] parameters;
        public static float Default_initial_positionx = 0;
        public static float Default_initial_positiony = 0;
        public static SolidBrush Default_Brush = new SolidBrush(Color.White);
        public static Pen Default_Pen = new Pen(Color.White);
        public static bool fill = false;

        /// <summary>
        /// Class Takes the input and executes the give code to the run the application correctly
        /// </summary> 
        /// <param name="firstname"></param> first name of the code that is to be implemented
        /// <param name="parameters_string"></param> array of string that contains the input of parametes that has been given by the user to compile.
        /// <param name="gr"></param> graphics for the picturebox that the application draws the shapes in.
        public Shape_Implementation(string firstname , string[] parameters_string)
        {
            this.firstname = firstname;
           
            this.parameters = parameters_string;
            Shape_decider shape_type = new Shape_decider();
            if (firstname == "moveto" || firstname == "drawto")
            {
                        this.to_implementation();
            }
            else if(firstname=="pen")
            {
                if(parameters_string.Length==1)
                {
                    PencolorSwitcher p = new PencolorSwitcher(parameters_string[0]);
                    errors = p.error_pencolorSwitcher();
                }
                else
                {
                    errors[0] = "**Pass only a color name**";
                }
            }
            else if (firstname == "fill")
            {
                if (parameters_string.Length == 1)
                {
                    if (parameters_string[0] =="on")
                    {
                        fill = true;
                        errors[0] = "**Fill turned on**";


                    }
                    else if (parameters_string[0] == "off")
                    {
                        fill = false;
                        errors[0] = "**Fill turned off**";


                    }
                    else
                    {
                        errors[0] = "**You can turn on or turn off the fill in**";
                    }
                }
                else
                {
                    errors[0] = "**Pass only a color name**";
                }
            }

            else if(firstname == "circle")
            {
                if(parameters_string.Length==1)
                {
                    shape_changer(firstname, parameters_string.Length, parameters_string);

                }
                else
                {
                    errors[0] = "**Pass only a Radius**";
                }

            }
            else if (firstname == "drawarc")
            {
                if (parameters_string.Length == 4)
                {
                    shape_changer(firstname, parameters_string.Length, parameters_string);

                }
                else
                {
                    errors[0] = "**Pass width,height,start angle,sweep angle**";
                }

            }
            else if (firstname == "triangle")
            {
                if (parameters_string.Length == 3)
                {

                    shape_changer(firstname, parameters_string.Length, parameters_string);

                }
                else
                {
                    errors[0] = "**Pass legnths for each side**";
                }

            }
            else if (firstname == "rectangle")
            {
                if (parameters_string.Length == 2)
                {
                    shape_changer(firstname, parameters_string.Length, parameters_string);
                }
                else
                {
                    errors[0] = "**Pass a length and a breadth**";
                }

            }
            else if (firstname == "polygon")
            {
                if (parameters_string.Length >= 4)
                {
                    shape_changer(firstname, parameters_string.Length, parameters_string);
                }
                else
                {
                    errors[0] = "**Pass a 5 parameters for the sides**";
                }

            }
            else if (firstname == "rotate")
            {
                if (parameters_string.Length ==1)
                {
                    rotating_Graphics(parameters_string);
                }
                else
                {
                    errors[0] = "**Pass a rotating angle**";
                }

            }
            else
            {
                this.errors[0] = "**Not a Valid Code**";
            }

        }

        /// <summary>
        /// A method that implementes the shapes according to the given instructions by the user in the application
        /// </summary>
        /// <param name="shape"></param> name of the shape passed by the user
        /// <param name="length"></param> number of parameters passed by the user
        /// <param name="para"></param> string array of the parameters passed by the user
        public void shape_changer(string shape,int length,string[] para)

        {
            Shape_decider shape_type = new Shape_decider();

            float[] parameters_float = new float[length];
            for (int i = 0; i < length; i++)
            {

                if (Data_storing.List_of_varaiables.Contains(para[i]))
                {
                    int index = Data_storing.List_of_varaiables.IndexOf(para[i]);
                    parameters_float[i] = (float)Data_storing.Value_of_varaiables[index];

                }
                else
                {
                    try
                    {
                        parameters_float[i] = float.Parse(para[i]);
                    }
                    catch (FormatException fe)
                    {
                        this.errors[0] = "Please pass some valid parameters to the command";


                    }
                }
                

            }

            Shapes sh = shape_type.GetShapes(shape);
            if (fill)
            {
                sh.GetValue(parameters_float, Default_Brush);

            }
            else
            {
                sh.GetValue(parameters_float, Default_Pen);
            }
            sh.Draw(graphics, Default_initial_positionx,Default_initial_positiony, fill);

        }

        /// <summary>
        /// A method that implements the to command of the application (moveto and Drawto)
        /// </summary>
        public void to_implementation()
        {
            if(firstname=="moveto")
            {
                if (Data_storing.List_of_varaiables.Contains(parameters[0]))
                {
                    int index = Data_storing.List_of_varaiables.IndexOf(parameters[0]);
                    Default_initial_positionx = (float)Data_storing.Value_of_varaiables[index];

                }
                else
                {
                    try
                    {

                        Default_initial_positionx = int.Parse(parameters[0]);

                    }
                    catch (FormatException fe)
                    {
                        this.errors[0] = "Please pass some parameters to the command";


                    }
                }
                if (Data_storing.List_of_varaiables.Contains(parameters[1]))
                {
                    int index = Data_storing.List_of_varaiables.IndexOf(parameters[1]);
                    Default_initial_positiony= (float)Data_storing.Value_of_varaiables[index];

                }
                else
                {
                    try
                    {

                        Default_initial_positiony = int.Parse(parameters[1]);

                    }
                    catch (FormatException fe)
                    {
                        this.errors[0] = "Please pass some parameters to the command";


                    }
                }
                    errors[0] = "**Initial position moved to (" + Default_initial_positionx + "," + Default_initial_positiony + ")**";
            }
            else if(firstname=="drawto")
            {
                float param1=0,param2=0;

                if (Data_storing.List_of_varaiables.Contains(parameters[0]))
                {
                    int index = Data_storing.List_of_varaiables.IndexOf(parameters[0]);
                   param1 = (float)Data_storing.Value_of_varaiables[index];

                }
                else
                {
                    try
                    {

                        param1 = float.Parse(parameters[0]);

                    }
                    catch (FormatException fe)
                    {
                        this.errors[0] = "Please pass some parameters to the command";


                    }
                }
                if (Data_storing.List_of_varaiables.Contains(parameters[1]))
                {
                    int index = Data_storing.List_of_varaiables.IndexOf(parameters[1]);
                    param2 = (float)Data_storing.Value_of_varaiables[index];

                }
                else
                {
                    try
                    {

                        param2 = float.Parse(parameters[1]);

                    }
                    catch (FormatException fe)
                    {
                        this.errors[0] = "Please pass some parameters to the command";


                    }
                }


                this.graphics.DrawLine(Default_Pen, Default_initial_positionx, Default_initial_positiony, param1,param2);
                errors[0] = "**Line drawn to "+parameters[0]+","+parameters[1]+"**";

            }
        }

        public void rotating_Graphics(string[] para)
        {
            try
            {
               float rotating_angle = float.Parse(para[0]);
                Data_storing.rotating_angle = rotating_angle;
                this.errors[0] = "Rotated to " + rotating_angle + " deg";
            }
            catch (FormatException fe)
            {
                this.errors[0] = "Please pass angle in number form(degree)";
            }
        }

        /// <summary>
        /// A method that returns the errors cause by the class to if any misdata has been passed through the application
        /// </summary>
        /// <returns></returns> the array of errors that has been acquired in the application

        public string[] error_handling_code_implementation()
        {
            Data_storing.error_List.AddRange(this.errors);
            return this.errors;
        }
    }
}
