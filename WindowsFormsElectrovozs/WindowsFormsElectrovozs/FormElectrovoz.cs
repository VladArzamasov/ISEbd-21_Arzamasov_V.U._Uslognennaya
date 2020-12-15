using System;
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
        private ITransport train;
        public FormElectrovoz()
        {
            InitializeComponent();
        }
        // Передача поезда на форму
        public void SetTrain (ITransport train)
        {
            this.train = train;
            Draw();
        }
        // Метод отрисовки электровоза
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxTrains.Width, pictureBoxTrains.Height);
            Graphics gr = Graphics.FromImage(bmp);
            train.DrawTransport(gr);
            pictureBoxTrains.Image = bmp;
        }
        // Обработка нажатия кнопок управления
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    train?.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    train?.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    train?.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    train?.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
