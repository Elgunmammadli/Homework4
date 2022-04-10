using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2) 1-1000 qeder ededlerin icerisinden ele ededleri cap etki :
            // hem polindrom olsun,
            // hem ededin reqemleri daxilinde 3 olmasin
            // hem ededin reqemleri cemi 10 dan boyuk olsun

            bool condition = false;




            for (int eded = 1; eded < 1000; eded++)
            {
                int dublicate = eded;
                bool state = false;

                while (dublicate > 0)
                {
                    int num = dublicate % 10;
                    dublicate /= 10;

                    if (num == 3)
                    {
                        state = true;
                        break;
                    }
                }
                if (state == false)
                {
                    if ((eded / 100 == eded % 10) && eded >= 100 && eded < 1000) // 3 reqemli uchun
                        // ikinci usulla yazmisham .polindrom ededin tapilmasi
                    {
                        condition = true;
                        if (condition == true)
                        {
                            int eded2 = eded;
                            int cem = 0;
                            bool state2 = false;
                            while (eded2 > 0)
                            {
                                int remain = eded2 % 10;
                                cem += remain;
                                eded2 /= 10;
                                if (cem > 10)
                                {
                                    state2 = true;
                                }
                            }
                            if (state2 == true)
                            {
                                Console.WriteLine($"{eded} hem polindrom,hem 3 yoxdur hem de reqemleri cemi 10dan boyuk");
                            }
                        }
                    }
                }
            }


            // Console.WriteLine("birinci shert");
            /*
           for (int a = 1; a < 1000; a++)
            {
                if ((a / 100 == a % 10) && a >= 100 && a < 1000) // 3 reqemli uchun
                {
                    condition = true;
                    if (condition == true)
                    {
                        Console.WriteLine($"{a} 3 reqemli polinomdur");
                    }
                }
            }
               */


            //  Console.WriteLine("3cu shert");

            /*
            for (int c = 1; c < 1000; c++)
            {
                int eded2 = c;
                int cem = 0;
                bool state2 = false;
                while (eded2 > 0)
                {
                    int remain = eded2 % 10;
                    cem += remain;
                    eded2 /= 10;
                    if (cem > 10)
                    {
                        state2 = true;
                    }
                }
                if (state2 == true)
                {
                    Console.WriteLine(c);
                }
            }
            */


        }


    }
}
