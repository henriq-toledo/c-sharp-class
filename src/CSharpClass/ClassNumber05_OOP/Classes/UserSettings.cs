using System;

namespace ClassNumber05_OOP.Classes
{
    public class UserSettings
    {
        public ConsoleColor ForegroundColor { get; set; }

        public UserSettings()
        {
            ForegroundColor = ConsoleColor.White;
        }
    }
}