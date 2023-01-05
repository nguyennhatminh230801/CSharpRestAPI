namespace NguyenNhatMinh_2019600285_proj71
{
    class TaiKhoan
    {
        public string SoTaiKhoan { get; set; }

        public string TenTaiKhoan { get; set; }

        public string DiaChi { get; set; }

        public string DienThoai { get; set; }

        public double SoTien { get; set; }

        public TaiKhoan()
        {

        }

        public TaiKhoan(string soTaiKhoan, string tenTaiKhoan, string diaChi, string dienThoai, double soTien)
        {
            SoTaiKhoan = soTaiKhoan;
            TenTaiKhoan = tenTaiKhoan;
            DiaChi = diaChi;
            DienThoai = dienThoai;
            SoTien = soTien;
        }

        public override bool Equals(object? obj)
        {
            return obj is TaiKhoan khoan &&
                   SoTaiKhoan == khoan.SoTaiKhoan &&
                   TenTaiKhoan == khoan.TenTaiKhoan &&
                   DiaChi == khoan.DiaChi &&
                   DienThoai == khoan.DienThoai &&
                   SoTien == khoan.SoTien;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
