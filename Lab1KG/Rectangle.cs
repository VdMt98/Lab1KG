using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1KG
{
    public class Rectangle : BaseShape
    {
        public Rectangle(Graphics graphics) : 
            base(graphics) { }

        public Rectangle(Graphics graphics, string name, Point position, Size size, Pen pen, bool fillShape) : 
            base(graphics, name, position, size, pen, fillShape) { }


        public override void Draw()
        {
            graphics.DrawRectangle(pen, new System.Drawing.Rectangle());
        }
    }
}
