namespace Bai9Phieu1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public partial class SanPham
    {
        public string MaSanPham { get; set; }

        public string TenSanPham { get; set; }

        public double? DonGia { get; set; }

        public string MaDanhMuc { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }
    }
}
