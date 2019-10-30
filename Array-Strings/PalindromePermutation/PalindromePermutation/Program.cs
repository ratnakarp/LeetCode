using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromePermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            //ComputePermutationAndCheckPalindrome(str) ;
            char[] palindromeStr = { 'T', 'A', 'C' ,'O','C','A','T'};
            Palindrome(4, palindromeStr);
            Console.ReadKey();
        }

        static void Palindrome(int k, char[] s)
        {
            if (k == 1)
            {
                if(CheckPalindrome(s))
                    Console.WriteLine(s);
            }
            else
                for (int i = 0; i < k; i++)
                {
                    Palindrome(k - 1, s);
                    if (i < k - 1)
                    {
                        if (k % 2 == 0)
                        {
                            var tempStr = s[i];
                            s[i] = s[k - 1];
                            s[k - 1] = tempStr;
                        }
                        else
                        {
                            var tempStr = s[0];
                            s[0] = s[k - 1];
                            s[k - 1] = tempStr;
                        }
                    }
                }
        }

        //static void ComputePermutationAndCheckPalindrome(string s)
        //{
        //    int count1 = 0;
        //    int index = 0;
        //    var s2 = s.ToCharArray();

        //    char tempStr;
        //    string[] permutationStrs = new string[FactorialLength(s.Length)];
        //    int permutationCount = 0;
        //    permutationStrs[permutationCount] = s;
        //    Console.WriteLine(permutationStrs[permutationCount]);
        //    while (count1 < s2.Length) {
        //        string firstStr = "";
        //        char tempStr1;
        //        if (count1 > 0)
        //        {
        //                tempStr1 = s2[count1 - 1];
        //                s2[count1 - 1] = s2[count1];
        //                s2[count1] = tempStr1;
        //            string computedStr1 = new string(s2);
        //            if (permutationStrs[permutationCount - 1] == computedStr1)
        //            {
        //                if (count1 < s2.Length - 1)
        //                    count1++;
        //                else
        //                    count1 = 1;
        //                continue;
        //            }
        //            bool loopBreak = false;
        //            for (int i = 0; i < permutationStrs.Length; i++)
        //            {
        //                if (permutationStrs[i] == computedStr1)
        //                {
        //                    //loopBreak = true;
        //                    break;
        //                }
        //            }
        //            //if (loopBreak)
        //            //    break;

        //            permutationStrs[permutationCount] = new string(s2);
        //            Console.WriteLine(permutationStrs[permutationCount].ToString());
        //        }
        //        char[] s1 = s2;
        //        int count2 = 1;
        //        while (count2 <= s1.Length - 1)
        //        {
        //            permutationCount++;
        //            tempStr = s1[count2];
        //            if (count2 == s1.Length - 1)
        //            {
        //                tempStr = s1[count2 - 1];
        //                s1[count2 - 1] = s1[count2];
        //                s1[count2] = tempStr;
        //                string computedStr = new string(s1);
        //                bool loopBreak = false;
        //                for (int i = 0; i < permutationStrs.Length; i++)
        //                {
        //                    if (permutationStrs[i] == computedStr)
        //                    {
        //                        loopBreak = true;
        //                        break;
        //                    }
        //                }
        //                if (loopBreak)
        //                    break;
        //                permutationStrs[permutationCount] = new string(s1);
        //            }
        //            else
        //            {
        //                tempStr = s1[count2];
        //                s1[count2] = s1[count2 + 1];
        //                s1[count2 + 1] = tempStr;
        //                firstStr = new string(s1);
        //                bool loopBreak = false;
        //                for (int i = 0; i < permutationStrs.Length; i++)
        //                {
        //                    if (permutationStrs[i] == firstStr)
        //                    {
        //                        loopBreak = true;
        //                        break;
        //                    }
        //                }
        //                if (loopBreak)
        //                    break;
        //                permutationStrs[permutationCount] = firstStr;
        //            }

        //            Console.WriteLine(permutationStrs[permutationCount].ToString());
        //            count2++;
        //            if (firstStr.Equals(permutationStrs[count1]) && count2 == s1.Length - 1)
        //                count2 = 1;
        //        }
        //        count1++;
        //        index++;
        //    }
        //}

        static int FactorialLength(int length)
        {
            int j = 1;
            for(int i = 1 ; i <= length; i++)
                j = j * i;
            return j;
        }

        static bool CheckPalindrome(char[] palindromeStr)
        {
            int count = 0;
            for(int i= palindromeStr.Length - 1; i >=0; i--)
            {
                if (palindromeStr[i] != palindromeStr[count])
                    return false;
                count++;
            }


            return true ;
        }
        static string ReverseString(string palindromeStr)
        {
            var reversePalindromeStr = "";
            palindromeStr.Reverse();
            return reversePalindromeStr;
        }
    }
}
