using System;

namespace ConsoleApplication1
{
    public class MoreMath
    {
        public void Prime()
        {
            int q = 1000;
            for (int i = 1; i < q; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if ((i % j) == 0)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime)
                {
                    Console.Write("{0} ", i);
                }
            }
        }

        public double Fibonnaci(double n)
        {
            if (n <= 1)
                return n;
            return Fibonnaci(n - 1) + Fibonnaci(n - 2);
        }

        public double Factorial(double n)
        {
            if (n == 0)
            {
                return 1;
            }
            // Recursive call: the method calls itself
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}