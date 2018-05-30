
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyingBalls2
{
    [Serializable]
    class Ball
    {
        public Point Center { get; set; }

        public int State { get; set; }

        public static int Radius { get;  set; }

        Random r = new Random();


        public Ball(Point center)
        {            
            
            Center = center;
            State = r.Next(0, 3);
        }

        public void move(Point newCenter)
        {
            Center = newCenter;
        }


        public void Draw(Graphics g)
        {
            Brush b = null;
            if (State == 0)
            {
                b = new SolidBrush(Color.Green);
                g.FillEllipse(b, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            }

            else if (State == 1)
            {
                b = new SolidBrush(Color.Blue);
                g.FillEllipse(b, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            }

            else if (State == 2)
            {
                b = new SolidBrush(Color.Red);
                g.FillEllipse(b, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            }
        }
        public bool isHit(int x ,int y)
        {
            var diff = Math.Abs(Center.X - x) + Math.Abs(Center.Y - y);

            return diff <= Radius * 2;

        }
    }

}
