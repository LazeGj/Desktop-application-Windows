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

        public int HEIGHT = 10 * 40 + 10;
        public int WIDTH = 40 * 15 + 10;
        public Pacman()
        {
            Center = new Point(40*7+10,5*40+10);
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
        public void Move(int startX,int startY)
        {
            OpenMouth = !OpenMouth;

            if (Direction == Direction.down)
            {
                Center = new Point(Center.X, Center.Y + 1*40);
                if (!checkValidate(Center, this.WIDTH,this.HEIGHT, startX, startY)) 
                {
                    Center = new Point(Center.X, 10);
                }
            }

            else if (Direction == Direction.up)
            {
                Center = new Point(Center.X, Center.Y - 1*40);

                if (!checkValidate(Center, this.WIDTH, this.HEIGHT, startX, startY)) 
                {

                    Center = new Point(Center.X, this.HEIGHT );
                }
            }

            else if (Direction == Direction.right)
            {
                Center = new Point(Center.X + 40, Center.Y);
                if (!checkValidate(Center, this.WIDTH, this.HEIGHT, startX, startY)) 
                {

                    Center = new Point(10, Center.Y);
                }

            }

            else
            {
                Center = new Point(Center.X - 40, Center.Y);
                if (!checkValidate(Center, this.WIDTH, this.HEIGHT, startX, startY)) 
                {
                    
                    Center = new Point(this.WIDTH, Center.Y);
                }
            }



        }

        public bool eat(Point orangeCenter)
        {
            /* var diff = Math.Abs((Center.X - orangeCenter.Y) + (Center.Y - orangeCenter.Y));

             if (diff < 20)
                 return true;
             return false;*/
            return Center.Equals(orangeCenter);
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
