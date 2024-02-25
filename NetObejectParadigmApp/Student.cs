using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetObejectParadigmApp
{
    class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }

        public Person() : this("Anonim", 1) {}
        public Person(string name) : this(name, 1) { }
        public Person(int age) : this("Anonum", age) { }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public virtual void Print()
        {
            Console.Write($"Name: {Name}, Age: {Age}");
        }
    }


    class Employee : Person
    {
        public string? Company { set; get; }

        public Employee() : base("Anonim", 0)
        {
            Company = "NoWork";
        }

        public Employee(string name, int age, string company)
            : base(name, age)
        {
            Company = company;
        }

        public override void Print()
        {
            base.Print();
            Console.Write($", Company: {Company}");
        }
    }

    class Client : Person
    {
        public string? Bank { set; get; }

        public Client(string name, int age, string? bank)
            : base(name, age)
        {
            Bank = bank;
        }

        public override sealed void Print()
        {
            base.Print();
            Console.Write($", Bank: {Bank}");
        }
    }

    class Student
    {

    }


    abstract class Shape
    {
        public abstract int X {  set; get; }
        public int Y {  set; get; }

        public Shape() { }
        public Shape(int x, int y)
        {
            X = x;
            Y = y;
        }

        public abstract double Perimetr();
    }

    class Circle : Shape
    {
        public int Radius { set; get; }
        public override int X { get; set; }

        public Circle() { }
        public Circle(int x, int y, int radius) : base(x, y)
        { 
            Radius = radius;
        }

        public override double Perimetr()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
