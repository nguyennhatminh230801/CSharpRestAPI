using RestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace RestAPI.Controllers
{
    public class SanPhamController : ApiController
    {
        QuanLySanPhamEntities QuanLySanPhamEntities = new QuanLySanPhamEntities();

        [HttpGet]
        public List<SanPham> layToanBoSanPham()
        {
            return QuanLySanPhamEntities.SanPhams.ToList();
        }

        [HttpGet]
        public SanPham laySanPhamTheoMa(string masp)
        {
            return QuanLySanPhamEntities.SanPhams.FirstOrDefault(x => x.MaSP == masp);
        }

        [HttpPost]
        public bool ThemMoi(string masp, string tensp, string madm)
        {
            if(QuanLySanPhamEntities.SanPhams.FirstOrDefault(x => x.MaSP == masp) == null)
            {
                SanPham sanPham = new SanPham();
                sanPham.MaSP = masp;
                sanPham.TenSP = tensp;
                sanPham.MaDM = madm;
                QuanLySanPhamEntities.SanPhams.Add(sanPham);
                QuanLySanPhamEntities.SaveChanges();
                return true;
            }

            return false;
        }

        [HttpPut]
        public bool CapNhat(string masp, string tensp, string madm)
        {
            SanPham sanPham = QuanLySanPhamEntities.SanPhams.FirstOrDefault(x => x.MaSP == masp);
            
            if (sanPham != null)
            {
                sanPham.MaSP = masp;
                sanPham.TenSP = tensp;
                sanPham.MaDM = madm;
                QuanLySanPhamEntities.SaveChanges();
                return true;
            }

            return false;
        }

        [HttpDelete]
        public bool Xoa(string masp, string tensp, string madm)
        {
            SanPham sanPham = QuanLySanPhamEntities.SanPhams.FirstOrDefault(x => x.MaSP == masp);

            if (sanPham != null)
            {
                QuanLySanPhamEntities.SanPhams.Remove(sanPham);
                QuanLySanPhamEntities.SaveChanges();
                return true;
            }

            return false;
        }

    }
}
