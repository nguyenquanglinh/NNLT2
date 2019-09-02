using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SNT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtA.Text = "0";
            txtB.Text = "1000000";
            comboBox1.Text = "10";
            CheckForIllegalCrossThreadCalls = false;
        }



        private int GetThread()
        {
            return int.Parse(comboBox1.Text.ToString());
        }
        void CreateTable(int cot)
        {
            int ox = panel2.Location.X;
            int x = panel1.Width;
            int oy = panel1.Location.Y;
            int y = panel1.Height;
            int w = (x - ox) / 2;
            int h = (y - oy) / (cot / 2);
            int dem = 1;
            panel1.Controls.Clear();
            for (int i = 0; i < cot / 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    panel1.Controls.Add(new Button()
                    {
                        Width = w,
                        Height = h,
                        Location = new Point(ox, oy),
                        Text ="luồng "+ dem.ToString(),
                    });
                    ox += w;
                    dem++;
                }

                oy += h;
                ox = panel2.Location.X;
            }
        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            long a = long.Parse(txtA.Text);
            long b = long.Parse(txtB.Text);
            int luong = GetThread();
            CreateTable(luong);
            //MultiThread.Start(a, b, luong);
            //var x = MultiThread.dsThread;
        }
    }
}
