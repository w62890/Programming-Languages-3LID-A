using System;
using System.Collections.Generic;
using System.Text;

namespace Operation_on_arrays_9_13
{
    public static class ArrayUtils
    {
        public enum TriaEnum
        {
            Above = 1,
            Under
        }

        public enum FlutEnum
        {
            Row = 1,
            Column
        }
        public static int[] Diagonal2(int[,] inputArray)
        {
            var result = new List<int>();

            for (int i = 0; i < inputArray.GetLength(0); i++)
            {
                for (int j = 0; j < inputArray.GetLength(1); j++)
                {
                    // result.Add(inputArray[i, j]) ? i == j : continue;
                    if (i == j)
                    {
                        result.Add(inputArray[i, j]);
                    }
                }
            }

            return result.ToArray();
        }

        public static int[,] Triangularize(int[,] inputArray)
        {
            var result = new int[inputArray.GetLength(0), inputArray.GetLength(1)];

            for (int i = 0; i < inputArray.GetLength(0); i++)
            {
                for (int j = 0; j < inputArray.GetLength(1); j++)
                {
                    var cond = (j < i) ? result[i, j] = 0 : result[i, j] = inputArray[i, j];

                    // result[i, j] = 0 ? (j < i) : result[i, j] = inputArray[i, j];

                    //if (j < i)
                    //{
                    //    result[i, j] = 0;
                    //}
                    //else
                    //{
                    //    result[i, j] = inputArray[i, j];
                    //}
                }
            }

            return result;
        }

        public static int[,] Triangularize(int[,] inputArray, TriaEnum en)
        {
            var result = new int[inputArray.GetLength(0), inputArray.GetLength(1)];

            for (int i = 0; i < inputArray.GetLength(0); i++)
            {
                for (int j = 0; j < inputArray.GetLength(1); j++)
                {
                    var cond = (j < i) ? result[i, j] = 0 : result[i, j] = inputArray[i, j];

                    // result[i, j] = 0 ? (j < i) : result[i, j] = inputArray[i, j];

                    switch (en)
                    {
                        case TriaEnum.Above:
                            if (j > i)
                            {
                                result[i, j] = 0;
                            }
                            else
                            {
                                result[i, j] = inputArray[i, j];
                            }

                            break;
                        case TriaEnum.Under:
                            if (j < i)
                            {
                                result[i, j] = 0;
                            }
                            else
                            {
                                result[i, j] = inputArray[i, j];
                            }
                            break;
                        default:
                            break;
                    }



                }
            }

            return result;
        }

        public static int[] Flatten(int[,] inputArray)
        {
            var result = new List<int>();
            for (int i = 0; i < inputArray.GetLength(0); i++)
            {
                for (int j = 0; j < inputArray.GetLength(1); j++)
                {
                    result.Add(inputArray[i, j]);
                }
            }
            return result.ToArray();
        }

        public static int[] Flatten(int[,] inputArray, FlutEnum en)
        {
            var result = new List<int>();

            switch (en)
            {
                case FlutEnum.Row:

                    for (int i = 0; i < inputArray.GetLength(0); i++)
                    {
                        for (int j = 0; j < inputArray.GetLength(1); j++)
                        {
                            result.Add(inputArray[i, j]);
                        }
                    }
                    break;
                case FlutEnum.Column:
                    for (int i = 0; i < inputArray.GetLength(0); i++)
                    {
                        for (int j = 0; j < inputArray.GetLength(1); j++)
                        {
                            result.Add(inputArray[j, i]);
                        }
                    }
                    break;
                default:
                    break;
            }


            return result.ToArray();
        }
    }
}
