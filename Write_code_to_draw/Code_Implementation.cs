using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Write_code_to_draw
{
    public class Code_Implementation
    {
        string[] errors = { "", "" };
        string firstname;
        Graphics graphics;
        string[] parameters;
        int Default_initial_positionx = 0;
        int Default_initial_positiony = 0;
        public static SolidBrush Default_Brush = new SolidBrush(Color.White);
        public static Pen Default_Pen = new Pen(Color.White);
        public static bool fill = false;

        public Code_Implementation(string firstname , string[] parameters_string, Graphics gr)
        {
            this.firstname = firstname;
            this.graphics = gr;
            this.parameters = parameters_string;
            Shape_decider shape_type = new Shape_decider();
            if (firstname == "moveto" || firstname == "drawto")
            {
                        this.to_implementation();
            }

            else if(firstname == "circle")
            {
                if(parameters_string.Length==1)
                {

                    int[] parameters_int= { 0 };
                    for (int i = 0; i < parameters_string.Length; i++)
                    {
                        parameters_int[i] = int.Parse(parameters_string[i]);

                    }

                    Shapes sh = shape_type.GetShapes("circle");
                    if (fill)
                    {
                        sh.GetValue(parameters_int, Default_Brush);

                    }
                    else
                    {
                        sh.GetValue(parameters_int, Default_Pen);
                    }
                    sh.Draw(graphics, Default_initial_positionx, Default_initial_positiony, fill);
                }
                else
                {
                    errors[0] = "**Pass only a Radius**";
                }

            }
            else if (firstname == "triangle")
            {
                if (parameters_string.Length == 3)
                {

                    int[] parameters_int = { 0 ,0,0};
                    for (int i = 0; i < parameters_string.Length; i++)
                    {
                        parameters_int[i] = int.Parse(parameters_string[i]);

                    }

                    Shapes sh = shape_type.GetShapes("triangle");
                    if (fill)
                    {
                        sh.GetValue(parameters_int, Default_Brush);

                    }
                    else
                    {
                        sh.GetValue(parameters_int, Default_Pen);
                    }
                    sh.Draw(graphics, Default_initial_positionx, Default_initial_positiony, fill);
                }
                else
                {
                    errors[0] = "**Pass legnths for each side**";
                }

            }


            else
            {
                this.errors[0] = "**Not a Valid Code**";
            }

        }

        public void change_parameters_to_int(string[] parameters_string)
        {

           
        }
        public void to_implementation()
        {
            if(firstname=="moveto")
            {

                Default_initial_positionx = int.Parse(parameters[0]);
                Default_initial_positiony = int.Parse(parameters[1]);
                errors[0] = "**Initial position moved to ("+Default_initial_positionx+ ","+Default_initial_positiony+")**";
            }
            else if(firstname=="drawto")
            {

                int param1= int.Parse(parameters[0]);
                int param2 = int.Parse(parameters[1]);

                this.graphics.DrawLine(Default_Pen, Default_initial_positionx, Default_initial_positiony, param1,param2);
                errors[0] = "**Line drawn to "+parameters[0]+","+parameters[1]+"**";

            }
        }


        public string[] error_handling_code_implementation()
        {
            return this.errors;
        }
    }
}
