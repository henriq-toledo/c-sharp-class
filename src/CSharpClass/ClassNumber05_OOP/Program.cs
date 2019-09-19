using System;
using System.Collections.Generic;
using ClassNumber05_OOP.Classes;

namespace ClassNumber05_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Person maria = new Employee(firstName: "Maria", lastName: "Silva", 19, "IBM", "5968");

            // Console.WriteLine($"Maria is a person: {(maria is Person)}");
            // Console.WriteLine($"Maria is an employee: {(maria is Employee)}");

            //Employee mariaEmployee = (Employee) maria; // throw exception
            //Employee mariaEmployee = maria as Employee; // null

            Person joao = new Developer(firstName: "João", lastName: "Silva", age: 20, companyId: "Star Company", registrationId: "M2030");          
            joao.Show();

            Console.WriteLine($"Joao is a person: {(joao is Person)}");
            Console.WriteLine($"Joao is an employee: {(joao is Employee)}");
            Console.WriteLine($"Joao is a developer: {(joao is Developer)}");
           
            Employee joaoEmployee = (Employee) joao;

            Employee joseEmployee = new Developer(firstName: "Jose", lastName: "Silva", age: 30, companyId: "Star Company", registrationId: "J1980");
            Person josePerson = joseEmployee;
            var companyId = joseEmployee.CompanyId;

            var employee = new Developer(firstName: "Tony", lastName: "Silva", age: 35, 
                companyId: "Prime Company", registrationId: "T5098");

            employee.Show();

            var temporaryEmployee = new Developer(firstName: "Pedrinho", lastName: "Silva", age: 21, companyId: "Start Company");

            temporaryEmployee.Show();
            
            temporaryEmployee.Languages.Add("C#");
            temporaryEmployee.Languages.Add("Javascript");
            temporaryEmployee.Languages.Add("Lua");
            temporaryEmployee.Languages.Add("Python");

            var has = temporaryEmployee.HasLanguage("C#");

            var languagesShouldHave = new List<string>();
            languagesShouldHave.Add("C#");
            languagesShouldHave.Add("Javascript");

            var hasAll = temporaryEmployee.HasLanguage(languagesShouldHave);
            
            Console.WriteLine(temporaryEmployee.Credentials);
            Console.WriteLine(temporaryEmployee.HasDefaultLanguages);

            Developer.DefaultLanguages.Add("Ada");

            Console.WriteLine(temporaryEmployee.HasDefaultLanguages);

            Console.ReadKey();
        }
    }
}
