using System.Drawing;

namespace OOP_lab12
{
    class Rectangle : Shape
    {
        public Point topLeft;
        public int width, height;

        public Rectangle() { }
        public Rectangle(Point top, int Width, int Height)
        {
            topLeft = top;
            width = Width;
            height = Height;
        }


        public override void draw(Graphics g)
        {
            g.GetNearestColor(getBorderColor());
            Pen pen = new Pen(getBorderColor(), 2);
            g.DrawRectangle(pen, topLeft.x, topLeft.y, width, height);
        }
    }
}
