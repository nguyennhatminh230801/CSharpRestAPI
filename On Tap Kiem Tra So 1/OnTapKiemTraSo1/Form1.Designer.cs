namespace OnTapKiemTraSo1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.cboNhaXuatBan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaSach = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.cbtnSuaSach = new System.Windows.Forms.Button();
            this.btnXoaSach = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dataGridViewSach = new System.Windows.Forms.DataGridView();
            this.nhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(360, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cập nhật thông tin sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhà xuất bản";
            // 
            // cboNhaXuatBan
            // 
            this.cboNhaXuatBan.FormattingEnabled = true;
            this.cboNhaXuatBan.Items.AddRange(new object[] {
            "NXB GD",
            "NXB TH"});
            this.cboNhaXuatBan.Location = new System.Drawing.Point(204, 70);
            this.cboNhaXuatBan.Name = "cboNhaXuatBan";
            this.cboNhaXuatBan.Size = new System.Drawing.Size(294, 28);
            this.cboNhaXuatBan.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã sách";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(206, 118);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(292, 27);
            this.txtMaSach.TabIndex = 4;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(204, 168);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(292, 27);
            this.txtTenSach.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên sách";
            // 
            // txtGiaSach
            // 
            this.txtGiaSach.Location = new System.Drawing.Point(206, 224);
            this.txtGiaSach.Name = "txtGiaSach";
            this.txtGiaSach.Size = new System.Drawing.Size(292, 27);
            this.txtGiaSach.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Giá sách";
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(206, 280);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(292, 27);
            this.txtTacGia.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tác giả";
            // 
            // btnThemSach
            // 
            this.btnThemSach.Location = new System.Drawing.Point(563, 69);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(94, 29);
            this.btnThemSach.TabIndex = 11;
            this.btnThemSach.Text = "Thêm sách";
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // cbtnSuaSach
            // 
            this.cbtnSuaSach.Location = new System.Drawing.Point(563, 123);
            this.cbtnSuaSach.Name = "cbtnSuaSach";
            this.cbtnSuaSach.Size = new System.Drawing.Size(94, 29);
            this.cbtnSuaSach.TabIndex = 12;
            this.cbtnSuaSach.Text = "Sửa sách";
            this.cbtnSuaSach.UseVisualStyleBackColor = true;
            this.cbtnSuaSach.Click += new System.EventHandler(this.cbtnSuaSach_Click);
            // 
            // btnXoaSach
            // 
            this.btnXoaSach.Location = new System.Drawing.Point(563, 173);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(94, 29);
            this.btnXoaSach.TabIndex = 13;
            this.btnXoaSach.Text = "Xóa sách";
            this.btnXoaSach.UseVisualStyleBackColor = true;
            this.btnXoaSach.Click += new System.EventHandler(this.btnXoaSach_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(563, 225);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dataGridViewSach
            // 
            this.dataGridViewSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nhaXuatBan,
            this.maSach,
            this.tenSach,
            this.giaBan,
            this.tacGia});
            this.dataGridViewSach.Location = new System.Drawing.Point(103, 334);
            this.dataGridViewSach.Name = "dataGridViewSach";
            this.dataGridViewSach.RowHeadersWidth = 51;
            this.dataGridViewSach.RowTemplate.Height = 29;
            this.dataGridViewSach.Size = new System.Drawing.Size(694, 244);
            this.dataGridViewSach.TabIndex = 15;
            this.dataGridViewSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSach_CellContentClick);
            // 
            // nhaXuatBan
            // 
            this.nhaXuatBan.HeaderText = "Nhà Xuất Bản";
            this.nhaXuatBan.MinimumWidth = 6;
            this.nhaXuatBan.Name = "nhaXuatBan";
            this.nhaXuatBan.ReadOnly = true;
            this.nhaXuatBan.Width = 125;
            // 
            // maSach
            // 
            this.maSach.HeaderText = "Mã sách";
            this.maSach.MinimumWidth = 6;
            this.maSach.Name = "maSach";
            this.maSach.ReadOnly = true;
            this.maSach.Width = 125;
            // 
            // tenSach
            // 
            this.tenSach.HeaderText = "Tên Sách";
            this.tenSach.MinimumWidth = 6;
            this.tenSach.Name = "tenSach";
            this.tenSach.ReadOnly = true;
            this.tenSach.Width = 125;
            // 
            // giaBan
            // 
            this.giaBan.HeaderText = "Giá bán";
            this.giaBan.MinimumWidth = 6;
            this.giaBan.Name = "giaBan";
            this.giaBan.Width = 125;
            // 
            // tacGia
            // 
            this.tacGia.HeaderText = "Tác Giả";
            this.tacGia.MinimumWidth = 6;
            this.tacGia.Name = "tacGia";
            this.tacGia.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 606);
            this.Controls.Add(this.dataGridViewSach);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoaSach);
            this.Controls.Add(this.cbtnSuaSach);
            this.Controls.Add(this.btnThemSach);
            this.Controls.Add(this.txtTacGia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGiaSach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboNhaXuatBan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
        private ComboBox cboNhaXuatBan;
        private Label label3;
        private TextBox txtMaSach;
        private TextBox txtTenSach;
        private Label label4;
        private TextBox txtGiaSach;
        private Label label5;
        private TextBox txtTacGia;
        private Label label6;
        private Button btnThemSach;
        private Button cbtnSuaSach;
        private Button btnXoaSach;
        private Button btnThoat;
        private DataGridView dataGridViewSach;
        private DataGridViewTextBoxColumn nhaXuatBan;
        private DataGridViewTextBoxColumn maSach;
        private DataGridViewTextBoxColumn tenSach;
        private DataGridViewTextBoxColumn giaBan;
        private DataGridViewTextBoxColumn tacGia;
    }
}