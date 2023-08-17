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
    public partial class NhanVien : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-7VQLI757\MSSQLSERVER01;Initial Catalog=QLKS;Integrated Security=True");
        public void hienthi()
        {
            Con.Open();
            string query = "SELECT * FROM NHANVIEN";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder sbd = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            datagnv.DataSource = ds.Tables[0];
            Con.Close();
        }
        public NhanVien()
        {
            InitializeComponent();
            hienthi();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {

        }

        private void Btnthem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtidnv.Text) || string.IsNullOrEmpty(txttennv.Text) || string.IsNullOrEmpty(txtsdtnv.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên");
                return;
            }
            string gt;
            if (radioButton1.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            Con.Open();
            SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM NHANVIEN WHERE IDNV = @IDNV", Con);
            checkCmd.Parameters.AddWithValue("@IDNV", txtidnv.Text);
            int count = (int)checkCmd.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("ID đã tồn tại");
                Con.Close();
                return;
            }
            SqlCommand cmd = new SqlCommand("INSERT INTO NHANVIEN VALUES (@IDNV, @TenNV, @SDTNV, @GT)", Con);
            cmd.Parameters.AddWithValue("@IDNV", txtidnv.Text);
            cmd.Parameters.AddWithValue("@TenNV", txttennv.Text);
            cmd.Parameters.AddWithValue("@SDTNV", txtsdtnv.Text);
            cmd.Parameters.AddWithValue("@GT", gt);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thêm nhân viên thành công");
            Con.Close();
            hienthi();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            hienthi();
        }

        private void Btnsua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtidnv.Text) || string.IsNullOrEmpty(txttennv.Text) || string.IsNullOrEmpty(txtsdtnv.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên");
                return;
            }
            string gt;
            if (radioButton1.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            Con.Open();
            SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM NHANVIEN WHERE IDNV = @IDNV", Con);
            checkCmd.Parameters.AddWithValue("@IDNV", txtidnv.Text);
            int count = (int)checkCmd.ExecuteScalar();
            if (count == 0)
            {
                MessageBox.Show("Không tìm thấy ID nhân viên");
                Con.Close();
                return;
            }
            SqlCommand cmd = new SqlCommand("UPDATE NHANVIEN SET TenNV = @TenNV, SdtNV = @SDTNV, GioiTinh = @GT WHERE IDNV = @IDNV", Con);
            cmd.Parameters.AddWithValue("@TenNV", txttennv.Text);
            cmd.Parameters.AddWithValue("@SDTNV", txtsdtnv.Text);
            cmd.Parameters.AddWithValue("@GT", gt);
            cmd.Parameters.AddWithValue("@IDNV", txtidnv.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sửa thông tin nhân viên thành công");
            Con.Close();
            hienthi();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.datagnv.Rows[e.RowIndex];
                txtidnv.Text = row.Cells[0].Value.ToString();
                txttennv.Text = row.Cells[1].Value.ToString();
                txtsdtnv.Text = row.Cells[2].Value.ToString();
            }
            
        }

        private void Btnxoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtidnv.Text))
            {
                MessageBox.Show("Vui lòng nhập ID nhân viên cần xóa");
                return;
            }
            Con.Open();
            SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM NHANVIEN WHERE IDNV = @IDNV", Con);
            checkCmd.Parameters.AddWithValue("@IDNV", txtidnv.Text);
            int count = (int)checkCmd.ExecuteScalar();
            if (count == 0)
            {
                MessageBox.Show("Không tìm thấy ID nhân viên");
                Con.Close();
                return;
            }
            string xacnhan1 = "Bạn có chắc chắn muốn xóa nhân viên có ID '" + txtidnv.Text + "' không?";
            string xacnhan2 = "Xác nhận xóa nhân viên";
            DialogResult kq = MessageBox.Show(xacnhan1, xacnhan2, MessageBoxButtons.YesNo);
            if (kq == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM NHANVIEN WHERE IDNV = @IDNV", Con);
                cmd.Parameters.AddWithValue("@IDNV", txtidnv.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa nhân viên thành công");
            }
            Con.Close();
            hienthi();
        }

        private void Btntknv_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "SELECT * FROM NHANVIEN WHERE IDNV = '" + txttknv.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder sbd = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy thông tin nhân viên");
            }
            else
            {
                datagnv.DataSource = ds.Tables[0];
            }
            Con.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }
    }
}
