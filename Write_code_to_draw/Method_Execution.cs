using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Write_code_to_draw
{
    public class Method_Execution
    {
        string[] errors = { "", "" };
        public Method_Execution ( string code)
        {
           
            if (code.Contains("method ") && code.Contains("("))
            {

                string[] breaking_method_in_lines = code.Split('\n');

                

                string[] breaking_1st_line = breaking_method_in_lines[0].Split('(');

                string[] breaking_down_for_name = breaking_1st_line[0].Split(' ');
                string name_of_method = breaking_down_for_name[1].Trim();
                Data_storing.names_of_method.Add(name_of_method);
                Data_storing.length_of_method.Add(breaking_method_in_lines.Length);
                breaking_method_in_lines[0] = name_of_method ;
                MessageBox.Show(breaking_method_in_lines[0]);
                Data_storing.Method_code_line.AddRange(breaking_method_in_lines);
               
            }
            else if( code.Contains("(") && code.Contains(")"))
            {
                Validation v;
                string[] splitting_the_code = code.Split('(');
                for (int x=0; x<splitting_the_code.Length;x++)
                {
                    splitting_the_code[x] = splitting_the_code[x].Trim();
                }
                
                if(Data_storing.names_of_method.Contains(splitting_the_code[0]))
                {
                    errors[0] = "**Method called "+ splitting_the_code[0] +"**";

                    int index_starting_of_the_method =Data_storing.Method_code_line.IndexOf(splitting_the_code[0]);
                    int length_of_method =(int)Data_storing.length_of_method[index_starting_of_the_method];
                    for(int i = index_starting_of_the_method+1;i<length_of_method-1;i++)
                    {
                         v= new Validation((string)Data_storing.Method_code_line[i]);
                        this.errors = v.error_handling_validation();
                    }
                }
            }
                else
                {
                    errors[0] = "**There is no such method**";
                }

            }

        public string[] error_handling_method_executiion()
        {
            Data_storing.error_List.AddRange(this.errors);
            return this.errors;
        }
        }

    }

