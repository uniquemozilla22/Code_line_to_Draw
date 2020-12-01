using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Write_code_to_draw
{
    public class Circle : Shapes
    {

        int radius;
        public void GetValue(int[] param)
        {
            this.radius = param[0];
        }

         public void Draw(Graphics g ,int initial_x, int initial_Y)
        {

        }
    }
}
