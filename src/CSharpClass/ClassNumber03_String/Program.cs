using System;
using System.Globalization;

namespace ClassNumber03_String
{
    class Program
    {
        static Action limiter => () => Console.WriteLine("----------------------------------------------------");

        static void Main(string[] args)
        {
            //EmptyStringBestPractice();
            //StringLength();
            //StringFromCharArray();
            //StringConcat();
            //StringFormat();
            //StringSplit();
            //StringReplace();
            //StringRemove();
            //StringTrim();
            //StringIndexOf();
            //SubString();
            //UpperAndLower();
            //StartsWithAndEndsWith();
            //DecimalToString();
            DateTimeToString();

            limiter();
            Console.Read();
        }

        static void EmptyStringBestPractice()
        {
            ShowTitle("EmptyStringBestPractice");

            // best practice, if possible do not use ""
            var stringValue = string.Empty;

            Console.WriteLine(stringValue);
        }

        static void StringLength()
        {
            ShowTitle("StringLength");

            var stringValue = "Get my length";

            Console.WriteLine(stringValue);
            Console.WriteLine($"Length: {stringValue.Length}");
        }

        static void StringFromCharArray()
        {
            ShowTitle("StringFromArray");

            var charArray = new char[] { 'C', 'S', 'H', 'A', 'R', 'P' };
            var stringFromCharArray = new string(charArray);

            Console.WriteLine(stringFromCharArray);
        }

        static void StringConcat()
        {
            ShowTitle("StringConcat");

            var stringValue1 = "C";
            var stringValue2 = "#";
            var stringValue3 = " ";
            var stringValue4 = "Class";
            
            var stringValue = string.Concat(stringValue1, stringValue2, stringValue3, stringValue4);

            Console.WriteLine(stringValue);

            var stringArray = new string[]
            {
                "C",
                "Sharp",
                " ",
                "Class"
            };

            stringValue = string.Concat(stringArray);

            Console.WriteLine();
            Console.WriteLine(stringValue);

            stringValue = string.Empty;
            stringValue = "C" + "Sharp" + " " + "Class";

            Console.WriteLine();
            Console.WriteLine(stringValue);

            stringValue = string.Empty;
            stringValue += "C";
            stringValue += "Sharp";
            stringValue += " ";
            stringValue += "Class";

            Console.WriteLine();
            Console.WriteLine(stringValue);
        }

        static void StringFormat()
        {
            ShowTitle("StringFormat");
            
            var stringValue = string.Format("{0}{1} {2}", "C", "Sharp", " Class");

            Console.WriteLine(stringValue);

            var classNumber = 3;
            stringValue = $"C# Class Number: {classNumber}";

            Console.WriteLine();
            Console.WriteLine(stringValue);            
        }

