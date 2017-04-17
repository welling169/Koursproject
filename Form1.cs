using laba2._1.Drawers;
using laba2._1.Figures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba2._1
{
    public partial class mainform : Form
    {

        private List<Point> listP = new List<Point>();
        private Drawer drawer = new Drawer();

        public mainform()
        {
            InitializeComponent();
        }

        private void pbpaint_MouseDown(object sender, MouseEventArgs e)
        {
            listP.Add(new Point(e.X, e.Y));

            if (rbtriangle.Checked == false && listP.Count > 2)
                listP.Clear();

            if (listP.Count == 2 && !rbtriangle.Checked)
            {
                TwoPointFigure twopointsfigure = new TwoPointFigure(listP[0], listP[1]);

                if (rbline.Checked == true)                
                    twopointsfigure.TYPE = "line"; 
                                                                       
                if (rbellipse.Checked == true)
                    twopointsfigure.TYPE = "ellipse";

                if (rbcircle.Checked == true)
                    twopointsfigure.TYPE = "circle";

                if (rbrectangle.Checked == true)
                    twopointsfigure.TYPE = "rectangle";

                if (rbsquare.Checked == true)
                    twopointsfigure.TYPE = "square";

                drawer.draw(twopointsfigure, pbpaint.CreateGraphics(), new Pen(Color.Black, 3));
                listP.Clear();
            }

            if (listP.Count == 3 && rbtriangle.Checked == true)
            {
                ThreePointFigure threepointsfigure = new ThreePointFigure(listP[0], listP[1], listP[2]);
                drawer.draw(threepointsfigure, pbpaint.CreateGraphics(), new Pen(Color.Black, 3));
                listP.Clear();    
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            pbpaint.Refresh();
        }
    }
}
