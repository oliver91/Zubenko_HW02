using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of clients: ");
            try
            {
                int clientsNum;
                do
                {
                    clientsNum = Int32.Parse(Console.ReadLine());
                    if (clientsNum > 25) Console.WriteLine("The number of clients value is greater than allowed because result " +
                                                           "will be greater than Int32.MaxValue.\nTry again.");
                } while (clientsNum > 25);

                long result = 1;
                do
                {
                    result *= clientsNum;
                    clientsNum--;
                } while (clientsNum > 0);
                Console.WriteLine("the number of delivery options: {0}", result);
                Console.ReadKey();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message + "\ntry again.");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message + "\ntry again.");
            }

        }
    }
}
