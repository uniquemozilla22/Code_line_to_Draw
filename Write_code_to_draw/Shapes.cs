using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Write_code_to_draw
{
    public interface Shapes
    {
        void Draw(Graphics G, int x, int y,bool fill);

        void GetValue(int[] parameters,Pen Default_Pen);

        void GetValue(int[] parameters, Brush Default_Brush);


    }
}
