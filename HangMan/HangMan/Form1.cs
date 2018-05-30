using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangMan
{
    public partial class Form1 : Form
    {
        Hangman game;
        private int timeElapsed;
        public Form1()
        {
            InitializeComponent();
            newGame();

        }
        void upDateTime()
        {
            int left = Hangman.TIME - timeElapsed;
            int min = left / 60;
            int sec = left % 60;

            time.Text = String.Format("{0:00}:{1:00}", min, sec);
            //to update the label for time
        }
        void newGame()
        {
            game = new Hangman("Macedonia");//to be continued
            timeElapsed = 0;
            upDateTime();
            timer1.Start();
           
            timeLeft.Maximum = Hangman.TIME;
            timeLeft.Value = 10;
            
            unnsTries.Maximum = Hangman.TRIES;
            unnsTries.Value = game.WrongCount;

            MaskedWord.Text=game.init();
            MessageBox.Show(game.init());
            updateGuessedLetters();
            
        }

        private void enterLetter()
        {
            if (letterToSubmit.Text.Length > 0)
            {
                Char c = Convert.ToChar(letterToSubmit.Text.ToLower());

                if (!game.check(c))
                {
                    MessageBox.Show("The letter is alredy used");
                    return;
                }

                game.lastTry = c;
               
                updateWordMask();
                updateGuessedLetters();
                checkState();
                unnsTries.Value = game.WrongCount;
            }
        }

        private void checkState()
        {
            if(game.IsGuessed)
            {
                game.IsGuessed = false;
                if (MessageBox.Show("The game is over, your time elapsed", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                    newGame();
                     }
            }
            else if(timeLeft.Value==0)
            {
                if(MessageBox.Show("The game is over, your time elapsed","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                    timer1.Stop();
                    newGame();
                }
            }
           
        }
        private void submit_Click(object sender, EventArgs e)
        {
            enterLetter();
                        
        }

        private void updateWordMask()
        {
            MaskedWord.Text = game.guess();
        }

        private void updateGuessedLetters()
        {
            allLetters.Text = game.allLetters();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeElapsed++;
            upDateTime();
            if (timeLeft.Value == 0)
                timer1.Stop();
            checkState();
            timeLeft.Value = timeLeft.Value - 1;
          
           
        }
    }
}
