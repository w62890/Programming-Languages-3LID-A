using System;
using System.Collections.Generic;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Game();
        }

        private static void Game()
        {
            Console.WriteLine("The game will generate random number ([1 ; 100]) you should guess it");
            Console.WriteLine("Enter number of Players: ");
            var ppl = Convert.ToInt32(Console.ReadLine());

            var arr = new List<string>();

            for (int i = 0; i < ppl; i++)
            {
                Console.WriteLine($"Enter {i + 1} player name: ");

                arr.Add(Console.ReadLine());
            }

            Random rnd = new Random();

            var randomNum = rnd.Next() % 100 + 1;
            //Console.WriteLine($"Shhhhhhhhhhh your rnd num: {randomNum}");

            var flag = false;
            while (!flag)
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    Console.WriteLine($"Turn of player {arr[i]}, Enter your guess");

                    var g = Convert.ToInt32(Console.ReadLine());



                    if (g > 100 || g < 1)
                    {
                        Console.WriteLine("Wrong input, you skip ^^");
                    }
                    else if (g < randomNum)
                    {
                        Console.WriteLine("Too small");
                    }
                    else if (g > randomNum)
                    {
                        Console.WriteLine("Too big");
                    }
                    else if (g == randomNum)
                    {
                        Console.WriteLine($"The player {arr[i]} won!");
                        flag = true;
                        break;
                    }


                }

            }



        }
    }
}
