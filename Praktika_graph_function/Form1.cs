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
        SolidBrush brush;   //кисть для отрисовки графика функции
        Font font;          //используемый шрифт для разметки графика

        FontStyle my_font_style;
        Color my_color;

        public graph_function()
        {
            InitializeComponent();

            my_color = Color.Red;
            my_font_style = FontStyle.Regular;
        }


        private void graph_function_Load(object sender, EventArgs e)
        {
            font = new Font("Microsoft Sans Serif", 10);
            brush = new SolidBrush(Color.Black);
        }

        //Функция смена стиля шрифта
        private void btn_font_Click(object sender, EventArgs e)
        {
            Font_style form = new Font_style();
            form.New_font = my_font_style;

            if (form.ShowDialog() == DialogResult.OK)
            {
                my_font_style = form.New_font;
                pictureBox_graph_func.Invalidate();
            }
        }

        //Функция смены цвета графика
        private void btn_color_Click(object sender, EventArgs e)
        {
            Color_ form = new Color_();
            form.New_color = my_color;

            if (form.ShowDialog() == DialogResult.OK)
            {
                my_color = form.New_color;
                pictureBox_graph_func.Invalidate();
            }
        }

        //Функция графика
        private double Function(double x)
        {
            return Math.Exp(-3 * x) * Math.Abs(Math.Cos(20 * x));
        }

        //Функция создания графика
        private void btn_create_graph_Click(object sender, EventArgs e)
        {
            //начало координат 
            int x0 = 35;
            int y0 = (int)(pictureBox_graph_func.Height * 0.92);

            //установка масштабов для осей X, Y
            int Mx = (int)pictureBox_graph_func.Width - 2 * x0;
            int My = (int)pictureBox_graph_func.Height - 2 * y0;

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

            //ось X
            graph.DrawLine(Pens.Black, x0, y0, x0 + Mx, y0);

            //ось Y
            graph.DrawLine(Pens.Black, x0, y0, x0, y0 + My);

            //Разметка ось X
            for (int i = 0; i <= 10; i++)
            {
                double x = i / 10.0;

                //экранная координата
                int xi = (int)(x0 + Mx * x);
                graph.DrawLine(Pens.Black, xi, y0 - 4, xi, y0 + 4);

                //подпись ось координат
                graph.DrawString(x.ToString(), font, brush, xi - 4, y0 + 4);
            }

            //Разметка ось Y
            for (int i = 1; i <= 3; i++)
            {
                double y = i / 10.0;

                //экранная координата
                int yi = (int)(y0 + My * y);
                graph.DrawLine(Pens.Black, x0 - 4, yi, x0 + 4, yi);

                //подпись ось координат
                graph.DrawString(y.ToString(), font, brush, x0 - 27, yi - 8);
            }
        }
    }
}
