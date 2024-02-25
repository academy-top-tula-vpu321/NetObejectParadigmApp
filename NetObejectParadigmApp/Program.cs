// MAIN ASSEMBLY

using NetObejectParadigmApp;
using System;

//
Employee employee = new("Bobby", 23, "Yandex");
employee.Print();
Console.WriteLine();

Person person = employee; //new Person("Peet", 33);
person.Print();
Console.WriteLine();

//if(person is Employee)
//{
//    Console.WriteLine("Yes Employee!");
//}

//if (person is Person)
//{
//    Console.WriteLine("Yes Person!");
//}

//
Client client = new Client("Tommy", 32, "Sber");
client.Print();
Console.WriteLine();

person = client;
person.Print();
Console.WriteLine();


//
//Employee sam = (Employee)new Person("Sam", 29);
//Employee? joe = new Person("Joe", 41) as Employee;

//joe?.Print();


//Object obj = new Client("Leo", 22, "VTB");
//Employee? leo =  obj as Employee;




void PrintObject(object obj)
{
    if(obj is Person person)
    {
        //Person? person = obj as Person;
        person.Print();
    }
    
}

Shape shape = new Circle(5, 5, 10); //new Shape(1, 2);
Console.WriteLine(shape.Perimetr());

