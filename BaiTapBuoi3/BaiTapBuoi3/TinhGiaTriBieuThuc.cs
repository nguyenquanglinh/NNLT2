using System;
using System.Collections.Generic;

namespace BaiTapBuoi3
{

    public class TinhGiaTriBieuThuc
    {
        /// <summary>
        /// giá trị cần xử lý
        /// </summary>
        public List<string> Chuoi { get; private set; }

        /// <summary>
        /// hàm khởi tạo của class
        /// </summary>
        /// <param name="s"></param>
        public TinhGiaTriBieuThuc(List<string> s)
        {
            this.Chuoi = s;
        }

        /// <summary>
        /// kiểm tra toán tử 
        /// </summary>
        /// <param name="kyTu">toán tử</param>
        /// <returns>true nếu như đã được định nghĩa</returns>
        private static bool KiemTraToanTu(string kyTu)
        {
            if (kyTu == "+" || kyTu == "-" ||
                kyTu == "*" || kyTu == "÷" ||
                kyTu == "%" || kyTu == "^" ||
                kyTu == "!" || kyTu == "√" ||
                kyTu == ".")
                return true;
            return false;
        }

        /// <summary>
        /// kiểm tra xem có phải số hay k
        /// </summary>
        /// <param name="s">chuỗi số hạng cần kiểm tra</param>
        /// <returns>dúng khi có thể ep kiểu</returns>
        private static bool kiemTraSoTuNhien(string s)
        {
            try
            {
                float.Parse(s);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Đánh giá mức độ ưu tiên của toán tử
        /// </summary>
        /// <param name="s">chuỗi toán tử</param>
        /// <returns>thứ tự thực hiện của toán tử</returns>
        private int SoSanhDoUuTienToanTu(string s)
        {
            if (s == "√" || s == "!")
                return 4;
            else if (s == "%" || s == "^")
                return 3;
            else if (s == "*" || s == "÷")
                return 2;
            else if (s == "+" || s == "-")
                return 1;
            return 0;
        }

        /// <summary>
        /// tính giá trị của biểu thức đã truyền vào
        /// </summary>
        /// <returns>giá trị của biểu thức tính được</returns>
        public string Tinh()
        {
            var stack = new Stack<string>();
            var kq = ChuyenBieuThucTrungTo();

            foreach (var s2 in kq)
            {
                if (s2 == " ")
                    continue;
                else if (kiemTraSoTuNhien(s2))
                    stack.Push(s2);
                else if (KiemTraToanTu(s2))
                {
                    if (s2 == "+")
                    {
                        var x1 = float.Parse(stack.Pop());
                        var x2 = float.Parse(stack.Pop());
                        stack.Push((x1 + x2).ToString());
                    }
                    else if (s2 == "-")
                    {
                        var x1 = float.Parse(stack.Pop());
                        float x2 = 0;
                        try
                        {
                            x2 = float.Parse(stack.Pop());
                        }
                        catch
                        {
                            x2 = 0;
                        }
                        stack.Push((x2 - x1).ToString());
                    }
                    else if (s2 == "*")
                    {
                        var x1 = float.Parse(stack.Pop());
                        var x2 = float.Parse(stack.Pop());
                        stack.Push((x1 * x2).ToString());
                    }

                    else if (s2 == "÷")
                    {
                        var x1 = float.Parse(stack.Pop());
                        var x2 = float.Parse(stack.Pop());

                        stack.Push(((float)(x2 / x1)).ToString());
                    }
                    else if (s2 == "%")
                    {
                        var x1 = float.Parse(stack.Pop());
                        var x2 = float.Parse(stack.Pop());
                        stack.Push((x2 % x1).ToString());
                    }
                    else if (s2 == "^")
                    {
                        var x1 = float.Parse(stack.Pop());
                        var x2 = float.Parse(stack.Pop());
                        stack.Push(((float)Math.Pow(x2, x1)).ToString());
                    }
                    //{  '√', '!' };
                    else if (s2 == "!")
                    {
                        stack.Push(GiaiThua((int)float.Parse(stack.Pop())).ToString());

                    }
                    else if (s2 == "√")
                    {
                        var x1 = float.Parse(stack.Pop());
                        stack.Push(((float)Math.Sqrt(x1)).ToString());
                    }
                    else stack.Push("khong ton tai phep tinh");
                }
            }
            return (stack.Pop());
        }

        

        /// <summary>
        /// Chuyển biểu thức bt sang biểu thức trung tố
        /// </summary>
        /// <returns>thứ tự toán hạng và các phép tính sau đó</returns>
        public List<string> ChuyenBieuThucTrungTo()
        {
            var stack = new Stack<string>();
            var kq = new List<string>();
            foreach (var s1 in Chuoi)
            {
                if (s1 == "")
                    continue;
                else if (kiemTraSoTuNhien(s1))
                    kq.Add(s1);
                else if (s1 == "(")
                    stack.Push(s1);
                else if (s1 == ")")
                {
                    var kqTrongStack = stack.Pop();
                    while (kqTrongStack != "(")
                    {
                        kq.Add(kqTrongStack);
                        kqTrongStack = stack.Pop();
                    }
                }
                else if (KiemTraToanTu(s1))
                {
                    while (stack.Count > 0 && SoSanhDoUuTienToanTu(s1) <= SoSanhDoUuTienToanTu(stack.Peek()))
                    {
                        kq.Add(stack.Pop());
                    }
                    stack.Push(s1);
                }
            }
            while (stack.Count > 0)
            {
                kq.Add(stack.Pop());
            }
            return kq;
        }

        /// <summary>
        /// Hàm tính giá trị giai thừa của 1 số
        /// </summary>
        /// <param name="x">giá trị càn tính</param>
        /// <returns></returns>
        int GiaiThua(int x)
        {
            if (x <= 1)
                return 1;
            return x * GiaiThua(x - 1);
        }

    }
}
