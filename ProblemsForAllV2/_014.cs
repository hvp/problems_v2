using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsForAllV2
{

    



    class _014
    {
       
        Dictionary<long, long> _cCache = new Dictionary<long, long>();
        
        const int upper = 1000000;
        long candidate = 1;

        long bestN = 0, bestC = 0;

        public _014()
        {
            Console.WriteLine(HowManyInChain(200));
            for (int i = 2; i <= upper; ++i)
            {
                candidate = i;


                long chainCount = HowManyInChain(candidate);
                _cCache.Add(candidate, chainCount);

                if (chainCount > bestC)
                {
                    bestC = chainCount;
                    bestN = candidate;
                }
                

               
            }

            Console.WriteLine("Winner: {0} with {1} chains.", bestN, bestC + 1);
         



            
        }





        long HowManyInChain(long x)
        {
            int count = 0;

            while (x > 1)
            {
              

                if (_cCache.ContainsKey(x))
                {


                    if (_cCache.TryGetValue(x, out long c))
                        return count + c;
                   
                }
               else
                {
    
                    if (x % 2 == 0)
                        x = even(x);
                    else
                        x = odd(x);

                    count++;
                }

                

            }

            return count;
        }

        long even(long x)
        {
            return (x / 2);
        }

        long odd(long x)
        {
            return x * 3 + 1;
        }
    }
}


