using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace HW_11_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrays();
        }

        public static void Ex11()
        {
            // using array
            Console.WriteLine("Enter the number of number ( array )");
            var c = Convert.ToInt32(Console.ReadLine());

            var arr = new int[c];

            for (int i = 0; i < c; i++)
            {
                Console.Write("Please enter the num: ");
                var num = Convert.ToInt32(Console.ReadLine());
                arr[i] = num;
            }

            Console.WriteLine($"Sum is {arr.Sum()}, Avg is {arr.Average()}");

            // using list
            Console.WriteLine("Enter the number of number ( list )");
            var c1 = Convert.ToInt32(Console.ReadLine());

            var arr1 = new List<int>();

            for (int i = 0; i < c; i++)
            {
                Console.Write("Please enter the num: ");
                var num = Convert.ToInt32(Console.ReadLine());
                arr1.Add(num);
            }

            Console.WriteLine($"Sum is {arr1.Sum()}, Avg is {arr1.Average()}");

        }

        public static void Ex12a()
        {
            Console.WriteLine("Enter the numbers, enter the Enter to stop");


            var min = 0.0;
            var count = 0;
            var max = 0.0;
            var sum = 0.0;

            while (true)
            {
                Console.Write("Please enter the num: ");
                var str = Console.ReadLine();
                if (str == "")
                {
                    Console.WriteLine($"Sum is {sum}, Avg is {sum / count}");
                    return;
                }
                var num = Convert.ToDouble(str);
                if (count == 0)
                {
                    min = num;
                    max = num;
                    sum += num;
                    count++;
                }
                else
                {
                    if (num > max)
                    {
                        max = num;
                    }

                    if (num < min)
                    {
                        min = num;
                    }

                    sum += num;

                    count++;

                }



            }
        }

        public static void Ex12b()
        {
            Console.WriteLine("Enter the numbers, enter the Enter to stop");

            var arr = new List<double>();

            while (true)
            {
                Console.Write("Please enter the num: ");
                var str = Console.ReadLine();
                if (str == "")
                {
                    Console.WriteLine($"Sum is {arr.Sum()}, Avg is {arr.Average()}, Min is {arr.Min()}, Max is {arr.Max()}");
                    return;
                }
                var num = Convert.ToDouble(str);
                arr.Add(num);



            }



        }

        public static void Arrays()
        {
            // int[] arr = { -1, 3, 4, 5, 7 , -1 , -3};

            int[] arr1 = { -1, 3, 4, 5, 7, -1, -3 };
            int[] arr2 = { 2, 3, 4, 5 };

            var result = ArrayUtils.Zip(arr1, arr2);

            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }




            Console.WriteLine();
            var result1 = ArrayUtils.Accum(arr2);

            foreach (var item in result1)
            {
                Console.Write($"{item} ");
                
            }
        }


    }
}
