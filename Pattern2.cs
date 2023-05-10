using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPracticePrograms
{
    internal class Pattern2
    {
        public void StarPattern()
        {
            int row = 7;
            int col = 7;

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= col; j++)
                {
                    if (i == 1 || i == row || j == 1 || j == col)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
