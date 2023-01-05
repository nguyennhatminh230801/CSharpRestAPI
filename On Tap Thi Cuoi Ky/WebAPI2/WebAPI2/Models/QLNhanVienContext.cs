using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebAPI2.Models
{
    public partial class QLNhanVienContext : DbContext
    {
        public QLNhanVienContext()
            : base("name=QLNhanVienContext")
        {
        }

        public virtual DbSet<NhanVien> NhanViens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
