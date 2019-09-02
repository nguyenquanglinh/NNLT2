using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapBuoi1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            int demLoi = 0;
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
                    if (x > 0) demDuong ++;
                    else if (x < 0) demAm ++;
                    tong += x;
                }
                catch
                {
                    demLoi ++;
                    Console.WriteLine("chi duoc nhap so bam escape de thoat");
                    if (demLoi > 4)
                    {
                        Console.WriteLine("B da bam qua so lan quy dinh");
                        break;
                    }
                }

            } while (s != " ");
            Console.WriteLine("tong day so b vua nhap la {0}\nday so co {1} so lon hon 0\nday so co {2} so nho hon 0", tong, demDuong, demAm);
            Console.ReadLine();
        }
    }
}
