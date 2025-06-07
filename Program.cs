using System;
class Person
{
    public string name;

    //constructor
    public Person(string personName)
    {
        name = personName;
    }

    public void SayHello()
    {
        Console.WriteLine("Hello, " + name);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creatong Object from class
        Person p1 = new Person("Mahesh");
        Person p2 = new Person("Sita");

        //calling method

        p1.SayHello();
        p2.SayHello();
          }
}