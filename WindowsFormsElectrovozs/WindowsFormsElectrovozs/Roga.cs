using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsElectrovozs
{
    public class Roga
    {
        private DopPerechisl countRoga;
        public int CountRoga
        {
            set
            {
                if (value == 1)
                {
                    countRoga = DopPerechisl.one;
                }
                if (value == 2)
                {
                    countRoga = DopPerechisl.two;
                }
                if (value == 3)
                {
                    countRoga = DopPerechisl.three;
                }
            }
        }
        public void DrawRoga(Graphics g, float Posx, float Posy, Color dopColor)
        {
            for(int i = 0; i < (int)countRoga; i++)
            {
                DrawRog(g, Posx + 25 * i, Posy, dopColor);
            }

        }
        private void DrawRog(Graphics g, float _startPosX, float _startPosY, Color _dopColor)
        {
            Pen roga = new Pen(_dopColor, 2);
            g.DrawLine(roga, _startPosX + 5, _startPosY + 17, _startPosX + 10, _startPosY + 7);
            g.DrawLine(roga, _startPosX + 15, _startPosY + 17, _startPosX + 10, _startPosY + 7);
            g.DrawLine(roga, _startPosX + 5, _startPosY + 4, _startPosX + 10, _startPosY + 7);
            g.DrawLine(roga, _startPosX + 15, _startPosY + 4, _startPosX + 10, _startPosY + 7);
            g.DrawLine(roga, _startPosX + 5, _startPosY + 4, _startPosX + 10, _startPosY);
            g.DrawLine(roga, _startPosX + 15, _startPosY + 4, _startPosX + 10, _startPosY);
        }
    }
}
