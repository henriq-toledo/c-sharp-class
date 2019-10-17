using System.Collections.Generic;

namespace ExerciseNumber03_OOP.Classes
{
    public class Support : Employee
    {
        private List<string> _programs { get; set; }

        public Support(string firstName, string lastName, string companyName) : base(firstName, lastName, companyName)
        {
            _programs = new List<string>();
        }

        public void AddProgram(string program)
        {
            _programs.Add(program);
        }

        public void RemoveProgram(string program)
        {
            _programs.Remove(program);
        }
    }
}