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
    public partial class FormDepo : Form
    {
        // Объект от класса-депо
        private readonly DepoCollection depoCollection;
        public LinkedList<Train> trains = new LinkedList<Train>();
        public FormDepo()
        {
            InitializeComponent();
            depoCollection = new DepoCollection(pictureBoxDepo.Width, pictureBoxDepo.Height);
            Draw();
        }
        // Заполнение listBoxLevels
        private void ReloadLevels()
        {
            int index = ListBoxDepo.SelectedIndex;
            ListBoxDepo.Items.Clear();
            for (int i = 0; i < depoCollection.Keys.Count; i++)
            {
                ListBoxDepo.Items.Add(depoCollection.Keys[i]);
            }
            if (ListBoxDepo.Items.Count > 0 && (index == -1 || index >=
           ListBoxDepo.Items.Count))
            {
                ListBoxDepo.SelectedIndex = 0;
            }
            else if (ListBoxDepo.Items.Count > 0 && index > -1 && index <
           ListBoxDepo.Items.Count)
            {
                ListBoxDepo.SelectedIndex = index;
            }
        }
        // Метод отрисовки депо
        private void Draw()
        {
            if (ListBoxDepo.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxDepo.Width, pictureBoxDepo.Height);
                Graphics gr = Graphics.FromImage(bmp);
                depoCollection[ListBoxDepo.SelectedItem.ToString()].Draw(gr);
                pictureBoxDepo.Image = bmp;
            }
        }
        // Обработка нажатия кнопки "Забрать"
        private void buttonZobr_Click(object sender, EventArgs e)
        {
            if (ListBoxDepo.SelectedIndex > -1 && maskedTextBoxPlace.Text != "")
            {
                var train = depoCollection[ListBoxDepo.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxPlace.Text);
                if (train != null)
                {
                    trains.AddFirst(train);
                }
                Draw();
            }
        }
        private void buttonTrainsCheck_Click(object sender, EventArgs e)
        {
            if (trains.Count > 0)
            {
                FormElectrovoz form = new FormElectrovoz();
                form.SetTrain(trains.First.Value);
                trains.RemoveFirst();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите поезд");
            }
        }
        private void buttonSvobodMesta_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxCompareForSimilarity.Text != "")
            {
                int index = Convert.ToInt32(maskedTextBoxCompareForSimilarity.Text);
                if (depoCollection[ListBoxDepo.SelectedItem.ToString()] == index)
                {
                    MessageBox.Show("Свободных мест в депо = " + index);
                }
                else if (depoCollection[ListBoxDepo.SelectedItem.ToString()] != index)
                {
                    MessageBox.Show("Свободных мест в депо не " + index);
                }
            }
        }
        // Обработка нажатия кнопки "Добавить депо"
        private void buttonDobavlDepo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNameDepo.Text))
            {
                MessageBox.Show("Введите название депо", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            depoCollection.AddDepo(textBoxNameDepo.Text);
            ReloadLevels();
        }
        // Обработка нажатия кнопки "Удалить депо"
        private void buttonUdalDepo_Click(object sender, EventArgs e)
        {
            if (ListBoxDepo.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить депо { ListBoxDepo.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    depoCollection.DelDepo(ListBoxDepo.Text);
                    ReloadLevels();
                }
            }
        }
        // Метод обработки выбора элемента на listBox
        private void listBoxParkings_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
        private void buttonAddTrain_Click(object sender, EventArgs e)
        {
            var formElectrovozConfig = new FormElectrovozConfig();
            formElectrovozConfig.AddEvent(AddTrain);
            formElectrovozConfig.Show();
        }
        private void AddTrain(Train train)
        {
            if (train != null && ListBoxDepo.SelectedIndex > -1)
            {
                if ((depoCollection[ListBoxDepo.SelectedItem.ToString()]) + train)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Поезд не удалось поставить");
                }
            }
        }
    }
}
