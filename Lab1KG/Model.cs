using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Lab1KG
{
    public class Model
    {

        public Point position;
        public Size size;

        private List<BaseShape> _shapes;
        private int _count;

        public Model(int numCycles = 6, float delta = 10f, float scale = 0.05f, float phaze = 0, int size = 200)
        {
            _shapes = new List<BaseShape>();
            this.size = new Size(size, size);
            int oX = 0;
            int oY = 0;

            double X = oX;
            double Y = oY;
            double fi = 0;
            double radius = 0;
            int lastSize = 0;


            Pen pen = new Pen(Color.Red, 1);

            while (Math.Sqrt(X*X + Y*Y) < size/2f - lastSize)
            {
                fi += delta;
                radius = fi * scale;

                X = (radius * Math.Cos((fi + phaze) / 180 * Math.PI)) + oX;
                Y = (radius * Math.Sin((fi + phaze) / 180 * Math.PI)) + oY;
                lastSize = (int)( Math.Sqrt(fi) / 180f * 1000 * scale);
                BaseShape bs = new BaseShape("shape", new Point((int)X, (int)Y), lastSize, pen, false);
                _shapes.Add(bs);
            }
        }

        public void Draw(Graphics graphics) { 

            //graphics.DrawRectangle(new Pen(Color.Black, 3), new Rectangle(position, size));
            Point center = new Point(position.X + size.Width / 2, position.Y + size.Width / 2);
           // graphics.DrawRectangle(new Pen(Color.Black, 3), new Rectangle(new Point(110, 110), size));
            foreach (BaseShape bs in _shapes) {
                bs.Draw(graphics, center);
            }
            
        }

        private bool needNext() {
            return false;
        }
    }
}
