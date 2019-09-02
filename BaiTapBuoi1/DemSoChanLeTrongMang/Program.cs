using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemSoChanLeTrongMang
{
    class Program
    {
        static void NhapMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("nhap sinh vien thu {0}: ", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static int DemSoChanLe(int[] a,bool chan)
        {
            int dChan = 0;
            int dLe = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                    dChan++;
                else dLe++;
            }
            if (chan)
                return dChan;
            return dLe;
        }
        static void Main(string[] args)
        {
            var x = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            Console.WriteLine("so chan trong ds la:{0} ",DemSoChanLe(x,true));
        }
    }
}
