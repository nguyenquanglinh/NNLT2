using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDangKy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void btnlogup_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAddress.Text) || !string.IsNullOrWhiteSpace(txtClass.Text) || !string.IsNullOrWhiteSpace(txtname.Text))
            {
                File.AppendAllText("login.txt", txtname.Text + ";" + txtClass.Text + txtAddress.Text + "\n");
                MessageBox.Show("đã lưu thông tin xong");
            }
            else MessageBox.Show("không được để trống trường nào");
        }
    }
}
