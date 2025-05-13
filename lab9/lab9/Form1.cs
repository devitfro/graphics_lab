using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9
{
    public partial class Form1 : Form
    {
        private double[,] Sq = new double[4, 3]; // Матриця тіла (4 точки × 3 координати)
        private double[,] T = new double[3, 3];  // Матриця перетворення (3x3)

        public Form1()
        {
            InitializeComponent();
            InitFigure();     // Початкове положення фігури
            InitIdentity();   // Одинична матриця
            this.Paint += Form1_Paint;
        }

        // початкові координати квадрату
        private void InitFigure()
        {
            Sq[0, 0] = 0; Sq[0, 1] = 0; Sq[0, 2] = 1;
            Sq[1, 0] = 100; Sq[1, 1] = 0; Sq[1, 2] = 1;
            Sq[2, 0] = 100; Sq[2, 1] = 100; Sq[2, 2] = 1;
            Sq[3, 0] = 0; Sq[3, 1] = 100; Sq[3, 2] = 1;
        }

        // Установка одиничної матриці
        private void InitIdentity()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    T[i, j] = (i == j) ? 1 : 0;
        }

        // Матриця масштабування
        private void SetScaleMatrix(double scale)
        {
            InitIdentity();
            T[0, 0] = scale;
            T[1, 1] = scale;
        }

        // Матриця відображення по осі OX
        private void SetReflectOX()
        {
            InitIdentity();
            T[1, 1] = -1;
        }

        // Матриця повороту
        private void SetRotateMatrix(double angleDegrees)
        {
            double angleRad = angleDegrees * Math.PI / 180;
            InitIdentity();
            T[0, 0] = Math.Cos(angleRad);
            T[0, 1] = -Math.Sin(angleRad);
            T[1, 0] = Math.Sin(angleRad);
            T[1, 1] = Math.Cos(angleRad);
        }

        // Застосування матриці T до фігури Sq
        private void Transform()
        {
            double[] b = new double[3];

            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    b[i] = 0;
                    for (int k = 0; k < 3; k++)
                        b[i] += Sq[j, k] * T[k, i];
                }

                for (int k = 0; k < 3; k++)
                    Sq[j, k] = b[k];
            }

            Normalize();
        }

        private void Normalize()
        {
            for (int j = 0; j < 4; j++)
            {
                Sq[j, 0] /= Sq[j, 2];
                Sq[j, 1] /= Sq[j, 2];
                Sq[j, 2] = 1;
            }
        }
      
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen skyBluePen = new Pen(Brushes.DeepSkyBlue);
            int cx = ClientSize.Width / 2;
            int cy = ClientSize.Height / 2;
            g.DrawLine(skyBluePen, cx, 0, cx, ClientSize.Height);
            g.DrawLine(skyBluePen, 0, cy, ClientSize.Width, cy);

            Pen SqPen = new Pen(Brushes.BlueViolet);
            g.DrawLine(SqPen, (int)(cx + Sq[0, 0]), (int)(cy - Sq[0, 1]), (int)(cx + Sq[1, 0]), (int)(cy - Sq[1, 1]));

            g.DrawLine(SqPen, (int)(cx + Sq[1, 0]), (int)(cy - Sq[1, 1]), (int)(cx + Sq[2, 0]), (int)(cy - Sq[2, 1]));

            g.DrawLine(SqPen, (int)(cx + Sq[2, 0]), (int)(cy - Sq[2, 1]), (int)(cx + Sq[3, 0]), (int)(cy - Sq[3, 1]));

            g.DrawLine(SqPen, (int)(cx + Sq[3, 0]), (int)(cy - Sq[3, 1]), (int)(cx + Sq[0, 0]), (int)(cy - Sq[0, 1]));
        }

        private void buttonScale_Click(object sender, EventArgs e)
        {
            SetScaleMatrix(2);
            Transform();
            Invalidate();
        }

        private void buttonReflectOX_Click(object sender, EventArgs e)
        {
            SetReflectOX();
            Transform();
            Invalidate();
        }

        private void buttonRotate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double angle))
            {
                SetRotateMatrix(angle);
                Transform();
                Invalidate();
            }
            else
            {
                MessageBox.Show("Введіть дійсний кут у градусах.");
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            InitFigure();
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void bttnArrowRight_Click(object sender, EventArgs e) { }

        private void bttnArrowLeft_Click(object sender, EventArgs e) { }

        private void bttnArrowUp_Click(object sender, EventArgs e) { }

        private void bttnArrowDown_Click(object sender, EventArgs e) { }

        private void bttnRotateRight_Click(object sender, EventArgs e) { }

        private void bttnRotateLeft_Click(object sender, EventArgs e) { }

        private void bttnRefresh_Click(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void button4_Click(object sender, EventArgs e) { }
    }
}
