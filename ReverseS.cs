using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPracticePrograms
{
    internal class ReverseS
    {
        public void ReverseString()
        {
            string inputString = "I love to play Badminton";
            string[] words = inputString.Split(' ');
            string reversedString = "";

            foreach (string word in words)
            {
                char[] letters = word.ToCharArray();
                Array.Reverse(letters);
                reversedString += new string(letters) + " ";
            }

            Console.WriteLine("Original string: " + inputString);
            Console.WriteLine("Reversed string: " + reversedString.Trim());
        }
    }
}
