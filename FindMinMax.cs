using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPracticePrograms
{
    internal class FindMinMax
    {
        public void MinMax()
        {
            int[] arr = {14, 5, 3, 4, 87, 5, 4, 6, 787, 345};
            int min = arr[0];
            int max = arr[0];

            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i]<min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Maximum element: {0}", max);
            Console.WriteLine("Minimum element: {0}", min);

        }
    }
}
