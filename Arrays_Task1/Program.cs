using System;

namespace Arrays_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] originArr = {1, 2, 3, 4, 5, 6, 7, 8, 9};
            PrintArray(originArr, "origin");
            int[] reversedArr = MyReverse(originArr);
            PrintArray(reversedArr, "reversed");
        }

        private static int[] MyReverse(int[] array)
        {
            int[] resultArr = new int[array.Length];
            int i, j;
            for (i = array.Length-1, j = 0; i >= 0; i--, j++)
                resultArr[j] = array[i];
            return resultArr;
        }

        private static void PrintArray(int[] arr, string arrayName)
        {
            Console.Write(arrayName + " array: { ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i < arr.Length - 1) Console.Write(", ");
            }
            Console.WriteLine(" }\n");
        }
    }
}
