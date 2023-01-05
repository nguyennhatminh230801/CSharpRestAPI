using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            string link = "http://localhost/qlnv2/api/QLNV/";

            HttpWebRequest request = WebRequest.CreateHttp(link);
            request.Method = "GET";
            request.ContentType = "application/json;charset=UTF-8";


        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
