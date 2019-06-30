using System;
using System.Text;

namespace _1_AAABBBCDEEEF
{
    public class StringUtil
    {
        public static string CountDuplicate(string inputString)
        {
            if (String.IsNullOrWhiteSpace(inputString))
                return String.Empty;

            StringBuilder output = new StringBuilder();
            for (int idx = 0; idx < inputString.Length; )
            {
                int currentCount = 1;
                char currentChar = inputString[idx];
                int newIdx = idx + 1;

                for (; newIdx < inputString.Length; newIdx++)
                {
                    char nextChar = inputString[newIdx];
                    if (currentChar != nextChar) 
                    {
                        break;
                    }
                    else
                    {
                        currentCount++;
                    }
                }

                output.Append(currentCount);
                output.Append(currentChar);
                idx = newIdx;
            }

            return output.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = null;
            System.Console.WriteLine("{0} <==> {1}", "NULL", StringUtil.CountDuplicate(str1));

            string str2 = "";
            System.Console.WriteLine("{0} <==> {1}", str2, StringUtil.CountDuplicate(str2));

            string str3 = "ABCDEF";
            System.Console.WriteLine("{0} <==> {1}", str3, StringUtil.CountDuplicate(str3));

            string str4 = "AAAAAA";
            System.Console.WriteLine("{0} <==> {1}", str4, StringUtil.CountDuplicate(str4));

            string str5 = "AABBCCDDEE";
            System.Console.WriteLine("{0} <==> {1}", str5, StringUtil.CountDuplicate(str5));

            string str6 = "AAAAAABBBBB";
            System.Console.WriteLine("{0} <==> {1}", str6, StringUtil.CountDuplicate(str6));

            string str7 = "AAAAAAB";
            System.Console.WriteLine("{0} <==> {1}", str7, StringUtil.CountDuplicate(str7));

            string str8 = "AABBCCDDEEFF";
            System.Console.WriteLine("{0} <==> {1}", str8, StringUtil.CountDuplicate(str8));

            string str9 = "A";
            System.Console.WriteLine("{0} <==> {1}", str9, StringUtil.CountDuplicate(str9));
        }
    }
}
