using System;

namespace Lab1
{
    public class Fraction
    {
        private int gauge = 0;
        private int denominator = 1;

        public Fraction(int gauge, int denominator)
        {
            this.gauge = gauge;
            this.denominator = denominator;
        }

        public Fraction(Fraction fraction)
        {
            gauge = fraction.gauge;
            denominator = fraction.denominator;
        }

        public int Gauge
        {
            get { return gauge; }
        }

        public int Denominator
        {
            get { return denominator; }
        }

        public static Fraction operator +(Fraction a) => a;

        public static Fraction operator -(Fraction a) => new(-a.gauge, a.denominator);

        public static Fraction operator +(Fraction a, Fraction b) =>
               new(a.gauge * b.denominator + b.gauge * a.denominator, a.denominator * b.denominator);

        public static Fraction operator *(Fraction a, Fraction b) =>
                new(a.gauge * b.gauge, a.denominator * b.denominator);

        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.gauge == 0)
            {
                throw new DivideByZeroException();
            }

            return new Fraction(a.gauge * b.denominator, a.denominator * b.gauge);
        }

        public double RoundDown()
        { 
            return Math.Floor((double)gauge / denominator);
        }
        public double RoundUp()
        {
            return Math.Ceiling((double)gauge / denominator);
        }

        public int CompareTo(Fraction otherFraction)
        {
            if (otherFraction == null) return 1;

            if (otherFraction != null)
                return ((float)gauge / denominator).CompareTo((float)otherFraction.gauge / otherFraction.denominator);
            else
                throw new ArgumentException("Object is not a Fraction");
        }

        public bool Equals(Fraction other)
        {
            if (other == null)
                return false;

            if (this.gauge == other.gauge && this.denominator == other.denominator)
                return true;
            else
                return false;
        }

        public override string ToString() => $"{gauge}/{denominator}";

    }
}
