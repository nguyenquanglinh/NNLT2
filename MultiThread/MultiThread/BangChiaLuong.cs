using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace MultiThread
{
    public class BangChiaLuong
    {
        #region biến
        public List<Button> DsButton { get; set; }
        public List<Thread> DsThread { get; set; }
        public long A { get; private set; }
        public long B { get; private set; }
        public int Luong { get; private set; }
        public Panel PanelBoardThread { get; private set; }
        #endregion

        #region Hàm khởi tạo
        public BangChiaLuong()
        {

        }

        public BangChiaLuong(Panel panelBoardThread, long a, long b, int luong) : this()
        {
            this.A = a;
            this.B = b;
            this.Luong = luong;
            this.PanelBoardThread = panelBoardThread;
        }
        #endregion

        #region hàm thực thi bên trong
        private void TaoButton(int soLuong)
        {
            DsButton = new List<Button>();
            PanelBoardThread.Controls.Clear();
            int ox = 0;
            int x = PanelBoardThread.Width;
            int oy = 0;
            int y = PanelBoardThread.Height;
            int w = (x - ox) / 2;
            int h = (y - oy) / (soLuong / 2);
            int dem = 0;
            for (int i = 0; i < soLuong / 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    var button = new Button()
                    {
                        Width = w,
                        Height = h,
                        Location = new Point(ox, oy),
                        Name = DsThread[dem].Name + "\n",
                        BackColor = Color.Red,
                    };
                    DsButton.Add(button);
                    PanelBoardThread.Controls.Add(button);
                    ox += w;
                    dem++;
                }
                oy += h;
                ox = 0;
            }
        }
        private void Update(string s)
        {
            foreach (var item in DsButton)
            {
                item.Text = item.Name + s;
            }
        }
        private void TaoLuong(int soLuong)
        {
            DsThread = new List<Thread>();
            long batDau = A;
            long bacNhay = (B - A) / soLuong;
            for (int i = 1; i < soLuong; i++)
            {
                var luong = new Thread((new SoNguyenTo(batDau, batDau + bacNhay).LaySNT));
                luong.Name = "luong " + i.ToString() + " : [" + batDau + "->" + (batDau + bacNhay) + "]";
                DsThread.Add(luong);
                batDau += bacNhay + 1;
            }
            var luongCuoi = new Thread((new SoNguyenTo(batDau, B).LaySNT));
            luongCuoi.Name = "luong: " + soLuong.ToString() + " [" + batDau + "," + B + "]";
            DsThread.Add(luongCuoi);
        }
        private void StartLuong()
        {
            foreach (var item in DsThread)
            {
                item.Start();
                Thread.Sleep(1000);
            }
        }

        private bool KiemTraLuong(int second)
        {
            foreach (var item in DsThread)
                if (!item.Join(second))
                    return false;
            return true;
        }
        private void HoanThanh()
        {
            foreach (var item in DsButton)
            {
                item.BackColor = Color.Blue;
            }
        }
        #endregion

        #region hàm thực thi cho phép bên ngoài 
        public void Start(long a, long kt, int soLuong)
        {
            TaoLuong(soLuong);
            TaoButton(soLuong);
            Update("chua xong");
            StartLuong();
        }

        public bool KiemTraLuongChay(int second)
        {
            if (KiemTraLuong(second)) { HoanThanh(); return true; }
            else
            {
                for (int i = 0; i < DsThread.Count; i++)
                {
                    if (DsThread[i].Join(second))
                    {
                        DsButton[i].BackColor = Color.Blue;
                        DsButton[i].Text = DsButton[i].Name + "đã chạy xong";
                    }
                    else
                    {
                        DsButton[i].Text = DsButton[i].Name + "chưa chạy xong";
                        DsButton[i].BackColor = DsButton[i].BackColor == Color.Yellow ? Color.Red : Color.Yellow;
                    }
                }
            }
            return false;
        }
        public void BatDau()
        {
            Start(A, B, Luong);
        }
        #endregion
    }
}
