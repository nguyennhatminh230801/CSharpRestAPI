
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OnTapKiemTraSo1
{
    class DataUtils
    {
        XmlDocument document;
        XmlElement rootElem;
        private const string FILE_NAME = "..\\..\\..\\DanhSachSach.xml";

        public DataUtils()
        {
            document = new XmlDocument();
            document.Load(FILE_NAME);
            rootElem = document.DocumentElement;
        }
        public void HienThiLenDataGridView(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            dataGridView.ColumnCount = 5;

            XmlNodeList xmlNodeList = rootElem.SelectNodes("Sach");

            if(xmlNodeList != null)
            {
                int index = 0;

                foreach (XmlNode item in xmlNodeList)
                {
                    dataGridView.Rows.Add();
                    dataGridView.Rows[index].Cells[0].Value = item.Attributes[1].InnerText;
                    dataGridView.Rows[index].Cells[1].Value = item.Attributes[0].InnerText;
                    dataGridView.Rows[index].Cells[2].Value = item.SelectSingleNode("TenSach").InnerText;
                    dataGridView.Rows[index].Cells[3].Value = item.SelectSingleNode("GiaBan").InnerText;
                    dataGridView.Rows[index].Cells[4].Value = item.SelectSingleNode("TacGia").InnerText;
                    index++;
                }
            }
        }
        public void AddSach(Sach s)
        {
            XmlElement sach = document.CreateElement("Sach");
            sach.SetAttribute("mas", s.MaSach);
            sach.SetAttribute("nhaxb", s.NhaXuatBan);

            XmlElement tenSach = document.CreateElement("TenSach");
            tenSach.InnerText = s.TenSach;

            XmlElement giaBan = document.CreateElement("GiaBan");
            giaBan.InnerText = s.GiaBan.ToString();

            XmlElement TacGia = document.CreateElement("TacGia");
            TacGia.InnerText = s.TacGia;

            sach.AppendChild(tenSach);
            sach.AppendChild(giaBan);
            sach.AppendChild(TacGia);

            rootElem.AppendChild(sach);
            document.Save(FILE_NAME);
        }

        public void UpdateSach(Sach s)
        {
            XmlNode xmlNode = rootElem.SelectSingleNode($"Sach[@mas='{s.MaSach}']");

            if (xmlNode != null)
            {
                XmlElement sach = document.CreateElement("Sach");
                sach.SetAttribute("mas", s.MaSach);
                sach.SetAttribute("nhaxb", s.NhaXuatBan);

                XmlElement tenSach = document.CreateElement("TenSach");
                tenSach.InnerText = s.TenSach;

                XmlElement giaBan = document.CreateElement("GiaBan");
                giaBan.InnerText = s.GiaBan.ToString();

                XmlElement TacGia = document.CreateElement("TacGia");
                TacGia.InnerText = s.TacGia;

                sach.AppendChild(tenSach);
                sach.AppendChild(giaBan);
                sach.AppendChild(TacGia);

                rootElem.ReplaceChild(sach, xmlNode);
                document.Save(FILE_NAME);
            }
            else
            {
                throw new Exception("Không tìm được");
            }
        }

        public void DeleteSach(Sach s)
        {
            XmlNode xmlNode = rootElem.SelectSingleNode($"Sach[@mas='{s.MaSach}']");

            if (xmlNode != null)
            {
                rootElem.RemoveChild(xmlNode);
                document.Save(FILE_NAME);
            }
            else
            {
                throw new Exception("Không tìm được");
            }
        }
    }
}
