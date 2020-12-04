using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsElectrovozs
{
    public interface InterDop
    {
        int Number { set; }
        void DrawRoga(Graphics g, float Pozx, float Pozy);
    }
}
