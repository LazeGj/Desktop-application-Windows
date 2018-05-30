using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    public class Hangman
    {
        public static int TIME = 600;
        public static int TRIES = 10;
        public String Word { get; set; }

        public HashSet<Char> WordLetters { get; set; }

       public HashSet<Char> AllLetters { get; set; }

        public int WrongCount { get; set; }
        public bool IsGuessed { get; set; }

        public char lastTry { get; set; }
        public Hangman(string word)
        {
            IsGuessed = false;
            WrongCount = 0;
            Word = word;
            WordLetters = new HashSet<char>();
           

            AllLetters = new HashSet<char>();


        }


       

        public bool check(char c)
        {
            if(AllLetters.Contains(c))
            {
                return false;
            }
            return true;
        }

        public String init()
        {
            StringBuilder word = new StringBuilder();
          
            foreach (char item in Word)
            {               
                    word.Append("_" + " ");
                
             }

            
            return word.ToString();
        }

        public String allLetters()
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 'a'; i < 'z'; i++)
            {
                if (AllLetters.Contains((char)i))
                    stringBuilder.Append((char)i+" ");
                else
                    stringBuilder.Append("_" + " ");
            }

            return stringBuilder.ToString();
        }

        public String guess()
        {
            int isFinish = 0;
            AllLetters.Add(lastTry);
                        StringBuilder word = new StringBuilder();
            if (!Word.Contains(lastTry) && !Word.Contains(char.ToUpper(lastTry)))
                    WrongCount++;
            if (Word.Contains(lastTry) || Word.Contains(char.ToUpper(lastTry)))
            {
                WordLetters.Add(lastTry);

            }
            for(int i=0;i<Word.Length;++i)
            {
                char c = Char.ToLower(Word[i]);
                if (WordLetters.Contains(c))
                {
                    word.Append(c + " ");
                    isFinish++;
                }

                else
                {
                    word.Append("_" + " ");
                }

            }
            if (isFinish == Word.Count())
                IsGuessed = true;


            return word.ToString();

        }
    }
}
