using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9C_NumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            BisectionAlgorithm b = new BisectionAlgorithm();

            Console.WriteLine("Basic Bisection Algorithm: 1. " +
                "\n\nGuess my number, human plays: 2." +
                "\n\nGuess my number, computer plays: 3.");
            input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    b.RunBasic();
                    break;
                case 2:
                    b.RunHumanPlays();
                    break;
                case 3:
                    b.RunCompPlays();
                    break;
            }
            
        }
    }
}
