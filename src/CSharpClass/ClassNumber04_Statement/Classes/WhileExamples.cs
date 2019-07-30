using System;

namespace ClassNumber04_Statement.Classes
{
    class WhileExamples
    {
        public static void ExecuteAll()
        {
            WhileExample();
            WhileInput();
        }

        static void WhileExample()
        {
            Console.WriteLine("While example");
            Console.WriteLine();

            int input = 0;

            while (input < 10)
            {
                Console.WriteLine($"Inside looping: {input}");

                input++;
            }

            Console.WriteLine($"After looping: {input}");

            Console.WriteLine();
        }

        static void WhileInput()
        {
            Console.WriteLine("While input");
            Console.WriteLine();

            var input = string.Empty;

            while (input != "99")
            {
                Console.WriteLine("Type something (99 to exit):");
                input = Console.ReadLine();
                Console.WriteLine($"Typed: {input}");
            }
            
            Console.WriteLine();
        }
    }
}