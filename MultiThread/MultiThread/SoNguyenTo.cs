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
        #region hàm khởi tạo
        public SoNguyenTo(long bDau, long kThuc)
        {
            this.BatDau = bDau;
            this.KetThuc = kThuc;
        }
        #endregion

        #region hàm thực thi
        public void LaySNT()
        {
            for (long i = BatDau; i <= KetThuc; i++)
            {
                if (KiemTraSNT(i))
                {
                    s += i + "\t";
                    dem++;
                }
            }
        }
        public static bool KiemTraSNT(long a)
        {
            if (a <2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a% i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region biến
        public long BatDau { get; private set; }
        public long KetThuc { get; private set; }
        public static string s = "";
        public static long dem = 0;
        #endregion

    }
}
