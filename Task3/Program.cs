using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        { // 3) 1-100000 qeder ederlerin icerisinden ele ededleri cap etki :
          // hem butun reqemleri eyni olsun,
          // hem reqemleri cemi 5 den boyuk olsun
          // hem reqemleri arasinda 5 reqemi olmasin

            for (int eded = 10; eded < 100000; eded++)
            {
                int dublicate = eded;
                bool state = false;

                while (dublicate > 0)
                {
                    int num = dublicate % 10;
                    dublicate /= 10;

                    if (num == 5)
                    {
                        state = true;
                        break;
                    }
                }
                if (state == false)
                {
                    int temp = eded;
                    int last = eded % 10;

                    bool state1 = false;

                    while (temp > 0)
                    {
                        if (temp % 10 != last)
                        {
                            state1 = true;
                            break;
                        }
                        temp = temp / 10;
                    }
                    if (state1 == false)
                    {
                        int eded2 = eded;
                        int cem = 0;
                        bool state2 = false;
                        while (eded2 > 0)
                        {
                            int remain = eded2 % 10;
                            cem += remain;
                            eded2 /= 10;
                            if (cem > 5)
                            {
                                state2 = true;
                            }
                        }
                        if (state2 == true)
                        {
                            Console.WriteLine($"{eded} hem reqemleri 5den boyuk,hem butun reqemleri eyni hem de 5 reqemi yoxdur");
                        }
                    }
                }
            }






            //shert 1
            /*
            for (int x = 10;x < 100000; x++)
            {
                
                int temp = x;
                int last = x % 10;

                bool state1 = false;

                while (temp > 0)
                {
                    if (temp % 10 != last)
                    {
                        state1 = true;
                        break;
                    }
                    temp = temp / 10;
                }
                if (state1 == false)
                {
                    Console.WriteLine($"{x}");
                }
               
            }
            */

            //shert 2
            /*
            for (int c = 1; c < 100000; c++)
            {
                int eded2 = c;
                int cem = 0;
                bool state2 = false;
                while (eded2 > 0)
                {
                    int remain = eded2 % 10;
                    cem += remain;
                    eded2 /= 10;
                    if (cem > 5)
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


            //3cu shert
            /*
            for (int eded = 1; eded < 1000; eded++)
            {
                int dublicate = eded;
                bool state = false;

                while (dublicate > 0)
                {
                    int num = dublicate % 10;
                    dublicate /= 10;

                    if (num == 5)
                    {
                        state = true;
                        break;
                    }
                }
                if (state == false)
                {
                    Console.WriteLine(eded);
                }
            }
            */
        }
    }
}
