namespace Bai9Phieu1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [Key]
        [StringLength(10)]
        public string MaSanPham { get; set; }

        [StringLength(50)]
        public string TenSanPham { get; set; }

        public double? DonGia { get; set; }

        [StringLength(10)]
        public string MaDanhMuc { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }
    }
}
