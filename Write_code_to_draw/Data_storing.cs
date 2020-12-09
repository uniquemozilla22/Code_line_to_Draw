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
        public static ArrayList code_lines = new ArrayList();
        public static ArrayList List_of_varaiables = new ArrayList();
        public static ArrayList Value_of_varaiables = new ArrayList();


        public static void logging_theList()
        {
            string x = "";
            string y = "";
            for(int i =0; i<List_of_varaiables.Count;i++)
            {
                x += List_of_varaiables[i];
                y += Value_of_varaiables[i];

            }
            MessageBox.Show(x+"="+y);

        }

        public static void logging_theLines()
        {

            string x = "";
            string y = "";
            for (int i = 0; i < code_lines.Count; i++)
            {
                x += code_lines[i];
                MessageBox.Show(x + "=" + code_lines.Count);


            }
        }



    }
}
