using Bai9Phieu1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bai9Phieu1.Controllers
{
    public class QLBanHangController : ApiController
    {
        [HttpGet]
        public List<DanhMuc> LayToanBoDanhMucSanPham()
        {
            CSDLQLBanHang cSDLQLBanHang = new CSDLQLBanHang();
            foreach(DanhMuc danhMuc in cSDLQLBanHang.DanhMucs)
            {
                danhMuc.SanPhams.Clear();
            }
            return cSDLQLBanHang.DanhMucs.ToList();
        }

        [HttpGet]
        public DanhMuc LayChiTietMotDanhMuc(string madm)
        {
            CSDLQLBanHang cSDLQLBanHang = new CSDLQLBanHang();
            DanhMuc danhMuc = cSDLQLBanHang.DanhMucs.FirstOrDefault(x => x.MaDanhMuc == madm);
            if (danhMuc != null) danhMuc.SanPhams.Clear();
            return danhMuc;
        }

        [HttpPost]        
        public bool ThemMotDanhMucMoi(string madm, string tendm)
        {
            try
            {
                CSDLQLBanHang cSDLQLBanHang = new CSDLQLBanHang();
                DanhMuc danhMuc = new DanhMuc();
                danhMuc.MaDanhMuc = madm;
                danhMuc.TenDanhMuc = tendm;
                cSDLQLBanHang.DanhMucs.Add(danhMuc);
                cSDLQLBanHang.SaveChanges();
                return true;
            } catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPut]
        public bool SuaMotDanhMuc(string madm, string tendm)
        {
            try
            {
                CSDLQLBanHang cSDLQLBanHang = new CSDLQLBanHang();
                DanhMuc danhMuc = cSDLQLBanHang.DanhMucs.FirstOrDefault(x => x.MaDanhMuc == madm);
                if (danhMuc == null) throw new Exception();
                danhMuc.MaDanhMuc = madm;
                danhMuc.TenDanhMuc = tendm;
                cSDLQLBanHang.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpDelete]
        public bool XoaMotDanhMuc(string madm)
        {
            try
            {
                CSDLQLBanHang cSDLQLBanHang = new CSDLQLBanHang();
                DanhMuc danhMuc = cSDLQLBanHang.DanhMucs.FirstOrDefault(x => x.MaDanhMuc == madm);
                if (danhMuc == null) throw new Exception();
                cSDLQLBanHang.DanhMucs.Remove(danhMuc);
                cSDLQLBanHang.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
