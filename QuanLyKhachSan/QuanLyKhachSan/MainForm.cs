using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.Show();
            this.Hide();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NguoiDung nd = new NguoiDung();
            nd.Show();
            this.Hide();
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phong p = new Phong();
            p.Show();
            this.Hide();
        }

        private void đặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatPhong dp = new DatPhong();
            dp.Show();
            this.Hide();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
