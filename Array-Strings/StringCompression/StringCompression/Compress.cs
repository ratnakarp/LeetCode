using System;
using System.Collections.Generic;
using System.Text;

namespace StringCompression
{
    public static class Compress
    {
        public static void CompressString(string s)
        {
            string compressedStr = "";
            var count = 1;
            string character = "";
            for(int i=0;i<s.Length; i++)
            {
                character = s[i].ToString();
                if (i < s.Length - 1 && s[i] == s[i + 1])
                    count++;
                else
                {
                    compressedStr = compressedStr + character + count.ToString();
                    count = 1;
                }
            }

            if (compressedStr.Length < s.Length)
                Console.WriteLine(compressedStr);
            else
                Console.WriteLine("String cannot be compressed");
        }
    }
}
