using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayTinhDonGian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tinh_Click(object sender, EventArgs e)
        {
            
        }
        void kiemTraPhepTinh()
        {
            if(string.IsNullOrWhiteSpace( soA.Text) )
            {
                soA.Text = "0";
            }
            if(string.IsNullOrWhiteSpace(soB.Text))
            {
                soB.Text = "0";
            }
        }

        private void Cong_Click(object sender, EventArgs e)
        {
            Kq.Text = "0";
            //try
            //{
            //    kiemTraPhepTinh();
            //    {
            //        for (int i =0;i<soA.Text.Length;i++)
            //        {
            //            if(soA.Text.Contains(' '))
            //                soA.Text.Remove(i);
            //        }
            //        for (int i =0;i<soA.Text.Length;i++)
            //        {
            //            if(soA.Text.Contains(' '))
            //                soA.Text.Remove(i);
            //        }
            //        float a = float.Parse(soA.Text);
            //        float b = float.Parse(soB.Text);
            //        Kq.Text = (a + b).ToString();
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("nhap sai");
            //}
            
            
        }

        private void Tru_Click(object sender, EventArgs e)
        {
            int a = int.Parse(soA.Text);
            int b = int.Parse(soB.Text);
            Kq.Text = (a - b).ToString();
        }

        private void Nhan_Click(object sender, EventArgs e)
        {
            int a = int.Parse(soA.Text);
            int b = int.Parse(soB.Text);
            Kq.Text = (a * b).ToString();
        }

        private void Chia_Click(object sender, EventArgs e)
        {
            int a = int.Parse(soA.Text);
            int b = int.Parse(soB.Text);
            if (b == 0)
            {
                MessageBox.Show("số bị chia không thể bằng 0");
                return;
            }
                
            Kq.Text = (a / b).ToString();
        }
    }
}
