using System;
using ClassNumber05_OOP.Classes;

namespace ClassNumber05_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Employee(firstName: "João", lastName: "Silva", age: 10);            
            Console.WriteLine(person.ToString());

            Person joao = new Employee(firstName: "João", lastName: "Silva", age: 10);          
            Console.WriteLine(joao.ToString());

            Console.ReadKey();
        }
    }
}
