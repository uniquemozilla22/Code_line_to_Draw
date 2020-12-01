using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Write_code_to_draw
{
    public class Command_validator
    {
        string[] errors = { "", "" };
        Panel p = new Panel();

        public Command_validator(string code ,string command)
        {
            string comm = command.ToLower().Trim();
            if (comm == "run")
            {
                Validation valid = new Validation(code);
                errors = valid.error_handling_validation();
            }
            else if (comm == "clear")
            {
                p.Clear();
            }
            else if (comm == "reset")
            {
                p.Reset();
            }
            else
            {
                errors[1] = "**Please enter a valid command**";
            }
        }

        public string[] error_command_handler()
        {
            return this.errors;
        }
    }
}
