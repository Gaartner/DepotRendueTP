using System;

namespace ConsoleApplication1
{
    public class Exo3
    {
        public void TryCatch()
        {
            for (int number1 = -3; number1 <= 3; number1++)
            {
                try
                {
                    Console.WriteLine(10 / ((int) (Math.Pow(number1, 2)) - 4));
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Division of {0} by zero.", number1);
                }
            }
        }
    }
}