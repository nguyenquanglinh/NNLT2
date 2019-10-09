using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace MultiThread
{
    public class BangChiaLuong
    {
        private Panel panelBoardControls;
        private Panel panelBoardThread;


        public BangChiaLuong()
        {
        }

        public BangChiaLuong(Panel panelBoardControls, Panel panelBoardThread) : this()
        {
            this.panelBoardControls = panelBoardControls;
            this.panelBoardThread = panelBoardThread;
        }

        public BangChiaLuong(Panel panelBoardControls, Panel panelBoardThread, long a, long b, int luong) : this(panelBoardControls, panelBoardThread)
        {
            this.A = a;
            this.B = b;
            this.Luong = luong;
        }

        public List<Button> DsButton { get; set; }
        public List<Thread> DsThread { get; set; }
        public long A { get; private set; }
        public long B { get; private set; }
        public int Luong { get; private set; }

        void TaoButton(int soLuong)
        {
            DsButton = new List<Button>();
            panelBoardThread.Controls.Clear();
            int ox = panelBoardControls.Location.X;
            int x = panelBoardThread.Width;
            int oy = panelBoardThread.Location.Y;
            int y = panelBoardThread.Height;
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
                    panelBoardThread.Controls.Add(button);
                    ox += w;
                    dem++;
                }
                oy += h;
                ox = panelBoardControls.Location.X;
            }
        }
        void Update(string s)
        {
            //panelBoardThread.Controls.Clear();
            foreach (var item in DsButton)
            {
                item.Text = item.Name + s;
            }
        }
        void TaoLuong(long a, long kt, int soLuong)
        {
            DsThread = new List<Thread>();
            long batDau = a;
            long bacNhay = (kt - a) / soLuong;
            for (int i = 1; i < soLuong; i++)
            {
                var luong = new Thread((new SoNguyenTo(batDau, batDau + bacNhay).LaySNT));
                luong.Name = "luong " + i.ToString() + " : [" + batDau + "->" + (batDau + bacNhay) + "]";
                DsThread.Add(luong);
                batDau += bacNhay + 1;
            }
            var luongCuoi = new Thread((new SoNguyenTo(batDau, kt).LaySNT));
            luongCuoi.Name = "luong: " + soLuong.ToString() + " [" + batDau + "," + kt + "]";
            DsThread.Add(luongCuoi);
        }

        void StartLuong()
        {
            foreach (var item in DsThread)
            {
                item.Start();
                Thread.Sleep(500);
            }
        }
        public void Start(long a, long kt, int soLuong)
        {
            TaoLuong(a, kt, soLuong);
            TaoButton(soLuong);
            Update("chua xong");
            StartLuong();
        }

        Color[] ten = {  Color.White, Color.Yellow, Color.Red };
        int chiSoMau = 0;
        public bool KiemTraLuongChay(int second)
        {
            chiSoMau++;
            if (chiSoMau > 2)
                chiSoMau = 0;
            
            int dem = 0;
            for (int i = 0; i < DsThread.Count; i++)
            {
                if (DsThread[i].Join(second))
                {
                    DsButton[i].BackColor = Color.Blue;
                    DsButton[i].Text = DsButton[i].Name + "da chay xong";
                    dem++;
                    if (dem >= DsThread.Count)
                    {
                        return true;
                    }
                }
                else
                {
                    DsButton[i].Text = DsButton[i].Name + "dang chay chua xong";
                    DsButton[i].BackColor = ten[chiSoMau];
                }
            }
            Thread.Sleep(50);
            return false;
            //Update("");
        }


        public void BatDau()
        {
            Start(A, B, Luong);
        }
    }
}
