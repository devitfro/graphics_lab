using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class MainForm: Form
    {
        private Timer timer;
        private float x = 15;
        private float y = 0;
        private const int squareSize = 50;

        public MainForm()
        {

            this.Text = "Hello animation!";
            this.Size = new Size(700, 500);
            this.BackColor = Color.Beige;
            this.DoubleBuffered = true; // подвійна буферизація (щоб уникнути мерехтіння) - true, малювання відбувається у пам’яті, а потім все разом виводиться на екран.

            timer = new Timer();
            timer.Interval = 30;
            timer.Tick += new EventHandler(UpdateAnimation); // подія, яка викликається кожного разу, коли спрацьовує таймер
            this.Paint += new PaintEventHandler(DrawSquare);
            timer.Start();

        }
        private void UpdateAnimation(object sender, EventArgs e)
        {
            // рух вліво => x зменшується
            x -= 2;
            y = -2.5f * x + 15;

            // Stop, якщо квадрат вийшов за межі екрану
            if (x < -squareSize || y > this.ClientSize.Height)
            {
                //timer.Stop();
                x = 15;
                y = 0;
            }
            this.Invalidate(); // перерисовка
        }

        private void DrawSquare(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Color color = Color.YellowGreen;
            Color borderColor = Color.LightPink;

            using (SolidBrush brush = new SolidBrush(color))
            using (Pen pen = new Pen(borderColor, 2))
            {
                RectangleF square = new RectangleF(x, y, squareSize, squareSize);
                g.FillRectangle(brush, square);
                g.DrawRectangle(pen, x, y, squareSize, squareSize);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
