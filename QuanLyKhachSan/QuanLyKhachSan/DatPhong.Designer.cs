namespace QuanLyKhachSan
{
    partial class DatPhong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatPhong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtiddp = new System.Windows.Forms.TextBox();
            this.cmbkh = new System.Windows.Forms.ComboBox();
            this.cmbphong = new System.Windows.Forms.ComboBox();
            this.dateTimePickernd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickernt = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.txttkdp = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnxoaphong = new System.Windows.Forms.Button();
            this.btnsuadp = new System.Windows.Forms.Button();
            this.btnthemphong = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1725, 100);
            this.panel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("MV Boli", 7.875F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button2.Location = new System.Drawing.Point(12, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(587, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin đặt phòng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 7.875F);
            this.label2.Location = new System.Drawing.Point(128, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID Đặt Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 7.875F);
            this.label3.Location = new System.Drawing.Point(128, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 7.875F);
            this.label4.Location = new System.Drawing.Point(128, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 7.875F);
            this.label5.Location = new System.Drawing.Point(128, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày đặt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 7.875F);
            this.label6.Location = new System.Drawing.Point(128, 486);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ngày trả";
            // 
            // txtiddp
            // 
            this.txtiddp.Location = new System.Drawing.Point(281, 171);
            this.txtiddp.Name = "txtiddp";
            this.txtiddp.Size = new System.Drawing.Size(280, 31);
            this.txtiddp.TabIndex = 8;
            // 
            // cmbkh
            // 
            this.cmbkh.FormattingEnabled = true;
            this.cmbkh.Location = new System.Drawing.Point(281, 251);
            this.cmbkh.Name = "cmbkh";
            this.cmbkh.Size = new System.Drawing.Size(280, 33);
            this.cmbkh.TabIndex = 9;
            this.cmbkh.SelectedIndexChanged += new System.EventHandler(this.Cmbkh_SelectedIndexChanged);
            this.cmbkh.DisplayMemberChanged += new System.EventHandler(this.KHACHHANG);
            // 
            // cmbphong
            // 
            this.cmbphong.FormattingEnabled = true;
            this.cmbphong.Location = new System.Drawing.Point(281, 329);
            this.cmbphong.Name = "cmbphong";
            this.cmbphong.Size = new System.Drawing.Size(280, 33);
            this.cmbphong.TabIndex = 10;
            this.cmbphong.SelectedIndexChanged += new System.EventHandler(this.cmbphong_SelectedIndexChanged);
            // 
            // dateTimePickernd
            // 
            this.dateTimePickernd.Location = new System.Drawing.Point(281, 409);
            this.dateTimePickernd.Name = "dateTimePickernd";
            this.dateTimePickernd.Size = new System.Drawing.Size(280, 31);
            this.dateTimePickernd.TabIndex = 11;
            this.dateTimePickernd.ValueChanged += new System.EventHandler(this.DateTimePickernd_ValueChanged);
            // 
            // dateTimePickernt
            // 
            this.dateTimePickernt.Location = new System.Drawing.Point(281, 483);
            this.dateTimePickernt.Name = "dateTimePickernt";
            this.dateTimePickernt.Size = new System.Drawing.Size(280, 31);
            this.dateTimePickernt.TabIndex = 12;
            this.dateTimePickernt.ValueChanged += new System.EventHandler(this.DateTimePickernt_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(844, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 45);
            this.button1.TabIndex = 23;
            this.button1.Text = "Tìm kiếm đặt phòng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txttkdp
            // 
            this.txttkdp.Location = new System.Drawing.Point(595, 168);
            this.txttkdp.Name = "txttkdp";
            this.txttkdp.Size = new System.Drawing.Size(243, 31);
            this.txttkdp.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(595, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1106, 375);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1114, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnxoaphong
            // 
            this.btnxoaphong.Location = new System.Drawing.Point(450, 584);
            this.btnxoaphong.Name = "btnxoaphong";
            this.btnxoaphong.Size = new System.Drawing.Size(126, 45);
            this.btnxoaphong.TabIndex = 27;
            this.btnxoaphong.Text = "Xóa";
            this.btnxoaphong.UseVisualStyleBackColor = true;
            this.btnxoaphong.Click += new System.EventHandler(this.btnxoaphong_Click);
            // 
            // btnsuadp
            // 
            this.btnsuadp.Location = new System.Drawing.Point(267, 584);
            this.btnsuadp.Name = "btnsuadp";
            this.btnsuadp.Size = new System.Drawing.Size(126, 45);
            this.btnsuadp.TabIndex = 26;
            this.btnsuadp.Text = "Sửa";
            this.btnsuadp.UseVisualStyleBackColor = true;
            this.btnsuadp.Click += new System.EventHandler(this.btnsuaphong_Click);
            // 
            // btnthemphong
            // 
            this.btnthemphong.Location = new System.Drawing.Point(72, 584);
            this.btnthemphong.Name = "btnthemphong";
            this.btnthemphong.Size = new System.Drawing.Size(126, 45);
            this.btnthemphong.TabIndex = 25;
            this.btnthemphong.Text = "Đặt phòng";
            this.btnthemphong.UseVisualStyleBackColor = true;
            this.btnthemphong.Click += new System.EventHandler(this.btnthemphong_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 6F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(591, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 21);
            this.label7.TabIndex = 28;
            this.label7.Text = "Nhập ID đặt phòng";
            // 
            // DatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1725, 662);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnxoaphong);
            this.Controls.Add(this.btnsuadp);
            this.Controls.Add(this.btnthemphong);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txttkdp);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePickernt);
            this.Controls.Add(this.dateTimePickernd);
            this.Controls.Add(this.cmbphong);
            this.Controls.Add(this.cmbkh);
            this.Controls.Add(this.txtiddp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "DatPhong";
            this.Text = "Đặt phòng";
            this.Load += new System.EventHandler(this.DatPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtiddp;
        private System.Windows.Forms.ComboBox cmbkh;
        private System.Windows.Forms.ComboBox cmbphong;
        private System.Windows.Forms.DateTimePicker dateTimePickernd;
        private System.Windows.Forms.DateTimePicker dateTimePickernt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txttkdp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnxoaphong;
        private System.Windows.Forms.Button btnsuadp;
        private System.Windows.Forms.Button btnthemphong;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
    }
}