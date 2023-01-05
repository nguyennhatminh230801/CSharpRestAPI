using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapKiemTraSo1
{
    class Sach
    {
        public string MaSach { get; set; }
        public string NhaXuatBan { get; set; }
        public string TenSach { get; set; }
        public double GiaBan { get; set; }
        public string TacGia { get; set; }

        public Sach()
        {
                
        }

        public Sach(string maSach, string nhaXuatBan, string tenSach, double giaBan, string tacGia)
        {
            MaSach = maSach;
            NhaXuatBan = nhaXuatBan;
            TenSach = tenSach;
            GiaBan = giaBan;
            TacGia = tacGia;
        }

        
    }
}
