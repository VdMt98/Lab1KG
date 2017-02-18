using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1KG
{
    public class BaseShape
    {
        public string name;

        public Point position;
        public int size;
        public Pen rectanlePen;
        public Pen circlePen;
        public bool fillShape;


        public BaseShape() {
            this.name = "emptyShape";
            this.position = new Point(100, 100);
            this.size = 100;
            this.rectanlePen = new Pen(Color.Black, 1);
            this.fillShape = false;
        }

        public BaseShape(string name, Point position, int size, Pen pen, bool fillShape) {
            this.name = name;
            this.position = position;
            this.size = size;
            this.rectanlePen = pen;
            this.fillShape = fillShape;
        }


        public void Draw(Graphics graphics, Point center) {
            Point drawPoint = new Point(center.X + position.X, center.Y + position.Y);
            Rectangle rect = new Rectangle(drawPoint, new Size(size, size));
            Rectangle elipse = new Rectangle(drawPoint, new Size(size, size));
            graphics.DrawRectangle(rectanlePen, rect);
            graphics.DrawEllipse(rectanlePen, rect);
        }
    }
}
