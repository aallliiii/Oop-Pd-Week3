using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JapaneseGame.BL;

namespace JapaneseGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game g = new Game();
            while (true)
            {
                while (g.GameCondition != false)
                {
                    Console.Clear();
                    string word;
                    Console.WriteLine("Enter Word: ");
                    word = Console.ReadLine();
                    g.CheckGameConditions(word);

                }
                Console.Clear();
                Console.WriteLine("Would you like to Restart again");
                Console.WriteLine("Press 1 for yes and 2 for No");
                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    g.Restart();
                }
                else
                {
                    break;
                }
            }
            Console.Clear() ;
            Console.WriteLine("Game Closed");
            Console.ReadLine();
        }
    }
}
