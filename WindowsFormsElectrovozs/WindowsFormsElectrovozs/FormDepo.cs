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
        // Обработка нажатия кнопки "Припарковать локомотив"
        private void buttonParkingLocomotive_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var locomotiv = new Locomotive(100, 1000, dialog.Color);
                if (depoCollection[ListBoxDepo.SelectedItem.ToString()] + locomotiv)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Депо переполнено");
                }
            }
        }
        // Обработка нажатия кнопки "Припарковать електровоз"
        private void buttonParkingElectrovoz_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var train = new Electrovoz(100, 1000, Convert.ToInt32(ComboBoxRoga.SelectedItem), dialog.Color, dialogDop.Color, FormaRogov(), true, true);
                    buttonSecondForm.Enabled = true;
                    buttonFirstForm.Enabled = true;
                    buttonThirdForm.Enabled = true;
                    if (depoCollection[ListBoxDepo.SelectedItem.ToString()] + train)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Депо переполнено");
                    }
                }
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
    }
}
