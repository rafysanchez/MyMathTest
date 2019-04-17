using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrograms
{
   public class TTDPrograms
    {
        public double Power(int b, int exp)
        {
            double result = Math.Pow(b, exp);

            // our code

            return result;
        }

        public int Smallest(int[] arr)
        {
            int result = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (result > arr[i])
                {
                    result = arr[i];
                }
            }

            return result;
        }

        public string GetValueFizzBuzz(int input)
        {
            if (input %3 == 0 && input %5 ==0)
            {
                return "FizzBuzz";
            }
            if (input %3 ==0)
            {
                return "Fizz";
            }
            if (input % 5 == 0)
            {
                return "Buzz";
            }
            return input.ToString();
        }
    }
}
