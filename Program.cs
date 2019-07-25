using System;
using System.Collections.Generic;
using System.Linq;
using ScrabbleProgram;

namespace Scrabble
{
    public class ProjectName
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a word");
            string userString = Console.ReadLine().ToLower();
            Game newGame = new Game();
            int FinalScore = newGame.TallyPoints(userString);
            Console.WriteLine("total:  " + FinalScore);
        }
    }
}