        static void StringSplit()
        {
            ShowTitle("StringSplit");

            var stringValue = "1;2;;;9";
            // The StringSplitOptions parameter is optional, by default is None
            var stringArray = stringValue.Split(';', StringSplitOptions.None);

            Console.WriteLine(stringValue);

            Console.WriteLine();
            Console.WriteLine("Using StringSplitOptions.None");
            Console.WriteLine();

            Console.WriteLine($"Value on first position: '{stringArray[0]}'");
            Console.WriteLine($"Value on third position: '{stringArray[2]}'");

            stringArray = stringValue.Split(';', StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine();
            Console.WriteLine("Using StringSplitOptions.RemoveEmptyEntries");
            Console.WriteLine();
            
            Console.WriteLine($"Value on first position: '{stringArray[0]}'");
            Console.WriteLine($"Value on third position: '{stringArray[2]}'");
        }

        static void StringReplace()
        {
            ShowTitle("StringReplace");

            var stringValue = "1;2;9";
            // The StringSplitOptions parameter is optional, by default is None
            var stringArray = stringValue.Split(';', StringSplitOptions.None);

            Console.WriteLine($"Before the replacement: {stringValue}");

            stringValue = stringValue.Replace(';', ' ');

            Console.WriteLine($"After the replacement: {stringValue}");
        }

        static void StringRemove()
        {
            ShowTitle("StringRemove");

            var stringValue = "Class Number 3$";

            Console.WriteLine($"Before the remove: {stringValue}");

            stringValue = stringValue.Remove(stringValue.Length - 1, 1);

            Console.WriteLine($"After the remove: {stringValue}");

            stringValue = "Class Number 3 remove me";

            Console.WriteLine($"Before the remove: '{stringValue}'");

            stringValue = stringValue.Remove(14, 10);

            Console.WriteLine($"After the remove: '{stringValue}'");
        }

        static void StringTrim()
        {
            ShowTitle("StringTrim");

            var stringValue = "  I have spaces  ";

            Console.WriteLine($"'{stringValue}'");
            Console.WriteLine($"Removing spaces on the left: '{stringValue.TrimStart()}'");
            Console.WriteLine($"Removing spaces on the right: '{stringValue.TrimEnd()}'");
            Console.WriteLine($"Removing spaces on the right and left: '{stringValue.Trim()}'");
        }

        static void StringIndexOf()
        {
            ShowTitle("StringIndexOf");

            var stringValue = "get my index";

            Console.WriteLine($"'{stringValue}'");
            Console.WriteLine($"IndexOf e: {stringValue.IndexOf('e')}");            
            Console.WriteLine($"LastIndexOf e: {stringValue.LastIndexOf('e')}");            
        }

        static void SubString()
        {
            ShowTitle("SubString");

            var stringValue = "123456789";

            Console.WriteLine($"'{stringValue}'");
            Console.WriteLine($"Substring(2): '{stringValue.Substring(2)}'");
            Console.WriteLine($"Substring(7, 2): '{stringValue.Substring(7, 2)}'");            
        }

        static void UpperAndLower()
        {
            ShowTitle("UpperAndLower");

            var stringValue = "vAluE";
            Console.WriteLine(stringValue);
            Console.WriteLine($"Lower: {stringValue.ToLower()}");
            Console.WriteLine($"Upper: {stringValue.ToUpper()}");
        }

        static void StartsWithAndEndsWith()
        {
            ShowTitle("StartWithAndEndWith");

            var stringValue = "value";
            Console.WriteLine(stringValue);
            Console.WriteLine($"StartsWith('q'): {stringValue.StartsWith('q')}");
            Console.WriteLine($"StartsWith('v'): {stringValue.StartsWith('v')}");
            Console.WriteLine($"StartsWith(\"va\"): {stringValue.StartsWith("va")}");
            Console.WriteLine($"EndsWith('q'): {stringValue.EndsWith('q')}");
            Console.WriteLine($"EndsWith('e'): {stringValue.EndsWith('e')}");
            Console.WriteLine($"EndsWith(\"ue\"): {stringValue.EndsWith("ue")}");
        }

        // https://docs.microsoft.com/pt-br/dotnet/api/system.decimal.tostring?view=netframework-4.8
        static void DecimalToString()
        {
            ShowTitle("DecimalToString");

            var decimalValue = 2.58m;
            Console.WriteLine($"ToString(): {decimalValue.ToString()}");
            Console.WriteLine($"ToString(\"#\"): {decimalValue.ToString("#")}");
            Console.WriteLine($"ToString(\"#.##\"): {decimalValue.ToString("#.##")}");
            Console.WriteLine($"ToString(\"#.###\"): {decimalValue.ToString("#.###")}");
            Console.WriteLine($"ToString(\"0.000\"): {decimalValue.ToString("0.000")}");
            Console.WriteLine($"ToString(\"P\"): {decimalValue.ToString("P")}");
            Console.WriteLine($"en-us: {decimalValue.ToString(CultureInfo.CreateSpecificCulture("en-us"))}");
            Console.WriteLine($"pt-br: {decimalValue.ToString(CultureInfo.CreateSpecificCulture("pt-br"))}");

            // C from currency            
            Console.WriteLine($"en-us: {decimalValue.ToString("C", CultureInfo.CreateSpecificCulture("en-us"))}");                    
            Console.WriteLine($"pt-br: {decimalValue.ToString("C", CultureInfo.CreateSpecificCulture("pt-br"))}");
        }

        // https://docs.microsoft.com/pt-br/dotnet/api/system.datetime.tostring?view=netframework-4.8
        static void DateTimeToString()
        {
            ShowTitle("DateTimeToString");

            var today = DateTime.Now;

            Console.WriteLine($"{today.ToString()}");
            Console.WriteLine($"dd/MM/yyyy: {today.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"yyyy-MM-dd HH:mm:ss: {today.ToString("yyyy-MM-dd HH:mm:ss")}");
            Console.WriteLine($"hh:mm:ss: {today.ToString("hh:mm:ss")}");
            Console.WriteLine($"r: {today.ToString("r")}");
        }

        static void ShowTitle(string title)
        {
            limiter();
            Console.WriteLine();
            Console.WriteLine($"Example: {title}");
            Console.WriteLine();
        }
    }
}
