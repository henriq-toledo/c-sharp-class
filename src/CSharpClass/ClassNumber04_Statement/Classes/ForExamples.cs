using System;

namespace ClassNumber04_Statement.Classes
{
    class ForExamples
    {
        public static void ExecuteAll()
        {
            Increment();
            Decrement();
            BlankForStatement();
            UsingString();
        }

        static void Increment()
        {
            Console.WriteLine($"Increment");
            Console.WriteLine();

            int i;

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine($"Execution: {i}");
            }

            Console.WriteLine($"Final value from i: {i}");
            Console.WriteLine();
        }

        static void Decrement()
        {
            Console.WriteLine($"Decrement");
            Console.WriteLine();

            int i = 0;

            i = i + 1;
            i++;
            i += 1;

            for (i = 10; i > 0; i-=2)
            {
                Console.WriteLine($"Execution: {i}");               
            }

            Console.WriteLine($"Final value from i: {i}");
            Console.WriteLine();
        }

        static void BlankForStatement()
        {
            Console.WriteLine($"Blank For Statement");
            Console.WriteLine();

            int i = 0;

            for (;;)
            {
                if (i < 10)
                {
                    Console.WriteLine($"Execution: {i}");
                }
                else
                {
                    break;
                }

                 i++;
            }

            Console.WriteLine($"Final value from i: {i}");
            Console.WriteLine();
        }

        static void UsingString()
        {
            Console.WriteLine("Using string");
            Console.WriteLine();

            for (var i = 0; i < 10; i++)
            {
                for (var text = string.Empty; text.Length < 10; text += "a")
                {
                    Console.WriteLine(text);

                    if (text == "aaa")
                    {
                        return;
                    }
                }
            }
        }
    }
}