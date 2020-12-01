﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Write_code_to_draw
{
    public class Shape_decider
    {
        public Shapes GetShapes(string shape_type)
        {
            if (shape_type == "circle")
            {
                return new Circle();
            }
            else if(shape_type == "triangle")
            {
                return new Triangle();
            }
            else if (shape_type == "rectangle")
            {
                return new Rectangle();
            }
            return null;
        }
    }
}
