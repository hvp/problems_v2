using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsForAllV2.Helpers
{
    //Helper class!

   public static class Helper
    {

       public static double biggest(List<double> x)
        {
            double biggest = x[0];

            foreach (double num in x)
            {
                Console.WriteLine(num);
                if (num > biggest)
                {
                    biggest = num;
                }

            }

            return biggest;

        }

        public static bool isPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
        public static bool isPrime(double number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }

    
}
