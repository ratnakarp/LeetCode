using System;

namespace OneAway
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] s1 = { 'p', 'a', 'l', 'e' };
            char[] s2 = { 'b', 'a', 'k' ,'e'};
            var result = OneAwayCompare.CompareInsertRemoveReplaceCharacter(s1, s2);
            Console.WriteLine(result.ToString());
        }
    }
}
