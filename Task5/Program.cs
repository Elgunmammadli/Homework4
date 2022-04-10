using System;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        { //5) Her hansi bir eded daxil et.
          //Eger eded polindromdursa o zaman bu ededin evveline ve axirin 1 reqemini artir ve cap et.
          //Eks halda ededin ozunu cap et.   polindrom eded:  123321; 12321--guzgu effekti
            Console.Write("eded daxil et:");
            int a = Convert.ToInt32(Console.ReadLine());
            int dublicate = a;
            int ters=0;
            while (a > 0)
            {
                int remain = a % 10;
                ters = ters * 10 + remain;
                a /= 10;
            }
            if (dublicate==ters)
            {
                Console.WriteLine(int.Parse(1+dublicate.ToString()+1));
            }
            else
            {
                Console.WriteLine(dublicate);
            }

        }
    }
}
