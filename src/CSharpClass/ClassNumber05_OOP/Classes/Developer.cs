using System;
using System.Collections.Generic;

namespace ClassNumber05_OOP.Classes
{
    public class Developer : Employee
    {
        public static List<string> DefaultLanguages { get; set; } = new List<string>()
        {
            "C#",
            "Javascript"
        };

        public List<string> Languages { get; private set; }

        public Developer(string firstName, string lastName, short age, string companyId)
            : base(firstName, lastName, age, companyId)
        {
            Languages = new List<string>();
        }

        public Developer(string firstName, string lastName, short age, string companyId, string registrationId)
            : base(firstName, lastName, age, companyId, registrationId)
        {
            Languages = new List<string>();
        }

        public override void Show()
        {
            Console.WriteLine($"Developer: {base.ToString()}");
        }

        public bool HasLanguage(string language)
        {
            return Languages.Contains(language);
        }

        public bool HasLanguage(List<string> languages)
        {
            var has = languages.TrueForAll(l => Languages.Contains(l));

            return has;
        }

        public bool HasDefaultLanguages 
            => Developer.DefaultLanguages.TrueForAll(language => Languages.Contains(language)); 

        public override string Credentials => $"Developer: {base.Credentials}";
    }
}