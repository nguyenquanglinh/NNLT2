using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhSachSinhVien
{
    class Program
    {
        static void NhapMang(string[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("nhap sinh vien thu {0}: ", i + 1);
                string s= Console.ReadLine();

                a[i] = s;
            }
        }
        static void TimPhanTuMang(string[] a, string str)
        {
            Console.WriteLine("ds cac sv co ho la {0} trong ds cac sv da nhap la:", str);
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Contains(str))
                    Console.WriteLine(a[i]);
            }
        }
        static int DemSinhVienCoTrongDoTuoi(string[] a)
        {
            int demSV = 0;
            for (int i = 0; i < a.Length; i++)
            {

                var dataTime = a[i].Split('/');
                if (dataTime.Count() == 3)
                {
                    try
                    {
                        int namSinh = DateTime.Now.Year - int.Parse(dataTime[2]);
                        if (19 < namSinh && namSinh < 22)
                            demSV++;
                    }
                    catch
                    {
                        Console.WriteLine("ngay thang nam khong duoc de trong {0}", a[i]);
                    }
                }
                else Console.WriteLine("nhap sai cau truc ngay/thang/nam {0}", a[i]);
            }
            return demSV;
        }
        static void Main(string[] args)
        {
            var x = new string[10];
            NhapMang(x);
            TimPhanTuMang(x, "nguyen");
            DemSinhVienCoTrongDoTuoi(x);
            Console.ReadKey();
        }
    }
}
