using Pacman.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman
{
    public partial class Form1 : Form
    {
        private Pacman game;
        
        static readonly int TIMER_INTERVAL = 250;
        static readonly int WORLD_WIDTH = 15;
        static readonly int WORLD_HEIGHT = 10;
        Timer timer;
        Image foodImage;
        bool[][] foodWorld;
        Point[][] foodLocation;
        
        
        public Form1()
        {
            this.DoubleBuffered = true;
            game = new Pacman();
            timer = new Timer();
            timer.Enabled = true;
            timer.Start();
            foodImage = Resources.GameOrange;
       
            InitializeComponent();

            foodWorld = new bool[15][];
            for(int i=0;i<foodWorld.Length;++i)
            {
                foodWorld[i] = new bool[10];
            }

            for (int i = 0; i < foodWorld.Length; ++i)
            {
                for (int j = 0; j < foodWorld[0].Length; ++j)
                    foodWorld[i][j] = true;
            }

            foodLocation = new Point[15][];
            for (int i = 0; i < foodWorld.Length; ++i)
            {
                foodLocation[i] = new Point[10];
            }

            for (int i = 0; i < foodWorld.Length; ++i)
            {
                for (int j = 0; j < foodWorld[0].Length; j++)
                        foodLocation[i][j] = new Point(i*40+10,j*40+10);
            }
        }


        private void drawOranges(Graphics g)
        {
            for(int i=0;i<foodWorld.Length;++i)
            {
                for(int j=0;j<foodWorld[0].Length;++j)
                {
                    if(i==7 && j==5)
                    {
                        continue;
                    }
                    else if(foodWorld[i][j])
                    {
                        //MessageBox.Show("dsads");
                        g.DrawImage(foodImage,foodLocation[i][j].X-20, foodLocation[i][j].Y-20, 2*20,2*20);
                    }
                }
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            drawOranges(e.Graphics);
            game.Draw(e.Graphics);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            game.Move(20,20,this.Width,this.Height);
            for(int i=0;i<foodLocation.Length;++i)
            {
                for(int j=0;j<foodLocation[0].Length;++j)
                {
                    if (game.eat(foodLocation[i][j]))
                        foodWorld[i][j] = false;
                }
            }

            Invalidate(true);
        }
    }
}
