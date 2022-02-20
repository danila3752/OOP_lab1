using System.Drawing;

namespace OOP_lab12
{
    class Square : Rectangle
    {

        public Square(Point top, int Side) : base(top, Side, Side) { }

        public override void draw(Graphics g)
        {
            g.GetNearestColor(getBorderColor());
            Pen pen = new Pen(getBorderColor(), 2);
            g.DrawRectangle(pen, topLeft.x, topLeft.y, height, width);
        }
    }
}
