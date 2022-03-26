using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fraction
{
    class Fraction : IComparable<Fraction>, IEquatable<Fraction>
    {
        public int meter;
        public int denominator;
        public Fraction(int meter, int denominator)
        {
            if (denominator != 0)
            {
                this.meter = meter;
                this.denominator = denominator;
            } 
            else
            {
                throw new ArgumentException("incorrect denominator");
            }
        }

        public override string ToString()
        {
            return $"{meter}/{denominator}";
        }

        public Fraction add(Fraction fraction)
        {
            int meterResult = meter * fraction.denominator + fraction.meter * denominator;
            int denominatorResult = denominator * fraction.denominator;
            Fraction result = new Fraction(meterResult, denominatorResult);
            return result;
        }

        public int CompareTo(Fraction fraction)
        {
            if ((float)meter / denominator < (float)fraction.meter / fraction.denominator)
                return -1;
            else if ((float)meter / denominator > (float)fraction.meter / fraction.denominator)
                return 1;
            else return 0;
        }

        public bool Equals(Fraction otherFraction)
        {
            int meter1 = meter * otherFraction.denominator;
            int meter2 = otherFraction.meter * denominator;
            return meter1 == meter2;
        }

        public static Fraction operator +(Fraction fraction1, Fraction fraction2)
        {
            int meterResult = fraction1.meter * fraction2.denominator + fraction2.meter * fraction1.denominator;
            int denominatorResult = fraction1.denominator * fraction2.denominator;

            return new Fraction(meterResult, denominatorResult);
        }

        public static Fraction operator -(Fraction fraction1, Fraction fraction2)
        {
            int meterResult = fraction1.meter * fraction2.denominator - fraction2.meter * fraction1.denominator;
            int denominatorResult = fraction1.denominator * fraction2.denominator;

            return new Fraction(meterResult, denominatorResult);
        }

        public static Fraction operator /(Fraction fraction1, Fraction fraction2)
        {
            if (fraction2.denominator == 0)
            {
                throw new ArgumentException("incorrect denominator");
            } 

            int meterResult = fraction1.meter * fraction2.denominator;
            int denominatorResult = fraction1.denominator * fraction2.meter;

            return new Fraction(meterResult, denominatorResult);
        }

    }
}
