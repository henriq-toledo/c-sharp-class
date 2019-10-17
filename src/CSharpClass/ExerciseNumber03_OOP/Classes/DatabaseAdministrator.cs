using System.Collections.Generic;

namespace ExerciseNumber03_OOP.Classes
{
    public class DatabaseAdministrator : Employee
    {
        private List<string> _databases { get; set; }

        public DatabaseAdministrator(string firstName, string lastName, string companyName) : base(firstName, lastName, companyName)
        {
            _databases = new List<string>();
        }

        public void AddDatabase(string database)
        {
            _databases.Add(database);
        }

        public void RemoveDatabase(string database)
        {
            _databases.Remove(database);
        }

        public override string GetInformation()
        {
            var info = base.GetInformation();

            foreach(var database in _databases)
            {
                info += database;
            }

            return info;
        }
    }
}