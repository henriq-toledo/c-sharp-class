using System;
using ClassNumber05_OOP.Classes;

namespace ClassNumber06_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var temporaryEmployee = new Developer(firstName: "Joaozinho", lastName: "Silva", age: 21, companyId: "Start Company");

            temporaryEmployee.Show();

            Console.ReadKey();
        }
    }
}
