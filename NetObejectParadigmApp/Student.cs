using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetObejectParadigmApp
{
    public class Person
    {
        //protected int id;
        public string? Name { get; set; }
        public int Age { get; set; }
        //protected internal int Code { get; set; }

        public Person()
        {
            this.Name = "Anonim";
            this.Age = 1;
            Console.WriteLine("Person is create");
        }
    }


    public class Student : Person
    {
        public Student()
        {
            this.Name = "Student";
            Console.WriteLine("Student is create");
        }
    }
}
