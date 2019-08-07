using System;

namespace ClassNumber04_Statement.Classes
{
    class ForeachExamples
    {
        public static void ExecuteAll()
        {
            ForeachExample();
        }

        static void ForeachExample()
        {
            var names = new[]
            {
                "maria",
                "josé",
                "joão"
            };

            foreach (var name in names)
            {
                if (name == "maria")
                {
                    continue;
                }

                Console.WriteLine(name);
            }
        }
    }
}