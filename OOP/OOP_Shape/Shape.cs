using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Shape
{
    public abstract class Shape:IComparable<Shape>
    {
        protected string name = "shape";
        public virtual void GetInfo()
        {
            Console.WriteLine("day la {0}",name);
        }
        public abstract double Area();
        public abstract int CompareTo(Shape other);
    }
}
