using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        private static int AskUserForParameter()
        {
            Console.WriteLine("\nPlease write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("exercise 1 : Multiplication table. \"1\"");
            Console.WriteLine("exercise 2 : More math. \"2\"");
            Console.WriteLine("exercise 3 : Try/catch. \"3\"");
            Console.WriteLine("exercise 4 : Square. \"4\"");
            Console.WriteLine("exercise 5 : Christmas tree. \"5\"");

            var exercise = AskUserForParameter();
            switch (exercise)
            {
                case 1:
                    Multiplication test = new Multiplication();
                    Console.WriteLine("exercise 1.1: Every multiplication table from 1*1 to 10*10. Enter \"1\"");
                    Console.WriteLine(
                        "exercise 1.2: Every multiplication table from 1*1 to 10*10 with odd. Enter \"2\"");
                    var exo = AskUserForParameter();
                    switch (exo)
                    {
                        case 1:
                            Console.WriteLine(
                                "if you give a parameter, the display the multiplication table for this number N, if else it display all the table.");
                            test.Mult(AskUserForParameter());
                            break;
                        case 2:
                            Console.WriteLine(
                                "if you give a parameter, the display the multiplication table for this number N, if else it display all the table.");
                            test.OddMultiplication(AskUserForParameter());
                            break;
                    }

                    break;
                case 2:
                    MoreMath exo2 = new MoreMath();
                    Console.WriteLine("exercise 2.1: Prints all prime number between 1 and 1000. Enter \"1\"");
                    Console.WriteLine("exercise 2.2: Fibonacci. Enter \"2\"");
                    Console.WriteLine("exercise 2.3: Factorial. Enter \"3\"");
                    var choice = AskUserForParameter();
                    switch (choice)
                    {
                        case 1:
                            exo2.Prime();
                            break;
                        case 2:
                            Console.WriteLine(exo2.Fibonnaci(AskUserForParameter()));
                            break;
                        case 3:
                            Console.WriteLine(exo2.Factorial(AskUserForParameter()));
                            break;
                    }

                    break;
                case 3:
                    Exo3 exo3 = new Exo3();
                    exo3.TryCatch();
                    break;
                case 4:
                    Rectangle exo4 = new Rectangle();
                    exo4.Square();
                    break;
                case 5:
                    Tree exo5 = new Tree();
                    exo5.Christmas();
                    break;
                default:
                    Console.WriteLine("End !");
                    break;
            }
        }
    }
}