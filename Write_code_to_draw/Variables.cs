using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Write_code_to_draw
{
    public class Variables
    {

        public string[] error = { "", "" };
        public Variables(string code)
        {
            string[] code_array = code.Split('=');
            for (int i=0; i<code_array.Length;i++)
            {
                code_array[i] = code_array[i].Trim();
            }

            if(code_array.Length==2)
            {
                string trimmed_code = string.Join("=", code_array);
                Data_storing.List_of_varaiables.Add(trimmed_code);
            }
            else
            {
                this.error[0] = "Syntax is not correct";
            }
        }

        public string[] error_handling_variables()
        {
            return this.error;
        }
    }
}
