using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SNT
{
    public static class MultiThread
    {
        public static List<Thread> dsThread= new List<Thread>();
        public static void Start(long a, long b, int luong)
        {
            int dem = 1;
           
            long i = a;
            long bacNhay = (b - a) / luong;
            while (true)
            {
                if (b - i > bacNhay)
                {
                    var x = new Thread((new SoNguyenToKhoang(i, i + bacNhay).TimSNT));
                    x.Name = dem.ToString();
                    x.Start();
                    dsThread.Add(x);
                }
                else
                {
                    var x = new Thread((new SoNguyenToKhoang(i, b).TimSNT));
                    x.Name = i.ToString();
                    x.Start();
                    dsThread.Add(x);
                    break;
                }
                i = i + bacNhay;
                dem++;
            }
        }

        //static bool KiemTraLuongChay(int second)
        //{
        //    foreach (var item in L)
        //    {
        //        return item.Join(second);

        //    }
        //    return false;
        //}
    }
}
