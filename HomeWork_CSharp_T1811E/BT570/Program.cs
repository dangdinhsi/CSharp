using System;

namespace BT570
{
    public delegate void PrimeNumberFinder(int number);

    class Program
    {
        private static event PrimeNumberFinder OnPrimeNumber;
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
        }
        private static void checkSNT(int number)
        {
            for(int i = 0; i <= number / 2; i++)
            {
                ///
            }
        }
    }
}
