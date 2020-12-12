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
        string code;
        public Variables(string code)
        {
            this.code = code;
           if(code.Contains("="))
            {
                this.Storing_the_variables();
                this.error[0] = "Varaiable executed";
            }
            else if (code.Contains("+"))
            {
                this.adding_to_the_variables();
            }
            else if (code.Contains("-"))
            {
                this.subtracting_to_the_variables();
            }
            else if (code.Contains("*"))
            {
                this.multiplying_to_the_variables();
            }
            else if (code.Contains("%"))
            {
                this.remaining_to_the_variables();
            }
            else if (code.Contains("/"))
            {
                this.dividing_to_the_variables();
            }

        }

        public void Storing_the_variables()
        {
            string[] code_array = code.Split('=');
            for (int i = 0; i < code_array.Length; i++)
            {
                code_array[i] = code_array[i].Trim();
            }

            if (code_array.Length == 2)
            {
                try
                {
                    float passed_data = float.Parse(code_array[1]);

                    if (Data_storing.List_of_varaiables.Contains(code_array[0]))
                    {

                        int index = Data_storing.List_of_varaiables.IndexOf(code_array[0]);
                        Data_storing.Value_of_varaiables[index] = passed_data;
                    }
                    else
                    {
                        Data_storing.List_of_varaiables.Add(code_array[0]);
                        Data_storing.Value_of_varaiables.Add(passed_data);

                    }
                }
                catch (Exception)
                {
                    this.error[0] = "**Please pass a number to the variable**";
                }

            }
            else
            {
                this.error[0] = "**Syntax is not correct for variables**";
            }
        }

        public void adding_to_the_variables()
        {
            string[] code_array = code.Split('+');
            for (int i = 0; i < code_array.Length; i++)
            {
                code_array[i] = code_array[i].Trim();
            }

            if (code_array.Length == 2)
            {
                try
                {
                    
                    float passed_data = float.Parse(code_array[1]);
                    if (Data_storing.List_of_varaiables.Contains(code_array[0]))
                    {
                        int index = Data_storing.List_of_varaiables.IndexOf(code_array[0]);
                        float value_of_the_variable= (float)Data_storing.Value_of_varaiables[index];

                        float sum_of_data = passed_data + value_of_the_variable;

                        Data_storing.Value_of_varaiables[index] = sum_of_data;

                    }
                    else
                    {
                        this.error[0] = "Not a valid varable name";
                    }

                   

                }
                catch (Exception)
                {
                    this.error[0] = "**Please pass a adding number to the variable**";
                }
            }
            else
            {
                this.error[0] = "**Syntax is not correct for adding variables**";
            }
        }

        public void dividing_to_the_variables()
        {
            string[] code_array = code.Split('/');
            for (int i = 0; i < code_array.Length; i++)
            {
                code_array[i] = code_array[i].Trim();
            }

            if (code_array.Length == 2)
            {
                try
                {

                    float passed_data = float.Parse(code_array[1]);
                    if (Data_storing.List_of_varaiables.Contains(code_array[0]))
                    {
                        int index = Data_storing.List_of_varaiables.IndexOf(code_array[0]);
                        float value_of_the_variable = (float)Data_storing.Value_of_varaiables[index];

                        float sum_of_data = value_of_the_variable/ passed_data;

                        Data_storing.Value_of_varaiables[index] = sum_of_data;

                    }
                    else
                    {
                        this.error[0] = "Not a valid varable name";
                    }



                }
                catch (Exception)
                {
                    this.error[0] = "**Please pass a dividing number to the variable**";
                }
            }
            else
            {
                this.error[0] = "**Syntax is not correct for dividing variables**";
            }
        }
        public void remaining_to_the_variables()
        {
            string[] code_array = code.Split('%');
            for (int i = 0; i < code_array.Length; i++)
            {
                code_array[i] = code_array[i].Trim();
            }

            if (code_array.Length == 2)
            {
                try
                {

                    float passed_data = float.Parse(code_array[1]);
                    if (Data_storing.List_of_varaiables.Contains(code_array[0]))
                    {
                        int index = Data_storing.List_of_varaiables.IndexOf(code_array[0]);
                        float value_of_the_variable = (float)Data_storing.Value_of_varaiables[index];

                        float sum_of_data = value_of_the_variable % passed_data;

                        Data_storing.Value_of_varaiables[index] = sum_of_data;

                    }
                    else
                    {
                        this.error[0] = "Not a valid varable name";
                    }



                }
                catch (Exception)
                {
                    this.error[0] = "**Please pass a Moduling number to the variable**";
                }
            }
            else
            {
                this.error[0] = "**Syntax is not correct for moduling variables**";
            }
        }

        public void multiplying_to_the_variables()
        {
            string[] code_array = code.Split('*');
            for (int i = 0; i < code_array.Length; i++)
            {
                code_array[i] = code_array[i].Trim();
            }

            if (code_array.Length == 2)
            {
                try
                {

                    float passed_data = float.Parse(code_array[1]);
                    if (Data_storing.List_of_varaiables.Contains(code_array[0]))
                    {
                        int index = Data_storing.List_of_varaiables.IndexOf(code_array[0]);
                        float value_of_the_variable = (float)Data_storing.Value_of_varaiables[index];

                        float sum_of_data = passed_data * value_of_the_variable;

                        Data_storing.Value_of_varaiables[index] = sum_of_data;

                    }
                    else
                    {
                        this.error[0] = "Not a valid varable name";
                    }



                }
                catch (Exception)
                {
                    this.error[0] = "**Please pass a multypling number to the variable**";
                }
            }
            else
            {
                this.error[0] = "**Syntax is not correct for multypling variables**";
            }
        }

        public void subtracting_to_the_variables()
        {
            string[] code_array = code.Split('-');
            for (int i = 0; i < code_array.Length; i++)
            {
                code_array[i] = code_array[i].Trim();
            }

            if (code_array.Length == 2)
            {
                try
                {

                    float passed_data = float.Parse(code_array[1]);
                    if (Data_storing.List_of_varaiables.Contains(code_array[0]))
                    {
                        int index = Data_storing.List_of_varaiables.IndexOf(code_array[0]);
                        float value_of_the_variable = (float)Data_storing.Value_of_varaiables[index];

                        float sum_of_data =value_of_the_variable-passed_data;

                        Data_storing.Value_of_varaiables[index] = sum_of_data;

                    }
                    else
                    {
                        this.error[0] = "Not a valid varable name";
                    }



                }
                catch (Exception)
                {
                    this.error[0] = "**Please pass a subtracting number to the variable**";
                }
            }
            else
            {
                this.error[0] = "**Syntax is not correct for subtracting variables**";
            }
        }
        public string[] error_handling_variables()
        {
            Data_storing.error_List.AddRange(this.error);

            return this.error;
        }
    }
}
