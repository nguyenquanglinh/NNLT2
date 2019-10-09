using System;

namespace DemOTrong
{

    class Program
    {
        static int DeQuy(int[] a)
        {
            int tong = 0;
            for (int i = 0; i < a.Length - 2; i++)
            {
                if (a[i] > a[i + 1])
                {
                    int vt1 = a[i];
                    //for (int q = i + 1; q < a.Length - 1; q++)
                    //{
                    //    if (a[q] < a[i])
                    //    {
                    int vt2 = a[i + 1];
                    int hSo = 1;
                    for (int j = i + 2; j < a.Length; j++)
                    {
                        if (a[j] > a[i + 1])
                        {
                            int vt3 = a[j];
                            int kq = 0;
                            if (vt1 >= vt3)
                                kq = vt3 - vt2;
                            else
                                kq = vt1 - vt2;
                            for (int k = j - 1; k >= i + 1; k--)
                            {
                                a[k] += kq;
                            }
                            tong += kq * hSo + DeQuy(a);
                            break;
                        }
                        hSo += 1;
                        //    }
                        //    break;
                        //}
                    }
                }
            }
            return tong;
        }
        static void Main(string[] args)
        {
            var a = new int[] { 7, 1, 3, 5, 7 };
            Console.WriteLine("tong o la: " + DeQuy(a));
            Console.ReadLine();
        }
    }
}
