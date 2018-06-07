using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace baitaplamviecnham
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-6GQCIR0\SQLEXPRESS;Initial Catalog=sinhvien;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = txttaikhoan.Text;
                string mk = txtmatkhau.Text;
                string sql = "select *from nguoidung where taikhoan='" + tk + "' and matkhau='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show("đăng nhập thành công");
                    Form2 b = new Form2();
                    b.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("đăng nhập thất bại");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Đăng ký tài khoản");
        }
    }
}
