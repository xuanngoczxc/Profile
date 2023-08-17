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
    public partial class DatPhong : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-7VQLI757\MSSQLSERVER01;Initial Catalog=QLKS;Integrated Security=True");
       
        public DatPhong()
        {
            InitializeComponent();
            hienthi();
        }

        public void hienthi()
        {
            Con.Open();
            string query = "SELECT * FROM DATPHONG";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            //SqlCommandBuilder sbd = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void DateTimePickernd_ValueChanged(object sender, EventArgs e)
        {
            DateTime ngaydat = dateTimePickernd.Value.Date;
            DateTime ngaytra = DateTime.Now.Date;

            if (ngaydat < ngaytra)
            {
                MessageBox.Show("Ngày đặt phòng không hợp lệ. Vui lòng chọn ngày hiện tại hoặc sau ngày hiện tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePickernd.Value = ngaytra;
            }
        }

        private void DatPhong_Load(object sender, EventArgs e)
        {
            loadcbbkh();
            loadcbbidphong();
        }

        private void DateTimePickernt_ValueChanged(object sender, EventArgs e)
        {
            DateTime ngaytra = dateTimePickernt.Value.Date;
            DateTime ngaydat = dateTimePickernd.Value.Date;

            if (ngaytra < ngaydat)
            {
                MessageBox.Show("Ngày trả không hợp lệ. Vui lòng chọn ngày bằng hoặc sau ngày đặt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePickernt.Value = ngaydat;
            }
        }
        public void loadcbbkh()
        {
            cmbkh.Items.Clear(); // Xóa các mục cũ trong ComboBox trước khi thêm mới

            using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7VQLI757\MSSQLSERVER01;Initial Catalog=QLKS;Integrated Security=True"))
            {
                con.Open();
                string query = "SELECT IDKH FROM KHACHHANG";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                cmbkh.DisplayMember = "IDKH"; // Thiết lập trường hiển thị của ComboBox
                cmbkh.ValueMember = "IDKH"; // Thiết lập trường giá trị của ComboBox
                cmbkh.DataSource = dataTable; // Gán DataTable làm nguồn dữ liệu cho ComboBox
            }
        }
        private void Cmbkh_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string show = cmbkh.SelectedValue.ToString();
            //MessageBox.Show(show);
        }

        private void KHACHHANG(object sender, EventArgs e)
        {

        }
        public void loadcbbidphong()
        {
            cmbphong.Items.Clear(); // Xóa các mục cũ trong ComboBox trước khi thêm mới

            using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7VQLI757\MSSQLSERVER01;Initial Catalog=QLKS;Integrated Security=True"))
            {
                con.Open();
                string query = "SELECT IDPhong FROM PHONG";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                cmbphong.DisplayMember = "IDPhong"; // Thiết lập trường hiển thị của ComboBox
                cmbphong.ValueMember = "IDPhong"; // Thiết lập trường giá trị của ComboBox
                cmbphong.DataSource = dataTable; // Gán DataTable làm nguồn dữ liệu cho ComboBox
            }
        }
        private void cmbphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            hienthi();
        }

        private void btnthemphong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtiddp.Text) || string.IsNullOrEmpty(cmbkh.Text) || string.IsNullOrEmpty(cmbphong.Text) || string.IsNullOrEmpty(dateTimePickernd.Value.ToString()) || string.IsNullOrEmpty(dateTimePickernt.Value.ToString()))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            DateTime ngayDat = dateTimePickernd.Value;
            DateTime ngayTra = dateTimePickernt.Value;

            Con.Open();
            SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM DATPHONG WHERE IDDP = @IDDP", Con);
            checkCmd.Parameters.AddWithValue("@IDDP", txtiddp.Text);
            int count = (int)checkCmd.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("ID đặt phòng đã tồn tại");
                Con.Close();
                return;
            }
            SqlCommand cmd = new SqlCommand("INSERT INTO DATPHONG VALUES (@IDDP, @IDKH, @IDPhong, @NgayDat, @NgayTra)", Con);
            cmd.Parameters.AddWithValue("@IDDP", txtiddp.Text);
            cmd.Parameters.AddWithValue("@IDKH", cmbkh.Text);
            cmd.Parameters.AddWithValue("@IDPhong", cmbphong.Text);
            cmd.Parameters.AddWithValue("@NgayDat", ngayDat.ToString());
            cmd.Parameters.AddWithValue("@NgayTra", ngayTra.ToString());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đặt phòng cho khách hàng thành công");
            Con.Close();
            hienthi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "SELECT * FROM DATPHONG WHERE IDDP = '" + txttkdp.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder sbd = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả");
            }
            else
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            Con.Close();
        }

        private void btnsuaphong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtiddp.Text) || string.IsNullOrEmpty(cmbkh.Text) || string.IsNullOrEmpty(cmbphong.Text) || string.IsNullOrEmpty(dateTimePickernd.Value.ToString()) || string.IsNullOrEmpty(dateTimePickernt.Value.ToString()))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            Con.Open();
            SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM DATPHONG WHERE IDDP = @IDDP", Con);
            checkCmd.Parameters.AddWithValue("@IDDP", txtiddp.Text);
            int count = (int)checkCmd.ExecuteScalar();
            if (count == 0)
            {
                MessageBox.Show("Không tìm thấy ID");
                Con.Close();
                return;
            }
            SqlCommand cmd = new SqlCommand("UPDATE DATPHONG SET IDKH = @IDKH, IDPhong = @IDPhong, NgayDat = @NgayDat, NgayTra = @NgayTra WHERE IDDP = @IDDP", Con);
            cmd.Parameters.AddWithValue("@IDKH", cmbkh.Text);
            cmd.Parameters.AddWithValue("@IDPhong", cmbphong.Text);
            cmd.Parameters.AddWithValue("@NgayDat", dateTimePickernd.Value.ToString());
            cmd.Parameters.AddWithValue("@NgayTra", dateTimePickernt.Value.ToString());
            cmd.Parameters.AddWithValue("@IDDP", txtiddp.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cập nhật thành công");
            Con.Close();
            hienthi();
        }

        private void btnxoaphong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtiddp.Text))
            {
                MessageBox.Show("Vui lòng nhập ID đặt phòng cần xóa");
                return;
            }
            Con.Open();
            SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM DATPHONG WHERE IDDP = @IDDP", Con);
            checkCmd.Parameters.AddWithValue("@IDDP", txtiddp.Text);
            int count = (int)checkCmd.ExecuteScalar();
            if (count == 0)
            {
                MessageBox.Show("Không tìm thấy ID đặt phòng");
                Con.Close();
                return;
            }
            string tieude = "Bạn có chắc chắn muốn xóa ID đặt phòng'" + txtiddp.Text + "' không?";
            string xacnhan = "Xác nhận xóa ID";
            DialogResult kq = MessageBox.Show(tieude, xacnhan, MessageBoxButtons.YesNo);
            if (kq == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM DATPHONG WHERE IDDP = @IDDP", Con);
                cmd.Parameters.AddWithValue("@IDDP", txtiddp.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thông tin đặt phòng thành công");
            }
            Con.Close();
            hienthi();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtiddp.Text = row.Cells[0].Value.ToString();
                cmbkh.Text = row.Cells[1].Value.ToString();
                cmbphong.Text = row.Cells[2].Value.ToString();
                // Gán giá trị ngày/tháng/năm vào DateTimePicker
                if (DateTime.TryParse(row.Cells[3].Value.ToString(), out DateTime selectedDate))
                {
                    dateTimePickernd.Value = selectedDate;
                }
                if (DateTime.TryParse(row.Cells[4].Value.ToString(), out DateTime selectedDate2))
                {
                    dateTimePickernt.Value = selectedDate2;
                }
            }
        }
    }
}
