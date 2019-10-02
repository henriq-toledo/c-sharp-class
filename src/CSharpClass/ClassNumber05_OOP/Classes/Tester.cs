namespace ClassNumber05_OOP.Classes
{
    public partial class Tester : Employee
    {
        public Tester(string firstName, string lastName, short age, string companyId, string registrationId) 
            : base(firstName, lastName, age, companyId, registrationId)
        {
        }
    }
}