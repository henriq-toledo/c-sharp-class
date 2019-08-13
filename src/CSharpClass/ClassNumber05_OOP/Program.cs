using System;
using ClassNumber05_OOP.Classes;

namespace ClassNumber05_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(firstName: "João", lastName: "Silva", age: 10);
            person.Show();

            Console.ReadKey();
        }
    }
}
