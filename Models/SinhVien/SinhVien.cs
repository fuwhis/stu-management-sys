using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN292_Group1_QLSvien.Models.SinhVien
{
    public class SinhVien
    {
        public int MaSV { get; set; }
        public string HoSV { get; set; }
        public string TenSV { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string MaKhoa { get; set; }

        public SinhVien(int maSV, string hoSV, string tenSV, DateTime ngaySinh, bool gioiTinh, string maKhoa)
        {
            this.MaSV = maSV;
            this.HoSV = hoSV;
            this.TenSV = tenSV;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.MaKhoa = maKhoa;
        }
    }
}
