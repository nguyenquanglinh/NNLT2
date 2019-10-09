using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongThucTongQuat
{
    class Program
    {
        delegate int NumberCHanger(int n);
        static void Swap<Q>(ref Q lhs, ref Q rhs)
        {
            Q temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
        static int num = 10;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MulNum(int q)
        {
            num *= q;
            return num;
        }
        public static int GetNum()
        {
            return num;
        }
        static FileStream fs;
        static StreamWriter sw;
        public delegate void PrintString(string s);
        public static void WriteToConsole(string s)
        {
            Console.WriteLine("The string is "+s);
        }
        public static void WriteToFile(string s)
        {
            fs = new FileStream("message.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        public static void SendString(PrintString ps)
        {
            ps("nguyen quang linh");
        }
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("a={0}, b={1}",a,b);
            Swap<int>(ref a, ref b);
            Console.WriteLine("swap a={0}, b={1}",a,b);
            NumberCHanger nc1 = new NumberCHanger(AddNum);
            NumberCHanger nc2 = new NumberCHanger(MulNum);
            nc1(15);
            Console.WriteLine("gia tri nc1 la "+GetNum());
            nc2(30);
            Console.WriteLine("gia tri nc2 la "+GetNum());
            PrintString ps1 = new PrintString(WriteToConsole);
            var ps2 = new PrintString(WriteToFile);
            SendString(ps1);
            SendString(ps2);
        }

    }
}
