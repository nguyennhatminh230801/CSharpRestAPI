namespace OnTapKiemTraSo1
{
    public partial class Form1 : Form
    {
        DataUtils dataUtils = new DataUtils();
     
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataUtils.HienThiLenDataGridView(dataGridViewSach);
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            sach.MaSach = txtMaSach.Text;
            sach.TenSach = txtTenSach.Text;
            sach.TacGia = txtTacGia.Text;
            sach.GiaBan = double.Parse(txtGiaSach.Text);
            sach.NhaXuatBan = cboNhaXuatBan.GetItemText(cboNhaXuatBan.SelectedItem);

            dataUtils.AddSach(sach);
            MessageBox.Show("Thêm sách thành công");
            dataUtils.HienThiLenDataGridView(dataGridViewSach);
            ClearComponent();
        }

        private void cbtnSuaSach_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            sach.MaSach = txtMaSach.Text;
            sach.TenSach = txtTenSach.Text;
            sach.TacGia = txtTacGia.Text;
            sach.GiaBan = double.Parse(txtGiaSach.Text);
            sach.NhaXuatBan = cboNhaXuatBan.GetItemText(cboNhaXuatBan.SelectedItem);

            try
            {
                dataUtils.UpdateSach(sach);
                MessageBox.Show("Sửa sách thành công");
                dataUtils.HienThiLenDataGridView(dataGridViewSach);
                ClearComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            sach.MaSach = txtMaSach.Text;
            sach.TenSach = txtTenSach.Text;
            sach.TacGia = txtTacGia.Text;
            sach.GiaBan = double.Parse(txtGiaSach.Text);
            sach.NhaXuatBan = cboNhaXuatBan.GetItemText(cboNhaXuatBan.SelectedItem);

            try
            {
                dataUtils.DeleteSach(sach);
                MessageBox.Show("Xóa sách thành công");
                dataUtils.HienThiLenDataGridView(dataGridViewSach);
                ClearComponent();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ClearComponent()
        {
            txtGiaSach.Clear();
            txtMaSach.Clear();
            txtTacGia.Clear();
            txtTenSach.Clear();
            cboNhaXuatBan.SelectedItem = null;
        }

        private void dataGridViewSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridViewSach.SelectedCells[0].RowIndex;

            DataGridViewRow dataGridViewRow = dataGridViewSach.Rows[rowIndex];

            txtMaSach.Text = Convert.ToString(dataGridViewRow.Cells["maSach"].Value);
            txtGiaSach.Text = Convert.ToString(dataGridViewRow.Cells["giaBan"].Value);
            txtTacGia.Text = Convert.ToString(dataGridViewRow.Cells["tacGia"].Value);
            txtTenSach.Text = Convert.ToString(dataGridViewRow.Cells["tenSach"].Value);
            cboNhaXuatBan.SelectedItem = Convert.ToString(dataGridViewRow.Cells["nhaXuatBan"].Value);
        }
    }
}