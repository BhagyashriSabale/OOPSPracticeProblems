using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPracticePrograms
{
    internal class TotalDuplicates
    {
        public void DuplicateElement()
        {
            int[] arr = { 1, 3, 2, 4, 5, 3, 4, 5, 6, 4, 5, 6 };
            int count = 0;

            for(int i=0; i<arr.Length; i++)
            {
                for (int j=i+1; j<arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        break;
                    }

                }
            }
            Console.WriteLine("Total No.of Duplicates in array: " + count);

        }
    }
}
