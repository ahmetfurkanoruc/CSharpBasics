using System;

namespace AsalSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 7;
            bool isPrime = IsPrimeNumber(number);
            if (isPrime)
                Console.WriteLine("{0} asal sayıdır", number);
            else
                Console.WriteLine("{0} asal sayı değildir",number);
            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            bool status = true;
            for(int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    status = false;
                    break;
                }
                    
            }

            return status;

        }
    }
}
