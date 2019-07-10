using System;

namespace ClassNumber01_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("byte");
            Console.WriteLine($"Min: {byte.MinValue}");
            Console.WriteLine($"Max: {byte.MaxValue}");

            Console.WriteLine();

            Console.WriteLine("short");
            Console.WriteLine($"Min: {short.MinValue}");
            Console.WriteLine($"Max: {short.MaxValue}");

            Console.WriteLine();

            Console.WriteLine("int");
            Console.WriteLine($"Min: {int.MinValue}");
            Console.WriteLine($"Max: {int.MaxValue}");

            Console.WriteLine();

            Console.WriteLine("long");
            Console.WriteLine($"Min: {long.MinValue}");
            Console.WriteLine($"Max: {long.MaxValue}");

            Console.WriteLine();

            Console.WriteLine("decimal");
            Console.WriteLine($"Min: {decimal.MinValue}");
            Console.WriteLine($"Max: {decimal.MaxValue}");

            Console.WriteLine();

            Console.WriteLine("float");
            Console.WriteLine($"Min: {float.MinValue}");
            Console.WriteLine($"Max: {float.MaxValue}");

            Console.WriteLine();

            Console.WriteLine("double");
            Console.WriteLine($"Min: {double.MinValue}");
            Console.WriteLine($"Max: {double.MaxValue}");

            Console.WriteLine();

            var guidValue = Guid.NewGuid();

            // The {0} is the placeholder
            Console.WriteLine("Guid value: {0}", guidValue);

            Console.WriteLine();

            var name = "John";

            // It's necessary use $ and {} and between the bracktes to use the variable
            Console.WriteLine($"Name: {name}");

            Console.WriteLine("-------------------------------------------");
        }
    }
}
