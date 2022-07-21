using System;
// 'new' modifier will hide the base class implementation
namespace Demo
{
    class Employee
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public void Print()
        {
            Console.WriteLine($"{FirstName}{LastName}");
        }
    }
    class Developer:Employee
    {
        public new void Print()   // hides the base class implementation
        {
            Console.WriteLine($"{FirstName}{LastName}Decveloper");
        }
    }
    class Program
    {
        static void Main()
        {
            Developer developer = new Developer { FirstName="Sarath",LastName="Chandra"};
            developer.Print();
        }
    }
}