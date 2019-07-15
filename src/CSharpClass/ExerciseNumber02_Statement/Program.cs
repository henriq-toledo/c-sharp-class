using System;
using System.Linq;

namespace ExerciseNumber02_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            IfElseIfElse();

            Console.Read();
        }

        static void IfElseIfElse()
        {
            Start:
            Console.WriteLine("Type a number between 0 and 100:");
            var input = Console.ReadLine();

            if(input.Any(c => char.IsDigit(c) == false))
            {
                Console.WriteLine($"The value '{input}' is not a number.");                
                goto Start;
            }

            var value = int.Parse(input);

            if (value < 0 || value > 100)
            {
                Console.WriteLine($"The value '{value}' is not between 0 and 100.");
                goto Start;
            }

            if (value <= 0)
            {
                Console.WriteLine("Black");
            }
            else if(value < 25)
            {
                Console.WriteLine("Red");
            }
            else if(value < 75)
            {
                Console.WriteLine("Yellow");
            }
            else
            {
                Console.WriteLine("Green");
            }
        }
    }
}
