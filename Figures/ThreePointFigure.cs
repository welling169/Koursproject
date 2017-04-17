using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace laba2._1.Figures
{
    public class ThreePointFigure : TwoPointFigure
    {
        private Point p3; 

        public ThreePointFigure(Point p1, Point p2, Point p3) : base (p1,p2)
        {
            this.P3 = p3;
        }

        public Point P3
        {
            get { return p3; }
            set { this.p3 = value; }
        }

    }
}
