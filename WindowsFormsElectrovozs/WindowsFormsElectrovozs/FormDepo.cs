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
        private readonly Depo<Locomotive, RogaStandart> depo;
        public FormDepo()
        {
            InitializeComponent();
            depo = new Depo<Locomotive, RogaStandart>(pictureBoxDepo.Width, pictureBoxDepo.Height);
            Draw();
        }
        // Метод отрисовки депо
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxDepo.Width, pictureBoxDepo.Height);
            Graphics gr = Graphics.FromImage(bmp);
            depo.Draw(gr);
            pictureBoxDepo.Image = bmp;
        }
        // Обработка нажатия кнопки "Припарковать локомотив"
        private void buttonParkingLocomotive_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var locomotiv = new Locomotive(100, 1000, dialog.Color);
                if (depo + locomotiv)
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
                    if (depo + train)
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
            if (maskedTextBoxPlace.Text != "")
            {
                var train = depo - Convert.ToInt32(maskedTextBoxPlace.Text);
                if (train != null)
                {
                    FormElectrovoz form = new FormElectrovoz();
                    form.SetTrain(train);
                    form.ShowDialog();
                }
                Draw();
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
                if (depo == index)
                {
                    MessageBox.Show("Свободных мест в депо = " + index);
                }
                else if (depo != index)
                {
                    MessageBox.Show("Свободных мест в депо не " + index);
                }
            }
        }
    }
}
