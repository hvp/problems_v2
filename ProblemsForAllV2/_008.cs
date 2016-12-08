using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsForAllV2
{
    class _008
    {


        int pointer = 0;
        int lengthCount = 13;
        string number = "";
        List<double> products = new List<double>();

        public _008()
        {
            string[] text = System.IO.File.ReadAllLines(@"C:\Users\Dell2\Documents\problems_v2\data.txt");

            foreach (string line in text)
            {
                number += line;
            }

           while(pointer < number.Length - lengthCount)
            {
               
               products.Add(getNextProduct());
               pointer++;
            }

            Console.WriteLine(biggest(products));
        }

       double getNextProduct()
        {
            string _13 = "";

            for (int k = pointer; k < pointer + lengthCount; ++k)
            {
                _13 += number[k];

            }

            double product = 1;
            foreach (char digit in _13)
            {
                 product *= double.Parse(digit.ToString());
            }
         
     
            return product;
        }

        double biggest(List<double> x)
        {
            double biggest = x[0];

            foreach(double num in x)
            {
                Console.WriteLine(num);
                if (num > biggest)
                {
                    biggest = num;
                }

            }

            return biggest;

        }
    }
}
