namespace ClassNumber07_Collections.Classes
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static Pet[] GetAll()
        {
            return new Pet[]
            {
                new Pet(){ Id = 1, Name = "Bob" },
                new Pet(){ Id = 2, Name = "John" },
                new Pet(){ Id = 3, Name = "Titi" }
            };
        }
    }
}