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
        public Color color;
        public bool fillShape;

        public BaseShape() {
            this.name = "emptyShape";
            this.position = new Point(0, 0);
            this.size = new Size(10, 10);
            this.color = Color.Black;
            this.fillShape = false;
        }

        public BaseShape(string name, Point position, Size size, Color color, bool fillShape) {
            this.name = name;
            this.position = position;
            this.size = size;
            this.color = color;
            this.fillShape = fillShape;
        }

        public abstract void Draw();
    }
}
