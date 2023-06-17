using System;
namespace Assignment.Services
{
    public class ArithmeticAndMath
    {
        public int Sum(int param1, int param2, int param3)
        {
            return param1 + param2 + param3;
        }

        public int Multiply(int param1, int param2, int param3)
        {
            return param1 * param2 * param3;
        }

        public int Min(int param1, int param2, int param3)
        {
            return Math.Min(Math.Min(param1, param2), param3);
        }

        public int Max(int param1, int param2, int param3)
        {
            return Math.Max(Math.Max(param1, param2), param3);
        }

        public int Lcm(int param1, int param2, int param3)
        {
            int gcd1 = Gcd(param1, param2);
            int lcm1 = param1 / gcd1 * param2;

            int gcd2 = Gcd(lcm1, param3);
            return lcm1 / gcd2 * param3;
        }

        public int Gcd(int param1, int param2)
        {
            while (param2 != 0)
            {
                int temp = param2;
                param2 = param1 % param2;
                param1 = temp;
            }
            return param1;
        }
    }
}
