using System;
using System.IO;
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
                File.AppendAllText("login.txt", txtname.Text + ";" + txtClass.Text +";"+ txtAddress.Text + Environment.NewLine);
                MessageBox.Show("đã lưu thông tin xong");
                txtname.Text = txtAddress.Text = txtClass.Text = "";
            }
            else MessageBox.Show("không được để trống trường nào");
        }
    }
}
