﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsElectrovozs
{
    public partial class FormElectrovoz : Form
    {
        private Electrovoz electrvoz;
        public FormElectrovoz()
        {
            InitializeComponent();
        }
        // Метод отрисовки электровоза
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxTrains.Width, pictureBoxTrains.Height);
            Graphics gr = Graphics.FromImage(bmp);
            electrvoz.DrawTransport(gr);
            pictureBoxTrains.Image = bmp;
        }
        // Обработка нажатия кнопки "Создать"
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (ComboBoxRoga.SelectedIndex > -1)
            {
                electrvoz = new Electrovoz(rnd.Next(100, 300), rnd.Next(1000, 2000), Convert.ToInt32(ComboBoxRoga.SelectedItem),
                    Color.Green, Color.Yellow, true, true);
                electrvoz.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxTrains.Width, pictureBoxTrains.Height);
                Draw();
            }
            else
            {
                MessageBox.Show("Выберете количество рoгов");
            }
        }
        // Обработка нажатия кнопок управления
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    electrvoz.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    electrvoz.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    electrvoz.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    electrvoz.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
