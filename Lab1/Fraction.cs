using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Fraction
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
        public override string ToString() => $"{gauge} / {denominator}";

    }
}
