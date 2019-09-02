using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNT
{
    class SoNguyenToKhoang
    {
        public static int demNST = 0;
        public static List<long> DsNST = new List<long>();
        public SoNguyenToKhoang(long soBatDau, long soKetThuc)
        {
            this.SoBatDau = soBatDau;
            this.SoKetThuc = soKetThuc;
        }

        public long SoBatDau { get; private set; }
        public long SoKetThuc { get; private set; }
        public void TimSNT()
        {
            for (long i = SoBatDau; i < SoKetThuc; i++)
            {
                if (KiemTraSNT(i))
                {
                    DsNST.Add(i);
                }
            }
        }
        public bool KiemTraSNT(long a)
        {
            if (a < 2)
                return false;
            else if (a == 2)
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
}
