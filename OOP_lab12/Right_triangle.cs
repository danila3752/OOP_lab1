using System.Drawing;

namespace OOP_lab12
{
    class Right_triangle : Triangle
    {

        public Right_triangle(Point Top, Point BottomRight) : base(Top, BottomRight) { }

        private Point getBottom()
        {
            int x = top.x;
            int y = bottomRight.y;
            return new Point(x, y);
        }

        public override void draw(Graphics g)
        {
            g.GetNearestColor(getBorderColor());
            Pen pen = new Pen(getBorderColor(), 2);
            Point bottomLeft = getBottom();
            System.Drawing.Point[] points = {new System.Drawing.Point(top.x, top.y),
                new System.Drawing.Point(bottomRight.x, bottomRight.y),
                new System.Drawing.Point(bottomLeft.x, bottomLeft.y)};
            g.DrawPolygon(pen, points);
        }
    }
}
