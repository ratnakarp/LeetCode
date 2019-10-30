using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsUnique2
{
    class Program
    {
            static void Main(string[] args)
            {
                string s = "#44";
                Console.WriteLine(IsUnique(s).ToString());
                Console.ReadKey();
            }

        static bool IsUnique(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                        return false;
                }
            }
            return true;
        }
    }
}
