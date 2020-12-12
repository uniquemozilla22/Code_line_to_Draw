using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace Write_code_to_draw
{
    /// <summary>
    /// A class for validating the error output that is shown on the application.
    /// </summary>
    public class Validation
    {
        string[] errors = { "", "" };


        /// <summary>
        /// takes the input and executes the graphic materials.
        /// 
        /// </summary>
        /// <param name="code"></param> the code given by the user for the execution of the programme
        /// <param name="g"></param> Graphics object to draw the shapes and implement the application in the Picturebox
        public Validation(string code)
        {

            if (code == "")
            {

                this.errors[0] = "**Feild is empty**";
            }
            else
            {
                if (code.Contains(';'))
                {
                    string[] multiline = code.Split(';');
                    foreach(string line in multiline)
                    {
                        string code_line = line.ToLower().Trim();
                       
                        Parameters_Implementation(code_line);
                    }
                }
                else
                {

                    code = code.ToLower().Trim();
                    this.Parameters_Implementation(code);
                }
                              


            }
        }
        /// <summary>
        /// Method that is used in the class for executing the parameters and passing them to implement in the code.
        /// </summary>
        public void Parameters_Implementation(string code)
        {

           
            if (code.Contains("loop "))
            {
                MessageBox.Show(code);
                Loop_execution le = new Loop_execution(code);
                this.errors = le.error_handling_loop_execution();
            }
            else if((code.Contains("method ")) || (code.Contains("(")&& code.Contains(")")))
            {
                Method_Execution me = new Method_Execution(code);
                this.errors = me.error_handling_method_executiion();
            }
            else if (code.Contains('=') || code.Contains('+') || code.Contains('%') || code.Contains('-') || code.Contains('/') || code.Contains('*') || code.Contains('<') || code.Contains('>'))
            {
                string check_conditional = code.Trim();

                if(check_conditional.Contains("if "))
                {
                    Conditional_execution ce = new Conditional_execution(code);
                    this.errors = ce.error_handling_Conditional_execution();
                }
               
                else
                {
                    Variables vr = new Variables(code);
                    this.errors = vr.error_handling_variables();
                }
            }

            else {
                string[] code_arr = code.Split(' ');

                if (code_arr.Length!=1)
                {
                    string firstname = code_arr[0];

                    string[] parameters_string = code_arr[1].Split(',');


                    if (parameters_string.Length <= 0)
                    {
                        this.errors[0] = "**Parameters not passed correctly**";
                    }
                    else if (!(code_arr.Length == 1))
                    {
                        for (int x = 0; x < code_arr.Length; x++)
                        {
                            code_arr[x] = code_arr[x].Trim();
                        }

                        Shape_Implementation im = new Shape_Implementation(firstname, parameters_string);
                        this.errors = im.error_handling_code_implementation();
                    }
                    else
                    {
                        this.errors[0] = "**Not a valid syntax**";
                    }
                }
                else if (code_arr[0]!="")
                {
                    this.errors[0] = "**Please pass parameter or see help**";
                }
                
                
            }
            

        }

        /// <summary>
        /// Handling the errors thrown out by the class
        /// </summary>
        /// <returns></returns> array of errors for displaying in the application
        public string[] error_handling_validation()
        {
            Data_storing.error_List.AddRange(this.errors);
            return this.errors;
        }
    }

}
