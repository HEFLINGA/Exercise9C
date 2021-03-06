﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9C_NumberGame
{
    class BisectionAlgorithm
    {
        int iterations = 0;
        int total = 0;
        int count = 0;

        private int BisectionAlg(int[] list, int input)
        {
            int left = 0;
            int right = list.Length;            

            while (left <= right)
            {
                int center = left + (right - left) / 2;
                iterations++;
                Console.WriteLine($"{center}");

                if (list[center] > input)
                {
                    right = center - 1;
                }
                else if (list[center] < input)
                {
                    left = center + 1;
                }
                else
                {
                    return center;
                }
            }

            return iterations;
        }
        private void HumPlaysGuesser(int compInput)
        {
            iterations = 0;
            double avg = 0.0;
            bool guessedIt = false;
            int input = 0;
            Console.WriteLine("Please guess a number between 1 and 1000.. human..");

            while (guessedIt == false)
            {
                input = int.Parse(Console.ReadLine());
                if (input > 0 && input <= 1000)
                {
                    if (input > compInput)
                    {
                        Console.WriteLine("To High. Guess again.");
                        iterations++;
                    }
                    else if (input < compInput)
                    {
                        Console.WriteLine("To Low. Guess again.");
                        iterations++;
                    }
                    else if (input == compInput)
                    {
                        total += iterations;
                        count += 1;
                        avg = total / count;
                        Console.WriteLine($"You guessed it, number was {compInput} alllll alonnnngggg, and took you {iterations} iterations." +
                            $"\nTaking you an avarage (so far) of {avg}");
                        
                        guessedIt = true;
                    }
                }
                else
                {
                    Console.WriteLine("No valid input" +
                        "\nPress 'enter' to continue..");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }                
            }            
        }
        private void CompPlaysGuesser(int num)
        {
            iterations = 0;
            int check = 0;
            int[] list = new int[100];
            int input = 0;

            bool cont = true;
            int left = 0;
            int right = list.Length;

            while (left <= right && cont == true)
            {
                int center = left + (right - left) / 2;
                
                iterations++;
                Console.Clear();
                Console.WriteLine($"Your number: {num}");
                Console.WriteLine("1. for to high \n2. for to low. \n3. for JUUSTT RIGHT!");
                Console.WriteLine($"Computers Guess: {center}");
                Console.WriteLine("Rest of current list: ");
                for (int i = center; i < right; i++)
                {
                    list[i] = i + 1;
                    check = list[i];
                    Console.Write($"{check} ");                    
                }
                Console.WriteLine("");
                input = int.Parse(Console.ReadLine());

                if (input == 1 || input == 2 || input == 3)
                {
                    if (input == 1)
                    {
                        right = center - 1;
                    }
                    else if (input == 2)
                    {
                        left = center + 1;
                    }
                    else if (input == 3)
                    {
                        total += iterations;
                        count += 1;
                        double avg = total / count;
                        Console.WriteLine($"Computer got it right, taking {iterations},  average is: {avg}");
                        cont = false;
                    }
                }
                else
                {
                    Console.WriteLine("No valid input detected");
                }                
            }           
        }

        public void RunBasic()
        {
            int[] list = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int input = 0;
            Console.Clear();
            Console.WriteLine("Please enter your number Between 1 and 10");
            input = int.Parse(Console.ReadLine());

            if (input <= 0 || input > 10)
            {
                Console.WriteLine("No valid input");
                Console.WriteLine("Press 'enter' to continue");
                Console.ReadLine();
                Console.Clear();
            }
            else if(input > 0 && input <= 10)
            {
                Console.WriteLine($"Your number was {BisectionAlg(list, input)}, it took {iterations} iterations.");
                Console.WriteLine("Press 'enter' to continue");
                Console.ReadLine();
                Console.Clear();
                iterations = 0;
                total = 0;
                count = 0;
            }            
        }
        public void RunHumanPlays()
        {
            string answer = "";
            bool again = true;
            do
            {
                Console.Clear();
                Random rnd = new Random();
                int compInput = rnd.Next(1, 1000);
                HumPlaysGuesser(compInput);
                Console.WriteLine("Go again? Y for yes, N for no.");
                answer = Console.ReadLine().ToLower();
                if (answer == "y")
                {
                    again = true;
                }
                else if (answer == "n")
                {
                    Console.Clear();
                    iterations = 0;
                    total = 0;
                    count = 0;
                    again = false;
                }
                else
                {
                    Console.WriteLine("No valid input" +
                        "\nPress 'enter' to continue..");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (again == true);
            
        }
        public void RunCompPlays()
        {
            string answer = "";
            int num = 0;
            bool again = true;

            Console.Clear();
            Console.WriteLine("Input a number 1-100! (this will just be to help you remember it, but you must still tell the comp if they are high or low. NO LYING TO THE COMPUTER.).");
            num = int.Parse(Console.ReadLine());

            if (num >= 1 && num <= 100)
            {
                CompPlaysGuesser(num);
                do
                {
                    Console.WriteLine("Play again? Y for yes, N for no.");
                    answer = Console.ReadLine().ToLower();
                    if (answer == "y")
                    {
                        Console.WriteLine("Input a number! (this will just be to help you remember it, but you must still tell the comp if they are high or low. NO LYING TO THE COMPUTER.).");
                        num = int.Parse(Console.ReadLine());
                        if (num >= 1 && num <= 100)
                        {
                            CompPlaysGuesser(num);
                            again = true;
                        }
                        else
                        {
                            Console.WriteLine("No valid input" +
                            "\nPress 'enter' to continue..");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        
                    }
                    else if (answer == "n")
                    {
                        Console.Clear();
                        iterations = 0;
                        total = 0;
                        count = 0;
                        again = false;
                    }
                    else
                    {
                        Console.WriteLine("No valid input" +
                            "\nPress 'enter' to continue..");
                        Console.ReadLine();
                        Console.Clear();
                    }
                } while (again == true);
            }
            else
            {
                Console.WriteLine("No valid input" +
                            "\nPress 'enter' to continue..");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
