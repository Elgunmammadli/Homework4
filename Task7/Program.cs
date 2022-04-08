using System;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author();
            author.AuthorName = ReadString("Muellif Adi:", 3);
            author.AuthorSurname = ReadString("Muellif Soyadi:", 6);
            Book b1 = new Book();
            b1.name = ReadString("Kitab Adi:", 3);
            b1.author = author;
            b1.publishedDate = ReadInt("Nesr ili: ");
            b1.pageCount = ReadCount("Sehife sayi: ",10);
           
            Book("Qerb burkusu", author, 2013, 300);
            Console.WriteLine(b1);
        }
        public static void Book(string name, Author author, int publishedDate, int pageCount)
        {

            Console.WriteLine($"Eser: {name}\n" +
                $"Muellif adi: {author.AuthorName="Chingiz"} {author.AuthorSurname="Abdullayev"}\n" +
                $"Neshr ili: {publishedDate}\n" +
                $"Sehife sayi: {pageCount}"); 
        }

        public static string ReadString(string caption,int minCount)
        {
        l1:
            Console.Write(caption);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string value = Console.ReadLine();

            if (minCount > 0 && (string.IsNullOrWhiteSpace(value) || value.Length < minCount))
            {
                PrintError($"Min uzunluq {minCount} olmalidir");
                goto l1;
            }
            Console.ResetColor();
            return value;
        }

         public static int ReadCount(string caption,int minCount)
        {
            t1:
            Console.Write(caption);
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            if (!int.TryParse(Console.ReadLine(),out int value))
            {
                Console.WriteLine("Eded daxil edilmelidir");
                goto t1;
            }
            if (!(value >=10) )
            {
                PrintError($"Min uzunluq {minCount} olmalidir");
                goto t1;
            }
            Console.ResetColor();

            return value;
            
        }

        public static int ReadInt(string caption)
        {
        l1:
            Console.Write(caption);
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            if (!int.TryParse(Console.ReadLine(), out int value))
            {
                PrintError("Reqem daxil edilmedlidir");
                goto l1;
            }
            Console.ResetColor();

            return value;
        }

        public static void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(message);
            Console.Beep();
            Console.ResetColor();
        }
    }
}
