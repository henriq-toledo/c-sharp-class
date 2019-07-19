using System;

namespace ClassNumber04_Statement.Classes
{
    class IfElseExamples
    {
        static string message;

        public static void ExecuteAll()
        {
            NegativeInIf();
            TernaryOperator();
            CheckingAllConditions();
        }

        static bool Check(int value)
        {
            message += $" Check {value}";
            Console.WriteLine("Check");
            return value > 20;
        }

        /// <summary>
        /// All the negative condition on if are equal
        /// </summary>
        static void NegativeInIf()
        {
            var intValue = 1;

            if (!(intValue == 0))
            {
                Console.WriteLine($"!({intValue} == 0)");
            }

            if ((intValue == 0) == false)
            {
                Console.WriteLine($"({intValue} == 0) == false");
            }

            if (intValue != 0)
            {
                Console.WriteLine($"{intValue} != 0");
            }
        }

        static void TernaryOperator()
        {
            var value = 0;
            var text = value > 0 ? "More than zero" : "Less or equal zero";

            Console.WriteLine(text);

            string textNullable = "1";
            text = textNullable ?? "new value";
            text = textNullable == null ? "new value" : textNullable;

            Console.WriteLine(text);
        }

        static void CheckingAllConditions()
        {
            var intValue = 30;

            if (intValue == 0)            
            {
                Console.WriteLine("IF");
            }
            else if(intValue > 10 & Check(intValue))
            {
                Console.WriteLine("ELSE IF 10 CHECK");
            }
            else if(intValue > 0 || Check(intValue) | Check(10))
            {
                Console.WriteLine("ELSE IF");
            }               
            else if(intValue > 10)
            {
                Console.WriteLine("ELSE IF 10");
            }         
            else
            {
                Console.WriteLine("ELSE");
            }

            Console.WriteLine(message);
        }
    }
}
