using System;

namespace Arrays_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9};
            PrintArray(arr, "origin");
            Console.WriteLine("origin array length: {0}\n", arr.Length);
            int[] enlargedArray = EnlargeArray(arr, 10);
            PrintArray(enlargedArray, "enlarged");
            Console.WriteLine("enlarged array length: {0}\n", enlargedArray.Length);
        }

        private static int[] EnlargeArray(int[] array, int value)
        {
            int[] resultArray = new int[array.Length+1];
            array.CopyTo(resultArray, 0);
            resultArray[array.Length] = value;
            return resultArray;
        }

        private static void PrintArray(int[] arr, string arrayName)
        {
            Console.Write(arrayName + " array: { ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i < arr.Length - 1) Console.Write(", ");
            }
            Console.WriteLine(" }");
        }
    }
}
