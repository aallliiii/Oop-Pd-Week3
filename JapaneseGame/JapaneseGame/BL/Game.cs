using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace JapaneseGame.BL
{
    internal class Game
    {
        public List<string> Characters;
        public bool GameCondition;

        public Game()
        {
            Characters = new List<string>();
            GameCondition = true;
        }

        public void CheckGameConditions(string word)
        {
            int ListLength = Characters.Count - 1;
            int wordLength;
            if (ListLength == -1)
            {
                wordLength = 0;
            }
            else
            {
                wordLength = Characters[ListLength].Length - 1;
            }


            if (ListLength == -1 || (word[0] == Characters[ListLength][wordLength] && (!Characters.Contains(word))))
            {
                Characters.Add(word);


            }
            else
            {
                GameCondition = false;

            }
        }

        public void Restart()
        {
            Characters.Clear();
            GameCondition = true;
        }
    }
}
