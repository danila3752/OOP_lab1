using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_lab12
{
    public partial class Form1 : Form
    {
        Graphics g;
        ShapeList shapeList = new ShapeList();
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            shapeList.add(new Point(160, 80));
            Polyline polyline = new Polyline(new Point(300, 130));
            polyline.addPoint(250, 50);
            polyline.addPoint(200, 60);
            polyline.addPoint(200, 100);
            shapeList.add(polyline);
            shapeList.add(new Ellipse(new Point(120, 220), 150, 70));
            shapeList.add(new Circle(new Point(600, 300), 30));
            shapeList.add(new Rectangle(new Point(340, 100), 170, 100));
            shapeList.add(new Square(new Point(570, 120), 70));
            shapeList.add(new Triangle(new Point(360, 230), new Point(410, 300)));
            shapeList.add(new Right_triangle(new Point(450, 230), new Point(500, 370)));
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            shapeList.draw(g);
        }
    }
}
