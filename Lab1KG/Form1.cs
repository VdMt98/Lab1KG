using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1KG
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            InitRedrawTimer();
        }

        private void InitRedrawTimer() {
            var timer = new Timer();
            timer.Interval = 1000 / 10;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            Draw();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Draw();
        }

        int i = 360;
        public void Draw() {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            Size pictureSize = pictureBox1.Size;
            i -= 5;
            if (i < 5)
                i = 360;
            Model model1 = new Model(6, 15, 0.1f, i);
            model1.position = new Point(10, 10);
            model1.size = new Size(200, 200);
            model1.Draw(g);
        }
    }
}
