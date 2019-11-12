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
    public partial class BangDieuKhien : Form
    {
        #region Hàm khởi tạo
        public BangDieuKhien()
        {
            InitializeComponent();
            txtA.Text = "0";
            txtB.Text = "1000000";
            comboBox1.Text = "2";
        }
        #endregion

        #region Hàm thực thi
        private int GetThread()
        {
            return int.Parse(comboBox1.Text.ToString());
        }
        private void Start()
        {
            long a = long.Parse(txtA.Text);
            long b = long.Parse(txtB.Text);
            int luong = GetThread();
            var x = new Luong(a, b, luong);
            x.ShowDialog();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Start();
            }
            catch
            {

            }

        }
        #endregion
    }
}
