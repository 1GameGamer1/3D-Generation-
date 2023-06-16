using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КПЗ
{
    public partial class Form1 : Form
    {
        const int x = 600, y = 400; const float k =(float) 0.09;
        public void Circle(int x, int y)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen myPen = new Pen(Color.Red);
           
            g.DrawEllipse(myPen, x, y, 6, 6);
            
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        #region Оси
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible=false;
            button5.Visible = true;
            Pen myPen2 = new Pen(Color.Black);
            //int X = 300, Y = 480;
            Graphics g = pictureBox1.CreateGraphics();
            
            Circle(x-3, y-2);

            //double R = Math.Floor(-k * X * Math.Cos(30) + k * y * Math.Cos(30));
            //double Q = Math.Floor(-k * X * Math.Cos(30) - k * y * Math.Cos(30) + k * 0);

            //int R1 = (int)Math.Round(R);
            //int Q1 = (int)Math.Round(Q);

            //R = Math.Floor(-k * x * Math.Cos(30) + k * Y * Math.Cos(30));
            //Q = Math.Floor(-k * x * Math.Cos(30) - k * Y * Math.Cos(30) + k * 0);
            //R1 = (int)Math.Round(R);
            //Q1 = (int)Math.Round(Q);

            //X
            int Xx = (int)Math.Round(x - 2000 * Math.Cos(30)), Xy = (int)Math.Round(y + 2000 * k);
            Point[] points = new Point[2];
            points[0] = new Point(x, y);
            points[1] = new Point(Xx, Xy);
            g.DrawLines(myPen2, points);

            //Y
            int Yx = (int)Math.Round(x + 2000 * Math.Cos(30)), Yy = (int)Math.Round(y + 2000 * k);
            points[0] = new Point(x, y);
            points[1] = new Point(Yx, Yy);
            g.DrawLines(myPen2, points);

            //Z
            points[0] = new Point(x, y);
            points[1] = new Point(x, y-300);
            g.DrawLines(myPen2, points);

            ////line
            //Point[] points1 = new Point[2];
            //points1[0] = new Point(x + 1000, y);
            //points1[1] = new Point(x - 1000, y);
            //g.DrawLines(myPen2, points1);

        }
        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            button1.Visible = true;
            Pen myPen2 = new Pen(Color.White);
            //int X = 300, Y = 480;
            Graphics g = pictureBox1.CreateGraphics();

            g.DrawEllipse(myPen2, x-3, y-2, 6, 6);

            //X
            int Xx = (int)Math.Round(x - 2000 * Math.Cos(30)), Xy = (int)Math.Round(y + 2000 * k);
            Point[] points = new Point[2];
            points[0] = new Point(x, y);
            points[1] = new Point(Xx, Xy);
            g.DrawLines(myPen2, points);

            //Y
            int Yx = (int)Math.Round(x + 2000 * Math.Cos(30)), Yy = (int)Math.Round(y + 2000 * k);
            points[0] = new Point(x, y);
            points[1] = new Point(Yx, Yy);
            g.DrawLines(myPen2, points);

            //Z
            points[0] = new Point(x, y);
            points[1] = new Point(x, y - 300);
            g.DrawLines(myPen2, points);

        }
        #endregion

        #region Платформа
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                button2.Visible = false;
                button6.Visible = true;

            int n = Int32.Parse(textBox1.Text);//1200 (x)
            int b = Int32.Parse(textBox2.Text);//1920 (y)
            int m = Int32.Parse(textBox3.Text); 
            Graphics g = pictureBox1.CreateGraphics();
                Color col = Color.FromArgb(100, 80, 80); ;
                //Flat
                System.Drawing.SolidBrush myPen = new System.Drawing.SolidBrush(col);
                //X
                int XxL = (int)Math.Round(x - n * Math.Cos(30)), XyL = (int)Math.Round(y + n * k);
            Point[] points = new Point[4];
            points[0] = new Point(x, y - m);
            points[1] = new Point(XxL, XyL - m);

            //Y
            int YxL = (int)Math.Round(x + b * Math.Cos(30)), YyL = (int)Math.Round(y + b * k);
            points[3] = new Point(YxL, YyL - m);

            int YxL1 = (int)Math.Round(XxL + b * Math.Cos(30)), YyL1 = (int)Math.Round(XyL + b * k);
            points[2] = new Point(YxL1, YyL1 - m);

            

            //points[0] = new Point(YxL, YyL - m);
            //points[1] = new Point(YxL1, YyL1 - m);
            g.FillPolygon(myPen, points);

                //int XxL1, XyL1;
                //Pen myPen3 = new Pen(Color.Blue);
                //for (int i = 1; i < 10; i++)
                //{
                //    YxL = (int)Math.Round(x + (b - i * b / 10) * Math.Cos(30)); YyL = (int)Math.Round(y + (b - i * b / 10) * k);
                //    YxL1 = (int)Math.Round(XxL + (b - i * b / 10) * Math.Cos(30)); YyL1 = (int)Math.Round(XyL + (b - i * b / 10) * k);
                //    //Thread.Sleep(100);

                //    points[0] = new Point(YxL, YyL - m);
                //    points[1] = new Point(YxL1, YyL1 - m);
                //    g.DrawLines(myPen3, points);
                //}


                //YxL = (int)Math.Round(x + b * Math.Cos(30)); YyL = (int)Math.Round(y + b * k);
                //YxL1 = (int)Math.Round(XxL + b * Math.Cos(30)); YyL1 = (int)Math.Round(XyL + b * k);
                //for (int i = 1; i < 10; i++)
                //{
                //    XxL = (int)Math.Round(x - (n - i * n / 10) * Math.Cos(30)); XyL = (int)Math.Round(y + (n - i * n / 10) * k);
                //    XxL1 = (int)Math.Round(YxL - (n - i * n / 10) * Math.Cos(30)); XyL1 = (int)Math.Round(YyL + (n - i * n / 10) * k);
                //    //Thread.Sleep(100);

                //    points[0] = new Point(XxL, XyL - m);
                //    points[1] = new Point(XxL1, XyL1 - m);
                //    g.DrawLines(myPen3, points);

                //}
            }
            catch (Exception ex) //Проверка на наличие исключений
            {
                MessageBox.Show("Error: " + ex.Message);//Вывод сообщения если исключения найдены
                return; //Заканчиваем обработку
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                button6.Visible = false;
                button2.Visible = true;
                int n = Int32.Parse(textBox1.Text);//1200 (x)
                int b = Int32.Parse(textBox2.Text);//1920 (y)
                int m = Int32.Parse(textBox3.Text);
                Graphics g = pictureBox1.CreateGraphics();
                //Flat
                Pen myPen3 = new Pen(Color.White);
                //X
                int XxL = (int)Math.Round(x - n * Math.Cos(30)), XyL = (int)Math.Round(y + n * k);
                Point[] points = new Point[2];
                points[0] = new Point(x, y - m);
                points[1] = new Point(XxL, XyL - m);
                g.DrawLines(myPen3, points);

                //Y
                int YxL = (int)Math.Round(x + b * Math.Cos(30)), YyL = (int)Math.Round(y + b * k);
                points[0] = new Point(x, y - m);
                points[1] = new Point(YxL, YyL - m);
                g.DrawLines(myPen3, points);

                int YxL1 = (int)Math.Round(XxL + b * Math.Cos(30)), YyL1 = (int)Math.Round(XyL + b * k);
                points[0] = new Point(XxL, XyL - m);
                points[1] = new Point(YxL1, YyL1 - m);
                g.DrawLines(myPen3, points);

                int XxL1, XyL1;

                points[0] = new Point(YxL, YyL - m);
                points[1] = new Point(YxL1, YyL1 - m);
                g.DrawLines(myPen3, points);

                for (int i = 1; i < 10; i++)
                {
                    YxL = (int)Math.Round(x + (b - i * b / 10) * Math.Cos(30)); YyL = (int)Math.Round(y + (b - i * b / 10) * k);
                    YxL1 = (int)Math.Round(XxL + (b - i * b / 10) * Math.Cos(30)); YyL1 = (int)Math.Round(XyL + (b - i * b / 10) * k);
                    //Thread.Sleep(100);

                    points[0] = new Point(YxL, YyL - m);
                    points[1] = new Point(YxL1, YyL1 - m);
                    g.DrawLines(myPen3, points);
                }


                YxL = (int)Math.Round(x + b * Math.Cos(30)); YyL = (int)Math.Round(y + b * k);
                YxL1 = (int)Math.Round(XxL + b * Math.Cos(30)); YyL1 = (int)Math.Round(XyL + b * k);
                for (int i = 1; i < 10; i++)
                {
                    XxL = (int)Math.Round(x - (n - i * n / 10) * Math.Cos(30)); XyL = (int)Math.Round(y + (n - i * n / 10) * k);
                    XxL1 = (int)Math.Round(YxL - (n - i * n / 10) * Math.Cos(30)); XyL1 = (int)Math.Round(YyL + (n - i * n / 10) * k);
                    //Thread.Sleep(100);

                    points[0] = new Point(XxL, XyL - m);
                    points[1] = new Point(XxL1, XyL1 - m);
                    g.DrawLines(myPen3, points);

                }
            }
            catch (Exception ex) //Проверка на наличие исключений
            {
                MessageBox.Show("Error: " + ex.Message);//Вывод сообщения если исключения найдены
                return; //Заканчиваем обработку
            }
        }
        #endregion

        #region Узлы
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                button4.Visible = false;
                button8.Visible = true;
                int n = Int32.Parse(textBox1.Text);//1200 (x)
                int b = Int32.Parse(textBox2.Text);//1920 (y)
                int m = Int32.Parse(textBox3.Text);
                Graphics g = pictureBox1.CreateGraphics();
                int YxL, YyL;
                int XxL1, XyL1;
                Pen myPen = new Pen(Color.Green);
                for (int j = 0; j <= 10; j++)
                {
                    for (int i = 0; i <= 10; i++)
                    {
                        XxL1 = (int)Math.Round(x - (j * n / 10) * Math.Cos(30)); XyL1 = (int)Math.Round(y + (j * n / 10) * k);
                        YxL = (int)Math.Round(XxL1 + (i * b / 10) * Math.Cos(30)); YyL = (int)Math.Round(XyL1 + (i * b / 10) * k);
                        
                        //Thread.Sleep(100);

                        g.DrawEllipse(myPen, YxL-3, YyL-2, 5, 5);
                    }

                }

            }
            catch (Exception ex) //Проверка на наличие исключений
            {
                MessageBox.Show("Error: " + ex.Message);//Вывод сообщения если исключения найдены
                return; //Заканчиваем обработку
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                button8.Visible = false;
                button4.Visible = true;
                int n = Int32.Parse(textBox1.Text);//1200 (x)
                int b = Int32.Parse(textBox2.Text);//1920 (y)
                int m = Int32.Parse(textBox3.Text);
                Graphics g = pictureBox1.CreateGraphics();
                int YxL, YyL;
                int XxL1, XyL1;
                Pen myPen = new Pen(Color.White);
                for (int j = 0; j <= 10; j++)
                {
                    for (int i = 0; i <= 10; i++)
                    {
                        XxL1 = (int)Math.Round(x - (j * n / 10) * Math.Cos(30)); XyL1 = (int)Math.Round(y + (j * n / 10) * k);
                        YxL = (int)Math.Round(XxL1 + (i * b / 10) * Math.Cos(30)); YyL = (int)Math.Round(XyL1 + (i * b / 10) * k);

                        //Thread.Sleep(100);

                        g.DrawEllipse(myPen, YxL - 3, YyL - 2, 5, 5);
                    }

                }

            }
            catch (Exception ex) //Проверка на наличие исключений
            {
                MessageBox.Show("Error: " + ex.Message);//Вывод сообщения если исключения найдены
                return; //Заканчиваем обработку
            }
        }
        #endregion

        #region Большие
        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                //int[] num = new int[8];
                Random rand = new Random();
                Random rand1 = new Random();
                Color rg;
                Pen myPen1 = new Pen(Color.Brown);
                int n = Int32.Parse(textBox1.Text);//1200 (x)
                int b = Int32.Parse(textBox2.Text);//1920 (y)
                int m = Int32.Parse(textBox3.Text);
                Graphics g = pictureBox1.CreateGraphics();
                int YxL, YyL, XxL, XyL;
                int YxL1, YyL1, XxL1, XyL1;
                Point[] points = new Point[2];
                for (int j = 0; j < 10; j++)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (rand.Next(10) <= 6)
                        {
                            XxL1 = (int)Math.Round(x - (j * n / 10) * Math.Cos(30)); XyL1 = (int)Math.Round(y + (j * n / 10) * k);
                            YxL = (int)Math.Round(XxL1 + (i * b / 10) * Math.Cos(30)); YyL = (int)Math.Round(XyL1 + (i * b / 10) * k);

                            for (int jj = 0; jj < 10; jj++)
                            {
                                for (int ii = 0; ii < 10; ii++)
                                {
                                    if (rand1.Next(100) >= 99)
                                    {
                                        rg = Color.FromArgb(rand.Next(200), rand.Next(100,200), 0);
                                        System.Drawing.SolidBrush myPen = new System.Drawing.SolidBrush(rg);
                                        XxL = (int)Math.Round(YxL - (jj * n / 100) * Math.Cos(30)); XyL = (int)Math.Round(YyL + (jj * n / 100) * k);
                                        YxL1 = (int)Math.Round(XxL + (ii * b / 100) * Math.Cos(30)); YyL1 = (int)Math.Round(XyL + (ii * b / 100) * k);
                                        points[0] = new Point(YxL1, YyL1);
                                        points[1] = new Point(YxL1, YyL1 - 30);
                                        g.FillEllipse(myPen, YxL1-9, YyL1 - 37, 18, 30);
                                        g.DrawLines(myPen1, points);
                                    }
                                }
                            }
                        }

                        
                    }

                }

            }
            catch (Exception ex) //Проверка на наличие исключений
            {
                MessageBox.Show("Error: " + ex.Message);//Вывод сообщения если исключения найдены
                return; //Заканчиваем обработку
            }
        }
        #endregion

        #region  Маленькие 
        private void button10_Click_1(object sender, EventArgs e)
        {
            try
            {
                //int[] num = new int[8];
                Random rand = new Random();
                Random rand1 = new Random();
                Color rg;
                Pen myPen1 = new Pen(Color.Brown);
                int n = Int32.Parse(textBox1.Text);//1200 (x)
                int b = Int32.Parse(textBox2.Text);//1920 (y)
                int m = Int32.Parse(textBox3.Text);
                Graphics g = pictureBox1.CreateGraphics();
                int YxL, YyL, XxL, XyL;
                int YxL1, YyL1, XxL1, XyL1;
                Point[] points = new Point[2];
                for (int j = 0; j < 10; j++)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (rand.Next(10) <= 8)
                        {
                            XxL1 = (int)Math.Round(x - (j * n / 10) * Math.Cos(30)); XyL1 = (int)Math.Round(y + (j * n / 10) * k);
                            YxL = (int)Math.Round(XxL1 + (i * b / 10) * Math.Cos(30)); YyL = (int)Math.Round(XyL1 + (i * b / 10) * k);

                            for (int jj = 0; jj < 10; jj++)
                            {
                                for (int ii = 0; ii < 10; ii++)
                                {
                                    if (rand1.Next(100) >= 99)
                                    {
                                        rg = Color.FromArgb(rand.Next(200), rand.Next(100,200), 0);
                                        System.Drawing.SolidBrush myPen = new System.Drawing.SolidBrush(rg);
                                        XxL = (int)Math.Round(YxL - (jj * n / 100) * Math.Cos(30)); XyL = (int)Math.Round(YyL + (jj * n / 100) * k);
                                        YxL1 = (int)Math.Round(XxL + (ii * b / 100) * Math.Cos(30)); YyL1 = (int)Math.Round(XyL + (ii * b / 100) * k);
                                        points[0] = new Point(YxL1, YyL1);
                                        points[1] = new Point(YxL1, YyL1 - 10);
                                        g.FillEllipse(myPen, YxL1 - 5, YyL1 - 18, 9, 15);
                                        g.DrawLines(myPen1, points);
                                    }
                                }
                            }
                        }
                    }

                }

            }
            catch (Exception ex) //Проверка на наличие исключений
            {
                MessageBox.Show("Error: " + ex.Message);//Вывод сообщения если исключения найдены
                return; //Заканчиваем обработку
            }
        }
        #endregion

        # region Трава
        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                //int[] num = new int[8];
                Random rand = new Random();
                Random rand1 = new Random();
                Color rg;
                int n = Int32.Parse(textBox1.Text);//1200 (x)
                int b = Int32.Parse(textBox2.Text);//1920 (y)
                int m = Int32.Parse(textBox3.Text);
                Graphics g = pictureBox1.CreateGraphics();
                int YxL, YyL, XxL, XyL;
                int YxL1, YyL1, XxL1, XyL1;
                Point[] points = new Point[2];
                for (int j = 0; j < 10; j++)
                {
                    for (int i = 0; i < 10; i++)
                    {
                         XxL1 = (int)Math.Round(x - (j * n / 10) * Math.Cos(30)); XyL1 = (int)Math.Round(y + (j * n / 10) * k);
                         YxL = (int)Math.Round(XxL1 + (i * b / 10) * Math.Cos(30)); YyL = (int)Math.Round(XyL1 + (i * b / 10) * k);

                         for (int jj = 0; jj < 10; jj++)
                         {
                             for (int ii = 0; ii < 10; ii++)
                             {
                                 if (rand1.Next(100) >= 70)
                                 {
                                     rg = Color.FromArgb(rand.Next(200), rand.Next(100, 200), 0);
                                     Pen myPen = new Pen(rg);
                                     XxL = (int)Math.Round(YxL - (jj * n / 100) * Math.Cos(30)); XyL = (int)Math.Round(YyL + (jj * n / 100) * k);
                                     YxL1 = (int)Math.Round(XxL + (ii * b / 100) * Math.Cos(30)); YyL1 = (int)Math.Round(XyL + (ii * b / 100) * k);
                                     points[0] = new Point(YxL1, YyL1);
                                     points[1] = new Point(YxL1, YyL1 - 3);
                                     g.DrawLines(myPen, points);
                                 }
                             }
                         }
                    }

                }

            }
            catch (Exception ex) //Проверка на наличие исключений
            {
                MessageBox.Show("Error: " + ex.Message);//Вывод сообщения если исключения найдены
                return; //Заканчиваем обработку
            }
        }
        #endregion

        private void button7_Click(object sender, EventArgs e)
        {
            #region Платформа
            try
            {
                int n = Int32.Parse(textBox1.Text);//1200 (x)
                int b = Int32.Parse(textBox2.Text);//1920 (y)
                int m = Int32.Parse(textBox3.Text);
                Graphics g = pictureBox1.CreateGraphics();
                Color col = Color.FromArgb(100, 80, 80); ;
                //Flat
                System.Drawing.SolidBrush myPen = new System.Drawing.SolidBrush(col);
                //X
                int XxL = (int)Math.Round(x - n * Math.Cos(30)), XyL = (int)Math.Round(y + n * k);
                Point[] points = new Point[4];
                points[0] = new Point(x, y - m);
                points[1] = new Point(XxL, XyL - m);

                //Y
                int YxL = (int)Math.Round(x + b * Math.Cos(30)), YyL = (int)Math.Round(y + b * k);
                points[3] = new Point(YxL, YyL - m);

                int YxL1 = (int)Math.Round(XxL + b * Math.Cos(30)), YyL1 = (int)Math.Round(XyL + b * k);
                points[2] = new Point(YxL1, YyL1 - m);



                //points[0] = new Point(YxL, YyL - m);
                //points[1] = new Point(YxL1, YyL1 - m);
                g.FillPolygon(myPen, points);

                //int XxL1, XyL1;
                //Pen myPen3 = new Pen(Color.Blue);
                //for (int i = 1; i < 10; i++)
                //{
                //    YxL = (int)Math.Round(x + (b - i * b / 10) * Math.Cos(30)); YyL = (int)Math.Round(y + (b - i * b / 10) * k);
                //    YxL1 = (int)Math.Round(XxL + (b - i * b / 10) * Math.Cos(30)); YyL1 = (int)Math.Round(XyL + (b - i * b / 10) * k);
                //    //Thread.Sleep(100);

                //    points[0] = new Point(YxL, YyL - m);
                //    points[1] = new Point(YxL1, YyL1 - m);
                //    g.DrawLines(myPen3, points);
                //}


                //YxL = (int)Math.Round(x + b * Math.Cos(30)); YyL = (int)Math.Round(y + b * k);
                //YxL1 = (int)Math.Round(XxL + b * Math.Cos(30)); YyL1 = (int)Math.Round(XyL + b * k);
                //for (int i = 1; i < 10; i++)
                //{
                //    XxL = (int)Math.Round(x - (n - i * n / 10) * Math.Cos(30)); XyL = (int)Math.Round(y + (n - i * n / 10) * k);
                //    XxL1 = (int)Math.Round(YxL - (n - i * n / 10) * Math.Cos(30)); XyL1 = (int)Math.Round(YyL + (n - i * n / 10) * k);
                //    //Thread.Sleep(100);

                //    points[0] = new Point(XxL, XyL - m);
                //    points[1] = new Point(XxL1, XyL1 - m);
                //    g.DrawLines(myPen3, points);

                //}
            }
            catch (Exception ex) //Проверка на наличие исключений
            {
                MessageBox.Show("Error: " + ex.Message);//Вывод сообщения если исключения найдены
                return; //Заканчиваем обработку
            }
#endregion

            #region Трава
            try
            {
                Random rand = new Random();
                Random rand1 = new Random();
                Color rg;
                int n = Int32.Parse(textBox1.Text);//1200 (x)
                int b = Int32.Parse(textBox2.Text);//1920 (y)
                int m = Int32.Parse(textBox3.Text);
                Graphics g = pictureBox1.CreateGraphics();
                int YxL, YyL, XxL, XyL;
                int YxL1, YyL1, XxL1, XyL1;
                Point[] points = new Point[2];
                for (int j = 0; j < 10; j++)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        XxL1 = (int)Math.Round(x - (j * n / 10) * Math.Cos(30)); XyL1 = (int)Math.Round(y + (j * n / 10) * k);
                        YxL = (int)Math.Round(XxL1 + (i * b / 10) * Math.Cos(30)); YyL = (int)Math.Round(XyL1 + (i * b / 10) * k);

                        for (int jj = 0; jj < 10; jj++)
                        {
                            for (int ii = 0; ii < 10; ii++)
                            {
                                if (rand1.Next(100) >= 50)
                                {
                                    rg = Color.FromArgb(rand.Next(200), rand.Next(150,200), 0);
                                    Pen myPen = new Pen(rg);
                                    XxL = (int)Math.Round(YxL - (jj * n / 100) * Math.Cos(30)); XyL = (int)Math.Round(YyL + (jj * n / 100) * k);
                                    YxL1 = (int)Math.Round(XxL + (ii * b / 100) * Math.Cos(30)); YyL1 = (int)Math.Round(XyL + (ii * b / 100) * k);
                                    points[0] = new Point(YxL1, YyL1);
                                    points[1] = new Point(YxL1, YyL1 - 3);
                                    g.DrawLines(myPen, points);
                                }
                            }
                        }
                    }

                }

                //Random rand = new Random();
                //Random rand1 = new Random();
                //Color rg;
                //int[][] p = new int[100][];
                //for (int i = 0; i < 100; i++)
                //    p[i] = new int[100];
                //int n = Int32.Parse(textBox1.Text);//1200 (x)
                //int b = Int32.Parse(textBox2.Text);//1920 (y)
                //int m = Int32.Parse(textBox3.Text);
                //Graphics g = pictureBox1.CreateGraphics();
                //int o=0, l=0;
                //int YxL, YyL, XxL, XyL;
                //int YxL1, YyL1, XxL1, XyL1;
                //Point[] points = new Point[2];

                //for (int i = 0; i < 100; i++)
                //    for (int j = 0; j < 100; j++)
                //        if (rand1.Next(100) >= 70)
                //        {
                //            p[i][j] = 1;
                //        }

                //for (int i = 0; i < 100; i++)
                //for (int j = 0; j < 100; j++)
                //        if(p[i][j]==1)
                //        {
                //            rg = Color.FromArgb(rand.Next(200), rand.Next(100, 200), 0);
                //            Pen myPen = new Pen(rg);
                //            XxL = (int)Math.Round(x - (i * n / 100) * Math.Cos(30)); XyL = (int)Math.Round(y + (i * n / 100) * k);
                //            YxL1 = (int)Math.Round(XxL + (j * b / 100) * Math.Cos(30)); YyL1 = (int)Math.Round(XyL + (j * b / 100) * k);
                //            points[0] = new Point(YxL1, YyL1);
                //            points[1] = new Point(YxL1, YyL1 - 3);
                //            g.DrawLines(myPen, points);
                //        }


            }
            catch (Exception ex) //Проверка на наличие исключений
            {
                MessageBox.Show("Error: " + ex.Message);//Вывод сообщения если исключения найдены
                return; //Заканчиваем обработку
            }
            #endregion

            #region  Маленькие
            try
            {
                //int[] num = new int[8];
                Random rand = new Random();
                Random rand1 = new Random();
                Color rg;
                Pen myPen1 = new Pen(Color.Brown);
                Pen myPen2 = new Pen(Color.DarkGreen);
                int n = Int32.Parse(textBox1.Text);//1200 (x)
                int b = Int32.Parse(textBox2.Text);//1920 (y)
                int m = Int32.Parse(textBox3.Text);
                Graphics g = pictureBox1.CreateGraphics();
                int YxL, YyL, XxL, XyL;
                int YxL1, YyL1, XxL1, XyL1;
                Point[] points = new Point[2];
                for (int j = 0; j < 10; j++)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (rand.Next(10) <= 8)
                        {
                            XxL1 = (int)Math.Round(x - (j * n / 10) * Math.Cos(30)); XyL1 = (int)Math.Round(y + (j * n / 10) * k);
                            YxL = (int)Math.Round(XxL1 + (i * b / 10) * Math.Cos(30)); YyL = (int)Math.Round(XyL1 + (i * b / 10) * k);

                            for (int jj = 0; jj < 10; jj++)
                            {
                                for (int ii = 0; ii < 10; ii++)
                                {
                                    if (rand1.Next(100) >= 99)
                                    {
                                        rg = Color.FromArgb(rand.Next(200), rand.Next(100, 200), 0);
                                        System.Drawing.SolidBrush myPen = new System.Drawing.SolidBrush(rg);
                                        XxL = (int)Math.Round(YxL - (jj * n / 100) * Math.Cos(30)); XyL = (int)Math.Round(YyL + (jj * n / 100) * k);
                                        YxL1 = (int)Math.Round(XxL + (ii * b / 100) * Math.Cos(30)); YyL1 = (int)Math.Round(XyL + (ii * b / 100) * k);
                                        points[0] = new Point(YxL1, YyL1);
                                        points[1] = new Point(YxL1, YyL1 - 10);
                                        g.FillEllipse(myPen, YxL1 - 5, YyL1 - 18, 9, 15);
                                        g.DrawEllipse(myPen2, YxL1 - 5, YyL1 - 18, 9, 15);
                                        g.DrawLines(myPen1, points);
                                    }
                                }
                            }
                        }
                    }

                }

            }
            catch (Exception ex) //Проверка на наличие исключений
            {
                MessageBox.Show("Error: " + ex.Message);//Вывод сообщения если исключения найдены
                return; //Заканчиваем обработку
            }
            #endregion

            #region  Большие
            try
            {
                    //int[] num = new int[8];
                    Random rand = new Random();
                    Random rand1 = new Random();
                    Color rg;
                    Pen myPen1 = new Pen(Color.Brown);
                    Pen myPen2 = new Pen(Color.DarkGreen);
                    int n = Int32.Parse(textBox1.Text);//1200 (x)
                    int b = Int32.Parse(textBox2.Text);//1920 (y)
                    int m = Int32.Parse(textBox3.Text);
                    Graphics g = pictureBox1.CreateGraphics();
                    int YxL, YyL, XxL, XyL;
                    int YxL1, YyL1, XxL1, XyL1;
                    Point[] points = new Point[2];
                    for (int j = 0; j < 10; j++)
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            if (rand.Next(10) <= 6)
                            {
                                XxL1 = (int)Math.Round(x - (j * n / 10) * Math.Cos(30)); XyL1 = (int)Math.Round(y + (j * n / 10) * k);
                                YxL = (int)Math.Round(XxL1 + (i * b / 10) * Math.Cos(30)); YyL = (int)Math.Round(XyL1 + (i * b / 10) * k);

                                for (int jj = 0; jj < 10; jj++)
                                {
                                    for (int ii = 0; ii < 10; ii++)
                                    {
                                    if (rand1.Next(100) >= 99)
                                    {
                                        rg = Color.FromArgb(rand.Next(200), rand.Next(100, 200), 0);
                                        System.Drawing.SolidBrush myPen = new System.Drawing.SolidBrush(rg);
                                        XxL = (int)Math.Round(YxL - (jj * n / 100) * Math.Cos(30)); XyL = (int)Math.Round(YyL + (jj * n / 100) * k);
                                        YxL1 = (int)Math.Round(XxL + (ii * b / 100) * Math.Cos(30)); YyL1 = (int)Math.Round(XyL + (ii * b / 100) * k);
                                        points[0] = new Point(YxL1, YyL1);
                                        points[1] = new Point(YxL1, YyL1 - 30);
                                        g.FillEllipse(myPen, YxL1 - 9, YyL1 - 37, 18, 30);
                                        g.DrawEllipse(myPen2, YxL1 - 9, YyL1 - 37, 18, 30);
                                        g.DrawLines(myPen1, points);
                                    }

                                    }
                                }
                            }
                        }

                    }

                }
                catch (Exception ex) //Проверка на наличие исключений
                {
                    MessageBox.Show("Error: " + ex.Message);//Вывод сообщения если исключения найдены
                    return; //Заканчиваем обработку
                }

            #endregion
        }

        #region  Улучшеные
        private void button3_Click(object sender, EventArgs e)
        {
            //int n = Int32.Parse(textBox1.Text);//1200 (x)
            //int b = Int32.Parse(textBox2.Text);//1920 (y)

            //int y1, x1;
            //int R = 25;

            //Point[] points = new Point[4];
            //Graphics g = pictureBox1.CreateGraphics();
            //Pen myPen = new Pen(Color.Blue);

            //int XxL = (int)Math.Round(x - n * Math.Cos(30)), XyL = (int)Math.Round(y + n * k);
            //int YxL = (int)Math.Round(x + b * Math.Cos(30)), YyL = (int)Math.Round(y + b * k);
            ////XxL = (int)Math.Round(YxL - (jj * n / 100) * Math.Cos(30)); XyL = (int)Math.Round(YyL + (jj * n / 100) * k);
            ////YxL1 = (int)Math.Round(XxL + (ii * b / 100) * Math.Cos(30)); YyL1 = (int)Math.Round(XyL + (ii * b / 100) * k);

            //for (int i = 64; i < 86; i++)
            //{
            //    x1 = (int)Math.Round(x + 500 + R * Math.Cos(2 * Math.PI * i / 100));
            //    y1 = (int)Math.Round(y + 500 + R * Math.Sin(2 * Math.PI * i / 100));
            //    g.DrawEllipse(myPen, x1, y1, 1, 1);
            //}

            //for (int i = 14; i < 36; i++)
            //{
            //    x1 = (int)Math.Round(x + R * Math.Cos(2 * Math.PI * i / 100));
            //    y1 = (int)Math.Round(y - 35 + R * Math.Sin(2 * Math.PI * i / 100));
            //    g.DrawEllipse(myPen, x1, y1, 1, 1);
            //}

            //for (int i = 0; i < 100; i++)
            //{
            //    x1 = (int)Math.Round(x + R * Math.Cos(2 * Math.PI * i / 100));
            //    y1 = (int)Math.Round(y + R * Math.Sin(2 * Math.PI * i / 100));
            //    g.DrawEllipse(myPen, x1, y1, 1, 1);
            //}

            try
            {
                bool t;
                //int[] num = new int[8];
                Random rand = new Random();
                Random rand1 = new Random();
                Color rg;
                Pen myPen1 = new Pen(Color.Brown,2);//128, 64, 48
                Pen myPen2 = new Pen(Color.DarkGreen);
                Pen myPen3 = new Pen(Color.Blue);
                Image image = new Bitmap("D:\\uchba\\КПЗ\\pngegg.png");
                TextureBrush tBrush = new TextureBrush(image);
                tBrush.Transform = new Matrix(33.64f / 841.0f,0.0f,0.0f,34.4f / 1032.0f,0.0f,0.0f);
                int hi=60, wy=40;

                int n = Int32.Parse(textBox1.Text);//1200 (x)
                int b = Int32.Parse(textBox2.Text);//1920 (y)
                int m = Int32.Parse(textBox3.Text);
                int y1, x1;
                int R = 150, rad=20;
                Graphics g = pictureBox1.CreateGraphics();
                int YxL, YyL, XxL, XyL;
                int YxL1, YyL1, XxL1, XyL1;
                Point[] points = new Point[2];
                //Point point;
                for (int j = 0; j < 10; j++)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (rand.Next(10) <= 7)
                        {
                            XxL1 = (int)Math.Round(x - (j * n / 10) * Math.Cos(30)); XyL1 = (int)Math.Round(y + (j * n / 10) * k);
                            YxL = (int)Math.Round(XxL1 + (i * b / 10) * Math.Cos(30)); YyL = (int)Math.Round(XyL1 + (i * b / 10) * k);

                            for (int jj = 0; jj < 10; jj++)
                            {
                                for (int ii = 0; ii < 10; ii++)
                                {
                                    if (rand1.Next(1000) >= 999)
                                    {
                                        t = true;


                                        rg = Color.FromArgb(rand.Next(200), rand.Next(100, 200), 0);
                                        System.Drawing.SolidBrush myPen;
                                        XxL = (int)Math.Round(YxL - (jj * n / 100) * Math.Cos(30)); XyL = (int)Math.Round(YyL + (jj * n / 100) * k);
                                        YxL1 = (int)Math.Round(XxL + (ii * b / 100) * Math.Cos(30)); YyL1 = (int)Math.Round(XyL + (ii * b / 100) * k);

                                        //Стебель
                                        points[0] = new Point(YxL1, YyL1);
                                        points[1] = new Point(YxL1, YyL1 - 60);
                                        g.DrawLines(myPen1, points);

                                        rg = Color.FromArgb(rand.Next(200), rand.Next(100, 200), 0);
                                        myPen = new System.Drawing.SolidBrush(rg);
                                        g.FillEllipse(myPen, YxL1 - 7, YyL1 - 62, rad, rad);
                                        //Низ
                                        for (int i1 = 0; i1 < 50; i1++)
                                        {
                                            rg = Color.FromArgb(rand.Next(200), rand.Next(100, 200), 0);
                                            myPen = new System.Drawing.SolidBrush(rg);
                                            x1 = (int)Math.Round(YxL1 + Math.Cos(30) * R * Math.Cos(2 * Math.PI * i1 / 50));
                                            y1 = (int)Math.Round(YyL1 - 20 + k * R * Math.Sin(2 * Math.PI * i1 / 50));
                                            //g.DrawEllipse(myPen3, x1, y1 - 15, 1, 1);
                                            if (rand.Next(10) > 8 || t)
                                            {
                                                t = false;
                                                points[0] = new Point(YxL1, YyL1 - rand.Next(10, 15));
                                                points[1] = new Point(x1, y1 - 20);
                                                g.DrawLines(myPen1, points);
                                                g.FillEllipse(myPen, x1 - 6, y1 - 20, rad, rad);
                                                //g.DrawEllipse(myPen2, x1-6, y1 - 17, rad, rad);
                                            }
                                        }
                                        //Верх
                                        for (int i1 = 0; i1 < 50; i1++)
                                        {
                                            rg = Color.FromArgb(rand.Next(200), rand.Next(100, 200), 0);
                                            myPen = new System.Drawing.SolidBrush(rg);
                                            x1 = (int)Math.Round(YxL1 + Math.Cos(30) * R * 1.5 * Math.Cos(2 * Math.PI * i1 / 50));
                                            y1 = (int)Math.Round(YyL1 - 35 + k * R * 1.5 * Math.Sin(2 * Math.PI * i1 / 50));
                                            // g.DrawEllipse(myPen3, x1, y1 - 30, 1, 1);
                                            if (rand.Next(10) > 7 || t)
                                            {
                                                t = false;
                                                points[0] = new Point(YxL1, YyL1 - rand.Next(25, 27));
                                                points[1] = new Point(x1, y1 - 30);
                                                g.DrawLines(myPen1, points);
                                                g.FillEllipse(myPen, x1 - 6, y1 - 32, rad, rad);
                                                //g.DrawEllipse(myPen2, x1 - 6, y1 - 32, rad, rad);
                                            }
                                        }
                                        g.DrawEllipse(myPen2, YxL1 - 7, YyL1 - 62, rad, rad);

                                        //g.DrawImage(image, YxL1-wy/2, YyL1-hi+2, wy, hi);
                                    }

                                }
                            }
                        }
                    }

                }
                //g.DrawImage(image, x-wy/2, y-hi+2, wy, hi);

            }
            catch (Exception ex) //Проверка на наличие исключений
            {
                MessageBox.Show("Error: " + ex.Message );//Вывод сообщения если исключения найдены
                return; //Заканчиваем обработку
            }
        }
        #endregion

        private void button12_Click(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        

        public class BiomeGenerator
        {
            private Random random;

            public BiomeGenerator(int seed)
            {
                random = new Random(seed);
            }

            public Biome[,] GenerateBiomes(int width, int height, bool[,,,] tree)
            {
                Biome[,] biomes = new Biome[width, height];

                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        for (int x1 = 0; x1 < 10; x1++)
                            for (int y1 = 0; y1 < 10; y1++)
                                tree[x, y, x1, y1] = false;
                        if (x != 0 && y != 0)
                            {
                            if (biomes[x - 1, y] == Biome.Forest || biomes[x, y - 1] == Biome.Forest)
                            {
                                biomes[x, y] = GenerateBiome1(x, y);
                                if (biomes[x - 1, y] == Biome.Mountains)
                                    biomes[x - 1, y] = Biome.Plains;
                                if (biomes[x, y - 1] == Biome.Mountains)
                                    biomes[x, y - 1] = Biome.Plains;
                            }
                            else if (biomes[x - 1, y] == Biome.Mountains || biomes[x, y - 1] == Biome.Mountains)
                            {
                                biomes[x, y] = GenerateBiome2(x, y);
                                if (biomes[x - 1, y] == Biome.Forest)
                                    biomes[x - 1, y] = Biome.Plains;
                                if (biomes[x, y - 1] == Biome.Forest)
                                    biomes[x, y - 1] = Biome.Plains;
                            }
                            else biomes[x, y] = GenerateBiome(x, y);

                                //if (y < height - 1 && biomes[x - 1, y+1] == Biome.Mountains)
                                //biomes[x, y] = Biome.Plains;
                            }
                            else if (x == 0 && y!=0)
                            {
                                if (biomes[x, y - 1] == Biome.Forest)
                                    biomes[x, y] = GenerateBiome1(x, y);
                                else if (biomes[x, y - 1] == Biome.Mountains)
                                    biomes[x, y] = GenerateBiome2(x, y);
                                else biomes[x, y] = GenerateBiome(x, y);
                            }
                            else if (y==0 && x!=0)
                            { 
                                if (biomes[x - 1, y] == Biome.Forest)
                                    biomes[x, y] = GenerateBiome1(x, y);
                                else if (biomes[x - 1, y] == Biome.Mountains)
                                    biomes[x, y] = GenerateBiome2(x, y);
                                else biomes[x, y] = GenerateBiome(x, y);
                            }
                            else biomes[x, y] = GenerateBiome(x, y);

                        if (random.Next(10) < 8)
                            for (int x1 = 0; x1 < 10; x1++)
                                for (int y1 = 0; y1 < 10; y1++)
                                    if (random.Next(100) >= 97)
                                        tree[x, y, x1, y1]=true;
                            //biomes[x, y] = GenerateBiome(x, y);
                    }
                }


                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        if(x!=0 && y!=0 && x< width-1 && y< height-1)
                        if (biomes[x - 1, y] == Biome.Forest && biomes[x, y - 1] == Biome.Forest && biomes[x + 1, y] == Biome.Forest && biomes[x, y+1] == Biome.Forest)
                        {
                            biomes[x, y] = Biome.Forest;
                        }
                    }
                }
                        return biomes;
            }

            private Biome GenerateBiome(int x, int y)
            {
               
                int randomNumber = random.Next(0, 100);
                if (randomNumber < 30)
                {
                    return Biome.Forest;
                }
                else if (randomNumber < 60)
                {
                    return Biome.Plains;
                }
                else
                {
                    return Biome.Mountains;
                }
            }
            private Biome GenerateBiome1(int x, int y)
            {
                
                int randomNumber = random.Next(0, 100);
                if (randomNumber < 70)
                {
                    return Biome.Forest;
                }
                else
                {
                    return Biome.Plains;
                }
                
            }
            private Biome GenerateBiome2(int x, int y)
            {
                
                int randomNumber = random.Next(0, 100);

                if (randomNumber < 70)
                {
                    return Biome.Plains;
                }
                else
                {
                    return Biome.Mountains;
                }
            }
        }
        public enum Biome
        {
            Forest,
            Plains,
            Mountains
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        //Approximation
        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                Image image = new Bitmap("D:\\uchba\\КПЗ\\pngegg.png");
                Image image1 = new Bitmap("D:\\uchba\\КПЗ\\pngegg1.png");
                Image image2 = new Bitmap("D:\\uchba\\КПЗ\\pngegg2.png");
                int hi = 60, wy = 40;
                int seed;//821014005
                Random random = new Random();
                if (textBox4.Text == "")
                {
                    seed = random.Next(1000000000);
                    textBox4.Text = seed.ToString();
                }
                else seed = Int32.Parse(textBox4.Text);
                BiomeGenerator bio = new BiomeGenerator(seed);
                int n = Int32.Parse(textBox1.Text);//1200 (x)
                int b = Int32.Parse(textBox2.Text);//1920 (y)
                int m = Int32.Parse(textBox3.Text);
                int m1;
                Graphics g = pictureBox1.CreateGraphics();
                //Pens
                System.Drawing.SolidBrush myPen = new System.Drawing.SolidBrush(Color.Green);
                System.Drawing.SolidBrush myPen1 = new System.Drawing.SolidBrush(Color.Yellow);
                System.Drawing.SolidBrush myPen11 = new System.Drawing.SolidBrush(Color.GreenYellow);
                System.Drawing.SolidBrush myPen2 = new System.Drawing.SolidBrush(Color.DarkOrange);
                System.Drawing.SolidBrush myPen21 = new System.Drawing.SolidBrush(Color.Orange);
                Pen myPen3 = new Pen(Color.Red);
                //X
                int XxL = (int)Math.Round(x - n * Math.Cos(30)), XyL = (int)Math.Round(y + n * k);
                Point[] points = new Point[2];
                points[0] = new Point(x, y - m);
                points[1] = new Point(XxL, XyL - m);
                g.DrawLines(myPen3, points);

                //Y
                int YxL = (int)Math.Round(x + b * Math.Cos(30)), YyL = (int)Math.Round(y + b * k);
                points[0] = new Point(x, y - m);
                points[1] = new Point(YxL, YyL - m);
                g.DrawLines(myPen3, points);

                int YxL1 = (int)Math.Round(XxL + b * Math.Cos(30)), YyL1 = (int)Math.Round(XyL + b * k);
                points[0] = new Point(XxL, XyL - m);
                points[1] = new Point(YxL1, YyL1 - m);
                g.DrawLines(myPen3, points);

                int XxL0, XyL0, YxL0, YyL0, XxL1, XyL1;

                points[0] = new Point(YxL, YyL - m);
                points[1] = new Point(YxL1, YyL1 - m);
                g.DrawLines(myPen3, points);

                int size = Int32.Parse(textBox5.Text);
                bool[,,,] tree = new bool[size, size, 10, 10];
                Biome[,] biomes = new Biome[size, size];
                biomes = bio.GenerateBiomes(size, size, tree);

                int ApproxX;
                if (textBox6.Text == "")
                {
                    ApproxX = 0;
                    textBox6.Text = ApproxX.ToString();
                }
                else ApproxX = Int32.Parse(textBox6.Text);
                int ApproxY;
                if (textBox7.Text == "")
                {
                    ApproxY = 0;
                    textBox7.Text = ApproxY.ToString();
                }
                else ApproxY = Int32.Parse(textBox7.Text);
                int cy = ApproxY;
                int ApproxSize;
                if (textBox8.Text == "")
                {
                    ApproxSize = 1;
                    textBox8.Text = ApproxSize.ToString();
                }
                else ApproxSize = Int32.Parse(textBox8.Text);
                int s = ApproxSize;

                Point[] points1 = new Point[4];
                Point[] points2 = new Point[4];
                Point[] points3 = new Point[4];

                for (int i = 0; i < s; i++)
                {
                    cy = ApproxY;
                    for (int j = 0; j < s; j++)
                    {
                            points1[2] = new Point(YxL, YyL);
                        //g.DrawEllipse(myPen3, YxL0-2, YyL0-2, 5, 5);
                        m = 0;


                        if (biomes[ApproxX, cy] == Biome.Forest)
                        {
                            XxL0 = (int)Math.Round(x - i * n / s * Math.Cos(30)); XyL0 = (int)Math.Round(y + i * n / s * k);
                            YxL0 = (int)Math.Round(XxL0 + j * b / s * Math.Cos(30)); YyL0 = (int)Math.Round(XyL0 + j * b / s * k);
                            points1[0] = new Point(YxL0, YyL0 - m);
                            XxL = (int)Math.Round(YxL0 - n / s * Math.Cos(30)); XyL = (int)Math.Round(YyL0 + n / s * k);
                            points1[1] = new Point(XxL, XyL - m);
                            YxL = (int)Math.Round(YxL0 + b / s * Math.Cos(30)); YyL = (int)Math.Round(YyL0 + b / s * k);
                            points1[3] = new Point(YxL, YyL - m);
                            YxL = (int)Math.Round(XxL + b / s * Math.Cos(30)); YyL = (int)Math.Round(XyL + b / s * k);
                            points1[2] = new Point(YxL, YyL - m);
                            g.FillPolygon(myPen, points1);

                            //Tree
                            for (int ii = 0; ii < 10; ii++)
                            {
                                XxL = (int)Math.Round(YxL0 - ii * n / (s * 10) * Math.Cos(30)); XyL = (int)Math.Round(YyL0 + ii * n / (s * 10) * k);
                                for (int jj = 0; jj < 10; jj++)
                                {
                                    if (tree[ApproxX, cy, ii, jj] == true)
                                    {
                                        YxL = (int)Math.Round(XxL + jj * b / (s * 10) * Math.Cos(30)); YyL = (int)Math.Round(XyL + jj * b / (s * 10) * k);
                                        g.DrawImage(image, YxL - (wy / s * 5) / 2, YyL - m - hi / s * 5, wy / s * 5, hi / s * 5);
                                    }
                                }
                            }
                        }
                        else if (biomes[ApproxX, cy] == Biome.Plains)
                        {
                            m1 = 100 / s;
                            XxL0 = (int)Math.Round(x - i * n / s * Math.Cos(30)); XyL0 = (int)Math.Round(y + i * n / s * k);
                            YxL0 = (int)Math.Round(XxL0 + j * b / s * Math.Cos(30)); YyL0 = (int)Math.Round(XyL0 + j * b / s * k);
                            points1[0] = new Point(YxL0, YyL0 - m1);

                            XxL = (int)Math.Round(YxL0 - n / s * Math.Cos(30)); XyL = (int)Math.Round(YyL0 + n / s * k);
                            points1[1] = new Point(XxL, XyL - m1);
                            points2[0] = new Point(XxL, XyL - m1);
                            points2[3] = new Point(XxL, XyL);

                            YxL = (int)Math.Round(YxL0 + b / s * Math.Cos(30)); YyL = (int)Math.Round(YyL0 + b / s * k);
                            points1[3] = new Point(YxL, YyL - m1);
                            points3[0] = new Point(YxL, YyL - m1);
                            points3[3] = new Point(YxL, YyL);

                            YxL = (int)Math.Round(XxL + b / s * Math.Cos(30)); YyL = (int)Math.Round(XyL + b / s * k);
                            points1[2] = new Point(YxL, YyL - m1);
                            points2[1] = new Point(YxL, YyL - m1);
                            points2[2] = new Point(YxL, YyL);
                            points3[1] = new Point(YxL, YyL - m1);
                            points3[2] = new Point(YxL, YyL);

                            g.FillPolygon(myPen1, points1);
                            if (cy < size - 1 && biomes[ApproxX + 1, cy] == Biome.Forest)
                                g.FillPolygon(myPen11, points2);
                            if (cy < size - 1 && biomes[ApproxX, cy + 1] == Biome.Forest)
                                g.FillPolygon(myPen11, points3);
                            
                            //Tree
                            for (int ii = 0; ii < 10; ii++)
                            {
                                XxL = (int)Math.Round(YxL0 - ii * n / (s * 10) * Math.Cos(30)); XyL = (int)Math.Round(YyL0 + ii * n / (s * 10) * k);
                                for (int jj = 0; jj < 10; jj++)
                                {
                                    if (tree[ApproxX, cy, ii, jj] == true)
                                    {
                                        YxL = (int)Math.Round(XxL + jj * b / (s * 10) * Math.Cos(30)); YyL = (int)Math.Round(XyL + jj * b / (s * 10) * k);
                                        g.DrawImage(image1, YxL - (wy / s * 5) / 2, YyL - m1 - hi / s * 5, wy / s * 5, hi / s * 5);
                                    }
                                }
                            }
                        }
                        else
                        {
                            m1 = 200 / s;
                            XxL0 = (int)Math.Round(x - i * n / s * Math.Cos(30)); XyL0 = (int)Math.Round(y + i * n / s * k);
                            YxL0 = (int)Math.Round(XxL0 + j * b / s * Math.Cos(30)); YyL0 = (int)Math.Round(XyL0 + j * b / s * k);
                            points1[0] = new Point(YxL0, YyL0 - m1);

                            XxL = (int)Math.Round(YxL0 - n / s * Math.Cos(30)); XyL = (int)Math.Round(YyL0 + n / s * k);
                            points1[1] = new Point(XxL, XyL - m1);
                            points2[0] = new Point(XxL, XyL - m1);
                            points2[3] = new Point(XxL, XyL);

                            YxL = (int)Math.Round(YxL0 + b / s * Math.Cos(30)); YyL = (int)Math.Round(YyL0 + b / s * k);
                            points1[3] = new Point(YxL, YyL - m1);
                            points3[0] = new Point(YxL, YyL - m1);
                            points3[3] = new Point(YxL, YyL);

                            YxL = (int)Math.Round(XxL + b / s * Math.Cos(30)); YyL = (int)Math.Round(XyL + b / s * k);
                            points1[2] = new Point(YxL, YyL - m1);
                            points2[1] = new Point(YxL, YyL - m1);
                            points2[2] = new Point(YxL, YyL);
                            points3[1] = new Point(YxL, YyL - m1);
                            points3[2] = new Point(YxL, YyL);

                            g.FillPolygon(myPen2, points1);
                            if (i < size - 1 && biomes[ApproxX + 1, cy] != Biome.Mountains)
                                g.FillPolygon(myPen21, points2);
                            if (j < size - 1 && biomes[ApproxX, cy + 1] != Biome.Mountains)
                                g.FillPolygon(myPen21, points3);

                            //Tree
                            for (int ii = 0; ii < 10; ii++)
                            {
                                XxL = (int)Math.Round(YxL0 - ii * n / (s * 10) * Math.Cos(30)); XyL = (int)Math.Round(YyL0 + ii * n / (s * 10) * k);
                                for (int jj = 0; jj < 10; jj++)
                                {
                                    if (tree[ApproxX, cy, ii, jj] == true)
                                    {
                                        YxL = (int)Math.Round(XxL + jj * b / (s * 10) * Math.Cos(30)); YyL = (int)Math.Round(XyL + jj * b / (s * 10) * k);
                                        g.DrawImage(image2, YxL - (wy / s * 5) / 2, YyL - m1 - hi / s * 5, wy / s * 5, hi / s * 5);
                                    }
                                }
                            }
                        }
                        //Thread.Sleep(100);
                        cy++;
                    }
                    ApproxX++;
                }

            }
            catch (Exception ex) //Проверка на наличие исключений
            {
                MessageBox.Show("Error: " + ex.Message + ex.StackTrace);//Вывод сообщения если исключения найдены
                return; //Заканчиваем обработку
            }
        }

        //Change panel
        private void button15_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button15.Visible = false;

            panel2.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button16.Visible = true;
            button17.Visible = true;
            button18.Visible = true;
            button19.Visible = true;
            button20.Visible = true;
        }

        //Change panel
        private void button16_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button15.Visible = true;

            panel2.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
        }

        
        //↑
        private void button17_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            int n;
            if (textBox7.Text == "" || textBox7.Text == "0")
            {
                n = 0;
                textBox7.Text = n.ToString();
                button13_Click(sender, e);
            }
            else
                {
                n = Int32.Parse(textBox7.Text);
                n--;
                textBox7.Text = n.ToString();
                button13_Click(sender, e);
            }
        }

        //↓
        private void button18_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            int closeSize;
            if (textBox8.Text == "")
            {
                closeSize = 1;
                textBox8.Text = closeSize.ToString();
            }
            else closeSize = Int32.Parse(textBox8.Text);

            int n; int s = Int32.Parse(textBox5.Text);
            if (textBox7.Text == "" || textBox7.Text == "0")
            {
                n = 1;
                textBox7.Text = n.ToString();
                button13_Click(sender, e);
            }
            else if(Int32.Parse(textBox7.Text)+ closeSize>=s)
            {
                n = s - closeSize;
                textBox7.Text = n.ToString();
                button13_Click(sender, e); 
            }
            else
            {
                n = Int32.Parse(textBox7.Text);
                n++;
                textBox7.Text = n.ToString();
                button13_Click(sender, e);
            }
        }

        //→
        private void button19_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            int n;
            if (textBox6.Text == "" || textBox6.Text == "0")
            {
                n = 0;
                textBox6.Text = n.ToString();
                button13_Click(sender, e);
            }
            else
            {
                n = Int32.Parse(textBox6.Text);
                n--;
                textBox6.Text = n.ToString();
                button13_Click(sender, e);
            }

        }

        //←
        private void button20_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            int closeSize;
            if (textBox8.Text == "")
            {
                closeSize = 1;
                textBox8.Text = closeSize.ToString();
            }
            else closeSize = Int32.Parse(textBox8.Text);

            int n; int s = Int32.Parse(textBox5.Text);
            if (textBox6.Text == "" || textBox6.Text == "0")
            {
                n = 1;
                textBox6.Text = n.ToString();
                button13_Click(sender, e);
            }
            else if (Int32.Parse(textBox6.Text) + closeSize >= s)
            {
                n = s - closeSize;
                textBox6.Text = n.ToString();
                button13_Click(sender, e); 
            }
            else
            {
                n = Int32.Parse(textBox6.Text);
                n++;
                textBox6.Text = n.ToString();
                button13_Click(sender, e);
            }
        }


        //Mountain
        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                Color col;
                Random rand = new Random();
                int n = Int32.Parse(textBox1.Text);//1200 (x)
                int b = Int32.Parse(textBox2.Text);//1920 (y)
                int m = Int32.Parse(textBox3.Text);
                Graphics g = pictureBox1.CreateGraphics();
                int[,] YxL=new int[100,100], YyL=new int[100,100];
                int XxL1, XyL1;
                int[,] t = new int [100,100];
                col = Color.FromArgb(0, 255, 0);
                Pen myPen = new Pen(col);
                Point[] points = new Point[4];

                for (int i = 0; i < 100; i++)
                {
                    for (int j = 0; j < 100; j++)
                    {
                        
                        XxL1 = (int)Math.Round(x - (j * n / 100) * Math.Cos(30)); XyL1 = (int)Math.Round(y + (j * n / 100) * k);
                        YxL[i,j] = (int)Math.Round(XxL1 + (i * b / 100) * Math.Cos(30)); YyL[i,j] = (int)Math.Round(XyL1 + (i * b / 100) * k);
                        
                        //Thread.Sleep(100);
                        if (i > 5 && i < 95 && j > 5 && j < 95)
                        {
                            //if (i < 50 && j < 50)
                            if(i<50 && j<50 || t[i-1, j]<=0 || t[i, j-1]<=0 || t[i-1, j-1]<=0)
                                if (rand.Next(100) < 80)
                                t[i, j] = (t[i - 1, j] + t[i - 1, j-1]+ t[i, j-1])/3 + 10;
                                else t[i, j] = (t[i - 1, j] + t[i - 1, j - 1] + t[i, j - 1]) / 3 - 10;
                            else if (rand.Next(100) < 80)
                                t[i, j] = (t[i - 1, j] + t[i - 1, j - 1] + t[i, j - 1]) / 3 - 10;
                            else t[i, j] = (t[i - 1, j] + t[i - 1, j - 1] + t[i, j - 1]) / 3 + 10;

                            //else if(i >= 50 && j < 50) 
                            //    t[i, j] = t[i-1, j] - 1;
                            if(t[i, j]>=0)
                            col = Color.FromArgb(0 + t[i, j]/2, 255 - t[i, j]/2, 0);
                            else col = Color.FromArgb(0, 255, 0);
                            myPen = new Pen(col);
                            g.DrawEllipse(myPen, YxL[i,j], YyL[i,j] - t[i,j], 1, 1);

                            if (i > 0 && j > 0)
                            {
                                points[0] = new Point(YxL[i, j], YyL[i, j] - t[i, j]);
                                points[1] = new Point(YxL[i - 1, j], YyL[i - 1, j] - t[i - 1, j]);
                                points[2] = new Point(YxL[i, j - 1], YyL[i, j - 1] - t[i, j - 1]);
                                points[3] = new Point(YxL[i - 1, j - 1], YyL[i - 1, j - 1] - t[i - 1, j - 1]);
                                g.DrawLines(myPen, points);
                            }

                        }
                        else
                            g.DrawEllipse(myPen, YxL[i, j], YyL[i, j], 1, 1);
                    }

                }

            }
            catch (Exception ex) //Проверка на наличие исключений
            {
                MessageBox.Show("Error: " + ex.Message + ex.StackTrace);//Вывод сообщения если исключения найдены
                return; //Заканчиваем обработку
            }
        }

        //Generate
        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                Image image = new Bitmap("D:\\uchba\\КПЗ\\pngegg.png");
                Image image1 = new Bitmap("D:\\uchba\\КПЗ\\pngegg1.png");
                Image image2 = new Bitmap("D:\\uchba\\КПЗ\\pngegg2.png");
                int hi = 60, wy = 40;
                int seed;
                Random random=new Random();
                if (textBox4.Text == "")
                {
                    seed = random.Next(1000000000);
                    textBox4.Text=seed.ToString();
                }
                else seed = Int32.Parse(textBox4.Text);
                BiomeGenerator bio=new BiomeGenerator(seed);
                int n = Int32.Parse(textBox1.Text);//1200 (x)
                int b = Int32.Parse(textBox2.Text);//1920 (y)
                int m = Int32.Parse(textBox3.Text);
                Graphics g = pictureBox1.CreateGraphics();
                //Pens
                System.Drawing.SolidBrush myPen = new System.Drawing.SolidBrush(Color.Green);
                System.Drawing.SolidBrush myPen1 = new System.Drawing.SolidBrush(Color.Yellow);
                System.Drawing.SolidBrush myPen11 = new System.Drawing.SolidBrush(Color.GreenYellow);
                System.Drawing.SolidBrush myPen2 = new System.Drawing.SolidBrush(Color.DarkOrange);
                System.Drawing.SolidBrush myPen21 = new System.Drawing.SolidBrush(Color.Orange);
                Pen myPen3 = new Pen(Color.Red);
                //X
                int XxL = (int)Math.Round(x - n * Math.Cos(30)), XyL = (int)Math.Round(y + n * k);
                Point[] points = new Point[2];
                points[0] = new Point(x, y - m);
                points[1] = new Point(XxL, XyL - m);
                g.DrawLines(myPen3, points);

                //Y
                int YxL = (int)Math.Round(x + b * Math.Cos(30)), YyL = (int)Math.Round(y + b * k);
                points[0] = new Point(x, y - m);
                points[1] = new Point(YxL, YyL - m);
                g.DrawLines(myPen3, points);

                int YxL1 = (int)Math.Round(XxL + b * Math.Cos(30)), YyL1 = (int)Math.Round(XyL + b * k);
                points[0] = new Point(XxL, XyL - m);
                points[1] = new Point(YxL1, YyL1 - m);
                g.DrawLines(myPen3, points);

                int XxL0, XyL0, YxL0, YyL0, XxL1, XyL1;

                points[0] = new Point(YxL, YyL - m);
                points[1] = new Point(YxL1, YyL1 - m);
                g.DrawLines(myPen3, points);

                int s=Int32.Parse(textBox5.Text);
                bool[,,,] tree = new bool[s, s, 10, 10];
                Biome[,] biomes = new Biome[s, s];
                biomes = bio.GenerateBiomes(s, s, tree);

                Point[] points1 = new Point[4];
                Point[] points2 = new Point[4];
                Point[] points3 = new Point[4];

                for (int i = 0; i < s; i++)
                {
                    
                    for (int j = 0; j < s; j++)
                    {
                        points1[2] = new Point(YxL, YyL);
                        //g.DrawEllipse(myPen3, YxL0-2, YyL0-2, 5, 5);
                        m = 0;


                        if (biomes[i, j] == Biome.Forest)
                        {
                            //Forest
                            XxL0 = (int)Math.Round(x - i * n / s * Math.Cos(30)); XyL0 = (int)Math.Round(y + i * n / s * k);
                            YxL0 = (int)Math.Round(XxL0 + j * b / s * Math.Cos(30)); YyL0 = (int)Math.Round(XyL0 + j * b / s * k);
                            points1[0] = new Point(YxL0, YyL0-m);
                            XxL = (int)Math.Round(YxL0 - n / s * Math.Cos(30)); XyL = (int)Math.Round(YyL0 + n / s * k);
                            points1[1] = new Point(XxL, XyL-m);
                            YxL = (int)Math.Round(YxL0 + b / s * Math.Cos(30)); YyL = (int)Math.Round(YyL0 + b / s * k);
                            points1[3] = new Point(YxL, YyL-m);
                            YxL = (int)Math.Round(XxL + b / s * Math.Cos(30)); YyL = (int)Math.Round(XyL + b / s * k);
                            points1[2] = new Point(YxL, YyL-m);
                            g.FillPolygon(myPen, points1);
                            
                            //Tree
                            for (int ii = 0; ii < 10; ii++)
                            {
                                XxL = (int)Math.Round(YxL0 - ii * n / (s * 10) * Math.Cos(30)); XyL = (int)Math.Round(YyL0 + ii * n / (s * 10) * k);
                                for (int jj = 0; jj < 10; jj++)
                                {
                                    if (tree[i, j, ii, jj] == true)
                                    {
                                        YxL = (int)Math.Round(XxL + jj * b / (s * 10) * Math.Cos(30)); YyL = (int)Math.Round(XyL + jj * b / (s * 10) * k);
                                        g.DrawImage(image, YxL - (wy / (s / 5)) / 2, YyL - m - hi / (s / 5), wy / (s / 5), hi / (s / 5));
                                    }
                                }
                            }
                        }
                        else if (biomes[i, j] == Biome.Plains)
                        {
                            //Plains
                            m = 100/s;
                            XxL0 = (int)Math.Round(x - i * n / s * Math.Cos(30)); XyL0 = (int)Math.Round(y + i * n / s * k);
                            YxL0 = (int)Math.Round(XxL0 + j * b / s * Math.Cos(30)); YyL0 = (int)Math.Round(XyL0 + j * b / s * k);
                            points1[0] = new Point(YxL0, YyL0-m);

                            XxL = (int)Math.Round(YxL0 - n / s * Math.Cos(30)); XyL = (int)Math.Round(YyL0 + n / s * k);
                            points1[1] = new Point(XxL, XyL-m);
                            points2[0] = new Point(XxL, XyL - m);
                            points2[3] = new Point(XxL, XyL);
                            
                            YxL = (int)Math.Round(YxL0 + b / s * Math.Cos(30)); YyL = (int)Math.Round(YyL0 + b / s * k);
                            points1[3] = new Point(YxL, YyL-m);
                            points3[0] = new Point(YxL, YyL - m);
                            points3[3] = new Point(YxL, YyL);
                            
                            YxL = (int)Math.Round(XxL + b / s * Math.Cos(30)); YyL = (int)Math.Round(XyL + b / s * k);
                            points1[2] = new Point(YxL, YyL-m);
                            points2[1] = new Point(YxL, YyL - m);
                            points2[2] = new Point(YxL, YyL);
                            points3[1] = new Point(YxL, YyL - m);
                            points3[2] = new Point(YxL, YyL);

                            g.FillPolygon(myPen1, points1);
                            if (i < s - 1 && biomes[i + 1, j] == Biome.Forest)
                                g.FillPolygon(myPen11, points2);
                            if (j < s - 1 && biomes[i, j+1] == Biome.Forest)
                                g.FillPolygon(myPen11, points3);
                                
                            //Tree
                            for (int ii = 0; ii < 10; ii++)
                            {
                                XxL = (int)Math.Round(YxL0 - ii * n / (s * 10) * Math.Cos(30)); XyL = (int)Math.Round(YyL0 + ii * n / (s * 10) * k);
                                for (int jj = 0; jj < 10; jj++)
                                {
                                    if (tree[i, j, ii, jj] == true)
                                    {
                                        YxL = (int)Math.Round(XxL + jj * b / (s * 10) * Math.Cos(30)); YyL = (int)Math.Round(XyL + jj * b / (s * 10) * k);
                                        g.DrawImage(image1, YxL - (wy / (s / 5)) / 2, YyL - m - hi / (s / 5), wy / (s / 5), hi / (s / 5));
                                    }
                                }
                            }
                        }
                        else
                        {
                            //Mountains
                            m = 200/s;
                            XxL0 = (int)Math.Round(x - i * n / s * Math.Cos(30)); XyL0 = (int)Math.Round(y + i * n / s * k);
                            YxL0 = (int)Math.Round(XxL0 + j * b / s * Math.Cos(30)); YyL0 = (int)Math.Round(XyL0 + j * b / s * k);
                            points1[0] = new Point(YxL0, YyL0-m);
                            
                            XxL = (int)Math.Round(YxL0 - n / s * Math.Cos(30)); XyL = (int)Math.Round(YyL0 + n / s * k);
                            points1[1] = new Point(XxL, XyL-m);
                            points2[0] = new Point(XxL, XyL - m);
                            points2[3] = new Point(XxL, XyL);

                            YxL = (int)Math.Round(YxL0 + b / s * Math.Cos(30)); YyL = (int)Math.Round(YyL0 + b / s * k);
                            points1[3] = new Point(YxL, YyL-m);
                            points3[0] = new Point(YxL, YyL - m);
                            points3[3] = new Point(YxL, YyL);

                            YxL = (int)Math.Round(XxL + b / s * Math.Cos(30)); YyL = (int)Math.Round(XyL + b / s * k);
                            points1[2] = new Point(YxL, YyL-m);
                            points2[1] = new Point(YxL, YyL - m);
                            points2[2] = new Point(YxL, YyL);
                            points3[1] = new Point(YxL, YyL - m);
                            points3[2] = new Point(YxL, YyL);

                            g.FillPolygon(myPen2, points1);

                            if(i<s-1 && biomes[i+1, j] != Biome.Mountains)
                                g.FillPolygon(myPen21, points2);
                            if (j < s - 1 && biomes[i, j+1] != Biome.Mountains)
                                g.FillPolygon(myPen21, points3);

                            //Tree
                            for (int ii = 0; ii < 10; ii++)
                            {
                                XxL = (int)Math.Round(YxL0 - ii * n / (s * 10) * Math.Cos(30)); XyL = (int)Math.Round(YyL0 + ii * n / (s * 10) * k);
                                for (int jj = 0; jj < 10; jj++)
                                {
                                    if (tree[i, j, ii, jj] == true)
                                    {
                                        YxL = (int)Math.Round(XxL + jj * b / (s * 10) * Math.Cos(30)); YyL = (int)Math.Round(XyL + jj * b / (s * 10) * k);
                                        g.DrawImage(image2, YxL - (wy / (s / 5)) / 2, YyL - m - hi / (s / 5), wy / (s / 5), hi / (s / 5));
                                    }
                                }
                            }
                        }
                        //Thread.Sleep(100);
                    }
                }
            }
            catch (Exception ex) //Проверка на наличие исключений
            {
                MessageBox.Show("Error: " + ex.Message);//Вывод сообщения если исключения найдены
                return; //Заканчиваем обработку
            }
            
        }
        

    }
}

