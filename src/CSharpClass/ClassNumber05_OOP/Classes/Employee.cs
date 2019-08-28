namespace ClassNumber05_OOP.Classes
{
    public class Employee : Person
    {
        public string test;

        public Employee(string firstName, string lastName, short age)
            : base(firstName: firstName, lastName: lastName, age: age)
        {
        }
    }
}