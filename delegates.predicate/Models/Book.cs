using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates.predicate.Models
{
    public class Book
    {
        public string Author { get; set; }
        public override string ToString()
        {
            return $"Author: {Author}";
        }

    }
}
