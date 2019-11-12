using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThread
{
    public partial class Luong : Form
    {
        #region biến
        public string BatDau { get; private set; }
        public string KetThuc { get; private set; }
        public BangChiaLuong BangChiaLuong { get; private set; }
        public int SLuong { get; private set; }
        public long B { get; private set; }
        public long A { get; private set; }
        #endregion

        #region Hàm khởi tạo
        public Luong()
        {
            InitializeComponent();
        }
        public Luong(long a, long b, int luong) : this()
        {

            BangChiaLuong = new BangChiaLuong(panelBoardThread, a, b, luong);
            this.A = a;
            this.B = b;
            this.SLuong = luong;
            Start();
        }
        #endregion

        #region Hàm thực thi
        public void Start()
        {
            BatDau = A.ToString();
            KetThuc = B.ToString();
            BangChiaLuong.Start(A, B, SLuong);
            timer1.Start();
        }
        public void End()
        {
            Thread.Sleep(5000);
            if (MessageBox.Show("Có: " + SoNguyenTo.dem.ToString() + " số nguyên tố trong đoạn từ " + BatDau + " đến " + KetThuc + "\n Bạn có muốn lưu vào file không?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                File.AppendAllText("prime.txt", "[ " + BatDau + " ; " + KetThuc + "] có: " + SoNguyenTo.dem + " SNT."+ Environment.NewLine + SoNguyenTo.s);
            else MessageBox.Show("Bạn đã không lưu kết quả ra file");
            SoNguyenTo.dem = 0;
            SoNguyenTo.s = "";
            this.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            BangChiaLuong.CapNhatLuongChay(500);
            if (BangChiaLuong.KiemTraHoanThanh())
                End();
            else timer1.Start();
        }
        #endregion
    }
}
