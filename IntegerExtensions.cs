using System;

namespace PadawansTask3
{
    public static class IntegerExtensions
    {
        public static int Gcd(int a, int b)
        {
            if (a == 0 && b == 0)
                throw new ArgumentException();
            a = CheckSign(a);
            b = CheckSign(b);
            if (a == 0 || b == 0)
                return a == 0 ? b : a;
            if ((a % b) > 0)
                return Gcd(b, (a % b));
            else
                return b;
        }

        private static int CheckSign(int number)
        {
            return Math.Abs(number);
        }
    }
}
