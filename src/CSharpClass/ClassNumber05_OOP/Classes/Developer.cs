using System;
using System.Collections.Generic;

namespace ClassNumber05_OOP.Classes
{
    public class Developer : Employee
    {
        private UserSettings _userSettings;

        public static List<string> DefaultLanguages { get; set; } = new List<string>()
        {
            "C#",
            "Javascript"
        };

        internal List<string> Languages { get; private set; }

        public Developer(string firstName, string lastName, short age, string companyId)
            : base(firstName, lastName, age, companyId)
        {
            Languages = new List<string>();
            _userSettings = new UserSettings();
        }

        public Developer(string firstName, string lastName, short age, string companyId, string registrationId)
            : base(firstName, lastName, age, companyId, registrationId)
        {
            Languages = new List<string>();
             _userSettings = new UserSettings();
        }

        public void ChangeColor(ConsoleColor color)
        {
            //Settings.ForegroundColor = color;
            _userSettings.ForegroundColor = color;
        }

        public override void Show()
        {
            Console.ForegroundColor = _userSettings.ForegroundColor;
            //Console.ForegroundColor = Settings.ForegroundColor;
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

        public void AddLanguage(string language) => Languages.Add(language);
        
        public void RemoveLanguage(string language) => Languages.Remove(language);
        public string[] GetLanguages() => Languages.ToArray();
    }
}