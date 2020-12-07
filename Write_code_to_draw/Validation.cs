using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Write_code_to_draw
{
    /// <summary>
    /// A class for validating the error output that is shown on the application.
    /// </summary>
    public class Validation
    {
        string[] errors = { "", "" };
        string[] code = null;

        /// <summary>
        /// takes the input and executes the graphic materials.
        /// 
        /// </summary>
        /// <param name="code"></param> the code given by the user for the execution of the programme
        /// <param name="g"></param> Graphics object to draw the shapes and implement the application in the Picturebox
        public Validation(string code)
        {

            if (code == "" )
            {

                this.errors[0] = "**Feild is empty**";
            }
            else 
            {
                code = code.ToLower().Trim();
                this.code = code.Split(' ');
                if(!(this.code.Length==1))
                {
                    for (int i = 0; i < this.code.Length; i++)
                    {
                        this.code[i] = this.code[i].Trim();
                    }
                    Parameters_Implementation(code);
                }
                else
                {
                    this.errors[0] = "**Not a valid syntax**";
                }
                
            }
        }
        /// <summary>
        /// Method that is used in the class for executing the parameters and passing them to implement in the code.
        /// </summary>
        public void Parameters_Implementation(string code)
        {
            string firstname = this.code[0];

            string[] parameters_string = this.code[1].Split(',');


            if (parameters_string.Length <= 0 || parameters_string.Length>=4)
            {
                this.errors[0] = "**Parameters not passed correctly**";
            }
            else if (code.Contains('='))
            {
                Variables vr = new Variables(code);
                this.errors = vr.error_handling_variables();
            }
            else
            {
                Shape_Implementation im = new Shape_Implementation(firstname, parameters_string);
                this.errors = im.error_handling_code_implementation();
                
            }
            

        }

        /// <summary>
        /// Handling the errors thrown out by the class
        /// </summary>
        /// <returns></returns> array of errors for displaying in the application
        public string[] error_handling_validation()
        {
            return this.errors;
        }
    }

}
