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
        // Метод отрисовки электровоза
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxTrains.Width, pictureBoxTrains.Height);
            Graphics gr = Graphics.FromImage(bmp);
            train.DrawTransport(gr);
            pictureBoxTrains.Image = bmp;
        }
        // Обработка нажатия кнопки "Создать локомотив"
        private void buttonCreateLocomotive_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            train = new Locomotive(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Green);
            train.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxTrains.Width,
           pictureBoxTrains.Height);
            Draw();
        }
        // Обработка нажатия кнопки "Создать электровоз"
        private void buttonCreateElectrovoz_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (ComboBoxRoga.SelectedIndex > -1)
            {
                train = new Electrovoz(rnd.Next(100, 300), rnd.Next(1000, 2000), Convert.ToInt32(ComboBoxRoga.SelectedItem),
                    Color.Green, Color.Yellow, FormaRogov(), true, true);
                train.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxTrains.Width, pictureBoxTrains.Height);
                buttonSecondForm.Enabled = true;
                buttonFirstForm.Enabled = true;
                buttonThirdForm.Enabled = true;
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
                    train.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    train.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    train.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    train.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
        private void buttonRogaForm_Click(object sender, EventArgs e)
        {
            if (sender == buttonFirstForm)
            {
                buttonSecondForm.Enabled = false;
                buttonThirdForm.Enabled = false;
            }
            else if (sender == buttonSecondForm)
            {
                buttonFirstForm.Enabled = false;
                buttonThirdForm.Enabled = false;
            }
            else
            {
                buttonFirstForm.Enabled = false;
                buttonSecondForm.Enabled = false;
            }
        }
        private int FormaRogov()
        {
            if (buttonFirstForm.Enabled == true)
            {
                return 0;
            }
            else if (buttonSecondForm.Enabled == true)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}
