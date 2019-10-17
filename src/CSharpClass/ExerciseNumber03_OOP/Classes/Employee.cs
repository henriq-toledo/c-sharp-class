namespace ExerciseNumber03_OOP.Classes
{
    public class Employee : Person
    {
        public string CompanyName { get; private set; }

        public Employee(string firstName, string lastName, string companyName) : base(firstName, lastName)
        {
            CompanyName = companyName;
        }

        public override string GetInformation()
        {
            return base.GetInformation() + " " + CompanyName;
        }
    }
}