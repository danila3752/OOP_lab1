using System.Drawing;
using System.Collections.Generic;

namespace OOP_lab12
{
    class Polyline : Point
    {
        private List<Point> points = new List<Point>();

        public Polyline() { }

        public Polyline(Point point)
        {
            points.Add(point);
        }

        public void addPoint(Point p)
        {
            points.Add(p);
        }

        public void addPoint(int x, int y)
        {
            Point p = new Point(x, y);
            points.Add(p);
        }

        protected void setPoint(int i, Point newPoint)
        {
            if (i < points.Count)
            {
                points.Insert(i, newPoint);
            }
            else
            {
                if (i == points.Count)
                {
                    addPoint(newPoint);
                }
            }
        }

        public Point getPoint(int i)
        {
            return (Point)points[i];
        }

        public int getPointsCount()
        {
            return points.Count;
        }

        public void setFinishPoint(Point point)
        {
            if (getPointsCount() < 2)
            {
                addPoint(point);
            }
            else
            {
                setPoint(getPointsCount() - 1, point);
            }
        }

        public void removeLastPoint()
        {
            if (points.Count > 0)
            {
                points.Remove(points[points.Count - 1]);
            }
        }

        public override void draw(Graphics g) 
        {
            g.GetNearestColor(getBorderColor());
            Pen pen = new Pen(getBorderColor(), 2);
            for(int i = 0; i<points.Count-1; i++)
                g.DrawLine(pen, points[i].x, points[i].y, points[i+1].x, points[i+1].y);
            g.DrawLine(pen, points[0].x, points[0].y, points[points.Count-1].x, points[points.Count - 1].y);
        }
    }
}
