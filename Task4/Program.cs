using System;
using System.Collections.Generic;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4) 1-1000 qeder ederlerin icerisinde
            // 11 - e bolunub reqemleri cemi 11 - den boyuk olan 11 - ci eded hansidir?

            Console.WriteLine(getResult());
        }

        static bool IsDevide11(int number)
        {
            return number % 11 == 0;
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

        static bool IsSumOfDigitsGreater11(int number)
        {
            int sumOfDigit = GetSumOfDigit(number);
            return  sumOfDigit >11;
        }

        static bool IsSatisified(int number)
        {
            return (
                IsSumOfDigitsGreater11(number)
                && IsDevide11(number)

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
            return intList[10];
        }
    }
}
