using System;

namespace SUM_EVEN
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] even =  { 1, 2, 3, 4, 5, 6 };
            for (int i = 1; i < even.Length; i++)
            {
                if (even[i] % 2 == 0)
                {
                    sum += even[i];
                    
                }
                 
            }
            Console.WriteLine(sum);
        }
    }
}
