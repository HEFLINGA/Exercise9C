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
            bool cont = true;
            int input;
            BisectionAlgorithm b = new BisectionAlgorithm();
            do
            {                
                Console.WriteLine("1: Basic Bisection Algorithm." +
                    "\n\n2: Guess my number, human plays" +
                    "\n\n3: Guess my number, computer plays" +
                    "\n\n99: Exit");
                input = int.Parse(Console.ReadLine());

                if (input == 1 || input == 2 || input == 3 || input == 99)
                {
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
                        case 99:
                            cont = false;
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Try again....");
                }
                
            } while (cont == true);
            Console.WriteLine("Have a nice day!");
            Console.WriteLine("Press 'enter' to exit..");
            Console.ReadLine();
        }
    }
}
