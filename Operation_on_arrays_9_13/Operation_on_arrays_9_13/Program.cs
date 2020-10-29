using System;

namespace Operation_on_arrays_9_13
{
    class Program
    {
        static void Main(string[] args)
        {
            // FluttenTest2();
        }

        public static void DiagonalTest()
        {
            int[,] array = { { 1, 4, -2 }, { 3, 6, 1 } };
            var result = ArrayUtils.Diagonal2(array);

            foreach (var element in result)
            {
                Console.WriteLine(element);
            }
        }

        public static void Triangularize()
        {
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            var result = ArrayUtils.Triangularize(array);

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write($"{result[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static void Triangularize2()
        {
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            var result = ArrayUtils.Triangularize(array, ArrayUtils.TriaEnum.Above);

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write($"{result[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            result = ArrayUtils.Triangularize(array, ArrayUtils.TriaEnum.Under);
            //result = ArrayUtils.Triangularize(array, 1);


            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write($"{result[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static void FluttenTest()
        {
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            var result = ArrayUtils.Flatten(array);

            foreach (var element in result)
            {
                Console.WriteLine(element);
            }

        }

        public static void FluttenTest2()
        {
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            // 1 2 3 
            // 4 5 6
            // 7 8 9
            var result = ArrayUtils.Flatten(array, ArrayUtils.FlutEnum.Column);

            foreach (var element in result)
            {
                Console.WriteLine(element);
            }

        }
    }
}
