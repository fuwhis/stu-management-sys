using PRN292_Group1_QLSvien.Models.SinhVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN292_Group1_QLSvien
{
    public partial class frmAdd_Update : MetroFramework.Forms.MetroForm
    {
        public frmAdd_Update()
        {
            InitializeComponent();
        }

        frmMain MainForm = new frmMain();
        Boolean GioiTinh;

        private void mrdFemale_CheckedChanged(object sender, EventArgs e)
        {
            GioiTinh = false;
        }

        private void mrdMale_CheckedChanged(object sender, EventArgs e)
        {
            GioiTinh = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // check null
            if (string.IsNullOrEmpty(txtMaSV.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter MaSV first!", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSV.Focus();
                return;
            }

            // nếu không có data thì hiển thị thông báo "Bạn có muốn thêm sinh viên mới không" nút save sẽ thành nút ADD
            // nếu có data thì show lên các textbox, cho phép modify và nút save sẽ thành nút UPDATE
            bool result = true;

            if (!SinhVienDAO.IsExistedStudent(txtMaSV.Text.Trim()))
            {
                // ADD 
                //if (MetroFramework.MetroMessageBox.Show(this, "MaSV has not already existed\nWould you like to ADD new Student???", "Message",
                //    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //{
                try
                {
                    result = SinhVienDAO.InsertStudent(txtMaSV.Text.Trim(), txtHo.Text.Trim(), txtTen.Text.Trim(),
                        dtNgaySinh.Value.Date, GioiTinh, txtMaKhoa.Text.Trim());
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //}
                // Thoát form này
                this.Close();
            }
            else if (SinhVienDAO.IsExistedStudent(txtMaSV.Text.Trim()))
            {
                // UPDATE 
                // Nếu maSV tồn tại
                try
                {
                    result = SinhVienDAO.UpdateInfo(txtMaSV.Text.Trim(), txtHo.Text.Trim(), txtTen.Text.Trim(),
                    dtNgaySinh.Value.Date, GioiTinh, txtMaKhoa.Text.Trim());
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }
            if (result)
            {
                // UPDATE thành công
                MetroFramework.MetroMessageBox.Show(this, "Updated.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MainForm.dgvManager.DataSource = SinhVienDAO.ListAllStudent();
                MainForm.dgvManager.Update();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.ShowDialog();
        }

        private void btnCheckStudentExist_Click(object sender, EventArgs e)
        {
            if (SinhVienDAO.IsExistedStudent(txtMaSV.Text.Trim()))
            {
                MetroFramework.MetroMessageBox.Show(this, "Student has already existed. Please input new Student!", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!SinhVienDAO.IsExistedStudent(txtMaSV.Text.Trim()))
            {
                MetroFramework.MetroMessageBox.Show(this, "Student has not already existed.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
