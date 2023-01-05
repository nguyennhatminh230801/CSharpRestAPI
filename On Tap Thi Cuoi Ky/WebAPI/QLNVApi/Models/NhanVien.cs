namespace QLNVApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNhanVien { get; set; }

        [StringLength(50)]
        public string TenNhanVien { get; set; }

        public double? HeSoLuong { get; set; }
    }
}
