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
            temporaryEmployee.AddLanguage("Python");
            temporaryEmployee.RemoveLanguage("Python");
            temporaryEmployee.AddLanguage("C#");

            foreach(var language in temporaryEmployee.GetLanguages())
            {
                Console.WriteLine($"Language: {language}.");
            } 

            temporaryEmployee.Show();

            Console.ReadKey();
        }
    }
}
