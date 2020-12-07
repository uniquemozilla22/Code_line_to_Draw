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



    }
}
