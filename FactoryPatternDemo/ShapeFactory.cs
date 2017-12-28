using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{
    class ShapeFactory
    {
        public Shape getShape(string shapeType)
        {
            if (shapeType == null)
                return null;

            if (shapeType.Equals("Circle"))
                return new Circle();
            else if (shapeType.Equals("Rectangle"))
                return new Rectangle();

            return null;
        }
    }
}
