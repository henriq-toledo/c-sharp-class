namespace ExerciseNumber03_OOP.Classes
{
    public class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string FullName => FirstName + " " + LastName;

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public virtual string GetInformation()
        {
            return FullName;
        }
    }
}