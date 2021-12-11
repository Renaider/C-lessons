using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_from_lab
{
    class RationalNumber
    {
        private int numerator;
        private int denominator;
        public RationalNumber(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        public static int NOD(int a, int b)
        {
            if (b < 0)
                b = -b;
            if (a < 0)
                a = -a;
            while (b > 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public static int NOK(int a, int b)
        {
            return Math.Abs(a * b) / NOD(a, b);
        }
        public static bool operator ==(RationalNumber num_1, RationalNumber num_2)
        {
            int nok = NOK(num_1.denominator, num_2.denominator);
            if (num_1.numerator * (nok / num_1.denominator) == num_2.numerator * (nok / num_2.denominator))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(RationalNumber num_1, RationalNumber num_2)
        {
            int nok = NOK(num_1.denominator, num_2.denominator);
            if (num_1.numerator * (nok / num_1.denominator) != num_2.numerator * (nok / num_2.denominator))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override bool Equals(object obj)
        {
            if (obj is RationalNumber)
            {
                return this == (obj as RationalNumber);
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(RationalNumber num_1, RationalNumber num_2)
        {
            if ((num_1.numerator * num_2.denominator) / (num_2.numerator * num_1.denominator) < 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >(RationalNumber num_1, RationalNumber num_2)
        {
            if ((num_1.numerator * num_2.denominator) / (num_2.numerator * num_1.denominator) > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <=(RationalNumber num_1, RationalNumber num_2)
        {
            if ((num_1.numerator * num_2.denominator) / (num_2.numerator * num_1.denominator) <= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >=(RationalNumber num_1, RationalNumber num_2)
        {
            if ((num_1.numerator * num_2.denominator) / (num_2.numerator * num_1.denominator) >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static RationalNumber operator +(RationalNumber num_1, RationalNumber num_2)
        {
            int nok = NOK(num_1.denominator, num_2.denominator);
            return new RationalNumber(num_1.numerator * (nok / num_1.denominator) + num_2.numerator * (nok / num_2.denominator), nok);
        }
        public static RationalNumber operator -(RationalNumber num_1, RationalNumber num_2)
        {
            int nok = NOK(num_1.denominator, num_2.denominator);
            return new RationalNumber(num_1.numerator * (nok / num_1.denominator) - num_2.numerator * (nok / num_2.denominator), nok);
        }
        public static RationalNumber operator ++(RationalNumber num)
        {
            return new RationalNumber(num.numerator + num.denominator, num.denominator);
        }
        public static RationalNumber operator --(RationalNumber num)
        {
            return new RationalNumber(num.numerator - num.denominator, num.denominator);
        }
        public static implicit operator float(RationalNumber num) => ((float)num.numerator / num.denominator);
        public static implicit operator int(RationalNumber num) => num.numerator / num.denominator;
        public static RationalNumber operator *(RationalNumber num_1, RationalNumber num_2)
        {
            return new RationalNumber(num_1.numerator * num_2.numerator, num_1.denominator * num_2.denominator);
        }
        public static RationalNumber operator /(RationalNumber num_1, RationalNumber num_2)
        {
            return new RationalNumber(num_1.numerator * num_2.denominator, num_1.denominator * num_2.numerator);
        }
        public static RationalNumber operator %(RationalNumber num_1, RationalNumber num_2)
        {
            int new_numerator = num_1.numerator * num_2.denominator;
            int new_denominator = num_1.denominator * num_2.numerator;
            return new RationalNumber(new_numerator % new_denominator, new_denominator);
        }
        public override string ToString()
        {
            return numerator + "/" + denominator;
        }
    }
}