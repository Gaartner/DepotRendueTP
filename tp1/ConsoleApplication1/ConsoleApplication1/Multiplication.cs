using System;

namespace ConsoleApplication1
{
    public class Multiplication
    {
        public void Mult(int ask)
        {
            if (ask == 0)
                for (var n = 0; n <= 10; n++)
                {
                    Console.Write("Time table:{0} start from 1 to 10 \n", n);
                    for (var j = 1; j <= 10; j++)
                    {
                        Console.Write("{0} X {1} = {2} \n", n, j, n * j);
                    }

                    Console.Write("\n");
                }
            else
            {
                Console.Write("Time table:{0} start from 1 to 10 \n", ask);
                for (var j = 1; j <= 10; j++)
                {
                    Console.Write("{0} X {1} = {2} \n", ask, j, ask * j);
                }

                Console.Write("\n");
            }
        }

        public void OddMultiplication(int ask)
        {
            if (ask == 0)
                for (var n = 0; n <= 10; n++)
                {
                    Console.Write("Time table:{0} without any even \n", n);
                    for (var j = 1; j <= 10; j++)
                    {
                        if (n * j % 2 == 1)
                        {
                            Console.Write("{0} X {1} = {2} \n", n, j, n * j);
                        }
                    }

                    Console.Write("\n");
                }
            else
            {
                Console.Write("Time table:{0} without any even \n", ask);
                for (var j = 1; j <= 10; j++)
                {
                    if (ask * j % 2 == 1)
                    {
                        Console.Write("{0} X {1} = {2} \n", ask, j, ask * j);
                    }
                }

                Console.Write("\n");
            }
        }
    }
}