using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyingBalls2
{
    [Serializable]
    class BallDoc
    {
        public List<Ball> Topcinja { get; set; }

        public int Width { get; set; }
        public int Misses { get; set; }
        
        public int Hit { get; set; }

        private static int Velocity = 10;
        public BallDoc(int w)
        {
            Hit = 0;
            Width = w;
            Misses = 0;
            Topcinja = new List<Ball>();
        }

        public void Draw(Graphics g)
        {
            foreach (var ball in Topcinja)
            {
                ball.Draw(g);
            }
        }

        public void Move()
        {
            foreach (var ball in Topcinja)
            {
                ball.move(new Point(ball.Center.X + Velocity, ball.Center.Y));
                if(ball.Center.X>=Width)
                {
                    ball.State = -1;
                }
            }

            for (int i = 0; i < Topcinja.Count; i++)
            {
                if(Topcinja[i].State==-1)
                {
                    Topcinja.RemoveAt(i);
                    Misses++;
                }
            }
        }

        public void Click(int x,int y)
        {
            foreach (var ball in Topcinja)
            {
                ball.move(new Point(ball.Center.X + Velocity, ball.Center.Y));
                if (ball.isHit(x,y))
                {
                    ball.State++; ;
                }
            }

            for (int i = 0; i < Topcinja.Count; i++)
            {
                if (Topcinja[i].State == 3)
                {
                    Hit++;
                    Topcinja.RemoveAt(i);
                }
            }

        }

        public void addBall(Ball b)
        {
            Topcinja.Add(b);
        }
    }
}
