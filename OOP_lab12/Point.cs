using System.Windows.Forms;
using System.Drawing;

namespace OOP_lab12
{
    class Point : Shape
    {
        public int x, y;

        public Point() { }

        public Point(Point point)
        {
            this.x = point.x;
            this.y = point.y;
        }

        public Point(MouseEventArgs e)
        {
            this.x = e.X;
            this.y = e.Y;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override void draw(Graphics g)
        {
            Brush aBrush = (Brush)Brushes.Black;
            g.FillRectangle(aBrush, this.x, this.y, 2, 2);
        }
    }
}
