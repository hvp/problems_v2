using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemsForAllV2.Helpers;

namespace ProblemsForAllV2
{
    class _012
    {
        List<int> Triangles = new List<int>();

        public _012()
        {
            DoSoultion();
        }



        private void DoSoultion()
        {
            int factorCount = 0;
            int count = 1;
            int sum = 0;
            int biggestSoFar = 0;
            while (factorCount < 500)
            {
                sum += count;
                factorCount = Helper.ReturnFactors(sum).Count;
                count++;

                if (factorCount > biggestSoFar)
                {
                    biggestSoFar = factorCount;
                    Console.Clear();
                    Console.Write(factorCount);
                    Console.WriteLine();
                }
              
             
            }

            Console.WriteLine("Tri Number: " + sum + " Number of factors: " + biggestSoFar );
        }

        private int getTriangleNumber(int target)
        {
            int sum = 0;
            for (int k = 1; k <= target; ++k)
            {
                sum += k;
                Triangles.Add(sum);
            }

            return sum;
        }
    }
}
