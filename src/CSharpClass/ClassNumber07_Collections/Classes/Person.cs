namespace ClassNumber07_Collections.Classes
{
    public class Person
    {
        public string Name { get; set; }
        public int PetId { get; set; }

        public static Person[] GetAll()
        {
            return new Person[]
            {
                new Person(){ Name = "JJ", PetId = 1},
                new Person(){ Name = "Tata", PetId = 1},
                new Person(){ Name = "Beck", PetId = 3},
                new Person(){ Name = "Titi", PetId = 3},
                new Person(){ Name = "Jason", PetId = 0}
            };
        }
    }
}