using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Write_code_to_draw
{
    public class Conditional_execution
    {
        string code =null;
        string[] errors = { "", "" };
        public Conditional_execution(string code)
        {

            this.code=code;
            if(code.Contains('='))
            {
                this.isEqualto_Condition();
            }
            else if (code.Contains('>'))
            {
                this.isGreaterTo_Condition();
            }
            else if (code.Contains('<'))
            {
                this.isLesserto_Condition();
            }
        }

        public void isEqualto_Condition()
        {

            string[] code_splitted = this.code.Split('=');

            string varaiable_name_with_if = code_splitted[0].Trim();

            if(varaiable_name_with_if.Contains(' '))
            {

                string[] splitting_varaiable_name_with_if = varaiable_name_with_if.Split(' ');

                string varaiable_name = splitting_varaiable_name_with_if[1].Trim();

                string[] splitting_using_break_line = code_splitted[1].Split('\n');

                try
                {
                    float given_number = float.Parse(splitting_using_break_line[0]);


                    if (Data_storing.List_of_varaiables.Contains(varaiable_name))
                    {
                        int index = Data_storing.List_of_varaiables.IndexOf(varaiable_name);

                        float varaiable_value = (float)Data_storing.Value_of_varaiables[index];

                        if(given_number == varaiable_value)
                        {

                            Validation vr;
                            for(int i=1; i < splitting_using_break_line.Length-1; i++)
                            {
                                MessageBox.Show(splitting_using_break_line[i]);

                                vr = new Validation(splitting_using_break_line[i]);
                                errors = vr.error_handling_validation();
                            }
                        }
                    }
                    else
                    {
                        errors[0] = "**No such varaiable found**";
                    }
                    
                }
                catch (FormatException e)
                {
                    errors[0] = "**Please pass a integer value**";
                }



            }
            else
            {
                errors[0] = "**Syntax Error**";
            }
        }


        public void isGreaterTo_Condition()
        {

            string[] code_splitted = this.code.Split('>');

            string varaiable_name_with_if = code_splitted[0].Trim();

            if (varaiable_name_with_if.Contains(' '))
            {

                string[] splitting_varaiable_name_with_if = varaiable_name_with_if.Split(' ');

                string varaiable_name = splitting_varaiable_name_with_if[1].Trim();

                string[] splitting_using_break_line = code_splitted[1].Split('\n');

                try
                {
                    float given_number = float.Parse(splitting_using_break_line[0]);


                    if (Data_storing.List_of_varaiables.Contains(varaiable_name))
                    {
                        int index = Data_storing.List_of_varaiables.IndexOf(varaiable_name);

                        float varaiable_value = (float)Data_storing.Value_of_varaiables[index];

                        if (varaiable_value > given_number )
                        {

                            Validation vr;
                            for (int i = 1; i < splitting_using_break_line.Length - 1; i++)
                            {
                                vr = new Validation(splitting_using_break_line[i]);
                                errors = vr.error_handling_validation();
                            }
                        }
                    }
                    else
                    {
                        errors[0] = "**No such varaiable found**";
                    }

                }
                catch (FormatException e)
                {
                    errors[0] = "**Please pass a integer value greater to**";
                }



            }
            else
            {
                errors[0] = "**Syntax Error**";
            }
        }


        public void isLesserto_Condition()
        {

            string[] code_splitted = this.code.Split('<');

            string varaiable_name_with_if = code_splitted[0].Trim();

            if (varaiable_name_with_if.Contains(' '))
            {

                string[] splitting_varaiable_name_with_if = varaiable_name_with_if.Split(' ');

                string varaiable_name = splitting_varaiable_name_with_if[1].Trim();

                string[] splitting_using_break_line = code_splitted[1].Split('\n');

                try
                {
                    float given_number = float.Parse(splitting_using_break_line[0]);


                    if (Data_storing.List_of_varaiables.Contains(varaiable_name))
                    {
                        int index = Data_storing.List_of_varaiables.IndexOf(varaiable_name);

                        float varaiable_value = (float)Data_storing.Value_of_varaiables[index];

                        if (varaiable_value < given_number )
                        {

                            Validation vr;
                            for (int i = 1; i < splitting_using_break_line.Length - 1; i++)
                            {
                                MessageBox.Show(splitting_using_break_line[i]);

                                vr = new Validation(splitting_using_break_line[i]);
                                errors = vr.error_handling_validation();
                            }
                        }
                    }
                    else
                    {
                        errors[0] = "**No such varaiable found**";
                    }

                }
                catch (FormatException e)
                {
                    errors[0] = "**Please pass a integer value**";
                }



            }
            else
            {
                errors[0] = "**Syntax Error**";
            }
        }

        public string[] error_handling_Conditional_execution()
        {
            return this.errors;
        }
    }
}
