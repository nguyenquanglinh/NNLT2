using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public static List<long> DsSNT = new List<long>();

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
                    DsSNT.Add(i);
                }
            }
        }
        public bool KiemTraSNT(long a)
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
}
