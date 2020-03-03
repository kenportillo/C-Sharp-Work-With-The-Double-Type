using System;

namespace Work_with_the_double_type
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");


            // The double numeric type represents 
            // double-precision floating point number.
            // A floating point number is useful to represent
            // non-integral numbers that may be very large 
            // or small in magnitude.
            
            // Double-precision means that these numbers
            // are stored using greater precision than
            // single-precision.

            // double a = 5;
            // double b = 4;
            // double c = 2;
            // double d = (a + b) / c;
            // Console.WriteLine(d);

            double a = 19;
            double b = 23;
            double c = 8;
            double d = (a + b) / c;
            Console.WriteLine(d);

            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");

            // The range of double is -1.7976931348623157E+308 to 1.7976931348623157E+308

            // The number to the left of the E is the significand.
            // The number to the right is the exponent, as
            // a power of 10. 

            double third = 1.0 / 3.0;
            Console.WriteLine(third);

        }
    }
}
