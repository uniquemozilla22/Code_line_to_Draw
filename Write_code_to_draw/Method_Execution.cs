using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Write_code_to_draw
{
    public class Method_Execution
    {
        string[] errors = { "", "" };
        string[] code = null;
        public Method_Execution ( string code)
        {
            if(code.Contains("method ") && code.Contains("("))
            {

                string[] breaking_method_in_lines = code.Split('\n');

                for (int i = 0; i < breaking_method_in_lines.Length; i++)
                {
                    this.code[i] = breaking_method_in_lines[i].Trim();
                }

                string[] breaking_1st_line = breaking_method_in_lines[0].Split('(');

                string[] breaking_down_for_name = breaking_1st_line[0].Split(' ');
                string name_of_method = breaking_down_for_name[2].Trim();
                Data_storing.names_of_method.Add(name_of_method);
                Data_storing.Method_code_line.AddRange(breaking_method_in_lines);
            }
            else if( !code.Contains("method ") && code.Contains("(") && code.Contains("("))
            {
                string[] splitting_the_code = code.Split('(');
                for (int i=0; i<splitting_the_code.Length;i++)
                {
                    splitting_the_code[i] = splitting_the_code[i].Trim();
                }
                if(Data_storing.names_of_method.Contains(splitting_the_code[1]))
                {

                }
                else
                {
                    errors[0] = "**There is no such method**";
                }

            }
        }

        public void 
    }
}
