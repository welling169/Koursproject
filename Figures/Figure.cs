using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace laba2._1.Figures
{
    public abstract class Figure
    {
        private Point p1;
        private Point p2;
        private string type = "";
        private int a;

        public int A
        {
            get { return a; }
            set { this.a = value; }
        }

        public string TYPE
        {
            get { return type; }
            set { this.type = value; }
        }

        public Point P1
        {
            get { return p1; }
            set { this.p2 = value; }
        }

        public Point P2
        {
            get { return p2; }
            set { this.p1 = value; }
        }
    }
}
