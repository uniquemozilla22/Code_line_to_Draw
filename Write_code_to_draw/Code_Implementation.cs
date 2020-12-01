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
        int[] parameters;
        Graphics graphics;
        int Default_initial_positionx = 0;
        int Default_initial_positiony = 0;
        Brush Default_Brush = new SolidBrush(Color.White);
        Pen Default_Pen = new Pen(Color.White);

        public Code_Implementation(string firstname , int[] parameters, Graphics gr)
        {
            this.firstname = firstname;
            this.parameters = parameters;
            this.graphics = gr;
            if (parameters[2]==0 && (firstname == "moveto" || firstname == "drawto"))
            {
                this.to_implementation();
            }
            else
            {
                this.errors[0] = "**Not a Valid Code**";
            }

        }
        public void to_implementation()
        {
            if(firstname=="moveto")
            {

                Default_initial_positionx = parameters[0];
                Default_initial_positiony = parameters[1];
                errors[0] = "**Initial position moved to ("+Default_initial_positionx+ ","+Default_initial_positiony+")**";
            }
            else if(firstname=="drawto")
            {

            }
        }


        public string[] error_handling_code_implementation()
        {
            return this.errors;
        }
    }
}
