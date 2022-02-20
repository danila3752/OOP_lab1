using System.Drawing;
using System.Collections.Generic;

namespace OOP_lab12
{
    class ShapeList
    {
        private List<Shape> shapeList;

        public ShapeList()
        {
            this.shapeList = new List<Shape>();
        }

        public ShapeList(List<Shape> shapeList)
        {
            this.shapeList = shapeList;
        }

        public void add(Shape shape)
        {
            shapeList.Add(shape);
        }

        public void draw(Graphics g)
        {
            foreach(Shape shape in shapeList)
            {
                shape.draw(g);
            }
        }
    }
}
