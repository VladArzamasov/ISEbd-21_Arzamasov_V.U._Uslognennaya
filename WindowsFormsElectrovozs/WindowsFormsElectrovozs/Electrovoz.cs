using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsElectrovozs
{
    public class Electrovoz : Locomotive
    {
        public Color DopColor { private set; get; }
        public int Roga { private set; get; }
        private InterDop roga;
        // Признак наличия рогов
        public bool FrontRoga { private set; get; }
        // Признак наличия молнии
        public bool FrontLightning { private set; get; }
        // Конструктор
        public Electrovoz(int maxSpeed, float weight, int _countRoga, Color mainColor, Color dopColor, int rogaForm,
       bool frontRoga, bool frontLightning) : base(maxSpeed, weight, mainColor, 95, 68)
        {
            DopColor = dopColor;
            FrontRoga = frontRoga;
            FrontLightning = frontLightning;
            if (rogaForm == 0)
            {
                roga = new RogaStandart(_countRoga, dopColor);
            }
            else if (rogaForm == 1)
            {
                roga = new RogaXstyle(_countRoga, dopColor);
            }
            else if (rogaForm == 2)
            {
                roga = new RogaYstyle(_countRoga, dopColor);
            }
        }
        // Отрисовка электровоза
        public override void DrawTransport(Graphics g)
        {
            //отрисуем локомотив
            base.DrawTransport(g);
            // рога
            if (FrontRoga)
            {
                roga.DrawRoga(g, _startPosX, _startPosY);
            }
            // молния
            if (FrontLightning)
            {
                Pen molniya = new Pen(DopColor, 2);
                g.DrawLine(molniya, _startPosX + 15, _startPosY + 30, _startPosX + 10, _startPosY + 43);
                g.DrawLine(molniya, _startPosX + 10, _startPosY + 43, _startPosX + 15, _startPosY + 40);
                g.DrawLine(molniya, _startPosX + 15, _startPosY + 40, _startPosX + 10, _startPosY + 53);
            }
        }
    }
}
