using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max3So
{
    class Program
    {
        static int Max(int a,int b)
        {
            if (a > b)
                return a;
            return b;
        }
        static int NhapSo(int stt)
        {
            Console.Write("Nhap vao so thu {0} ",stt);
            return int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int max = NhapSo(1);
            int st2 = NhapSo(2);
            max = Max(max, st2);
            st2 = NhapSo(3);
            max = Max(max, st2);
            Console.WriteLine("so lon nhat trong 3 so vua nhap la {0}",max);
            Console.ReadLine();
        }
    }
}
