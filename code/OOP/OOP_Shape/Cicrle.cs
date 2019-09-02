using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Shape
{
    public class Cicrle : Shape
    {

        private const double pi = 3.14;

        public double Radius { get; private set; }

        public Cicrle(double r)
        {
            this.Radius = r;
            name += " circle";
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("ban kinh la: {0}",Radius);
            Console.WriteLine("dien tich la {0:f2}", Area() == 0 ? 0:Area());
        }
        public override double Area()
        {
            return pi * Radius * Radius;
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
