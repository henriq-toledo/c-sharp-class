namespace ClassNumber05_OOP.Classes
{
    public abstract class Employee : Person
    {
        public string CompanyId { get; private set; }
        public string RegistrationId { get; private set; }
        public bool IsTemporary { get; private set; }
        public virtual string Credentials => $"{this.CompanyId}-{this.RegistrationId}";

        public Employee(string firstName, string lastName, short age, string companyId, string registrationId)
            : base(firstName: firstName, lastName: lastName, age: age)
        {
            CompanyId = companyId;
            RegistrationId = registrationId;
        }

        public Employee(string firstName, string lastName, short age, string companyId)
            : this(firstName: firstName, lastName: lastName, age: age,
            companyId: companyId, registrationId: System.Guid.NewGuid().ToString())
        {
            this.IsTemporary = true;
        }

        public override string ToString()
        {
            return base.ToString() + $", Company Id: {CompanyId}, Registration Id: {RegistrationId}, Is Temporary: {IsTemporary}";
        }

        public override abstract void Show();        
    }
}
