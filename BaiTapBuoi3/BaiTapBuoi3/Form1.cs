using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BaiTapBuoi3
{
    public partial class Form1 : Form
    {
        #region bien 
        private string chuoiChinh = "";
        private string chuoiTrcDo = "";
        private string chuoiHienTai = "";
        private String[] opearator = { "+", "-", "*", "'÷", "%", "√", "^", "!", "(", ")" };
        #endregion
        public Form1()
        {
            InitializeComponent();
            CreateTableNumber();
        }

        /// <summary>
        /// tao bang tính
        /// </summary>
        private void CreateTableNumber()
        {
            panel_number.Controls.Clear();
            var list_string = new List<string> { "1", "2", "3","+", "-", "AC",
                "4", "5", "6", "*", "÷","%",
                "7", "8", "9",  "√","^","!",
                "0",".", "=", "(",")", "Clear",
            };
            int ox = 0;
            int oy = 0;
            int soCot = 6;
            int w = panel_number.Width / soCot;
            int soHang = list_string.Count / soCot + 1;
            int h = panel_number.Height / soHang;
            int dem = 0;
            for (int i = 0; i < soHang; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    if (dem == list_string.Count)
                        break;
                    var button = new Button()
                    {
                        Text = list_string[dem],
                        Width = w,
                        Font = new Font(Font.FontFamily, h / 2),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Height = h,
                        Location = new Point(ox, oy)
                    };
                    try
                    {
                        int.Parse(list_string[dem]);
                        button.BackColor = Color.White;
                        button.Click += Button_number_Click;
                    }
                    catch
                    {
                        button.BackColor = Color.LightGray;
                        button.Click += Button_operator_Click;
                    };
                    panel_number.Controls.Add(button);
                    ox += w;
                    dem++;
                }
                ox = 0;
                oy += h;
            }
        }

        /// <summary>
        /// chuyển đổi chuỗi vừa tính về dạng list<string></string>
        /// </summary>
        /// <returns>chuoi được chuyển đổi</returns>
        List<string> CatChuoi()
        {
            return txtText.Text.Split(' ').ToList();
        }

        /// <summary>
        /// kiểm tra đủ đấu đóng,mở ngoặc chưa
        /// </summary>
        /// <returns>true khi đã đủ đấu đóng+ mở</returns>
        bool KiemTraDongMoNgoac()
        {
            int demMo = 0;
            int demDong = 0;
            foreach (var item in txtText.Text)
            {
                if (item == '(')
                    demMo++;
                else if (item == ')')
                    demDong++;
            }
            if (demDong == demMo)
            {
                return true;
            }
            MessageBox.Show("kiểm tra lại số ngoặc đóng ngoặc mở");
            return false;
        }

        private void Button_operator_Click(object sender, EventArgs e)

        {
            var but = sender as Button;
            if (but.Text == "=")
            {
                if (KiemTraDongMoNgoac())
                {
                    try
                    {
                        txtText.Text = "=" + new TinhGiaTriBieuThuc(CatChuoi()).Tinh().ToString();
                        chuoiChinh = "";
                        chuoiTrcDo = "";
                        chuoiHienTai = "";
                    }
                    catch
                    {
                        MessageBox.Show("kiểm tra lại biểu thức");
                    }

                }
            }
            else if (but.Text == "AC")
            {
                if (txtText.Text.Length > 0)
                {
                    txtText.Text = txtText.Text.Remove(txtText.Text.Length - 1);
                    chuoiChinh = txtText.Text;
                    chuoiHienTai = chuoiTrcDo = "";
                    if (txtText.Text.Length == 0)
                    {
                        txtText.Text = "0";
                        chuoiChinh = chuoiHienTai = "";
                    }
                }
            }
            else if (but.Text == "Clear")
            {
                txtText.Text = "0";
                chuoiChinh = chuoiHienTai = chuoiTrcDo = "";
            }
            else if (but.Text == ".")
            {
                if (ChuoiTruocDoCoDauCham())
                {
                    return;
                }
                else
                {
                    chuoiTrcDo += but.Text;
                    txtText.Text = chuoiChinh + " " + chuoiTrcDo;
                }
            }
            else
            {
                if (KiemTraBieuThucDung(chuoiTrcDo))
                {
                    chuoiChinh += " " + chuoiTrcDo + " " + but.Text;
                    chuoiHienTai = chuoiTrcDo = "";
                    txtText.Text = chuoiChinh;
                }
                else
                {
                    MessageBox.Show("khong the co 2 phep tinh o gan nhau");
                }
            }
        }

        /// <summary>
        /// kiêm tra xem biểu thức ở vị trí dưới cùng đã có phép tính nào chưa
        /// </summary>
        /// <param name="s"> chuỗi ở trước đó </param>
        /// <returns>true khi chuoi=0 và ở vị tri cuoi k phai la 1 phep tính</returns>
        private bool KiemTraBieuThucDung(string s)
        {
            if (s.Length == 0)
                return true;
            foreach (var item in opearator)
            {
                if (s[s.Length - 1].ToString() == item)
                    return false;
            }
            return true;

        }

        /// <summary>
        /// sự kiện button number được bấm
        /// </summary>
        /// <param name="sender">chính là cái button </param>
        /// <param name="e">e là sự kiện click</param>
        private void Button_number_Click(object sender, EventArgs e)
        {
            var but = sender as Button;

            if (KiemTraSoHienTai(but.Text))
            {
                if (chuoiHienTai != chuoiTrcDo)
                {
                    if (chuoiHienTai != chuoiChinh)
                    {
                        if (ChuoiTruocDoCoDauCham())
                        {
                            txtText.Text = chuoiChinh + " " + chuoiTrcDo;
                        }
                        else
                        {
                            chuoiTrcDo = chuoiHienTai;
                            txtText.Text = chuoiChinh + " " + chuoiHienTai;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// kiểm tra chuỗi trc do co ton tại dấu chấm không
        /// </summary>
        /// <returns>true nếu có</returns>
        private bool ChuoiTruocDoCoDauCham()
        {
            return chuoiTrcDo.Contains(".");
        }

        /// <summary>
        /// kiểm tra giá trị có vượt qua khả năng tính ko
        /// </summary>
        /// <param name="s"> chuỗi cần kiểm tra--btn.text</param>
        /// <returns>true khi ep kiểm được</returns>
        private bool KiemTraSoHienTai(string s)
        {
            try
            {
                if (ChuoiTruocDoCoDauCham())
                {
                    chuoiTrcDo += s;
                    return true;
                }
                chuoiHienTai = int.Parse(chuoiHienTai + s).ToString();
                return true;
            }
            catch
            {
                MessageBox.Show("giá trị phải nằm trong khoảng [" + int.MinValue + ";" + int.MaxValue + "]");
            }
            return false;
        }

        /// <summary>
        /// vẽ lại bẳng khi khích thước bị thay đổi
        /// </summary>
        /// <param name="sender">chính là cái form</param>
        /// <param name="e">sự kiện thay đổi kích thước form</param>
        private void Form1_Resize(object sender, EventArgs e)
        {
            CreateTableNumber();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
