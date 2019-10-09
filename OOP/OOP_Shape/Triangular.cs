using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Shape
{
    public class Triangular:Shape
    {
        public Triangular(double a,double b,double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public override double Area()
        {
            double p = (A + B + C)/2;
            return Math.Sqrt(p*(p - A)*(p - B)*(p - C));
        }

        public override int CompareTo(Shape other)
        {
            if (Area() < other.Area())
                return 1;
            else if (Area() == other.Area())
                return 0;
            else return -1;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("canh a= {0},canh b= {1}, canh c= {2} dien tich la {3}", A, B, C,Area()<=0?0:Area());
        }
    }
}
