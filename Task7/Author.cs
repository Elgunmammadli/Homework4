using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Author
    {
        public string AuthorName;
        public string AuthorSurname;

        public override string ToString()
        {
            return $"{AuthorName} {AuthorSurname}";
        }
    }
}
