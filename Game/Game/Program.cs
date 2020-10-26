using System;

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
            Console.WriteLine("The game will generate random number you should guess it");
            Random rnd = new Random();

            var randomNum = rnd.Next() % 100 + 1;
            // Console.WriteLine(randomNum);

            bool won = false;
            var count = 0;
            while (!won)
            {
                Console.WriteLine($"Enter your guess no. {count + 1}");
                count++;
                var g = Convert.ToInt32(Console.ReadLine());



                if (g > 100 || g < 1)
                {
                    Console.WriteLine("Wrong input, try again");
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
                    Console.WriteLine("You won!");
                    won = true;
                }

            }



        }
    }
}
