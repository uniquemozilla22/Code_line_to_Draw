using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Write_code_to_draw
{
    public class Validation
    {
        string[] errors = { "", "" };
        string[] code = null;
        Graphics graphic;

        public Validation(string code,Graphics g)
        {
            this.graphic = g;

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
                    Parameters_Implementation();
                }
                else
                {
                    this.errors[0] = "**Not a valid syntax**";
                }
                
            }
        }

        public void Parameters_Implementation()
        {
            string firstname = this.code[0];

            string[] parameters_string = this.code[1].Split(',');
            int[] parameters_int = {0,0,0};


            if (parameters_string.Length <= 0 || parameters_string.Length>=3)
            {
                this.errors[0] = "**Parameters not passed correctly**";
            }
            else
            {
                Code_Implementation im = new Code_Implementation(firstname, parameters_string,this.graphic);
                this.errors = im.error_handling_code_implementation();
                
            }
            

        }


        public string[] error_handling_validation()
        {
            return this.errors;
        }
    }

}
