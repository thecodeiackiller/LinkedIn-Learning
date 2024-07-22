using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    public class Fibonacci
    {
        
        public static string CalculateFibonacci(int numbers)
        {
            int j = 0;
            int k = 1;
            List<int> fibList = new List<int> { j, k};
            int sumOfPrevTwo = 0;
            for (int i = 2; i < numbers; i++)
            {
                // Need to update string and list
                sumOfPrevTwo = j + k;
                fibList.Add(sumOfPrevTwo);
                j = k;
                k = sumOfPrevTwo;

            }
            string mainFibList = string.Join(",", fibList);
            Console.WriteLine(mainFibList) ;
            return mainFibList;
            
        }
    }
}
