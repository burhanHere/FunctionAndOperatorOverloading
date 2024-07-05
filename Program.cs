using System.Runtime.CompilerServices;

namespace FunctionAndOperatorOverloading
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Fraction fraction1 = new(5, 3);
            Console.WriteLine(fraction1.ToString());

            // working with 2 objects only

            Fraction fraction2 = new(5, 2);

            Console.WriteLine($"addFraction function: {Fraction.Add(fraction1, fraction2)}"); // addFraction function
            Console.WriteLine($"operator + overloaded: {fraction1 + fraction2}");// operator + overloaded

            Console.WriteLine($"SubtractFraction function: {Fraction.Subtract(fraction1, fraction2)}"); // SubtractFraction function
            Console.WriteLine($"operator - overloaded: {fraction1 - fraction2}");// operator - overloaded

            Console.WriteLine($"MultiplyFraction function: {Fraction.Multiply(fraction1, fraction2)}"); // MultiplyFraction function
            Console.WriteLine($"operator * overloaded: {fraction1 * fraction2}");// operator * overloaded

            // working with 3 objects only

            Fraction fraction3 = new(2, 5);

            Console.WriteLine($"operator + overloaded: {fraction1 + fraction2 + fraction3}");// operator + overloaded

            Console.WriteLine($"operator - overloaded: {fraction1 - fraction2 - fraction3}");// operator - overloaded

            Console.WriteLine($"operator * overloaded: {fraction1 * fraction2 * fraction3}");// operator * overloaded

            Fraction fraction4 = fraction1;
            Console.WriteLine("checking if we dont over load operator = what would happen hen:");
            Console.WriteLine($"fraction4: {fraction4}");
            Console.WriteLine($"fraction1: {fraction1}");
            fraction1.Numerator = 60; // this was shallow copy before overloading operator =
            Console.WriteLine($"After updating valie of fraction1:");
            Console.WriteLine($"fraction4: {fraction4}");
            Console.WriteLine($"fraction1: {fraction1}");
        }
    }
}
