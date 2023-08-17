namespace QuanLyKhachSan
{
    partial class Phong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsophong = new System.Windows.Forms.TextBox();
            this.txtsdtphong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioco = new System.Windows.Forms.RadioButton();
            this.radiokhong = new System.Windows.Forms.RadioButton();
            this.btnxoaphong = new System.Windows.Forms.Button();
            this.btnsuaphong = new System.Windows.Forms.Button();
            this.btnthemphong = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txttkphong = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1523, 100);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("MV Boli", 7.875F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button2.Location = new System.Drawing.Point(12, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 41);
            this.button2.TabIndex = 22;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(593, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin phòng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtsophong
            // 
            this.txtsophong.Location = new System.Drawing.Point(312, 216);
            this.txtsophong.Name = "txtsophong";
            this.txtsophong.Size = new System.Drawing.Size(243, 31);
            this.txtsophong.TabIndex = 5;
            // 
            // txtsdtphong
            // 
            this.txtsdtphong.Location = new System.Drawing.Point(312, 291);
            this.txtsdtphong.Name = "txtsdtphong";
            this.txtsdtphong.Size = new System.Drawing.Size(243, 31);
            this.txtsdtphong.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 7.875F);
            this.label2.Location = new System.Drawing.Point(73, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 7.875F);
            this.label3.Location = new System.Drawing.Point(73, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Số điện thoại phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 7.875F);
            this.label4.Location = new System.Drawing.Point(73, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Miễn phí";
            // 
            // radioco
            // 
            this.radioco.AutoSize = true;
            this.radioco.Font = new System.Drawing.Font("Microsoft YaHei", 7.875F);
            this.radioco.Location = new System.Drawing.Point(309, 371);
            this.radioco.Name = "radioco";
            this.radioco.Size = new System.Drawing.Size(70, 32);
            this.radioco.TabIndex = 10;
            this.radioco.TabStop = true;
            this.radioco.Text = "Có";
            this.radioco.UseVisualStyleBackColor = true;
            // 
            // radiokhong
            // 
            this.radiokhong.AutoSize = true;
            this.radiokhong.Font = new System.Drawing.Font("Microsoft YaHei", 7.875F);
            this.radiokhong.Location = new System.Drawing.Point(385, 371);
            this.radiokhong.Name = "radiokhong";
            this.radiokhong.Size = new System.Drawing.Size(108, 32);
            this.radiokhong.TabIndex = 11;
            this.radiokhong.TabStop = true;
            this.radiokhong.Text = "Không";
            this.radiokhong.UseVisualStyleBackColor = true;
            // 
            // btnxoaphong
            // 
            this.btnxoaphong.Font = new System.Drawing.Font("MV Boli", 7.875F, System.Drawing.FontStyle.Bold);
            this.btnxoaphong.Location = new System.Drawing.Point(429, 525);
            this.btnxoaphong.Name = "btnxoaphong";
            this.btnxoaphong.Size = new System.Drawing.Size(126, 53);
            this.btnxoaphong.TabIndex = 15;
            this.btnxoaphong.Text = "Xóa";
            this.btnxoaphong.UseVisualStyleBackColor = true;
            this.btnxoaphong.Click += new System.EventHandler(this.Btnxoaphong_Click);
            // 
            // btnsuaphong
            // 
            this.btnsuaphong.Font = new System.Drawing.Font("MV Boli", 7.875F, System.Drawing.FontStyle.Bold);
            this.btnsuaphong.Location = new System.Drawing.Point(237, 525);
            this.btnsuaphong.Name = "btnsuaphong";
            this.btnsuaphong.Size = new System.Drawing.Size(126, 53);
            this.btnsuaphong.TabIndex = 14;
            this.btnsuaphong.Text = "Sửa";
            this.btnsuaphong.UseVisualStyleBackColor = true;
            this.btnsuaphong.Click += new System.EventHandler(this.Btnsuaphong_Click);
            // 
            // btnthemphong
            // 
            this.btnthemphong.Font = new System.Drawing.Font("MV Boli", 7.875F, System.Drawing.FontStyle.Bold);
            this.btnthemphong.Location = new System.Drawing.Point(51, 525);
            this.btnthemphong.Name = "btnthemphong";
            this.btnthemphong.Size = new System.Drawing.Size(126, 53);
            this.btnthemphong.TabIndex = 13;
            this.btnthemphong.Text = "Thêm";
            this.btnthemphong.UseVisualStyleBackColor = true;
            this.btnthemphong.Click += new System.EventHandler(this.Btnthemphong_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1133, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MV Boli", 7.875F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(863, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 45);
            this.button1.TabIndex = 20;
            this.button1.Text = "Tìm kiếm phòng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txttkphong
            // 
            this.txttkphong.Location = new System.Drawing.Point(601, 136);
            this.txttkphong.Name = "txttkphong";
            this.txttkphong.Size = new System.Drawing.Size(243, 31);
            this.txttkphong.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(601, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(857, 375);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 6F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(597, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nhập ID phòng";
            // 
            // Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1522, 663);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txttkphong);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnxoaphong);
            this.Controls.Add(this.btnsuaphong);
            this.Controls.Add(this.btnthemphong);
            this.Controls.Add(this.radiokhong);
            this.Controls.Add(this.radioco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsdtphong);
            this.Controls.Add(this.txtsophong);
            this.Controls.Add(this.panel1);
            this.Name = "Phong";
            this.Text = "Phòng";
            this.Load += new System.EventHandler(this.Phong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsophong;
        private System.Windows.Forms.TextBox txtsdtphong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioco;
        private System.Windows.Forms.RadioButton radiokhong;
        private System.Windows.Forms.Button btnxoaphong;
        private System.Windows.Forms.Button btnsuaphong;
        private System.Windows.Forms.Button btnthemphong;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txttkphong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
    }
}