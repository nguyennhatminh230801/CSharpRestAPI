using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txtMaNhanVien.Text = Convert.ToString(row.Cells[0].FormattedValue);
            txtTenNV.Text = Convert.ToString(row.Cells[1].FormattedValue);
            txtHeSoLuong.Text = Convert.ToString(row.Cells[2].FormattedValue);
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            string postString = string.Format("?manv={0}&tennv={1}&hesoluong={2}", int.Parse(txtMaNhanVien.Text), txtTenNV.Text, double.Parse(txtHeSoLuong.Text));
            string link = "http://localhost/qlnv2/api/QLNV";
            HttpWebRequest request = HttpWebRequest.CreateHttp(link + postString);
            request.Method = "POST";
            request.ContentType = "application/json;charset=UTF-8";

            byte[] bytes = Encoding.UTF8.GetBytes(postString);
            Stream stream = request.GetRequestStream();
            stream.Write(bytes, 0, bytes.Length);
            stream.Close();

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            var data = js.ReadObject(request.GetResponse().GetResponseStream());

            bool result = (bool)data;
            
            if(result)
            {
                LoadDataGridView();
                MessageBox.Show("Thêm mới thành công");
            } else
            {
                MessageBox.Show("Thêm mới thất bại");
            }
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            string postString = string.Format("/{0}", int.Parse(txtMaNhanVien.Text));
            string link = "http://localhost/qlnv2/api/QLNV";
            HttpWebRequest request = HttpWebRequest.CreateHttp(link + postString);
            request.Method = "DELETE";
            request.ContentType = "application/json;charset=UTF-8";

            byte[] bytes = Encoding.UTF8.GetBytes(postString);
            Stream stream = request.GetRequestStream();
            stream.Write(bytes, 0, bytes.Length);
            stream.Close();

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            var data = js.ReadObject(request.GetResponse().GetResponseStream());

            bool result = (bool)data;

            if (result)
            {
                LoadDataGridView();
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string link = "http://localhost/qlnv2/api/QLNV";
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(NhanVien[]));
            var data = js.ReadObject(response.GetResponseStream());
            NhanVien[] nhanViens = data as NhanVien[];
            dataGridView1.DataSource = nhanViens;
        }
    }
}
