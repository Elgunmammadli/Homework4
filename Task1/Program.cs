using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            // 1) 1-1000 qeder CUT ederlerin icerisinde reqemleri cemi 5 ile 7 arasinda olan en boyuk eded hansidir?

            Console.WriteLine(getResult());

        }

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        static int GetSumOfDigit(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int remain = number % 10;
                sum += remain;
                number /= 10;
            }
            return sum;
        }

        static bool IsSumOfDigitsBetween5And7(int number)
        {
            int sumOfDigit = GetSumOfDigit(number);
            return 5 <= sumOfDigit && sumOfDigit <= 7;
        }

        static bool IsSatisified(int number)
        {
            return (
                IsSumOfDigitsBetween5And7(number) 
                && IsEven(number)

                );
        }

        static int getResult()
        {
            List<int> intList = new List<int>();

            for (int i = 1; i <= 1000; i++)
            {
                if (IsSatisified(i))
                {
                    intList.Add(i);
                }
            }
            return intList.Max();
        }
    }
}
