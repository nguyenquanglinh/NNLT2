using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UocChung
{
    class Program
    {
        static void UocChungLonNhat(int n)
        {
            Console.Write("uoc cua n la ");
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    Console.Write("{0}, ", i);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.Write("nhap so n ");
            int n = int.Parse(Console.ReadLine());
            UocChungLonNhat(n);

        }
    }
}
