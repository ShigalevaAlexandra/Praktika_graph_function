using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika_graph_function
{
    public partial class graph_function : Form
    {
        SolidBrush brush;   //кисть для отрисовки разметки графика
        Font font;          //используемый шрифт для разметки графика

        public graph_function()
        {
            InitializeComponent();
        }

        //Функия задания начальных значений переменных
        private void graph_function_Load(object sender, EventArgs e)
        {
            font = new Font("Microsoft Sans Serif", 10);
            brush = new SolidBrush(Color.Black);
        }

        //Функция смены шрифта
        private void btn_new_font_Click(object sender, EventArgs e)
        {
            Font_ form = new Font_();
            form.New_font = font;

            if (form.ShowDialog() == DialogResult.OK )
            {
                font = form.New_font;
                pictureBox_graph_func.Invalidate();
            }

        }

        //Функция нахождения координат точек через уравнение
        private double Function(double x)
        {
            //разбор функции по действиям
            double item_1 = Math.Pow(x, 2);                     //x^2
            double item_2 = Math.PI / 3;                        //pi/3
            double item_3 = Math.Pow((item_1 + item_2), 2);     //(x^2 + pi/3)^2
            double item_4 = Math.Sin(item_3);                   //sin(x^2 + pi/3)^2
            double item_5 = Math.Pow(item_4, 3);                //sin^3(x^2 + pi/3)^2

            double item_6 = item_5 - Math.Sqrt(x / 2);    

            //предел функции
            if (x >= 2 || x <= 12) return item_6;
            else return 0;
        }

        //Функция создания графика
        private void btn_create_graph_Click(object sender, EventArgs e)
        {
            //начало координат 
            int x0 = 35;
            int y0 = (int)(pictureBox_graph_func.Height * 0.92);

            //установка масштабов для осей X, Y
            int Mx = (int)pictureBox_graph_func.Width - 2 * x0;
            int My = -y0 + 10;

            //число точек
            int M = (int)numeric_count_point.Value;

            //создание графика функции
            Graphics graph = pictureBox_graph_func.CreateGraphics();

            graph.Clear(Color.White);

            //создание массива точек
            Point[] point = new Point[M];

            for (int i = 0; i < M; i++)
            {
                double x = (double)i / M;
                double y = Function(x);

                int xi = (int)(x0 + Mx * x);
                int yi = (int)(y0 + My * y);

                point[i] = new Point(xi, yi);
            }
       
            //упругость графика
            float elasticity = (float)numeric_elasticity.Value;
            
            graph.DrawCurve(Pens.Red, point, elasticity);   //график

            //создание оси X
            graph.DrawLine(Pens.Black, x0, y0, x0 + Mx, y0);

            //создание оси Y
            graph.DrawLine(Pens.Black, x0, y0, x0, y0 + My);

            //Разметка оси X
            for (int i = 0; i <= 10; i++)
            {
                double x = i / 10.0;

                //экранная координата
                int xi = (int)(x0 + Mx * x);
                graph.DrawLine(Pens.Black, xi, y0 - 4, xi, y0 + 4);

                //подпись ось координат
                graph.DrawString(x.ToString(), font, brush, xi - 4, y0 + 4);
            }

            //Разметка оси Y
            for (int i = 1; i <= 10; i++)
            {
                double y = i / 10.0;

                //экранная координата
                int yi = (int)(y0 + My * y);
                graph.DrawLine(Pens.Black, x0 - 4, yi, x0 + 4, yi);

                //подпись ось координат
                graph.DrawString(y.ToString(), font, brush, x0 - 27, yi - 8);
            }
        }

        //Функция закрытия формы через кнопку "Выход"
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
