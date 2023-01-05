namespace ThucHanhWinform
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
            this.btnGetAllSanPham = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDanhMuc = new System.Windows.Forms.TextBox();
            this.txtTenDanhMuc = new System.Windows.Forms.TextBox();
            this.btnThemDanhMuc = new System.Windows.Forms.Button();
            this.btnSuaDanhMuc = new System.Windows.Forms.Button();
            this.btnXoaDanhMuc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetAllSanPham
            // 
            this.btnGetAllSanPham.Location = new System.Drawing.Point(324, 23);
            this.btnGetAllSanPham.Name = "btnGetAllSanPham";
            this.btnGetAllSanPham.Size = new System.Drawing.Size(211, 29);
            this.btnGetAllSanPham.TabIndex = 0;
            this.btnGetAllSanPham.Text = "Triệu gọi toàn bộ sản phẩm";
            this.btnGetAllSanPham.UseVisualStyleBackColor = true;
            this.btnGetAllSanPham.Click += new System.EventHandler(this.btnGetAllSanPham_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(765, 363);
            this.dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(951, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã danh mục";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(951, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên danh mục";
            // 
            // txtMaDanhMuc
            // 
            this.txtMaDanhMuc.Location = new System.Drawing.Point(1093, 69);
            this.txtMaDanhMuc.Name = "txtMaDanhMuc";
            this.txtMaDanhMuc.Size = new System.Drawing.Size(285, 27);
            this.txtMaDanhMuc.TabIndex = 5;
            // 
            // txtTenDanhMuc
            // 
            this.txtTenDanhMuc.Location = new System.Drawing.Point(1093, 138);
            this.txtTenDanhMuc.Name = "txtTenDanhMuc";
            this.txtTenDanhMuc.Size = new System.Drawing.Size(285, 27);
            this.txtTenDanhMuc.TabIndex = 6;
            // 
            // btnThemDanhMuc
            // 
            this.btnThemDanhMuc.Location = new System.Drawing.Point(968, 215);
            this.btnThemDanhMuc.Name = "btnThemDanhMuc";
            this.btnThemDanhMuc.Size = new System.Drawing.Size(136, 29);
            this.btnThemDanhMuc.TabIndex = 7;
            this.btnThemDanhMuc.Text = "Thêm danh mục";
            this.btnThemDanhMuc.UseVisualStyleBackColor = true;
            this.btnThemDanhMuc.Click += new System.EventHandler(this.btnThemDanhMuc_Click);
            // 
            // btnSuaDanhMuc
            // 
            this.btnSuaDanhMuc.Location = new System.Drawing.Point(968, 280);
            this.btnSuaDanhMuc.Name = "btnSuaDanhMuc";
            this.btnSuaDanhMuc.Size = new System.Drawing.Size(136, 29);
            this.btnSuaDanhMuc.TabIndex = 8;
            this.btnSuaDanhMuc.Text = "Sửa danh mục";
            this.btnSuaDanhMuc.UseVisualStyleBackColor = true;
            this.btnSuaDanhMuc.Click += new System.EventHandler(this.btnSuaDanhMuc_Click);
            // 
            // btnXoaDanhMuc
            // 
            this.btnXoaDanhMuc.Location = new System.Drawing.Point(968, 347);
            this.btnXoaDanhMuc.Name = "btnXoaDanhMuc";
            this.btnXoaDanhMuc.Size = new System.Drawing.Size(136, 29);
            this.btnXoaDanhMuc.TabIndex = 9;
            this.btnXoaDanhMuc.Text = "Xóa danh mục";
            this.btnXoaDanhMuc.UseVisualStyleBackColor = true;
            this.btnXoaDanhMuc.Click += new System.EventHandler(this.btnXoaDanhMuc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 487);
            this.Controls.Add(this.btnXoaDanhMuc);
            this.Controls.Add(this.btnSuaDanhMuc);
            this.Controls.Add(this.btnThemDanhMuc);
            this.Controls.Add(this.txtTenDanhMuc);
            this.Controls.Add(this.txtMaDanhMuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGetAllSanPham);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetAllSanPham;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDanhMuc;
        private System.Windows.Forms.TextBox txtTenDanhMuc;
        private System.Windows.Forms.Button btnThemDanhMuc;
        private System.Windows.Forms.Button btnSuaDanhMuc;
        private System.Windows.Forms.Button btnXoaDanhMuc;
    }
}
