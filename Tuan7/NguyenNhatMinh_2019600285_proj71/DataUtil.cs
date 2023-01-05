using System.Xml;

namespace NguyenNhatMinh_2019600285_proj71
{
    class DataUtil
    {
        private const string FILE_PATH = "../NganHang.xml";
        XmlDocument xmlDocument;
        XmlElement rootElement;

        public DataUtil()
        {
            xmlDocument = new XmlDocument();
            if (!File.Exists(FILE_PATH))
            {
                XmlElement course = xmlDocument.CreateElement("course");
                xmlDocument.AppendChild(course);
                xmlDocument.Save(FILE_PATH);
            }
            xmlDocument.Load(FILE_PATH);
            rootElement = xmlDocument.DocumentElement;
        }

        public void HienThiDanhSachTaiKhoan()
        {

        }

        public void ThemTaiKhoan(TaiKhoan taiKhoan)
        {
            XmlElement taiKhoanElem = xmlDocument.CreateElement("TaiKhoan");
            
            XmlElement soTaiKhoanElem = xmlDocument.CreateElement("SoTaiKhoan");
            soTaiKhoanElem.InnerText = taiKhoan.SoTaiKhoan;

            XmlElement tenTaiKhoanElem = xmlDocument.CreateElement("TenTaiKhoan");
            tenTaiKhoanElem.InnerText = taiKhoan.TenTaiKhoan;

            XmlElement diaChiElem = xmlDocument.CreateElement("DiaChi");
            diaChiElem.InnerText = taiKhoan.DiaChi;

            XmlElement dienThoaiElem = xmlDocument.CreateElement("DienThoai");
            dienThoaiElem.InnerText = taiKhoan.DienThoai;

            XmlElement soTienElem = xmlDocument.CreateElement("SoTien");
            soTienElem.InnerText = taiKhoan.SoTien.ToString();

            taiKhoanElem.AppendChild(soTaiKhoanElem);
            taiKhoanElem.AppendChild(tenTaiKhoanElem);
            taiKhoanElem.AppendChild(diaChiElem);
            taiKhoanElem.AppendChild(dienThoaiElem);
            taiKhoanElem.AppendChild(soTienElem);

            rootElement.AppendChild(taiKhoanElem);
            xmlDocument.Save(FILE_PATH);
        }
    }
}
