using System;
using ClassNumber05_OOP.Classes;

namespace ClassNumber05_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Person maria = new Person(firstName: "Maria", lastName: "Silva", 19);

            Console.WriteLine($"Maria is a person: {(maria is Person)}");
            Console.WriteLine($"Maria is an employee: {(maria is Employee)}");

            //Employee mariaEmployee = (Employee) maria; // throw exception
            Employee mariaEmployee = maria as Employee; // null

            Person joao = new Employee(firstName: "João", lastName: "Silva", age: 20, companyId: "Star Company", registrationId: "M2030");          
            Console.WriteLine(joao.ToString());

            Console.WriteLine($"Joao is a person: {(joao is Person)}");
            Console.WriteLine($"Joao is an employee: {(joao is Employee)}");
           
            Employee joaoEmployee = (Employee) joao;

            Employee joseEmployee = new Employee(firstName: "Jose", lastName: "Silva", age: 30, companyId: "Star Company", registrationId: "J1980");
            Person josePerson = joseEmployee;
            var companyId = joseEmployee.CompanyId;

            var employee = new Employee(firstName: "Tony", lastName: "Silva", age: 35, 
                companyId: "Prime Company", registrationId: "T5098");

            Console.WriteLine(employee.ToString());

            var temporaryEmployee = new Employee(firstName: "Pedrinho", lastName: "Silva", age: 21, companyId: "Start Company");

            Console.WriteLine(temporaryEmployee.ToString());
            

            Console.ReadKey();
        }
    }
}
