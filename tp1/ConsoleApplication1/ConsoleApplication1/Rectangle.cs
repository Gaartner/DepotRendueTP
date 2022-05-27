using System;

namespace ConsoleApplication1
{
    public class Rectangle
    {
        private static int AskUserForParameter()
        {
            Console.WriteLine("\nPlease write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }

        public void Square()
        {
            int n = 0, m = 0;
            while ((n <= 0 || n >= 1001) || (m >= 1001 || m <= 0))
            {
                Console.WriteLine("For N");
                n = AskUserForParameter();
                Console.WriteLine("For M");
                m = AskUserForParameter();
            }

            //top border
            Console.Write("0");
            for (var j = 0; j < n - 2; j++)
            {
                Console.Write("-");
            }

            Console.WriteLine("0");
            //side border + content
            for (var i = 0; i <= m; i++)
            {
                Console.Write("|");
                for (var j = 0; j < n - 2; j++)
                {
                    Console.Write((i + j) % 3 == 0 ? "*" : " ");
                }

                Console.WriteLine("|");
                i++;
            }

            // low border
            Console.Write("0");
            for (var j = 0; j < n - 2; j++)
            {
                Console.Write("-");
            }

            Console.WriteLine("0");
        }
    }
}