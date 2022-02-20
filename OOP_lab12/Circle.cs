using System.Drawing;
using System;

namespace OOP_lab12
{
    class Circle : Ellipse 
    {
        public Circle(Point center, int radius) : base(new Point(center.x - radius, center.y - radius), radius * 2, radius * 2) { }

    }
}
