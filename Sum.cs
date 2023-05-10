using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPracticePrograms
{
    internal class Sum
    {
        public void SumOfAllNumbers()
        {
            int n, sum = 0;
            Console.WriteLine("Enter the number: ");
            n = int.Parse(Console.ReadLine());
            while(n!=0)
            {
                sum += n % 10;
                n = n / 10;
            }
            Console.WriteLine("Sum of digits: " + sum);
        }
    }
}
