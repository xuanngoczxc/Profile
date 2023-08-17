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
    public partial class Phong : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-7VQLI757\MSSQLSERVER01;Initial Catalog=QLKS;Integrated Security=True");
        public void hienthi()
        {
            Con.Open();
            string query = "SELECT * FROM PHONG";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder sbd = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        public Phong()
        {
            InitializeComponent();
            hienthi();
        }

        private void Btnthemphong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtsophong.Text) || string.IsNullOrEmpty(txtsdtphong.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin phòng");
                return;
            }

            string mp;
            if (radioco.Checked == true)
                mp = "Miễn phí";
            else
                mp = "Không miễn phí";

            Con.Open();

            // Kiểm tra trùng mã phòng
            SqlCommand checkDuplicateCmd = new SqlCommand("SELECT COUNT(*) FROM PHONG WHERE IDPhong = @IDPhong", Con);
            checkDuplicateCmd.Parameters.AddWithValue("@IDPhong", txtsophong.Text);
            int duplicateCount = (int)checkDuplicateCmd.ExecuteScalar();

            if (duplicateCount > 0)
            {
                MessageBox.Show("Mã phòng đã tồn tại");
                Con.Close();
                return;
            }

            // Thêm phòng mới
            SqlCommand cmd = new SqlCommand("INSERT INTO PHONG VALUES(@IDPhong, @SdtPhong, @mp)", Con);
            cmd.Parameters.AddWithValue("@IDPhong", txtsophong.Text);
            cmd.Parameters.AddWithValue("@SdtPhong", txtsdtphong.Text);
            cmd.Parameters.AddWithValue("@mp", mp);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Thêm phòng thành công");
            Con.Close();
            hienthi();
        }

        private void Btnsuaphong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtsophong.Text) || string.IsNullOrEmpty(txtsdtphong.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin phòng");
                return;
            }
            string mp;
            if (radioco.Checked == true)
                mp = "Miễn phí";
            else
                mp = "Không miễn phí";
            Con.Open();
            // Kiểm tra mã phòng tồn tại
            SqlCommand checkma = new SqlCommand("SELECT COUNT(*) FROM PHONG WHERE IDPhong = @IDPhong", Con);
            checkma.Parameters.AddWithValue("@IDPhong", txtsophong.Text);
            int tontai = (int)checkma.ExecuteScalar();
            if (tontai == 0)
            {
                MessageBox.Show("Mã phòng không tồn tại");
                Con.Close();
                return;
            }
            // Xác nhận cập nhật thông tin phòng
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin phòng này?", "Xác nhận cập nhật", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Thực hiện cập nhật thông tin phòng
                SqlCommand cmd = new SqlCommand("UPDATE PHONG SET SdtPhong = @SdtPhong, PhongMP = @mp WHERE IDPhong = @IDPhong", Con);
                cmd.Parameters.AddWithValue("@IDPhong", txtsophong.Text);
                cmd.Parameters.AddWithValue("@SdtPhong", txtsdtphong.Text);
                cmd.Parameters.AddWithValue("@mp", mp);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thông tin phòng thành công");
            }
            Con.Close();
            hienthi();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtsophong.Text = row.Cells[0].Value.ToString();
                txtsdtphong.Text = row.Cells[1].Value.ToString();
            }
        }

        private void Btnxoaphong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtsophong.Text))
            {
                MessageBox.Show("Vui lòng nhập mã phòng");
                return;
            }
            Con.Open();
            // Kiểm tra mã phòng có tồn tại không
            SqlCommand checkma = new SqlCommand("SELECT COUNT(*) FROM PHONG WHERE IDPhong = @IDPhong", Con);
            checkma.Parameters.AddWithValue("@IDPhong", txtsophong.Text);
            int tontai = (int)checkma.ExecuteScalar();
            if (tontai == 0)
            {
                MessageBox.Show("Mã phòng không tồn tại");
                Con.Close();
                return;
            }
            // Xác nhận muốn xóa phòng
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phòng này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Xóa phòng
                SqlCommand cmd = new SqlCommand("DELETE FROM PHONG WHERE IDPhong = @IDPhong", Con);
                cmd.Parameters.AddWithValue("@IDPhong", txtsophong.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa phòng thành công");
            }
            Con.Close();
            hienthi();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "SELECT * FROM PHONG WHERE IDPhong = @IDPhong";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@IDPhong", txttkphong.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder sbd = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy thông tin phòng");
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

        private void Phong_Load(object sender, EventArgs e)
        {

        }
    }
}
