using System;
using System.Drawing;

namespace OOP_lab12
{
    class Ellipse : Shape
    {
        public Point fixedPoint, movingPoint;

        public Ellipse(Point topLeft, int width, int height)
        {
            fixedPoint = topLeft;
            movingPoint = new Point(topLeft.x + width, topLeft.y + height);
        }

        public override void draw(Graphics g)
        {
            g.GetNearestColor(getBorderColor());
            Pen pen = new Pen(getBorderColor(), 2);
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(fixedPoint.x, fixedPoint.y, movingPoint.x - fixedPoint.x, movingPoint.y - fixedPoint.y);
            g.DrawEllipse(pen, rect);
        }
    }
}
