using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "#1";
            string s2 = "#84";
        }

        string[] permutations(string s)
        {
            var permutationString = new string[s.Length];
            var count = 0;
            for(int i=0; i< s.Length; i++)
            {
                permutationString[count] += s[i];
                count++;
            }

            return permutationString;
        }
    }
}
