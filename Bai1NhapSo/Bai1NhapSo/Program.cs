using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1NhapSo
{
    class Program
    {


        //static int NhapSo()
        //{
        //    string s = Console.ReadLine();
        //    try
        //    {
        //        var x = int.Parse(s);
        //        return x;

        //    }
        //    catch
        //    {
        //        Console.WriteLine("chi duoc nhap so");
        //    }
        //    return null;
        //}
        static void Main(string[] args)
        {
            string s = "";
            int demDuong = 0;
            int demAm = 0;
            int tong = 0;
            do
            {
                Console.Write("Nhap so cua b ");
                s = Console.ReadLine();
                try
                {
                    var x = int.Parse(s);
                    if (x > 0) demDuong += 1;
                    else if (x < 0) demAm += 1;
                    tong += x;
                }
                catch
                {
                    Console.WriteLine("chi duoc nhap so bam escape de thoat");
                }

            } while (s != " ");
            Console.WriteLine("tong day so b vua nhap la {0}\nday so co {1} so lon hon 0\nday so co {2} so nho hon 0", tong, demDuong, demAm);
            Console.ReadLine();
        }
    }
}
