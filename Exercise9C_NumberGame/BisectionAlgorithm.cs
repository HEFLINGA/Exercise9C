using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9C_NumberGame
{
    class BisectionAlgorithm
    {
        int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int input = 0;

        private void Bisection(int input, int[] list)
        {
            int tmp = 0;
            Console.WriteLine("Input a number between 1 and 10");
            input = int.Parse(Console.ReadLine());

            if (input >= 1 && input <= 10)
            {
                for(int i = 0; i < list.Length; i++)
                {
                    tmp = list[i];
                    Console.WriteLine($"{tmp}");                    
                }
                Console.WriteLine($"Your number is {tmp}");
            }
            else
            {
                Console.WriteLine("No valid input detected. Program termination imminent");
            }
        }

        public void Run()
        {
            Bisection(input, list);
        }
    }
}
