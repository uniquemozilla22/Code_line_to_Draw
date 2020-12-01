using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Write_code_to_draw
{
    public class Validation
    {
        string[] errors = { "", "" };

        public Validation(string code )
        {

        }


        public string[] error_handling_validation()
        {
            return this.errors;
        }
    }

}
