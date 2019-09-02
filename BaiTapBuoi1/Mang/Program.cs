using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang
{
    class Program
    {
        static void NhapMang(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Nhap ho ten sinh vien thu {0}: ",i+1);
                arr[i] = Console.ReadLine();
            }
        }


        static void LayThongTinSinhVienTu(string str,string[]arr)
        {
            Console.WriteLine("ds sinh vien co ho la {0}:",str);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Contains(str))
                    Console.WriteLine("-{0}. ", arr[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so sinh vien co trong ds: ");
            int n = int.Parse(Console.ReadLine());
            string[] dsSinhVien = new string[n];
            NhapMang(dsSinhVien);
            Console.Write("nhap ho sinh vien can tim: ");
            string hoSV = Console.ReadLine();
            LayThongTinSinhVienTu(hoSV, dsSinhVien);
            Console.ReadLine();
        }
    }
}
