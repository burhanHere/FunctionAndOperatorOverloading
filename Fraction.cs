namespace FunctionAndOperatorOverloading
{
    public class Fraction
    {
        private double numerator;
        private double denominator;

        public double Numerator { get { return numerator; } set { numerator = value; } }
        public double Denominator
        {
            get { return denominator; }
            set
            {
                denominator = (value == 0) ? throw new ArgumentException("Denominator cannot be 0.") : value;
            }
        }

        public Fraction()
        {
            numerator = 0.0;
            denominator = 0.0;
        }

        public Fraction(double inputNumirator, double inputDenominator)
        {
            numerator = inputNumirator;
            denominator = inputDenominator;
        }

        public Fraction(Fraction obj)
        {
            numerator = obj.numerator;
            denominator = obj.denominator;
        }

        public static Fraction Add(Fraction f1, Fraction f2)
        {
            double numerator = (f1.denominator == f2.denominator) ?
                f1.numerator + f2.numerator :
                (f1.numerator * f2.denominator) + (f2.numerator * f1.denominator);

            double denominator = (f1.denominator == f2.denominator) ?
                f1.denominator :
                f1.denominator * f2.denominator;

            return new Fraction(numerator, denominator);
        }

        public static Fraction Subtract(Fraction f1, Fraction f2)
        {
            double numerator = (f1.denominator == f2.denominator) ?
                f1.numerator - f2.numerator :
                (f1.numerator * f2.denominator) - (f2.numerator * f1.denominator);

            double denominator = (f1.denominator == f2.denominator) ?
                f1.denominator :
                f1.denominator * f2.denominator;

            return new Fraction(numerator, denominator);
        }

        public static Fraction Multiply(Fraction f1, Fraction f2)
        {
            double numerator = f1.numerator * f2.numerator;
            double denominator = f1.denominator * f2.denominator;

            return new Fraction(numerator, denominator);
        }

        public double ToDecimal() // Consider using a more descriptive name like "ToDecimal"
        {
            return numerator / denominator;
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            return Add(f1, f2);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            return Subtract(f1, f2);
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            return Multiply(f1, f2);
        }

        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }
    }
}

