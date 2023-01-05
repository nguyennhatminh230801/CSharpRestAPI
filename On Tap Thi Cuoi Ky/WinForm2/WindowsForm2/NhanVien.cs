using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm2
{
    [DataContract]
    class NhanVien
    {
        [DataMember]
        public int MaNhanVien { get; set; }
        [DataMember]
        public string TenNhanVien { get; set; }
        [DataMember]
        public double HeSoLuong { get; set; }
    }
}
