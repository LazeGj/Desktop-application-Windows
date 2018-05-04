using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public enum Direction
    {
        up,
        down,
        left,
        right
    }
    public class Pacman
    {
        public Point Center { get; set; }

        public Direction Direction { get; set; }

        public int Radius { get; set; }
        public int Speed { get; set; }

        public bool OpenMouth { get; set; }

        public Brush MyBrush { get; set; }

        public Pacman()
        {
            Center = new Point(20*7,5*20);
            Direction = Direction.right;
            MyBrush = new SolidBrush(Color.Yellow);
            OpenMouth = true;
            Radius = 20;
            Speed = Radius;
        }

        public void ChangeDirecton(Direction direction)
        {
            Direction = direction;
        }


        private bool checkValidate(Point center, int width,int height,int startX,int startY)
        {
            if (center.X < startX)
                return false;
            if (center.Y < startY)
                return false;
            if (center.X > width)
                return false;
            if (center.Y > height)
                return false;
            return true;
        }
        public void Move(int startX,int startY,int Widht,int Height)
        {
            OpenMouth = !OpenMouth;

            if (Direction == Direction.down)
            {
                Center = new Point(Center.X, Center.Y + 1*20);
                if (!checkValidate(Center, Widht, Height, startX, startY)) ;
                {
                    Center = new Point(Center.X, 20);
                }
            }

            else if (Direction == Direction.up)
            {
                Center = new Point(Center.X, Center.Y - 1*20);

                if (!checkValidate(Center, Widht, Height, startX, startY)) ;
                {

                    Center = new Point(Center.X, Height - 20);
                }
            }

            else if (Direction == Direction.right)
            {
                Center = new Point(Center.X + 20, Center.Y);
                if (!checkValidate(Center, Widht, Height, startX, startY)) ;
                {

                    Center = new Point(20, Center.Y);
                }

            }

            else
            {
                Center = new Point(Center.X - 20, Center.Y);
                if (!checkValidate(Center, Widht, Height, startX, startY)) ;
                {
                    
                    Center = new Point(Widht-20, Center.Y);
                }
            }



        }

        public bool eat(Point orangeCenter)
        {
            var diff = Math.Abs((Center.X - orangeCenter.Y) + (Center.Y - orangeCenter.Y));

            if (diff < 20)
                return true;
            return false;
        }

        public void  Draw(Graphics g)
        {
            if(OpenMouth)
            {
                g.FillPie(this.MyBrush, new Rectangle(Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius), 45, 315);
                return;
            }

            g.FillEllipse(this.MyBrush, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);

        }
    }
}
