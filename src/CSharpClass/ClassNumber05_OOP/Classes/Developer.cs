using System;

namespace ClassNumber05_OOP.Classes
{
    public class Developer : Employee
    {
        public Developer(string firstName, string lastName, short age, string companyId) 
            : base(firstName, lastName, age, companyId)
        {
        }

        public Developer(string firstName, string lastName, short age, string companyId, string registrationId) 
            : base(firstName, lastName, age, companyId, registrationId)
        {
        }

        public override void Show()
        {
            Console.WriteLine($"Developer: {base.ToString()}");
        }
    }
}