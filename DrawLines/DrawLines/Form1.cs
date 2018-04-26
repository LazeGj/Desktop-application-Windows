using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DrawLines
{
    public partial class Form1 : Form
    {
        private static int SMALL=5;
        private static int MEDIUM = 10;
        private static int LARGE = 15;
        public LineDoc lineDoc;
        public Point currentPos;
        private Pen dashPen;
        public bool hasPosionate;
        Point lastPointed;
        int width;
        Stack<Line> undoStack;
        Stack<Line> redoStack;
        public Form1()
        {
            undoStack = new Stack<Line>();
            redoStack = new Stack<Line>();
            hasPosionate = true;
            width = MEDIUM;
            lineDoc = new LineDoc();
            InitializeComponent();
            DoubleBuffered = true;
            dashPen = new Pen(Color.Gray, 1);
            lastPointed = new Point();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Point newPoint = new Point(e.X, e.Y);
            if (!lastPointed.IsEmpty)
            {
                Line l = new Line(lastPointed, newPoint, width);
                lineDoc.addLine(l);
                undoStack.Push(l);
            }
            
            lastPointed = newPoint;
            Invalidate(true);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
            e.Graphics.Clear(Color.White);
            if(hasPosionate)
            {
                e.Graphics.DrawLine(dashPen, 0, currentPos.Y, this.Width, currentPos.Y);
                e.Graphics.DrawLine(dashPen, currentPos.X, 0, currentPos.X, this.Height);
            }

            
            lineDoc.drawLines(e.Graphics);
                       
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            currentPos = new Point(e.X, e.Y);
            Invalidate(true);
        }

        private void undoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Line undoLine = undoStack.Pop();
            lineDoc.lines.Remove(undoLine);
            redoStack.Push(undoLine);
            Invalidate(true);
        }

        private void redoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (redoStack.Count != 0)
            {
                Line redoLine = redoStack.Pop();
                undoStack.Push(redoLine);
                lineDoc.addLine(redoLine);
                Invalidate(true);
            }
        }
    }
}
