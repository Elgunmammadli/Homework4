using System;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 6) Her hansi bir eded daxil et.
            // Bu ededin daxilinden 5 ve 7 reqemlerini legv et.
            // Neticenin I ve Sonuncu reqemlerini deyishib cap et.
            // Alinan cavabin icerisinde nece dene tek reqem oldugunu yaz.
            Console.Write("Eded daxil et: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            bool state = false;
            double b = 0;

            while (a > 0)
            {

                double quvvet = Math.Pow(10, count);

                int remain = a % 10;
                if (!(remain == 5 || remain == 7))
                {
                    state = true;
                    if (state == true)
                    {
                        b += (quvvet * remain);
                        count++;
                    }

                }

                // 45678 => 468 => 864 
                a /= 10;


            }
            Console.WriteLine($"5 ve 7 ni legv edende:{b}");
            double digitCount = b.ToString().Length;
            double last = b % 10;
            int first = (int)(b / Math.Pow(10, digitCount - 1)); //468/100= 4
            b = b - first * Math.Pow(10, digitCount - 1) - last;
            b += last * Math.Pow(10, digitCount - 1) + first;

            Console.WriteLine("ilk ve son reqemlerini deyishende {0} ", b);

            int counter = 0;
            double dublicate = b;
            while (b > 0)
            {
                int rem = (int)b % 10;
                if (rem % 2 != 0)
                {
                    counter++;
                }
                b /= 10;
            }
            Console.WriteLine("{1}deki Tek reqemlerin sayi {0}",counter,dublicate);
        }
    }
}
