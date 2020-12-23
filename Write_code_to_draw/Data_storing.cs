using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Write_code_to_draw
{
    public class Data_storing
    {

        //for Variables execution
        public static ArrayList List_of_varaiables = new ArrayList();
        public static ArrayList Value_of_varaiables = new ArrayList();


        //For method execution
        public static ArrayList names_of_method = new ArrayList();
        public static ArrayList length_of_method = new ArrayList();
        public static ArrayList Method_code_line = new ArrayList();
        public static ArrayList Method_parameters = new ArrayList();
        public static ArrayList method_parameters_value = new ArrayList();
        public static ArrayList index_of_parameter = new ArrayList();

        //for errorhandling
        public static ArrayList error_List = new ArrayList();

        //for rotating the canvas
        public static float rotating_angle = 0;




    }
}

