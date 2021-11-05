using System;
using System.Numerics;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //These are most of the value types that you would ever expect to use and will probably use them in pretty much everything in some form or another.
            //It's best practice to select the data type that's most appropriate, for example if you know a number will only ever be between 0 and 255 then use a byte not a long.

            string text = "Hello World!";   //You can think of a string as an array of chars
            char character = 'b';   //any 16-bit unicode character

            bool isTrue = false;    //Either true or false

            byte byteValue = 255;   // 8-bit unsingned integer. So does not represent negative values. 0 - 255
            sbyte signedByte = 127;    //8-bit signed integer. Can represent negative values. -128 - 127

            short smallInteger = 32767;    //16-bit signed integer. -32768 - 32767
            int integer = 2147483647;   //32-bit signed integer. You will probably mostly use this. -2147483648 - 2147483647
            int integer2 = 2147483647;     //This will not work since the maximum value of this type has been exceeded.
            long longNumber = 9223372036854775807;   //64-bit signed Integer, can represent extremely large numbers. You're unlikely to need anything larger than this. -9223372036854775808 - 9223372036854775807

            BigInteger bigInt = 56;  //Big integers do not have a defined size and is signed, it is unlikely you will ever need to use this but I include it for the sake of completency. Must use System.Numerics;

            float floatingPointNumber = 1.569258f;   //32-bit single precision floating point value. -3.4 x 10^38 - 3.4 x 10^38. 7-decimal places
            double doubleNumber = 10.5D;    //64-bit double precision floating point value. 15 - 16 decimal places
            decimal decimalNumber = 1.3M;   //128-bit precisie decimal value. 27-28 decimal places

            //The unsigned numerical values can address almost double the value as a signed numberical value since they do not need to take up negative numbers.
            //We cannot create unsigned floating point numerical values due to how these are stored
            ushort unsignedShortInteger = 65535;
            uint unsignedInteger = 4294967295;
            ulong unsignedLongNumber = 18446744073709551615;

            Console.WriteLine($"Hello World!");

            int number1 = 54;
            int number2 = 103;
            float float1 = 5.5f;

            float total = number1 + float1;

            int multiplication = number1 * number2;
            int subtraction = number1 - number2;
            float division = number1 / number2;

            double power = Math.Pow(2,4);
            double root = Math.Sqrt(16);
            

            Console.WriteLine($"{root}");
        }
    }
}
