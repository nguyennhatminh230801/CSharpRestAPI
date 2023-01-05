using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using Bai9Phieu1.Models;
using System.IO;

namespace ThucHanhWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetAllSanPham_Click(object sender, EventArgs e)
        {
            //Link gọi API Lấy Toàn Bo Danh Muc
            string link = "http://localhost/restfulapi/api/QLBanHang/";

            //Tạo 1 webrequest theo link
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(link);   
            
            //Lấy phản hồi của request
            WebResponse response = request.GetResponse();

            //Mã hóa kiểu DanhMuc
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(DanhMuc[]));

            //Đọc dữ liệu chuyển đổi
            object data = serializer.ReadObject(response.GetResponseStream());

            response.Close();
            //Chuyển sang kiểu danh mục
            DanhMuc[] danhmuc = data as DanhMuc[];

            //Gán dữ liệu vào datasource
            dataGridView1.DataSource = danhmuc;
        }

        private void btnThemDanhMuc_Click(object sender, EventArgs e)
        {
            //Link gọi API Lấy Toàn Bo Danh Muc
            string link = "http://localhost/restfulapi/api/QLBanHang/";

            string param = String.Format("?madm={0}&tendm={1}", txtMaDanhMuc.Text, txtTenDanhMuc.Text);
            link += param;

            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(link);
            webRequest.Method = "POST";
            webRequest.ContentType = "application/json;charset=UTF-8";

            byte[] byteArray = Encoding.UTF8.GetBytes(link);

            webRequest.ContentLength = byteArray.Length;

            Stream stream = webRequest.GetRequestStream();
            stream.Write(byteArray, 0, byteArray.Length);
            stream.Close();
            
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(bool));

            object data = jsonSerializer.ReadObject(webRequest.GetResponse().GetResponseStream());
            bool kq = (bool)data;

            if(kq)
            {
                MessageBox.Show("Thêm thành công");
            } else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnSuaDanhMuc_Click(object sender, EventArgs e)
        {
            //Link gọi API Lấy Toàn Bo Danh Muc
            string link = "http://localhost/restfulapi/api/QLBanHang/";

            string param = String.Format("?madm={0}&tendm={1}", txtMaDanhMuc.Text, txtTenDanhMuc.Text);
            link += param;

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            httpWebRequest.Method = "PUT";
            httpWebRequest.ContentType = "application/json;charset=UTF-8";

            byte[] byteArray = Encoding.UTF8.GetBytes(link);
            httpWebRequest.ContentLength = byteArray.Length;

            Stream stream = httpWebRequest.GetRequestStream();
            stream.Write(byteArray, 0, byteArray.Length);
            stream.Close();

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(bool));

            object data = serializer.ReadObject(httpWebRequest.GetResponse().GetResponseStream());

            bool kq = (bool)data;

            if (kq)
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btnXoaDanhMuc_Click(object sender, EventArgs e)
        {
            //Link gọi API Lấy Toàn Bo Danh Muc
            string link = "http://localhost/restfulapi/api/QLBanHang/";

            string param = String.Format("?madm={0}", txtMaDanhMuc.Text.ToString().Trim());

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.CreateHttp(link + param);
            httpWebRequest.Method = "DELETE";
            httpWebRequest.ContentType = "application/json;charset=UTF-8";
             
            byte[] byteArray = Encoding.UTF8.GetBytes(param);
            httpWebRequest.ContentLength = byteArray.Length;
            WebResponse response = httpWebRequest.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            string data = streamReader.ReadToEnd();
            streamReader.Close();
            response.Close();

            if (data == "true")
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
    }
}
