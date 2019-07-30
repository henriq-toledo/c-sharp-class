using System;

namespace ClassNumber04_Statement.Classes
{
    class DoWhileExamples
    {
        public static void ExecuteAll()
        {
            DoWhileExample();
            DoWhileInput();
        }

        static void DoWhileInput()
        {
            Console.WriteLine("Do While input");
            Console.WriteLine();

            string input;

            do
            {
                Console.WriteLine("Type something (99 to exit):");
                input = Console.ReadLine();
                Console.WriteLine($"Typed: {input}");
            }
            while (input != "99");

            Console.WriteLine();
        }

        static void DoWhileExample()
        {
            Console.WriteLine("Do While example");
            Console.WriteLine();

            int input = 0;

            do
            {
                Console.WriteLine($"Inside looping: {input}");

                input++;
            }
            while (input < 10);

            Console.WriteLine($"After looping: {input}");

            Console.WriteLine();
        }
    }
}