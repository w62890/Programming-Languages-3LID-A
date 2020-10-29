using System;
using System.Collections.Generic;
using System.Text;

namespace HW_11_12
{
    public class ArrayUtils
    {
        public static void Reverse1(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                var temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
        }

        public static int[] Round(int[] inputArray, int threshold)
        {
            var result = new List<int>();

            foreach (var element in inputArray)
                if (element >= threshold)
                    result.Add(element);

            return result.ToArray();
        }

        public static int[] PickPositive(int[] inputArray)
        {
            return Round(inputArray, 1);
        }

        public static int[] PickPositive2(int[] inputArray) 
            => Round(inputArray, 1);

        public static int[] Zip(int[] arr1, int[] arr2)
        {
            var result = new List<int>();

            int len;


            if (arr1.Length > arr2.Length)
                len = arr2.Length;
            else
                len = arr1.Length;


            for (int i = 0; i < len; i++)
            {
                result.Add(arr1[i] + arr2[i]);
            }

            return result.ToArray();
        }

        public static int[] Accum(int[] arr)
        {
            var a = new int[arr.Length];
            
            a[0] = arr[0];
            // var acc = a[0];
            
            for (int i = 1; i < a.Length; i++)
            {
                a[i] = a[i-1] + arr[i];
            }

            return a;
        }




    }
}
