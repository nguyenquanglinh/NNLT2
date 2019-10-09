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
    public partial class Form1 : Form
    {
        BangChiaLuong bangChiaLuong;

        public Form1()
        {
            InitializeComponent();
            txtA.Text = "0";
            txtB.Text = "10000000000000";
            comboBox1.Text = "16";
            Application.DoEvents();
        }

        private int GetThread()
        {
            return int.Parse(comboBox1.Text.ToString());
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            GC.Collect();
            long a = long.Parse(txtA.Text);
            long b = long.Parse(txtB.Text);
            int luong = GetThread();
            bangChiaLuong = new BangChiaLuong(panelBoardControls, panelBoardThread);
            bangChiaLuong.Start(a, b, luong);
            timer1.Start();
            btnOk.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bangChiaLuong.KiemTraLuongChay(500))
            {
                timer1.Stop();
                Thread.Sleep(1000);
                File.AppendAllText("prime.txt", "từ " + txtA.Text + "->" + txtB.Text + "co: " + SoNguyenTo.dem + " SNT.\t "+ SoNguyenTo.s);
                MessageBox.Show("hoan thành");
                btnOk.Enabled = true;
            }
        }
    }
}
