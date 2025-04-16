using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace lab6
{
    public class MainForm : Form
    {
        public MainForm()
        {
            this.Text = "Hello world!";
            this.Size = new Size(700, 500);
            this.BackColor = Color.Pink;

            //this.Paint += new PaintEventHandler(MainForm_Paint);
            this.Paint += MainForm_Paint;
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // sky
            SolidBrush skyBrush = new SolidBrush(Color.SkyBlue);
            g.FillRectangle(skyBrush, 0, 0, this.ClientSize.Width, this.ClientSize.Height / 2);

            // grass
            SolidBrush grassBrush = new SolidBrush(Color.Green);
            g.FillRectangle(grassBrush, 0, this.ClientSize.Height / 2, this.ClientSize.Width, this.ClientSize.Height / 2);


            // sun
            SolidBrush sunBrush = new SolidBrush(Color.Yellow);
            g.FillEllipse(sunBrush, 500, 30, 80, 80);

            // house
            SolidBrush houseBrush = new SolidBrush(Color.RosyBrown);
            g.FillRectangle(houseBrush, 250, 200, 200, 150);

            // roof

            SolidBrush roofBrush = new SolidBrush(Color.BurlyWood);
            Point[] roof =
            {
                new Point(240, 200),
                new Point(360, 120),
                new Point(460, 200)
            };
            g.FillPolygon(roofBrush, roof);

            Pen roofPen = new Pen(Color.SaddleBrown, 3);
            g.DrawPolygon(roofPen, roof);

            //SolidBrush roofBrush = new SolidBrush(Color.BurlyWood);
            //Point[] halfRoof =
            //{
            //    new Point(240, 200),
            //    new Point(360, 120),
            //    new Point(350, 200)
            //};
            //g.FillPolygon(roofBrush, halfRoof);

            //Pen roofPen = new Pen(Color.SaddleBrown, 3);

            //Point[] roof =
            //{
            //    new Point(240, 200),
            //    new Point(360, 120),
            //    new Point(460, 200)
            //};
            //g.DrawPolygon(roofPen, roof);

            // window
            SolidBrush windowBrush = new SolidBrush(Color.LightPink);
            g.FillRectangle(windowBrush, 350, 240, 55, 55);
            //g.FillRectangle(windowBrush, 350, 240, 55, 55);


            // door
            SolidBrush doorBrush = new SolidBrush(Color.Gray);
            g.FillRectangle(doorBrush, 290, 280, 40, 70);

            // tree 1
            SolidBrush treeTrunk = new SolidBrush(Color.Brown);
            SolidBrush treeLeaves = new SolidBrush(Color.DarkGreen);
            g.FillRectangle(treeTrunk, 100, 250, 20, 80);
            g.FillEllipse(treeLeaves, 80, 200, 60, 60);
            g.FillEllipse(treeLeaves, 70, 230, 80, 60);

            // tree 2
            SolidBrush treeTrunk2 = new SolidBrush(Color.Brown);
            SolidBrush treeLeaves2 = new SolidBrush(Color.DarkGreen);
            g.FillRectangle(treeTrunk2, 180, 250, 20, 80);
            g.FillEllipse(treeLeaves2, 160, 200, 60, 60);
            g.FillEllipse(treeLeaves2, 150, 230, 80, 60);

            // tree 3
            SolidBrush treeTrunk3 = new SolidBrush(Color.Brown);
            SolidBrush treeLeaves3 = new SolidBrush(Color.DarkGreen);
            g.FillRectangle(treeTrunk3, 30, 250, 20, 80);
            g.FillEllipse(treeLeaves3, 10, 200, 60, 60);
            g.FillEllipse(treeLeaves3, 0, 230, 80, 60);

            // забор
            Pen fencePen = new Pen(Color.Yellow, 3);
            fencePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            // Рисуем забор из вертикальных линий
            int fenceHeight = this.ClientSize.Height / 2;

            for (int i = 20; i < this.ClientSize.Width - 450; i+= 50)
            {
                g.DrawLine(fencePen, i, fenceHeight + 70, i, this.ClientSize.Height);
            }

            for (int i = fenceHeight + 70; i < this.ClientSize.Height; i += 35) 
            {
                g.DrawLine(fencePen, 0, i, this.ClientSize.Width - 450, i); 
            }
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new MainForm());
        }
    }
}
