using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Shape
{
    public class Rectangle : Shape
    {
        public Rectangle(double length,double width)
        {
            this.Length = length;
            this.Width = width;
            name += " rectangle";
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("chieu dai la {0}\nchieu rong {1} \ndien tich {2}",Length,Width,Area()==0?0:Area());
        }

        public double Length { get; private set; }
        public double Width { get; private set; }

        public override double Area()
        {
            return Width * Length;

        }

        public override int CompareTo(Shape other)
        {
            if (Area() < other.Area())
                return 1;
            else if (Area() == other.Area())
                return 0;
            else return -1;
        }
    }
}
