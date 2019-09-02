using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTongDaySo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                Console.Write("Nhap so n ");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 0);
            int tong = 0;
            Console.Write("day so can tinh tong la: ");
            for (int i = 1; i <= n; i+=2)
            {
                Console.Write("{0}, ",i);
                tong += i;
            }
            Console.WriteLine("\nTong day so la {0}",tong);
            Console.ReadLine();
        }
    }
}
