using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Write_code_to_draw
{
    /// <summary>
    /// class to return the shapes
    /// </summary>
    public class Shape_decider
    {

        /// <summary>
        /// A class that takes the name of the shape to be passed and executes the programme to show the shape in the picturebox
        /// </summary>
        /// <param name="shape_type"></param> the name of the shape that has been requested theough the application code
        /// <returns></returns> the interface of the shapes that has been called in the application by the user
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
            else if (shape_type == "polygon")
            {
                return new Polygon();
            }
            return null;
        }
    }
}
