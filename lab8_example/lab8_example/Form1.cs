using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8_example
{
    public partial class Form1: Form
    {
        //Объявляем переменные доступные в каждом обработчике события
        private Point PreviousPoint, point; //Точка до перемещения курсора мыши
                                            //и текущая точка
        private Bitmap bmp;
        private Pen blackPen;
        private Graphics g;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            blackPen = new Pen(Color.Black, 4); //подготавливаем перо
        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            //открытие файла
            OpenFileDialog dialog = new OpenFileDialog();

            //задаем расширения файлов
            dialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)| *.bmp; *.jpg; *.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            if (dialog.ShowDialog() == DialogResult.OK) //вызываем диалоговое окно
            {
                Image image = Image.FromFile(dialog.FileName); //Загружаем в image изображение из выбранного файла
                                                               
                int width = image.Width;
                int height = image.Height;
                pictureBox1.Width = width;
                pictureBox1.Height = height;

                bmp = new Bitmap(image, width, height); //создаем и загружаем из image изображение в формате bmp
                                                        
                pictureBox1.Image = bmp; //записываем изображение в формате bmp в pictureBox1
                                         
                g = Graphics.FromImage(pictureBox1.Image); //подготавливаем объект Graphics для рисования в pictureBox1
                                                           
            }
        }

        private void pb_MouseDown(object sender, MouseEventArgs e)
        {
            // обработчик события нажатия кнопки на мыши
            // записываем в предыдущую точку (PreviousPoint) текущие координаты
            PreviousPoint.X = e.X;
            PreviousPoint.Y = e.Y;
        }

        private void pb_MouseMove(object sender, MouseEventArgs e)
        {
            //Обработчик события перемещения мыши по pictuteBox1

            if (e.Button == MouseButtons.Left) //Проверяем нажатие левой кнопка
            { //запоминаем в point текущее положение курсора мыши
                point.X = e.X;
                point.Y = e.Y;

                //соединяем линией предыдущую точку с текущей
                g.DrawLine(blackPen, PreviousPoint, point);

                //текущее положение курсора мыши сохраняем в PreviousPoint
                PreviousPoint.X = point.X;
                PreviousPoint.Y = point.Y;
                pictureBox1.Invalidate(); //Принудительно вызываем перерисовку
            }
        }

        private void button_Gray_color(object sender, EventArgs e)
        {
            //циклы для перебора всех пикселей на изображении 
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    int R = bmp.GetPixel(i, j).R; //извлекаем долю красного цвета
                    int G = bmp.GetPixel(i, j).G; //извлекаем долю зеленого цвета
                    int B = bmp.GetPixel(i, j).B; //извлекаем долю синего цвета
                   
                    int Gray = (R = G + B) / 3; // высчитываем среднее
                    Color p = Color.FromArgb(255, Gray, Gray, Gray); //переводим int в значение цвета. 255 - показывает степень прозрачности. остальные значения одинаковы для
                    // трех каналов R,G,B
                    bmp.SetPixel(i, j, p); //записываем полученный цвет в точку
                }
            Refresh(); //вызываем функцию перерисовки окна
        }

 

        private void button_Save_Click(object sender, EventArgs e)
        {
            //сохранение файла
            SaveFileDialog savedialog = new SaveFileDialog();

            //задаем свойства для savedialog
            savedialog.Title = "Сохранить картинку как ...";
            savedialog.OverwritePrompt = true;
            savedialog.CheckPathExists = true;
            savedialog.Filter =
            "Bitmap File(*.bmp)|*.bmp|" +
            "GIF File(*.gif)|*.gif|" +
            "JPEG File(*.jpg)|*.jpg|" +
            "TIF File(*.tif)|*.tif|" +
            "PNG File(*.png)|*.png";
            savedialog.ShowHelp = true;

            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                // в fileName записываем полный путь к файлу
                string fileName = savedialog.FileName;

                // Убираем из имени три последних символа (расширение файла)
                string strFilExtn = fileName.Remove(0, fileName.Length - 3);

                // Сохраняем файл в нужном формате и с нужным расширением
                switch (strFilExtn)
                {
                    case "bmp":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case "jpg":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case "gif":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case "tif":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Tiff);
                        break;
                    case "png":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    default:
                        break;
                }
            }
        }
        // Налаштувати яскравість, контраст
        private Color AdjustBrightnessContrast(Color color, int brightness, int contrast, int rShift, int gShift, int bShift)
        {
            // Нормалізуємо значення контрасту
            double contrastFactor = (259.0 * (contrast + 255)) / (255 * (259 - contrast));

            int r = color.R + brightness + rShift;
            int g = color.G + brightness + gShift;
            int b = color.B + brightness + bShift;

            // Застосовуємо контраст
            r = (int)(contrastFactor * (r - 128) + 128);
            g = (int)(contrastFactor * (g - 128) + 128);
            b = (int)(contrastFactor * (b - 128) + 128);

            // Обмеження значень до [0, 255]
            r = Math.Min(255, Math.Max(0, r));
            g = Math.Min(255, Math.Max(0, g));
            b = Math.Min(255, Math.Max(0, b));

            return Color.FromArgb(color.A, r, g, b);
        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            ApplyAdjustments();
        }

        private void ApplyAdjustments()
        {
            if (bmp == null) return;

            int brightness = trackBar_Brightness.Value;
            int contrast = trackBar_Contrast.Value;
            int rShift = trackBarRed.Value;
            int gShift = trackBarGreen.Value;
            int bShift = trackBarBlue.Value;

            Bitmap adjusted = new Bitmap(bmp.Width, bmp.Height);
            // не міняємо bmp напряму, щоб кожне регулювання починалося від оригіналу й не накопичувало похибки.

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color original = bmp.GetPixel(i, j);
                    Color newColor = AdjustBrightnessContrast(original, brightness, contrast, rShift, gShift, bShift);
                    adjusted.SetPixel(i, j, newColor);
                }
            }

            pictureBox1.Image = adjusted;
        }

        /// <summary>
        /// Variant 14. Переводить кожен парний рядок (y = 0, 2, 4) у градації сірого.
        /// </summary>

        public static void GrayEveryEvenRow(Bitmap img)
        {
            if (img == null) return;

            for (int y = 0; y < img.Height; y += 2)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    Color pixel = img.GetPixel(x, y);

                    // середнє значення трьох каналів
                    int gray = (pixel.R + pixel.G + pixel.B) / 3;

                    Color grayPixel = Color.FromArgb(255, gray, gray, gray);
                    //переводим int в значение цвета. 255 - показывает степень прозрачности. остальные значения одинаковы для
                    // трех каналов R,G,B
                    img.SetPixel(x, y, grayPixel);
                }
            }
        }

        private void v14_Click(object sender, EventArgs e)
        {
            if (bmp == null) return;

            GrayEveryEvenRow(bmp);

            pictureBox1.Invalidate(); // перерисувати
        }

        private void pb_MouseUp(object sender, MouseEventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private void trackBar3_Scroll(object sender, EventArgs e) { }
    }
}
