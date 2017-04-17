using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2._1.Figures
{
    public class TwoPointFigure : Figure
    {
       public TwoPointFigure(Point p1, Point p2)
        {
            this.P1 = p1;
            this.P2 = p2;
            this.A = Math.Abs(P1.X - P2.X);
        }
    }
}
