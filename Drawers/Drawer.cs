using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using laba2._1.Figures;
using System.Drawing;

namespace laba2._1.Drawers
{
    class Drawer
    {   
        public void draw(TwoPointFigure el, Graphics g, Pen p)
        {
            string type = el.TYPE;

            if (type == "line")
                g.DrawLine(p, el.P1, el.P2);

            if (type == "rectangle")
                g.DrawRectangle(p, new Rectangle(el.P1.X, el.P1.Y, Math.Abs(el.P2.X - el.P1.X), Math.Abs(el.P2.Y - el.P1.Y)));

            if (type == "ellipse")
                g.DrawEllipse(p, new Rectangle(el.P1.X, el.P1.Y, Math.Abs(el.P2.X - el.P1.X), Math.Abs(el.P2.Y - el.P1.Y)));

            if (type == "square")
                g.DrawRectangle(p, new Rectangle(el.P1.X, el.P1.Y, el.A, el.A));

            if (type == "circle")
                g.DrawEllipse(p, new Rectangle(el.P1.X, el.P1.Y, el.A, el.A));
        }

        public void draw(ThreePointFigure el, Graphics g, Pen p)
        {
            g.DrawLine(p, el.P1, el.P2);
            g.DrawLine(p, el.P2, el.P3);
            g.DrawLine(p, el.P3, el.P1);
        }
    }
}
