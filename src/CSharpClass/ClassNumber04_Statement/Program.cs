using System;
using System.Drawing;
using ClassNumber04_Statement.Classes;

namespace ClassNumber04_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.Clear();
                Console.WriteLine("Type the option and press enter:");
                Console.WriteLine("1 - If else example");
                Console.WriteLine("2 - For example");
                Console.WriteLine("3 - While");
                Console.WriteLine("4 - Do while");
                Console.WriteLine("5 - Foreach");
                Console.WriteLine("6 - Goto");
                Console.WriteLine("9 - Exit");

                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("1 - If else example");
                        Console.WriteLine();
                        IfElseExamples.ExecuteAll();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("2 - For example");
                        Console.WriteLine();
                        ForExamples.ExecuteAll();
                        break;

                    case "3":                        
                        Console.Clear();
                        Console.WriteLine("3 - While");
                        Console.WriteLine();
                        WhileExamples.ExecuteAll();
                        break;

                    case "4":                        
                        Console.Clear();
                        Console.WriteLine("4 - Do while");
                        Console.WriteLine();
                        DoWhileExamples.ExecuteAll();
                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine("5 - Foreach");
                        Console.WriteLine();
                        ForeachExamples.ExecuteAll();
                        break;

                    case "6":
                        Console.Clear();
                        Console.WriteLine("6 - Goto");
                        Console.WriteLine();
                        GotoExamples.ExecuteAll();
                        break;

                    case "9":

                        if (true)
                        {
                            return;
                        }

                    default:

                        Console.WriteLine("The option does not exist. Press enter.");
                        Console.Read();
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("End of the examples. Press enter to continue.");
                Console.ReadKey();
            }
        }
    }
}
