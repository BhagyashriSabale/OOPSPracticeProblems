using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPracticePrograms
{
    internal class UniqueElements
    {
        public void UniqueEle()
        {
            int[] arr = { 1, 3, 2, 4, 5, 3, 4, 5, 6, 4, 5, 6 };
            Console.Write("Unique elements in array: ");

            for(int i = 0; i < arr.Length; i++)
            {
                bool isDuplicate = false;

                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    Console.Write(arr[i] + " ");
                }   
            }
        }
    }
}
