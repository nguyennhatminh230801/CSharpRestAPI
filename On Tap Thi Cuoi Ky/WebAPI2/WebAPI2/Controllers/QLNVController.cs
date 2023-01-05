using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI2.Models;

namespace WebAPI2.Controllers
{
    public class QLNVController : ApiController
    {
        QLNhanVienContext context = new QLNhanVienContext();
        [HttpGet]
        public List<NhanVien> DanhSach()
        {
            
            return context.NhanViens.ToList();
        }

        [HttpPost]
        public bool ThemNV(int manv, string tennv, float hesoluong)
        {
            try
            {
                NhanVien nhanVien = context.NhanViens.FirstOrDefault(x => x.MaNhanVien == manv);
                if (nhanVien != null) throw new Exception();

                NhanVien nhanVien1 = new NhanVien();
                nhanVien1.MaNhanVien = manv;
                nhanVien1.TenNhanVien = tennv;
                nhanVien1.HeSoLuong = hesoluong;

                context.NhanViens.Add(nhanVien1);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpDelete]
        public bool XoaNV(int id)
        {
            try
            {
                NhanVien nhanVien = context.NhanViens.First(x => x.MaNhanVien == id);
                context.NhanViens.Remove(nhanVien);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
