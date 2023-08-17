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

namespace QuanLyKhachSan
{
    public partial class Form1 : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-7VQLI757\MSSQLSERVER01;Initial Catalog=QLKS;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM TAIKHOAN WHERE Username = @Username AND Pass = @Pass", Con);
            sda.SelectCommand.Parameters.AddWithValue("@Username", txtuser.Text);
            sda.SelectCommand.Parameters.AddWithValue("@Pass", txtpass.Text);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MainForm mf = new MainForm();
                mf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nhập sai tên đăng nhập hoặc mật khẩu");
            }
            Con.Close();

            // Xóa nội dung mật khẩu sau khi xử lý
            txtpass.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
