using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThread
{
    public class SoNguyenTo
    {
        public SoNguyenTo(long bDau, long kThuc)
        {
            this.BatDau = bDau;
            this.KetThuc = kThuc;
        }

        public long BatDau { get; private set; }
        public long KetThuc { get; private set; }

        public static Stack<long> DsSNT = new Stack<long>();
        public static long dem = 0;
        public static string s = "";

        public override string ToString()
        {
            string s = DsSNT.Count.ToString() + "\n";
            foreach (var item in DsSNT)
            {
                s += item.ToString() + "\t";
            }
            return s;
        }
      
        public void LaySNT()
        {
            for (long i = BatDau; i < KetThuc; i++)
            {
                if (KiemTraSNT(i))
                {
                    s += i + "\t";
                    dem++;
                }
                //try
                //{
                //    DsSNT.Add(i);
                //}
                //catch
                //{
                //    DsSNT.
                //}
                //if (KiemTraSNT(i))
                //{
                //    new Thread(new GhiFile(i.ToString()).WriteToFile).Start();
                //}
            }
        }
        public static bool KiemTraSNT(long a)
        {
            if (a % 2 == 0)
                return false;
            else
            {
                for (long i = 2; i <= Math.Sqrt(a); i++)
                    if (a % i == 0)
                        return false;
                if (a < 2)
                    return false;
                else if (a == 2)
                    return true;
                return true;
            }
        }
    }

    public class GhiFile
    {
        private string s;

        public GhiFile(string s)
        {
            this.s = s;
        }
        public  void WriteToFile()
        {
            var fs = new FileStream("prime.txt", FileMode.Append, FileAccess.Write);
            var sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }
}
