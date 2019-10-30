using System;
using System.Collections.Generic;
using System.Text;

namespace OneAway
{
    public static class OneAwayCompare
    {
        public static bool CompareInsertRemoveReplaceCharacter(char[] s1, char[] s2)
        {
            if(s2.Length > s1.Length || s1.Length - 1 > s2.Length)
                return false;

            int count = 0;

            for (int i = 0; i < s1.Length; i++)
            {
                bool matchedRecord = false;
                for (int j = 0; j < s2.Length; j++)
                {
                    if (s1[i] == s2[j])
                    {
                        matchedRecord = true;
                        break;
                    }
                }
                if (!matchedRecord)
                    count++;
            }
            if (count > 1)
                return false;

            return true;
        }
    }
}
