using System;


namespace OOP_std
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new Human("linh", 21);
            x.Introduce();
            Student std = new Student("17150140","linh", 20);
            std.Introduce();
            Console.ReadKey();
        }
    }
}
