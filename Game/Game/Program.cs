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
            Console.WriteLine("Two players requiered");
            Console.WriteLine("Player one name: ");
            var pl1 = Console.ReadLine();
            Console.WriteLine("Player two name: ");
            var pl2 = Console.ReadLine();

            Random rnd = new Random();

            var randomNum = rnd.Next() % 100 + 1;
            Console.WriteLine(randomNum);

            bool won = false;
            var pls = 0;
            var count = 0;

            if (rnd.Next() % 2 == 0)
            {
                pls = 1;
                Console.WriteLine("Player one is the first");
            }
            else
            {
                pls = 2;
                Console.WriteLine("Player two in the first");
            }



            while (!won)
            {
                for (int i = pls; i <= 2; i++)
                {
                    Console.WriteLine($"Turn of player {i}, Enter your guess");

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

                        switch (pls)
                        {
                            case 1:
                                Console.WriteLine($"{pl1} won!");
                                break;
                            case 2:
                                Console.WriteLine($"{pl2} won!");
                                break;
                            default:
                                break;
                        }

                        won = true;
                        break;
                    }


                }
                pls = 1;

            }



        }
    }
}
