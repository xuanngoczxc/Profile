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
    public partial class NguoiDung : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-7VQLI757\MSSQLSERVER01;Initial Catalog=QLKS;Integrated Security=True");
        public void hienthi()
        {
            Con.Open();
            string query = "SELECT * FROM KHACHHANG";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder sbd = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        public NguoiDung()
        {
            InitializeComponent();
            hienthi();
        }

        private void Btnthem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtid.Text) || string.IsNullOrEmpty(txttenkh.Text) || string.IsNullOrEmpty(txtsdt.Text) || string.IsNullOrEmpty(txtdiachi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng");
                return;
            }
            Con.Open();
            SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM KHACHHANG WHERE IDKH = @IDKH", Con);
            checkCmd.Parameters.AddWithValue("@IDKH", txtid.Text);
            int count = (int)checkCmd.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("ID đã tồn tại");
                Con.Close();
                return;
            }
            SqlCommand cmd = new SqlCommand("INSERT INTO KHACHHANG VALUES (@IDKH, @TenKH, @SDTKH, @DC)", Con);
            cmd.Parameters.AddWithValue("@IDKH", txtid.Text);
            cmd.Parameters.AddWithValue("@TenKH", txttenkh.Text);
            cmd.Parameters.AddWithValue("@SDTKH", txtsdt.Text);
            cmd.Parameters.AddWithValue("@DC", txtdiachi.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thêm khách hàng thành công");
            Con.Close();
            hienthi();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtid.Text = row.Cells[0].Value.ToString();
                txttenkh.Text = row.Cells[1].Value.ToString();
                txtsdt.Text = row.Cells[2].Value.ToString();
                txtdiachi.Text = row.Cells[3].Value.ToString();
            }
        }

        private void Btnsua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtid.Text) || string.IsNullOrEmpty(txttenkh.Text) || string.IsNullOrEmpty(txtsdt.Text) || string.IsNullOrEmpty(txtdiachi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng");
                return;
            }
            Con.Open();
            SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM KHACHHANG WHERE IDKH = @IDKH", Con);
            checkCmd.Parameters.AddWithValue("@IDKH", txtid.Text);
            int count = (int)checkCmd.ExecuteScalar();
            if (count == 0)
            {
                MessageBox.Show("Không tìm thấy ID khách hàng");
                Con.Close();
                return;
            }
            SqlCommand cmd = new SqlCommand("UPDATE KHACHHANG SET TenKH = @TenKH, SdtKH = @SDTKH, DiaChi = @DC WHERE IDKH = @IDKH", Con);
            cmd.Parameters.AddWithValue("@TenKH", txttenkh.Text);
            cmd.Parameters.AddWithValue("@SDTKH", txtsdt.Text);
            cmd.Parameters.AddWithValue("@DC", txtdiachi.Text);
            cmd.Parameters.AddWithValue("@IDKH", txtid.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sửa thông tin khách hàng thành công");
            Con.Close();
            hienthi();
        }

        private void Btnxoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtid.Text))
            {
                MessageBox.Show("Vui lòng nhập ID khách hàng cần xóa");
                return;
            }
            Con.Open();
            SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM KHACHHANG WHERE IDKH = @IDKH", Con);
            checkCmd.Parameters.AddWithValue("@IDKH", txtid.Text);
            int count = (int)checkCmd.ExecuteScalar();
            if (count == 0)
            {
                MessageBox.Show("Không tìm thấy ID khách hàng");
                Con.Close();
                return;
            }
            string xacnhan1 = "Bạn có chắc chắn muốn xóa khách hàng có ID '" + txtid.Text + "' không?";
            string xacnhan2 = "Xác nhận xóa khách hàng";
            DialogResult kq = MessageBox.Show(xacnhan1, xacnhan2, MessageBoxButtons.YesNo);
            if (kq == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM KHACHHANG WHERE IDKH = @IDKH", Con);
                cmd.Parameters.AddWithValue("@IDKH", txtid.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa khách hàng thành công");
            }
            Con.Close();
            hienthi();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "SELECT * FROM KHACHHANG WHERE IDKH = '" + txttk.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder sbd = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy thông tin khách hàng");
            }
            else
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            Con.Close();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            hienthi();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void NguoiDung_Load(object sender, EventArgs e)
        {

        }
    }
}
