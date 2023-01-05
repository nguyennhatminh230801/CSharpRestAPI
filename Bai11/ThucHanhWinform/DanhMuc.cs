namespace Bai9Phieu1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
   
    public partial class DanhMuc
    {
        public DanhMuc()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public string MaDanhMuc { get; set; }

        public string TenDanhMuc { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
