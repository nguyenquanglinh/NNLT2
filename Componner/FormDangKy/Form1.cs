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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogup_Click(object sender, EventArgs e)
        {
            File.AppendAllText("dangky.txt", txtname.Text + ";" + txtClass.Text + ";" + txtAddress.Text);
            MessageBox.Show("da luu thong tin");
        }
    }
}
