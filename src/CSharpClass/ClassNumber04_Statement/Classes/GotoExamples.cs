using System;

namespace ClassNumber04_Statement.Classes
{
    class GotoExamples
    {
        public static void ExecuteAll()
        {
            GotoExample();
        }

        static void GotoExample()
        {
            var i = 0;

        Print:

            Console.WriteLine(i);
            i++;

            if (i < 10)
            {
                goto Print;
            }
        }
    }
}