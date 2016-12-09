using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemsForAllV2.Helpers;
namespace ProblemsForAllV2
{
    class _010
    {

        public _010()
        {
            double ans = 0;
            for(double k = 1; k < 2000000d; k++ )
            {
                if (Helper.isPrime(k))
                    ans += k;

            }

            Console.WriteLine(ans);
        }

      
        
    }
}
