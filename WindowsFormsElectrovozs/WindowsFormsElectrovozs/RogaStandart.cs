using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsElectrovozs
{
    public class RogaStandart : InterDop
    {
        private DopPerechisl _countRoga;

        public int Number { set => _countRoga = (DopPerechisl)value; }

        public Color DopColor { private set; get; }

        public RogaStandart(int roga, Color dopColor)
        {
            Number = roga;
            DopColor = dopColor;
        }

        public void DrawRoga(Graphics g, float Pozx, float Pozy)
        {
            for (int i = 0; i < (int)_countRoga; i++)
            {
                DrawRog(g, Pozx + 25 * i, Pozy);
            }
        }
        private void DrawRog(Graphics g, float _startPosX, float _startPosY)
        {
            Pen roga = new Pen(DopColor, 2);
            g.DrawLine(roga, _startPosX + 5, _startPosY + 17, _startPosX + 10, _startPosY + 7);
            g.DrawLine(roga, _startPosX + 15, _startPosY + 17, _startPosX + 10, _startPosY + 7);
            g.DrawLine(roga, _startPosX + 5, _startPosY + 4, _startPosX + 10, _startPosY + 7);
            g.DrawLine(roga, _startPosX + 15, _startPosY + 4, _startPosX + 10, _startPosY + 7);
            g.DrawLine(roga, _startPosX + 5, _startPosY + 4, _startPosX + 10, _startPosY);
            g.DrawLine(roga, _startPosX + 15, _startPosY + 4, _startPosX + 10, _startPosY);
        }
    }
}
