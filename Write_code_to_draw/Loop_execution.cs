using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Write_code_to_draw

{
    public class Loop_execution
    {

        string code = null;
        string[] errors = { "", "" };
        public Loop_execution(string code)
          {
            this.code = code;
            
            string[] breaking_lines = code.Split('\n');
            for(int i =0; i<breaking_lines.Length;i++)
            {
                breaking_lines[i] = breaking_lines[i].Trim();
            }
            string[] breaking_the_first_line = breaking_lines[0].Split(' ');
            if (breaking_the_first_line.Length == 3)
            {
                string varaible_name_given_by_the_user = breaking_the_first_line[breaking_the_first_line.Length-1];

                if (Data_storing.List_of_varaiables.Contains(varaible_name_given_by_the_user))
                {
                    this.loop_processing(breaking_lines, varaible_name_given_by_the_user);

                }
                else
                {
                    errors[0] = "**Invalid variable for the loop**";
                }


            }
            else
            {
                errors[0] = "**Loop Syntax error**";
            }
                
          }

        public void loop_processing(string[] lines, string name_of_varaible)
        {
            int index_of_Varable = Data_storing.List_of_varaiables.IndexOf(name_of_varaible);
            float value_of_the_varable = (float)Data_storing.Value_of_varaiables[index_of_Varable];
            Validation vr;

            for (int i =1;i<=value_of_the_varable;i++)
            {
                for (int x = 1; x < lines.Length - 1; x++)
                {
                    if(!lines[x].Contains("endloop"))
                    {
                        vr = new Validation(lines[x]);
                        errors = vr.error_handling_validation();
                    }
                    else
                    {
                        break;
                    }
                }
            }
            
        }

        public string[] error_handling_loop_execution()
        {
            return this.errors;
        }
    }

}
