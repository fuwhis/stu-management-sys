using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN292_Group1_QLSvien.Models.SinhVien
{
    class SinhVienDAO
    {
        // Add, Remove, Update, Save, Cancel, Exit functions implemented in this class
        public static bool InsertStudent(string maSV, string Ho, string Ten, DateTime ngaySinh, bool gioiTinh, string maKhoa)
        {
            return DataProvider.DataProvider.ExecuteNonQuery("INSERT INTO SVIEN(MASV, HO, TEN, NGAYSINH, GIOITINH, MAKH) VALUES(@1, @2, @3, @4, @5, @6)", maSV, Ho, Ten, ngaySinh, gioiTinh, maKhoa);
        }

        public static bool RemoveStudent(string maSV)
        {
            return DataProvider.DataProvider.ExecuteNonQuery("DELETE FROM SVIEN WHERE MASV = @1", maSV);
        }

        public static bool UpdateInfo(string maSV, string Ho, string Ten, DateTime ngaySinh, bool gioiTinh, string maKhoa)
        {
            return DataProvider.DataProvider.ExecuteNonQuery("UPDATE SVIEN SET HO = @2, TEN = @3, NGAYSINH = @4, GIOITINH = @5, MAKHOA = @6 WHERE MASV = @1", maSV, Ho, Ten, ngaySinh, gioiTinh, maKhoa);
        }

        public static List<SinhVien> ListAllStudent()
        {
            List<SinhVien> listSV = null;
            int maSV;
            string hoSV = null, tenSV = null, maKhoa = null;
            bool gioiTinh;
            DateTime ngaySinh;
            SinhVien sinhVien = null;
            SqlDataReader dataReader = DataProvider.DataProvider.ExecuteDataReader("SELECT * FROM SVIEN");
            while (dataReader.Read())
            {
                maSV = (int)dataReader["MASV"];
                hoSV = (string)dataReader["HO"];
                tenSV = (string)dataReader["TEN"];
                ngaySinh = (DateTime)dataReader["NGAYSINH"];
                gioiTinh = (bool)dataReader["GIOITINH"];
                maKhoa = (string)dataReader["MAKH"];
                sinhVien = new SinhVien(maSV, hoSV, tenSV, ngaySinh, gioiTinh, maKhoa);
                if (listSV == null)
                {
                    listSV = new List<SinhVien>();
                }
                listSV.Add(sinhVien);
            }
            return listSV;
        }

        public static bool LoadData()
        {
            return DataProvider.DataProvider.ExecuteDataReader("SELECT * FROM SVIEN").Read();
        }
        

        public static bool IsExistedMASV(string maSV)
        {
            return DataProvider.DataProvider.ExecuteDataReader("SELECT * FROM SVIEN Where MASV = @1", maSV).Read();
        }
    }
}
