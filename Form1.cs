using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoordinateGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Paint += new PaintEventHandler(Form1_Paint); // подписка на событие перерисовки формы

            this.BackColor = Color.White; // устанавливаем белый цвет фона формы

            this.Size = new Size(1000, 1000); // устанавливаем размеры формы

        }

        private void Form1_Paint(object sender, PaintEventArgs e) // метод, который вызывается при перерисовке формы
        {
            Pen pen = new Pen(Color.Black); // объявляем "карандаш" - pen (для рисования)

            for (int y = 0; y < 1000; y += 10) // цикл, который будет отображать "сетку" (y - 10 - 1000)  
            {
                e.Graphics.DrawLine(pen, 0, y, 1000, y); // рисуем "линию" (x - 0-1000)  
            }

            for (int x = 0; x < 1000; x += 10)
            {
                e.Graphics.DrawLine(pen, x, 0, x, 1000);
            }

        }

    }
}
