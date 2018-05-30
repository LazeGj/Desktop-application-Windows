using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawLines
{
    public class LineDoc
    {
        public List<Line> lines { get; set; }

        public LineDoc()
        {
            lines = new List<Line>();
        }

        public void addLine(Line l)
        {
            lines.Add(l);
        }

        public void drawLines(Graphics g)
        {
            foreach (var line in lines)
            {
                line.Draw(g);
            }
        }
    }

  

}
