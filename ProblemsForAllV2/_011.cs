using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemsForAllV2.Helpers;

namespace ProblemsForAllV2
{
    class _011
    {
        int pointer = 0;
        int lengthCount = 4;
        string number = "";
        string [] text;

        public _011()
        {
            text = System.IO.File.ReadAllLines(@"C:\Users\Dell2\Documents\problems_v2\data2.txt");

    Console.WriteLine(Helper.biggest(getAdjacentProducts()));

        }

        List<double> getAdjacentProducts()
        {
            List<double> products = new List<double>();

            foreach (string line in text)
            {
                number += line;
            }

            while (pointer < number.Length - lengthCount)
            {

                products.Add(getNextProduct());
                pointer++;
            }

            return products;
        }


        double getNextProduct()
        {
            string _4 = "";

            for (int k = pointer; k < pointer + lengthCount; ++k)
            {
                _4 += number[k];

            }

            double product = 1;
            foreach (char digit in _4)
            {
                product *= double.Parse(digit.ToString());
            }


            return product;
        }

    }
}
