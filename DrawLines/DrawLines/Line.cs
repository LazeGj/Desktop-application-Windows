using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawLines
{
    public class Line
    {
        public Point prev { get; set; }
        public Point curr { get; set; }

        public int Witdh { get; set; }

        public Line(Point prev, Point curr,int Witdh)
        {
            this.prev = prev;
            this.curr = curr;
            this.Witdh = Witdh;
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black,Witdh);
            g.DrawLine(pen, prev, curr);
            pen.Dispose();
        }
    }
}
