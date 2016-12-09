using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsForAllV2
{
    class _009
    {
        public _009()
        {
            int limt = 500;

            int ans = 0;
            for (int a = 1; a < limt; ++a)
            {
                for (int b = 1; b < limt; ++b)
                {
                    for(int c = 1; c < limt; ++c)
                    {
                        if(a < b && b < c)
                        {
                            if(c * c == (a*a + b*b))
                            {
                                int sum = a + b + c;
                                Console.WriteLine(a + " " + b + " " + c + " SUM: " + sum );
                                if(sum == 1000)
                                {
                                    ans = a * b * c;
                                }
                            }
                        }
                    }
                        
                    
                }
            }

            Console.WriteLine("Ans: " + ans);
                

        }
    }
}
