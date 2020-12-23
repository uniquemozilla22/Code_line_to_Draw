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
                string[] parameter_recognizer = breaking_1st_line[1].Split(')');
               

                string[] breaking_down_for_name = breaking_1st_line[0].Split(' ');
                string name_of_method = breaking_down_for_name[1].Trim();
                Data_storing.names_of_method.Add(name_of_method);
                Data_storing.length_of_method.Add(breaking_method_in_lines.Length);
                breaking_method_in_lines[0] = name_of_method ;
                Data_storing.Method_code_line.AddRange(breaking_method_in_lines);
                if (parameter_recognizer[0].Contains("parameter "))
                {
                    string parameter = parameter_recognizer[0].Trim();
                    string[] parameter_code = parameter.Split(' ');
                    string joined_parameter =parameter_code[1];

                    Data_storing.List_of_varaiables.Add(joined_parameter);
                    Data_storing.Value_of_varaiables.Add(0);
                    Data_storing.index_of_parameter.Add(Data_storing.List_of_varaiables.IndexOf(joined_parameter));

                }
            }
            else if( code.Contains("(") && code.Contains(")"))
            {

                Validation v;
                string[] splitting_the_code = code.Split('(');
                for (int x = 0; x < splitting_the_code.Length; x++)
                {
                    splitting_the_code[x] = splitting_the_code[x].Trim();
                }
                string[] parameter_recognizer = splitting_the_code[1].Split(')');
                string parameter = parameter_recognizer[0].Trim();



                if (Data_storing.names_of_method.Contains(splitting_the_code[0]))
                {

                    if (Data_storing.List_of_varaiables.Contains(parameter))
                    {

                        int index = Data_storing.List_of_varaiables.IndexOf(parameter);
                        int index_of_parameter = (int)Data_storing.index_of_parameter[Data_storing.names_of_method.IndexOf(splitting_the_code[0])];

                        Data_storing.Value_of_varaiables[index_of_parameter] = Data_storing.Value_of_varaiables[index];

                    }

                    errors[0] = "**Method called " + splitting_the_code[0] + "**";

                    int index_starting_of_the_method = Data_storing.Method_code_line.IndexOf(splitting_the_code[0]);
                    int length_of_method = (int)Data_storing.length_of_method[index_starting_of_the_method];
                    for (int i = index_starting_of_the_method + 1; i < length_of_method - 1; i++)
                    {
                        v = new Validation((string)Data_storing.Method_code_line[i]);
                        this.errors = v.error_handling_validation();
                    }
                }
                else
                {
                    errors[0] = "**There is no such method set **";
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

