using System;

namespace ConsoleApplication1
{
    public class Tree
    {
        private static int AskUserForParameter()
        {
            Console.WriteLine("\nPlease write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }

        public void Christmas()
        {
            var n = 0;
            var z = 0;
            Console.WriteLine("Choose if you want decoration: 1:No 2:Yes");
            var choice = AskUserForParameter();

            while ((n <= 2 || n >= 21))
            {
                Console.WriteLine("For N");
                n = AskUserForParameter();
            }

            //first one for the number of rows,
            //second one for printing the spaces,
            //third one for printing the asterisks.
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n - i; j++)
                    Console.Write(" ");
                for (var k = 0; k < (2 * i + 1); k++)
                {
                    if (choice == 1)
                    {
                        Console.Write("*");
                        z = k;
                    }
                    else if (choice == 2)
                    {
                        Random rnd = new Random();
                        int decoration = rnd.Next(1, 9);
                        switch (decoration)
                        {
                            case 1:
                                Console.Write("*");
                                break;
                            case 2:
                                Console.Write("*");
                                break;
                            case 3:
                                Console.Write("*");
                                break;
                            case 4:
                                Console.Write("*");
                                break;
                            case 5:
                                Console.Write("*");
                                break;
                            case 6:
                                Console.Write("i");
                                break;
                            case 7:
                                Console.Write("i");
                                break;
                            case 8:
                                Console.Write("O");
                                break;
                        }

                        z = k;
                    }
                }

                Console.WriteLine("");
            }

            for (var j = 0; j < z / 2; j++)
                Console.Write(" ");
            Console.WriteLine("| |");
        }
    }
}