using System.Drawing;

namespace OOP_lab12
{
    class Triangle : Shape
    {
        public Point top, bottomRight;

        public Triangle() { }

        public Triangle(Point Top, Point BottomRight)
        {
            top = Top;
            bottomRight = BottomRight;
        }

        private Point getBottomLeft()
        {
            int x = 2 * top.x - bottomRight.x;
            int y = bottomRight.y;
            return new Point(x, y);
        }

        public override void draw(Graphics g)
        {
            g.GetNearestColor(getBorderColor());
            Pen pen = new Pen(getBorderColor(), 2);
            Point bottomLeft = getBottomLeft();
            System.Drawing.Point[] points = {new System.Drawing.Point(top.x, top.y),
                new System.Drawing.Point(bottomRight.x, bottomRight.y),
                new System.Drawing.Point(bottomLeft.x, bottomLeft.y)};
            g.DrawPolygon(pen, points);
        }
    }
}
