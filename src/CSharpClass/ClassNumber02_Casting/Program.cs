using System;

namespace ClassNumber02_Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------");

            ImplicitCasting();

            BoxingAndUnboxing();

            ExplicitCasting();

            ParseMethods();

            TryParseMethod();

            ConvertClass();

            CheckedKeyword();

            Console.WriteLine("-------------------------------------------");
        }

        static void ImplicitCasting()
        {
            // byte < short < int < long            
            var byteValue = byte.MaxValue;
            short shortValue = byteValue;
            int intValue = shortValue;
            long longValue = intValue;

            // float < double
            var floatValue = float.MaxValue;
            double doubleValue = floatValue;
        }

        static void ExplicitCasting()
        {
            // byte < short < int < long
            long longValue = 0;
            int intValue = (int)longValue;
            short shortValue = (short)intValue;
            byte byteValue = (byte)shortValue;
        }

        static void ParseMethods()
        {
            var intValue = int.MaxValue;
            string stringValue = intValue.ToString();

            intValue = int.Parse(stringValue);
        }

        static void TryParseMethod()
        {
            Console.WriteLine("TryParseMethod");
            Console.WriteLine();

            int intValue;
            var stringValue = "0";

            if (int.TryParse(stringValue, out intValue))
            {
                Console.WriteLine($"The value {intValue} was converted to int correctly.");
            }
            else
            {
                Console.WriteLine($"The value {stringValue} was not converted to int.");
            }
        }

        /// <summary>
        /// https://www.devmedia.com.br/boxing-e-unboxing-em-net/6962
        /// </summary>
        static void BoxingAndUnboxing()
        {
            // Pimitive types are by value
            var intValue = int.MaxValue;

            // Boxing
            // Objects are by reference
            object intObject = intValue;

            // Unboxing
            // Explicit casting
            intValue = (int)intObject;
        }

        static void ConvertClass()
        {
            long longValue = 1;
            var intValue = (int)Convert.ChangeType(longValue, typeof(int));
        }

        static void CheckedKeyword()
        {
            Console.WriteLine();
            Console.WriteLine("CheckedKeyword");
            Console.WriteLine();

            long longValue = 1;
            var intValue = (int)longValue;

            Console.WriteLine($"Without checked keyword the long was converted to {intValue} int value");

            try
            {
                checked
                {
                    longValue = long.MaxValue;
                    intValue = (int)longValue;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine($"When the keyword checked is present on a casting and the converted value exceed an OverflowException is throw.");
            }
        }
    }
}
