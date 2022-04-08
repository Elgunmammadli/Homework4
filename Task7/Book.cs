using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Book
    {
        public string name;
        public  Author author;
        public int publishedDate;
        public int pageCount;

        //public Book(string name, Author author, int publishedDate, int pageCount)
        //{
        //    this.name = name;
        //    this.author = author;
        //    this.publishedDate = publishedDate;
        //    this.pageCount = pageCount;
        //}

        public override string ToString()
        {
            return $"{author} '{name}' {publishedDate}";
        }

        
    }
}
