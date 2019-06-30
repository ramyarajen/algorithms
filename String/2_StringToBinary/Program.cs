using System;
using System.Text;

namespace _2_StringToBinary
{
    public class StringUtil
    {
        public static string ConvertToBinary(long number)
        {
            StringBuilder result = new StringBuilder();
            if (number == 0)
            {
                result.Append(number);
            }

            while (number != 0)
            {
                long reminder = number % 2;
                result.Insert(0, reminder);

                number = number >> 1;
            }

            return result.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            long number1 = 0x0; //0
            System.Console.WriteLine("{0} <==> {1}", Convert.ToString(number1, 2), StringUtil.ConvertToBinary(number1));

            long number2 = 0x1; //1
            System.Console.WriteLine("{0} <==> {1}", Convert.ToString(number2, 2), StringUtil.ConvertToBinary(number2));

            long number3 = 0x2; //10
            System.Console.WriteLine("{0} <==> {1}", Convert.ToString(number3, 2), StringUtil.ConvertToBinary(number3));

            long number4 = 0xFFFF; //1111 1111 1111 1111
            System.Console.WriteLine("{0} <==> {1}", Convert.ToString(number4, 2), StringUtil.ConvertToBinary(number4));

            long number5 = 0xA5F0; //1010 0101 1111 0000
            System.Console.WriteLine("{0} <==> {1}", Convert.ToString(number5, 2), StringUtil.ConvertToBinary(number5));
        }
    }
}
