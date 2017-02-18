using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1KG
{
    public abstract class BaseShape
    {
        public string name;
        public Point position;
        public Size size;
        public Pen pen;
        public bool fillShape;
        public readonly Graphics graphics;

        public BaseShape(Graphics graphics) {
            this.graphics = graphics;
            this.name = "emptyShape";
            this.position = new Point(0, 0);
            this.size = new Size(10, 10);
            this.pen = new Pen(Color.Black, 1);
            this.fillShape = false;
        }

        public BaseShape(Graphics graphics, string name, Point position, Size size, Pen pen, bool fillShape) {
            this.graphics = graphics;
            this.name = name;
            this.position = position;
            this.size = size;
            this.pen = pen;
            this.fillShape = fillShape;
        }

        public abstract void Draw();
    }
}
