namespace ClassNumber05_OOP.Classes
{
    public class Person
    {
        public string FirstName { get; private set; }
        
        private string _lastName;

        public string LastName => _lastName;

        private short _age;
        
        public short Age 
        { 
            get => _age;
            set => _age = value; 
        }

        public Person(string firstName, string lastName, short age)
        {
            FirstName = firstName;
            _lastName = lastName;
            Age = age;
        }

        public void Show()
        {
            System.Console.WriteLine($"First name: {FirstName}, Last name: {LastName}, Age: {Age}");
        }
    }
}