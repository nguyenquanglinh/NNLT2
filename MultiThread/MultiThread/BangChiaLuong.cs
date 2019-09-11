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

        public BangChiaLuong() { }

        public BangChiaLuong(Panel panelBoardControls, Panel panelBoardThread) : this()
        {
            this.panelBoardControls = panelBoardControls;
            this.panelBoardThread = panelBoardThread;
        }

        public List<Button> DsButton { get; set; }
        public List<Thread> DsThread { get; set; }

        void TaobangLuong(int soLuong)
        {
            int ox = panelBoardControls.Location.X;
            panelBoardThread.Controls.Clear();
            this.DsButton = new List<Button>();
            DsThread = new List<Thread>();
            int x = panelBoardThread.Width;
            int oy = panelBoardThread.Location.Y;
            int y = panelBoardThread.Height;
            int w = (x - ox) / 2;
            int h = (y - oy) / (soLuong / 2);
            int dem = 1;
            for (int i = 0; i < soLuong / 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    var button = new Button()
                    {
                        Width = w,
                        Height = h,
                        Location = new Point(ox, oy),
                        Text = "luồng " + dem.ToString(),
                    };

                    DsButton.Add(button);
                    ox += w;
                    dem++;
                }
                oy += h;
                ox = panelBoardControls.Location.X;
            }
            Update();
        }
        void Update()
        {
            foreach (var button in DsButton)
            {
                panelBoardThread.Controls.Add(button);
            }
        }
        public void Start(long a, long b, int soLuong)
        {
            TaobangLuong(soLuong);
            int dem = 1;
            long i = a;
            long bacNhay = (b - a) / soLuong;
            while (true)
            {
                if (b - i > bacNhay)
                {
                    var x = new Thread((new SoNguyenTo(i, i + bacNhay).LaySNT));
                    x.Name = dem.ToString();
                    x.Start();
                    DsThread.Add(x);
                }
                else
                {
                    var x = new Thread((new SoNguyenTo(i, b).LaySNT));
                    x.Name = i.ToString();
                    x.Start();
                    DsThread.Add(x);
                    break;
                }
                i = i + bacNhay;
                dem++;
            }
        }

        public void KiemTraLuongChay(int second)
        {
            for (int i = 0; i < DsThread.Count; i++)
            {
                if (DsThread[i].Join(second))
                    DsButton[i].Text ="da xong";
                else DsButton[i].Text = "chua xong";
            }
            Update();
        }
    }
}
