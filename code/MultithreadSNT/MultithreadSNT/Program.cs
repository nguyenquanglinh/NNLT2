using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadSNT
{

    class LaySNT
    {
        public static int demNST = 0;
        public LaySNT(long a, long b)
        {
            this.A = a;
            this.B = b;
        }

        public long A { get; private set; }
        public long B { get; private set; }
        public void SNTKhoang()
        {
            for (long i = A; i < B; i++)
            {
                if (CheckSNT(i))
                    demNST += 1;
            }
        }
        public bool CheckSNT(long a)
        {
            if (a == 2)
                return true;
            else if (a % 2 == 0)
                return false;
            else
            {
                for (long i = 3; i < a - 1; i += 2)
                {
                    if (a % i == 0)
                        return false;
                }
                return true;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so a ");
            int a = 0;

            Console.Write("Nhap so b ");
            long b = 100000000;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            // the code that you want to measure comes here
           
            Multithread(a, b);
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("time running code= "+elapsedMs);
            
            Console.WriteLine("test");
            LaySNT.demNST = 0;
            var watchs = System.Diagnostics.Stopwatch.StartNew();
            // the code that you want to measure comes here
            new LaySNT(a, b).SNTKhoang();
            watchs.Stop();
            var elapsedMss = watchs.ElapsedMilliseconds;
            Console.WriteLine("time running code= " + elapsedMss);
            Console.WriteLine(LaySNT.demNST);
            Console.ReadLine();
            Console.ReadKey();
            //ThreadStart s = new ThreadStart(abc);
        }

        private static void Multithread(int a, long b)
        {
            var l = new List<Thread>();
            long i = a;
            long bacNhay = (b-a) / 10;
            while (true)
            {
                if (b - i > bacNhay)
                {
                    var x = new Thread((new LaySNT(i, i + bacNhay).SNTKhoang));
                    x.Name = i.ToString();
                    x.Start();
                    l.Add(x);
                }
                else
                {
                    var x = new Thread((new LaySNT(i, b).SNTKhoang));
                    x.Name = i.ToString();
                    x.Start();
                    l.Add(x);
                    break;
                }
                i = i + bacNhay;
            }
            while (true)
            {
                int dem0 = 0;
                foreach (var item in l)
                {
                    var s = item.Join(1000);
                    //Console.WriteLine(item.Name+":"+ s);
                    if (s)
                    {
                        dem0 += 1;
                    }
                }
                if (dem0 == l.Count)
                    break;
            }
        }

        static void abc()
        {

        }
    }
}
