using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            var l = new List<Shape>();
            Cicrle c = new Cicrle(5);
            l.Add(c);

            Rectangle r = new Rectangle(5,4);
            l.Add(r);
            Triangular t = new Triangular(4, 4, 4);
            l.Add(t);
            l.Sort();
            foreach (var s in l)
            {
                s.GetInfo();
            }
            Console.WriteLine("ss dt");
            l.Sort();
            Console.ReadLine();
        }
    }
}
