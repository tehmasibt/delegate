using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates.predicate.Models
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Adress { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Salary: {Salary}, Name: {Name}, Surname: {Surname}, Adress: {Adress}";
        }

    }
}
