using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyingBalls2
{
    public partial class Form1 : Form
    {
        String FileName;
        BallDoc ballDoc;
        Timer Timer;
        int thickCount;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();

            FileName = null;
            DoubleBuffered = true;
            thickCount = 0;
            ballDoc = new BallDoc(this.Width);
            Timer = new Timer();
            Timer.Enabled = true;
            Timer.Interval = 200;
            Timer.Tick += new EventHandler(this.Thick);
            Timer.Start();
            this.Paint += new PaintEventHandler(this.Paint_Form);
            this.MouseClick += new MouseEventHandler(this.Mouse_Click);
        }

        public void Thick(Object sender, EventArgs e)
        {
            if(thickCount%5==0)
            {
                
                Ball.Radius = (int)(this.Width * 0.02);
                int randomY = r.Next(0 + Ball.Radius*2, this.Height - Ball.Radius*2);
                Ball b = new Ball(new Point(-Ball.Radius, randomY));
                
                ballDoc.addBall(b);
            }
            thickCount++;
            ballDoc.Move();
            Invalidate(true);
        }

        public void Paint_Form(Object sender, PaintEventArgs e)
        {
            ballDoc.Draw(e.Graphics);

        }

        public void Mouse_Click(Object sender, MouseEventArgs e)
        {
            ballDoc.Click(e.X, e.Y);
            Invalidate(true);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileName = null;
            OpenFileDialog op = new OpenFileDialog();
            if(op.ShowDialog()==DialogResult.OK)
            {
                FileName = op.FileName;
            }
            if (FileName != null)
            {

                System.Runtime.Serialization.IFormatter formatter = new System.Runtime.Serialization.
                Formatters.Binary.BinaryFormatter();
                FileStream str = new FileStream(FileName, FileMode.Open);
                ballDoc = (BallDoc)formatter.Deserialize(str);
                str.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            if (FileName == null)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Ball File (*.bll)| *.bll";
                save.Title = "Save ball file";
                if(save.ShowDialog()==DialogResult.OK)
                {
                    FileName = save.FileName;

                }

            }


            if (FileName!=null)
            {
                System.Runtime.Serialization.IFormatter formatter = new System.Runtime
                    .Serialization.Formatters.Binary.BinaryFormatter();
                FileStream str = new FileStream(FileName,FileMode.Create,FileAccess.Write);

                formatter.Serialize(str, ballDoc);
                str.Close();
            }

            Timer.Start();
        }

        private void toolStripStatusLabel1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = String.Format("Hits {0}    Misses {1}", ballDoc.Hit, ballDoc.Misses);
        }
    }
}
